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

namespace Book_Exchange_System
{
    public partial class DonateBooks : Form
    {
        public int donorID { get; set; }//donor ID is public and needs be sent from the login form
                                        //since there is now way to know who is using the system from this form
        
        private List<int> booksToDonate = new List<int>();//list to keep track of all the books added



        private string connString = ConfigurationManager.ConnectionStrings["BookexchangeConn"].ConnectionString;

        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader reader;
        public DonateBooks()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Logins login = new Logins();
            login.Show();

            this.Hide();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            UpdateDonor.Visible = false;
            Donate.Visible = true;
        }

        private void btnUpdateDonor_Click(object sender, EventArgs e)
        {
            Donate.Visible = false;
            UpdateDonor.Visible = true;
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
                donorID = 1;
                DateTime donationDate = DateTime.Today;
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    foreach (int bookID in booksToDonate)
                    {
                        //string sqlQuery = @"INSERT INTO donate_books( Book_ID , Donation_Date) VALUES( @Book_ID , @Donation_Date)";
                        string sqlQuery = @"INSERT INTO donate_books(Donor_ID, Book_ID , Donation_Date) VALUES(@Donor_ID, @Book_ID , @Donation_Date)";
                        MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                        cmd.Parameters.AddWithValue("@Donor_ID", donorID);
                        cmd.Parameters.AddWithValue("@Book_ID", bookID);
                        cmd.Parameters.AddWithValue("@Donation_Date", donationDate);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();


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

        private void LoadDonors()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM donor";
                    cmd = new MySqlCommand(query, conn);

                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();

                    da.Fill(dt);

                    dgvCurrentApp.DataSource = dt;
                    dgvCurrentApp.Refresh();
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
            int edition = Convert.ToInt32(txtEdition.Text);
            int year = Convert.ToInt32(txtYear.Text);
            int bookCondition = Convert.ToInt32(nudCondition.Value);
            DateTime donationDate = DateTime.Today;


            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string sqlQuery = @"INSERT INTO books(Title, Author_FName , Author_LName , Edition ,Book_Condition,Year_Published ) VALUES(@Title,@Author_FName ,@Author_LName ,@Edition ,@Book_Condition,@Year_Published )";

                    cmd = new MySqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@Title", bookTitle);
                    cmd.Parameters.AddWithValue("@Author_FName", authorName);
                    cmd.Parameters.AddWithValue("@Author_LName", authorSurname);
                    cmd.Parameters.AddWithValue("@Edition", edition);
                    cmd.Parameters.AddWithValue("@Year_Published", year);
                    cmd.Parameters.AddWithValue("@Book_Condition", bookCondition);
                    cmd.ExecuteNonQuery();



                    MessageBox.Show("Book added successfully!");

                    int bookId = Convert.ToInt32(cmd.LastInsertedId);
                    booksToDonate.Add(bookId);

                    conn.Close();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            int selectedID = Convert.ToInt32(txtDonorID.Text.ToString());
            string Name = txtNewAName.Text;
            string studNum = txtNewSP_Number.Text;
            string Email = txtNewEmail.Text;
            bool validate = true;

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
            else
            {
                MessageBox.Show("Please choose a campus!");
                validate = false;
            }

            if (string.IsNullOrWhiteSpace(txtNewEmail.Text))
            {
                errorProvider1.SetError(txtNewEmail, "Please enter a email!");
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(txtNewSP_Number.Text))
            {
                errorProvider1.SetError(txtNewSP_Number, "Please enter a number!");
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(txtNewAName.Text))
            {
                errorProvider1.SetError(txtNewAName, "Please enter a email!");
                validate = false;
            }


            if (!validate)
            {
                return;
            }



            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string updateQuery = @"UPDATE donor SET Name = @Name, SP_Number = @Num, Email = @Email, Campus_ID = @Campus_ID WHERE Donor_ID = @ID";

                    cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Num", studNum);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Campus_ID", campusID);
                    cmd.Parameters.AddWithValue("@ID", selectedID);

                    cmd.ExecuteNonQuery();


                    string sqlQuery2 = @"UPDATE donor_login SET Email = @Email WHERE Donor_ID = @ID";

                    MySqlCommand cmd2 = new MySqlCommand(sqlQuery2, conn);
                    cmd2.Parameters.AddWithValue("@Email", Email);
                    cmd2.Parameters.AddWithValue("@Donor_ID", selectedID);

                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Donor updated successfully!");
                    

                    conn.Close();

                    txtNewAName.Clear();
                    txtNewSP_Number.Clear();
                    txtNewEmail.Clear();
                    
                    rdoPotch.Checked = false;
                    rdoMahikeng.Checked = false;
                    rdoVaal.Checked = false;

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
            LoadDonatedBooks();
            LoadDonors();
            txtDonorID.Text = donorID.ToString();
        }
    }
}
