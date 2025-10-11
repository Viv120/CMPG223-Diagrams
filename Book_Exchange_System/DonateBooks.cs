using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Book_Exchange_System
{
    public partial class DonateBooks : Form
    {
        private List<int> booksToDonate = new List<int>();
        private string connString = ConfigurationManager.ConnectionStrings["BookexchangeConn"].ConnectionString;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader reader;

        private int donorID;
        private int campusID;

        private bool isRegisterMode = false;

        public DonateBooks()
        {
            InitializeComponent();
            InitializeForm(false);
        }

        public DonateBooks(bool registerMode)
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
                btnRegDonor.Visible = true;
                btnDonate.Visible = false;
                btnUpdateDonor.Visible = false;
            }
            else
            {
                Add.Visible = false;
                btnRegDonor.Visible = false;
                btnDonate.Visible = true;
                btnUpdateDonor.Visible = true;
            }
        }

        private void ShowPanels(Panel panel)
        {
            UpdateDonor.Visible = false;
            Donate.Visible = false;
            Add.Visible = false;

            panel.Visible = true;
            panel.BringToFront();
        }

        private void LoadDonors()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM donor WHERE Donor_ID = @ID";
                    cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", donorID);

                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtDonorID.Text = reader["Donor_ID"].ToString();
                            txtNewAName.Text = reader["Name"].ToString();
                            txtNewSP_Number.Text = reader["SP_Number"].ToString();
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
                MessageBox.Show("Error loading donor info: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(txtDonorID.Text.ToString());

            string Name = txtNewAName.Text;
            string studNum = txtNewSP_Number.Text;
            string Email = txtNewEmail.Text;
            string password = txtDonorPass.Text;

            int campusID = 0;
            if (rdoPotch.Checked)
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
                txtDonorPass.BackColor = Color.LightPink;
                MessageBox.Show("Password must be 8+ characters with uppercase, number and special character!");
                return;
            }
            if (!Regex.IsMatch(txtNewSP_Number.Text, @"^([0-9]{5,10})"))
            {
                txtNewSP_Number.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a VALID phone/student number!");
                return; ;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string updateQuery = @"UPDATE donor SET Name = @Name, SP_Number = @Num, 
                                           Email = @Email, Campus_ID = @Campus_ID WHERE Donor_ID = @ID";

                    cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Num", studNum);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Campus_ID", campusID);
                    cmd.Parameters.AddWithValue("@ID", selectedID);

                    cmd.ExecuteNonQuery();


                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        string queryLogin = @"UPDATE donor_login SET Password = @Password, 
                                              Email = @Email WHERE Donor_ID = @ID";

                        cmd = new MySqlCommand(queryLogin, conn);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@ID", selectedID);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Donor updated successfully!");
                    LoadDonors();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating donor: " + ex.Message);
            }
        }

        private void DonateBooks_Load(object sender, EventArgs e)
        {
            ShowPanels(UpdateDonor);
        }


        private void btnUpdateDonor_Click(object sender, EventArgs e)
        {
            ShowPanels(UpdateDonor);
        }


        private void btnDonate_Click(object sender, EventArgs e)
        {
            ShowPanels(Donate);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Logins login = new Logins();
            login.Show();
            this.Close();
        }

        private void btnRegDonor_Click(object sender, EventArgs e)
        {
            ShowPanels(Add);
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            bool valid = true;

            string Num = txtAddSP_Num.Text;
            string name = txtAddName.Text;
            string password = txtAddPass.Text;
            string studEmail = txtAddEmail.Text;

            int campusID = 0;
            if (rdoP.Checked == true)
            {
                campusID = 1;
            }
            else if (rdoM.Checked == true)
            {
                campusID = 2;
            }
            else if (rdoV.Checked == true)
            {
                campusID = 3;
            }
            else
            {
                valid = false;
                rdoP.BackColor = Color.LightPink;
                rdoM.BackColor = Color.LightPink;
                rdoV.BackColor = Color.LightPink;
                errorProvider1.SetError(rdoP, "Please choose a campus!");
            }

            int donorType = 0;
            if (rdoInd.Checked == true)
            {
                donorType = 1;
            }
            else if (rdoOrg.Checked == true)
            {
                donorType = 2;
            }
            else
            {
                valid = false;
                rdoInd.BackColor = Color.LightPink;
                rdoOrg.BackColor = Color.LightPink;
                errorProvider1.SetError(rdoInd, "Please choose a donor type!");
            }


            if (string.IsNullOrWhiteSpace(txtAddEmail.Text) || !Regex.IsMatch(txtAddEmail.Text, @"^([a-zA-Z0-9]{1,50})@([a-zA-Z0-9]{1,50}).(.{3,6})"))
            {
                txtAddEmail.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAddEmail, "Please enter a VALID email!");
                valid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtAddSP_Num.Text) || !Regex.IsMatch(txtAddSP_Num.Text, @"^([0-9]{5,10})"))
            {
                txtAddSP_Num.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAddSP_Num, "Please enter a number!");
                valid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtAddName.Text))
            {
                txtAddName.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAddName, "Please enter a name!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(password) || !Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$"))
            {
                txtAddPass.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAddPass, "Password must be 8+ chars, uppercase, number & special char!");
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

                    string checkQuery = "SELECT COUNT(*) FROM donor WHERE Email = @Email";

                    using (MySqlCommand checksCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checksCmd.Parameters.AddWithValue("@Email", studEmail);
                        int exist = Convert.ToInt32(checksCmd.ExecuteScalar());

                        if (exist > 0)
                        {
                            MessageBox.Show("Email already registered!");
                            return;
                        }
                    }

                    string queryDonor = @"INSERT INTO donor(Email, Donor_Type_ID , Name,
                                      Campus_ID,SP_Number ) VALUES(@Email, @DonorType, 
                                      @Name, @Campus, @Number)";

                    using (MySqlCommand cmd = new MySqlCommand(queryDonor, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", studEmail);
                        cmd.Parameters.AddWithValue("@DonorType", donorType);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Campus", campusID);
                        cmd.Parameters.AddWithValue("@Number", Num);
                        cmd.ExecuteNonQuery();

                        long newDonorID = cmd.LastInsertedId;

                        string insertLogin = @"INSERT INTO donor_login(Email, Donor_ID, Password) 
                                               VALUES(@Email,@Donor_ID, @Password )";

                        using (MySqlCommand insertCmd = new MySqlCommand(insertLogin, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Email", studEmail);
                            insertCmd.Parameters.AddWithValue("@Donor_ID", newDonorID);
                            insertCmd.Parameters.AddWithValue("@Password", password);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK);
                }

                txtAddEmail.Clear();
                txtAddSP_Num.Clear();
                txtAddName.Clear();
                txtAddPass.Clear();
                rdoP.Checked = false;
                rdoM.Checked = false;
                rdoV.Checked = false;
                rdoInd.Checked = false;
                rdoOrg.Checked = false;

                Add.Visible = false;
                btnRegDonor.Visible = false;
                btnDonate.Visible = true;
                btnUpdateDonor.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding Donor: " + ex.Message);
            }
        }

        private void btnDonateBooks_Click(object sender, EventArgs e)
        {
            if (booksToDonate.Count == 0)
            {
                MessageBox.Show("Please add books first.");
                return;
            }
            try
            {
                DateTime donationDate = DateTime.Today;
                List<string> donatedTitles = new List<string>();

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    foreach (int bookID in booksToDonate)
                    {
                        string sqlQuery = @"INSERT INTO donate_books(Donor_ID, Book_ID, 
                                            Donation_Date) VALUES(@Donor_ID, @Book_ID, @Donation_Date)";

                        MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                        cmd.Parameters.AddWithValue("@Donor_ID", donorID);
                        cmd.Parameters.AddWithValue("@Book_ID", bookID);
                        cmd.Parameters.AddWithValue("@Donation_Date", donationDate);
                        cmd.ExecuteNonQuery();

                        string titleQuery = "SELECT Title FROM books WHERE Book_ID = @Book_ID";
                        MySqlCommand titleCmd = new MySqlCommand(titleQuery, conn);
                        titleCmd.Parameters.AddWithValue("@Book_ID", bookID);
                        string title = Convert.ToString(titleCmd.ExecuteScalar());
                        donatedTitles.Add(title);
                    }

                    string donatedList = string.Join(Environment.NewLine, donatedTitles);
                    MessageBox.Show($"Books donated successfully!\nBook IDs: \n{donatedList}");

                    booksToDonate.Clear();
                    LoadDonatedBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating donateBooks: " + ex.Message);
            }
        }

        private void LoadDonatedBooks()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM donate_books";
                    cmd = new MySqlCommand(query, conn);

                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();

                    da.Fill(dt);

                    dgvDonate.DataSource = dt;
                    dgvDonate.Refresh();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bookTitle = txtTitle.Text;
            string authorName = txtAName.Text;
            string authorSurname = txtASurname.Text;
            int edition, year;
            int bookCondition = Convert.ToInt32(nudCondition.Value);
            //DateTime donationDate = DateTime.Today;

            errorProvider1.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                txtTitle.BackColor = Color.LightPink;
                errorProvider1.SetError(txtTitle, "Enter book title!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtAName.Text))
            {
                txtAName.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAName, "Enter author first name!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtASurname.Text))
            {
                txtASurname.BackColor = Color.LightPink;
                errorProvider1.SetError(txtASurname, "Enter author last name!");
                valid = false;
            }
            if (!int.TryParse(txtEdition.Text, out edition))
            {
                txtEdition.BackColor = Color.LightPink;
                errorProvider1.SetError(txtEdition, "Enter a valid edition!");
                valid = false;
            }
            if (!int.TryParse(txtYear.Text, out year))
            {
                txtYear.BackColor = Color.LightPink;
                errorProvider1.SetError(txtYear, "Enter a valid year!");
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
                    string sqlQuery = @"INSERT INTO books(Title, Author_FName, Author_LName, 
                                        Edition, Book_Condition, Year_Published ) 
                                        VALUES(@Title, @Author_FName, @Author_LName, @Edition,
                                        @Book_Condition, @Year_Published )";

                    cmd = new MySqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@Title", bookTitle);
                    cmd.Parameters.AddWithValue("@Author_FName", authorName);
                    cmd.Parameters.AddWithValue("@Author_LName", authorSurname);
                    cmd.Parameters.AddWithValue("@Edition", edition);
                    cmd.Parameters.AddWithValue("@Year_Published", year);
                    cmd.Parameters.AddWithValue("@Book_Condition", bookCondition);
                    cmd.ExecuteNonQuery();

                    int bookId = Convert.ToInt32(cmd.LastInsertedId);
                    booksToDonate.Add(bookId);


                    MessageBox.Show("Book added successfully!");

                    txtTitle.Clear();
                    txtAName.Clear();
                    txtASurname.Clear();
                    txtEdition.Clear();
                    txtYear.Clear();
                    nudCondition.Value = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }
        }
    }
}
