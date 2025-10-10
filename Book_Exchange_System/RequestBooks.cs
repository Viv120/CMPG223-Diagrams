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
using System.Text.RegularExpressions;

namespace Book_Exchange_System
{
    public partial class RequestBooks : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=book_exchange_db;Uid=root;Pwd=Viv20050209!");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader reader;

        private int applicantID;
        private int campusID;

        public RequestBooks()
        {
            InitializeComponent();
            this.applicantID = applicantID;
            this.campusID = campusID;
        }

        private void ShowPanels(Panel panel)
        {
            UpdateApplicants.Visible = false;
            Request.Visible = false;

            panel.Visible = true;
            panel.BringToFront();
        }
        private void LoadApplicants()
        {
            try
            {
                conn.Open();

                string query = @"SELECT * FROM applicant WHERE Applicant_ID = @ID";
                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", applicantID);

                using(reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
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

                conn.Close();
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

                conn.Close();
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
                conn.Open();

                string queryApplicant = @"UPDATE applicant SET First_Name = @FirstName, Last_Name = @LastName, Email = @Email, Campus_ID = @CampusID WHERE Applicant_ID = @ID";

                cmd = new MySqlCommand(queryApplicant, conn);
                cmd.Parameters.AddWithValue("@FirstName", name);
                cmd.Parameters.AddWithValue("@LastName", surname);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@CampusID", campusID);
                cmd.Parameters.AddWithValue("@ID", applicantID);
                cmd.ExecuteNonQuery();
                
                if(!string.IsNullOrWhiteSpace(password))
                {
                    string queryLogin = @"UPDATE applicant_login SET Password = @Password, Email = @Email WHERE Applicant_ID = @ID";

                    cmd = new MySqlCommand(queryLogin, conn);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@ID", selectedID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Applicant updated successfully!");
                LoadApplicants();

                conn.Close();

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
                conn.Open();

                foreach(DataGridViewRow row in dgvBooks.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["SelectBooks"].Value);

                    if(isSelected)
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

                if(requestedBooks.Count > 0)
                {
                    MessageBox.Show("You have successfully requested the following books:\n\n" + string.Join("\n", requestedBooks), "Books Requested", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Please select at least one book to receive.", "No Books Selected", MessageBoxButtons.OK);
                }

                conn.Close();
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
                conn.Open();

                string query = @"SELECT Book_ID, Title, Author_FName, Author_LName, Edition, Year_Published, Book_Condition, 
                                 Campus_ID FROM books WHERE Campus_ID = @CampusID AND (Title LIKE @Title OR
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

                conn.Close();
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

        private void btnDeleteBooks_Click(object sender, EventArgs e)
        {
            Logins loginform = new Logins();
            loginform.Show();
            this.Close();
        }
    }
}
