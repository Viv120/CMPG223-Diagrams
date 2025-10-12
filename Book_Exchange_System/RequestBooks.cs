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
        string connString = "server=localhost;user id=bookexchange;password=OurProjectPassword;database=book_exchange_db;";
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader reader;

        private int applicantID;
        private int campusID;
        private string applicantEmail;


        private bool isRegisterMode = false;

        public RequestBooks(string email, bool registerMode)
        {
            InitializeComponent();
            this.applicantEmail = email;

            if(!registerMode)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        string query = "SELECT Applicant_ID, Campus_ID FROM applicant WHERE Email = @Email";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    applicantID = Convert.ToInt32(reader["Applicant_ID"]);
                                    campusID = Convert.ToInt32(reader["Campus_ID"]);
                                }
                                else
                                {
                                    MessageBox.Show("Applicant not found!");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving applicant ID: " + ex.Message);
                }
            }
            
            InitializeForm(registerMode);
            LoadApplicants();
            LoadApplicantLogin();
            LoadRequestedBooks();
        }


        private void InitializeForm(bool registerMode)
        {
            isRegisterMode = registerMode;

            if (isRegisterMode)
            {
                btnRegApp.Visible = true;
                btnReceive.Visible = false;
                btnUpdateApplicants.Visible = false;
            }
            else
            {
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

        private void LoadRequestedBooks()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                SELECT ib.Issued_ID, b.Title, b.Author_FName, b.Author_LName, b.Edition, 
                       b.Book_Condition, b.Year_Published, ib.Date_Issued
                FROM issue_books ib
                INNER JOIN books b ON ib.Book_ID = b.Book_ID
                WHERE ib.Applicant_ID = @ApplicantID
                ORDER BY ib.Date_Issued DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", applicantID);

                        da = new MySqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgvBooks.DataSource = dt;
                        dgvBooks.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requested books: " + ex.Message);
            }
        }

        private void UpdateCampusID()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT Campus_ID FROM applicant WHERE Applicant_ID = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", applicantID);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            campusID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating campus: " + ex.Message);
            }
        }


        private void LoadApplicantLogin()
        {
            if (string.IsNullOrWhiteSpace(applicantEmail))
                return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT Password FROM applicant_login WHERE Applicant_ID = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", applicantID);


                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            txtAppPass.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicant login info: " + ex.Message);
            }
        }


        private void LoadApplicants()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT * FROM applicant WHERE Applicant_ID = @ID";

                    using (MySqlCommand tableCmd = new MySqlCommand(query, conn))
                    {
                        tableCmd.Parameters.AddWithValue("@ID", applicantID);
                        MySqlDataAdapter da = new MySqlDataAdapter(tableCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCurrentApp.DataSource = dt;
                    }

                    string detailQuery = "SELECT * FROM applicant WHERE Applicant_ID = @ID";
                    using (MySqlCommand detailCmd = new MySqlCommand(detailQuery, conn))
                    {
                        detailCmd.Parameters.AddWithValue("@ID", applicantID);
                        using (MySqlDataReader reader = detailCmd.ExecuteReader())
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

            this.campusID = campusID;

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
                    LoadBooks(); 
                    LoadRequestedBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating applicant: " + ex.Message);
            }
        }

        private void RequestBooks_Load(object sender, EventArgs e)
        {
            Add.Visible = false;
            UpdateApplicants.Visible = false;
            Request.Visible = false;

            LoadApplicantLogin();
            LoadApplicants();
            LoadRequestedBooks();

            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
        }

        private void btnUpdateApplicants_Click(object sender, EventArgs e)
        {
            ShowPanels(UpdateApplicants);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            UpdateCampusID(); 
            ShowPanels(Request);
            LoadBooks();
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

                            string insertQuery = @"INSERT INTO issue_books (Applicant_ID, Book_ID, Date_Issued)
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
                        LoadRequestedBooks();
                        LoadBooks();
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

        private void btnSearchBooks_Click(object sender, EventArgs e)
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
                                 Campus_ID = @CampusID";

                    if (!string.IsNullOrWhiteSpace(title))
                    {
                        query += " AND Title LIKE @Title";
                    }
                    if (!string.IsNullOrWhiteSpace(authorName))
                    {
                        query += " AND Author_FName LIKE @AName";
                    }
                    if (!string.IsNullOrWhiteSpace(authorSurname))
                    {
                        query += " AND Author_LName LIKE @ASurname";
                    }
                    if (condition >= 1 && condition <= 5)
                    {
                        query += " AND Book_Condition = @Condition";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CampusID", campusID);

                        if (!string.IsNullOrWhiteSpace(title))
                        {
                            cmd.Parameters.AddWithValue("@Title", $"%{title}%");
                        }
                        if (!string.IsNullOrWhiteSpace(authorName))
                        {
                            cmd.Parameters.AddWithValue("@AName", $"%{authorName}%");
                        }
                        if (!string.IsNullOrWhiteSpace(authorSurname))
                        {
                            cmd.Parameters.AddWithValue("@ASurname", $"%{authorSurname}%");
                        }
                        if (condition >= 1 && condition <= 5)
                        {
                            cmd.Parameters.AddWithValue("@Condition", condition);
                        }

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvBooks.DataSource = dt;
                    }

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

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearchTitle.Clear();
            txtSearchName.Clear();
            txtSearchSurname.Clear();
            hsbCondition.Value = 0;

            LoadBooks();
            MessageBox.Show("Filters cleared and table reloaded.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else 
            {
                valid = false;
                rdoP.BackColor = SystemColors.Control;
                rdoM.BackColor = SystemColors.Control;
                rdoV.BackColor = SystemColors.Control;
                errorProvider1.SetError(rdoP, "Please choose a campus!");
            }
            
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

                        long newApplicantID = cmd.LastInsertedId;
                        applicantID = (int)newApplicantID;   
                        applicantEmail = email;                    
                        campusID = campusID;

                        string insertLogin = @"INSERT INTO applicant_login (Applicant_ID, Email, Password) 
                                       VALUES (@Applicant_ID, @Email, @Password)";
                        using (MySqlCommand insertCmd = new MySqlCommand(insertLogin, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Applicant_ID", newApplicantID);
                            insertCmd.Parameters.AddWithValue("@Email", email);
                            insertCmd.Parameters.AddWithValue("@Password", password);
                            insertCmd.ExecuteNonQuery();
                        }
                    }

                    LoadApplicants();
                    LoadApplicantLogin();
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
