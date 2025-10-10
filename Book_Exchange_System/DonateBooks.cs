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
                    string sqlQuery = @"INSERT INTO books(Title, Author_FName , Author_LName , Edition ,Book_Condition,Campus_ID ) VALUES(@Title,@Author_FName ,@Author_LName ,@Edition ,@Book_Condition,@Campus_ID )";

                    cmd = new MySqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@Title", bookTitle);
                    cmd.Parameters.AddWithValue("@Author_FName", authorName);
                    cmd.Parameters.AddWithValue("@Author_LName", authorSurname);
                    cmd.Parameters.AddWithValue("@Edition", edition);
                    cmd.Parameters.AddWithValue("@Book_Condition", year);
                    cmd.Parameters.AddWithValue("@Campus_ID", bookCondition);
                    cmd.ExecuteNonQuery();

                    // using this command since the ID is incremented in MySQL
                    // long bookID = cmd.LastInsertedId;


                    //string sqlQuery2 = @"INSERT INTO donate_books(Donor_ID, Book_ID , Donation_Date) VALUES(@Donor_ID, @Book_ID , @Donation_Date)";

                    // MySqlCommand cmd2 = new MySqlCommand(sqlQuery2, conn);
                    // cmd2.Parameters.AddWithValue("@Donor_ID", donorID);
                    // cmd2.Parameters.AddWithValue("@Book_ID", bookID);
                    // cmd2.Parameters.AddWithValue("@Donation_Date", donationDate);

                    // cmd2.ExecuteNonQuery();

                    MessageBox.Show("Book added successfully!");
                    conn.Close();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }
        }
    }
}
