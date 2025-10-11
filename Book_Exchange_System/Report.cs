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
    public partial class Report : Form
    {
        string connString = "server=localhost;user id=bookexchange;password=OurProjectPassword;database=book_exchange_db;";

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void btnIssuedReport_Click(object sender, EventArgs e)
        {
            Issued.Visible = true;
            Donated.Visible = false;
        }

        private void btnDonatedReport_Click(object sender, EventArgs e)
        {
            Issued.Visible = false;
            Donated.Visible = true;
        }

        private void btnIssued_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT b.Title AS 'Book Title', 
                                    i.Applicant_ID AS 'Applicant ID', 
                                    i.Date_Issued AS 'Date Issued'
                             FROM issue_books i
                             INNER JOIN books b ON i.Book_ID = b.Book_ID
                             WHERE i.Date_Issued BETWEEN @StartDate AND @EndDate
                             ORDER BY i.Date_Issued ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvIssue.DataSource = dt;

                    lblIssuedDateRange.Text = $"Books issued from {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}";
                    lblTotalIssued.Text = $"Total Books Issued: {dt.Rows.Count}";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void btnDonated_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpDonatedStart.Value.Date;
            DateTime endDate = dtpDonatedEnd.Value.Date;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT b.Title AS 'Book Title', 
                                    d.Donor_ID AS 'Donor ID', 
                                    d.Donation_Date AS 'Date Donated'
                             FROM donate_books d
                             INNER JOIN books b ON d.Book_ID = b.Book_ID
                             WHERE d.Donation_Date BETWEEN @StartDate AND @EndDate
                             ORDER BY d.Donation_Date ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvDonate.DataSource = dt;

                    lblDonatedDateRange.Text = $"Books donated from {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}";
                    lblTotalDonated.Text = $"Total Books Donated: {dt.Rows.Count}";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }
    }
}
