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

namespace Book_Exchange_System
{
    public partial class Admin : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=book_exchange_db;Uid=root;Pwd=Viv20050209!");
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
                conn.Open();

                string query = $"SELECT * FROM {tableName}";
                cmd = new MySqlCommand(query, conn);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                dgv.DataSource = dt;

                conn.Close();
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
            Report reportForm = new Report();
            reportForm.Show();
            this.Close();
        }

        private void btnMaintainBooks_Click(object sender, EventArgs e)
        {
            Books maintainBooks = new Books();
            maintainBooks.Show();
            this.Hide();
        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            Donors maintainDonors = new Donors();
            maintainDonors.Show();
            this.Hide();
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            Applicants maintainApplicants = new Applicants();
            maintainApplicants.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Logins loginForm = new Logins();
            loginForm.Show();
            this.Hide();
        }
    }
}
