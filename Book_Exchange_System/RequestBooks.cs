using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Book_Exchange_System
{
    public partial class RequestBooks : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["BookExchangeConn"].ConnectionString;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader reader;

        private int applicantID;
        private int campusID;

        private bool isRegisterMode = false;

        public RequestBooks()
        {
            InitializeComponent();
            InitializeForm(false);
        }

        public RequestBooks(bool registerMode)
        {
            InitializeComponent();
            InitializeForm(registerMode);
        }

        private void InitializeForm(bool registerMode)
        {
            isRegisterMode = registerMode;

            if (isRegisterMode)
            {
                Add.Visible = true;
                btnRegApp.Visible = true;
                btnReceive.Visible = false;
                btnUpdateApplicants.Visible = false;
            }
            else
            {
                Add.Visible = false;
                btnRegApp.Visible = false;
                btnReceive.Visible = true;
                btnUpdateApplicants.Visible = true;  
            }
        }

        private void ShowPanels(Panel panel)
        {
            UpdateApplicants.Visible = false;
            Request.Visible = false;
            Add.Visible = false;

            panel.Visible = true;
            panel.BringToFront();
        }

        private void LoadApplicants()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT * FROM applicant WHERE Applicant_ID = @ID";
                    cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", applicantID);

                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtAppID.Text = reader["Applicant_ID"].ToString();
                            txtNewName.Text = reader["First_Name"].ToString();
                            txtNewSurname.Text = reader["Last_Name"].ToString();
                            txtNewEmail.Text = reader["Email"].ToString();

                            int campus = Convert.ToInt32(reader["Campus_ID"]);
                            rdoPotch.Checked = campus == 1;
                            rdoMahikeng.Checked = campus == 2;
                            rdoVaal.Checked = campus == 3;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicant info: " + ex.Message);
            }
        }

        private void LoadBooks()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    int condition = hsbCondition.Value;
                    string searchTerm = txtSearchTitle.Text;

                    string query = "SELECT * FROM books WHERE Campus_ID = @CampusID";

                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        query += " AND (Title LIKE @Search OR Author_FName LIKE @Search OR Author_LName LIKE @Search)";
                    }

                    if (condition >= 1 && condition <= 5)
                    {
                        query += " AND Book_Condition = @Condition";
                    }

                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CampusID", campusID);

                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
                    }

                    cmd.Parameters.AddWithValue("@Condition", condition);

                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);

                    dgvBooks.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(txtAppID.Text);

            string name = txtNewName.Text;
            string surname = txtNewSurname.Text;
            string email = txtNewEmail.Text;
            string password = txtAppPass.Text;

            int campusID = 0;

            if(rdoPotch.Checked)
            {
                campusID = 1;
            }
            else if (rdoMahikeng.Checked)
            {
                campusID = 2;
            }
            else if (rdoVaal.Checked)
            {
                campusID = 3;
            }

            if (!Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$"))
            {
                txtAppPass.BackColor = Color.LightPink;
                MessageBox.Show("Password must be 8+ characters with uppercase, number and special character!");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string queryApplicant = @"UPDATE applicant SET First_Name = @FirstName, 
                                          Last_Name = @LastName, Email = @Email, 
                                          Campus_ID = @CampusID WHERE Applicant_ID = @ID";

                    cmd = new MySqlCommand(queryApplicant, conn);
                    cmd.Parameters.AddWithValue("@FirstName", name);
                    cmd.Parameters.AddWithValue("@LastName", surname);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@CampusID", campusID);
                    cmd.Parameters.AddWithValue("@ID", applicantID);
                    cmd.ExecuteNonQuery();

                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        string queryLogin = @"UPDATE applicant_login SET Password = @Password, 
                                          Email = @Email WHERE Applicant_ID = @ID";

                        cmd = new MySqlCommand(queryLogin, conn);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@ID", selectedID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Applicant updated successfully!");
                    LoadApplicants();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating applicant: " + ex.Message);
            }
        }

        private void RequestBooks_Load(object sender, EventArgs e)
        {
            ShowPanels(UpdateApplicants);

            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
        }

        private void btnUpdateApplicants_Click(object sender, EventArgs e)
        {
            ShowPanels(UpdateApplicants);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            ShowPanels(Request);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            List<string> requestedBooks = new List<string>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgvBooks.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["SelectBooks"].Value);

                        if (isSelected)
                        {
                            int bookID = Convert.ToInt32(row.Cells["Book_ID"].Value);
                            string title = row.Cells["Title"].Value.ToString();

                            string insertQuery = @"INSERT INTO issue_books (Applicant_ID, Book_ID, Issue_Date)
                                               VALUES (@ApplicantID, @BookID, @IssueDate)";

                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@ApplicantID", applicantID);
                                insertCmd.Parameters.AddWithValue("@BookID", bookID);
                                insertCmd.Parameters.AddWithValue("@IssueDate", DateTime.Now);
                                insertCmd.ExecuteNonQuery();
                            }

                            requestedBooks.Add(title);
                        }
                    }

                    if (requestedBooks.Count > 0)
                    {
                        MessageBox.Show("You have successfully requested the following books:\n\n" + string.Join("\n", requestedBooks), "Books Requested", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Please select at least one book to receive.", "No Books Selected", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = txtSearchTitle.Text;
            string authorName = txtSearchName.Text;
            string authorSurname = txtSearchSurname.Text;
            int condition = hsbCondition.Value;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT Book_ID, Title, Author_FName, Author_LName, Edition, 
                                 Year_Published, Book_Condition, Campus_ID FROM books WHERE 
                                 Campus_ID = @CampusID AND (Title LIKE @Title OR
                                 Author_FName LIKE @AName OR Author_LName LIKE @ASurname) 
                                 AND Book_Condition = @Condition";

                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CampusID", campusID);
                    cmd.Parameters.AddWithValue("@Title", $"%{title}%");
                    cmd.Parameters.AddWithValue("@AName", $"%{authorName}%");
                    cmd.Parameters.AddWithValue("@ASurname", $"%{authorSurname}%");
                    cmd.Parameters.AddWithValue("@Condition", condition);

                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);

                    dgvBooks.DataSource = dt;

                    foreach (DataGridViewRow row in dgvBooks.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvBooks.Rows)
            {
                if(row.Cells["SelectBooks"] is DataGridViewCheckBoxCell checkbox)
                {
                    checkbox.Value = false;
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }

            dgvBooks.ClearSelection();
            MessageBox.Show("Selection cleared");
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == dgvBooks.Columns["SelectBooks"].Index)
            {
                dgvBooks.EndEdit();

                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];
                bool isSelected = Convert.ToBoolean(row.Cells["SelectBooks"].Value);

                if(isSelected)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Logins loginform = new Logins();
            loginform.Show();
            this.Close();
        }

        private void btnRegApp_Click(object sender, EventArgs e)
        {
            ShowPanels(Add);
        }

        private void btnAddApplicant_Click(object sender, EventArgs e)
        {
            bool valid = true;

            string name = txtAddName.Text;
            string surname = txtAddSurname.Text;
            string studentNum = txtAddStudents.Text;
            string email = txtAddEmail.Text;
            string password = txtAddPassword.Text;

            int campusID = 0;
            if (rdoP.Checked)
            {
                campusID = 1;
            }
            else if (rdoM.Checked)
            {
                campusID = 2;
            }
            else if (rdoV.Checked)
            {
                campusID = 3;
            }

            errorProvider1.Clear();
            txtAddName.BackColor = SystemColors.Window;
            txtAddSurname.BackColor = SystemColors.Window;
            txtAddStudents.BackColor = SystemColors.Window;
            txtAddEmail.BackColor = SystemColors.Window;
            txtAddPassword.BackColor = SystemColors.Window;
            rdoP.BackColor = SystemColors.Control;
            rdoM.BackColor = SystemColors.Control;
            rdoV.BackColor = SystemColors.Control;

            if (string.IsNullOrWhiteSpace(name)) 
            {
                txtAddName.BackColor = Color.LightPink; 
                errorProvider1.SetError(txtAddName, "Enter your name!"); 
                valid = false; 
            }
            if (string.IsNullOrWhiteSpace(surname)) 
            {
                txtAddSurname.BackColor = Color.LightPink; 
                errorProvider1.SetError(txtAddSurname, "Enter your surname!"); 
                valid = false; 
            }
            if (string.IsNullOrWhiteSpace(studentNum) || !Regex.IsMatch(studentNum, @"^\d{8}$")) 
            {
                txtAddStudents.BackColor = Color.LightPink; 
                errorProvider1.SetError(txtAddStudents, "Enter a VALID student number with 8 digits!"); 
                valid = false; 
            }
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@")) 
            { 
                txtAddEmail.BackColor = Color.LightPink; 
                errorProvider1.SetError(txtAddEmail, "Enter a valid email!"); 
                valid = false; 
            }
            if (campusID == 0) 
            {
                rdoP.BackColor = Color.LightPink;
                rdoM.BackColor = Color.LightPink;
                rdoV.BackColor = Color.LightPink; 
                errorProvider1.SetError(rdoP, "Select a campus!"); 
                valid = false; 
            }
            if (string.IsNullOrWhiteSpace(password) || !Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$")) 
            {
                txtAddPassword.BackColor = Color.LightPink; 
                errorProvider1.SetError(txtAddPassword, "Password must be 8+ chars, uppercase, number & special char!"); 
                valid = false; 
            }

            if (!valid)
            {
                return;
            }


            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM applicant WHERE Email = @Email";

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists > 0)
                        {
                            MessageBox.Show("Email already registered!");
                            return;
                        }
                    }


                    string queryApplicant = @"INSERT INTO applicant (First_Name, Last_Name, 
                                              Student_Num, Email, Campus_ID) VALUES (@FirstName, 
                                              @LastName, @StudentNum, @Email, @CampusID)";

                    using (MySqlCommand cmd = new MySqlCommand(queryApplicant, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", name);
                        cmd.Parameters.AddWithValue("@LastName", surname);
                        cmd.Parameters.AddWithValue("@StudentNum", studentNum);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@CampusID", campusID);
                        cmd.ExecuteNonQuery();

                        long applicantID = cmd.LastInsertedId;

                        string insertLogin = @"INSERT INTO applicant_login (Applicant_ID, Email, Password) 
                                       VALUES (@Applicant_ID, @Email, @Password)";
                        using (MySqlCommand insertCmd = new MySqlCommand(insertLogin, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Applicant_ID", applicantID);
                            insertCmd.Parameters.AddWithValue("@Email", email);
                            insertCmd.Parameters.AddWithValue("@Password", password);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK);
                }

                txtAddName.Clear();
                txtAddSurname.Clear();
                txtAddStudents.Clear();
                txtAddEmail.Clear();
                txtAddPassword.Clear();
                rdoP.Checked = false;
                rdoM.Checked = false;
                rdoV.Checked = false;

                Add.Visible = false; 
                btnRegApp.Visible = false;
                btnReceive.Visible = true;    
                btnUpdateApplicants.Visible = true;   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering applicant: " + ex.Message);
            }
        }
    }
}
