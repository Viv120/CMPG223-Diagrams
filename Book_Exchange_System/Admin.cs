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

namespace Book_Exchange_System
{
    public partial class Admin : Form
    {
        string connString = "server=localhost;user id=bookexchange;password=OurProjectPassword;database=book_exchange_db;";
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;

        public Admin()
        {
            InitializeComponent();
        }

        private void LoadTable(string tableName, DataGridView dgv)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = $"SELECT * FROM {tableName}";
                    cmd = new MySqlCommand(query, conn);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);

                    dgv.DataSource = dt;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading table: " + ex.Message);
            }
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            Books.Visible = true;
            Applicants.Visible = false;
            Donors.Visible = false;

            LoadTable("books", dgvBooks);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Donors.Visible = false;
            Applicants.Visible = false;
            Books.Visible = false;
        }

        private void btnDeleteDonors_Click(object sender, EventArgs e)
        {
            Books.Visible = false;
            Applicants.Visible = false;
            Donors.Visible = true;

            LoadTable("donor", dgvDonors);
        }

        private void btnDeleteApps_Click(object sender, EventArgs e)
        {
            Books.Visible = false;
            Applicants.Visible = true;
            Donors.Visible = false;

            LoadTable("applicant", dgvApplicants);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report reportForm = new Report();
            reportForm.Show();
        }

        private void btnMaintainBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books maintainBooks = new Books();
            maintainBooks.Show();
        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donors maintainDonors = new Donors();
            maintainDonors.Show();
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            this.Hide();
            Applicants maintainApplicants = new Applicants();
            maintainApplicants.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logins loginForm = new Logins();
            loginForm.Show();
        }
    }
}
