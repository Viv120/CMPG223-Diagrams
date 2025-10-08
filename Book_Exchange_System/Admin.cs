using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Exchange_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Connection string (adjust if needed)
                string path = "Server=localhost;Database=book_exchange_db;Uid=root;Pwd=cmpg223;";

                using (MySqlConnection con = new MySqlConnection(path))
                {
                    con.Open();

                    // ✅ SQL query to retrieve all books
                    string query = "SELECT * FROM books";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    // ✅ Display data in DataGridView1
                    dataGridView1.DataSource = null;  // clear previous binding (optional but safe)
                    dataGridView1.Rows.Clear();       // clear rows before reloading
                    dataGridView1.DataSource = dt;

                    // ✅ Make columns fill the grid for a clean look
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                MessageBox.Show("Books loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDeleteDonors_Click(object sender, EventArgs e)
        {
            try
            {

                string applicantText = cbDeleteApp.Text.Trim();
                if (string.IsNullOrWhiteSpace(applicantText))
                {
                    MessageBox.Show("Please select or enter an Donor ID.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(applicantText, out int applicantId))
                {
                    MessageBox.Show("Donor ID must be a number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show($"Are you sure you want to delete Donor ID {applicantId}?",
                                              "Confirm Deletion",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                    return;

                string connStr = "Server=localhost;Database=book_exchange_db;Uid=root;Pwd=cmpg223;";
                using (MySqlConnection con = new MySqlConnection(connStr))
                {
                    con.Open();
                    MessageBox.Show("Connection successful!", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string query = "DELETE FROM Donor WHERE donor_id = @ApplicantId";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantId", applicantId);

                        int rows = cmd.ExecuteNonQuery();

                        // STEP 6: Show result
                        if (rows > 0)
                        {
                            MessageBox.Show($"Donor with ID {applicantId} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"No applicant found with ID {applicantId}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteApps_Click(object sender, EventArgs e)
        {
            try
            {
             
                string applicantText = cbDeleteApp.Text.Trim();
                if (string.IsNullOrWhiteSpace(applicantText))
                {
                    MessageBox.Show("Please select or enter an Applicant ID.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(applicantText, out int applicantId))
                {
                    MessageBox.Show("Applicant ID must be a number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show($"Are you sure you want to delete Applicant ID {applicantId}?",
                                              "Confirm Deletion",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                    return;

                string connStr = "Server=localhost;Database=book_exchange_db;Uid=root;Pwd=cmpg223;";
                using (MySqlConnection con = new MySqlConnection(connStr))
                {
                    con.Open();
                    MessageBox.Show("Connection successful!", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string query = "DELETE FROM applicant WHERE applicant_id = @ApplicantId";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantId", applicantId);

                        int rows = cmd.ExecuteNonQuery();

                        // STEP 6: Show result
                        if (rows > 0)
                        {
                            MessageBox.Show($"Applicant with ID {applicantId} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"No applicant found with ID {applicantId}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnReports_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Connection string (adjust if needed)
                string path = "Server=localhost;Database=book_exchange_db;Uid=root;Pwd=cmpg223;";

                using (MySqlConnection con = new MySqlConnection(path))
                {
                    con.Open();

                    // ✅ SQL query to retrieve all books
                    string query = "SELECT * FROM issue_books";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    // ✅ Display data in DataGridView1
                    dataGridView1.DataSource = null;  // clear previous binding (optional but safe)
                    dataGridView1.Rows.Clear();       // clear rows before reloading
                    dataGridView1.DataSource = dt;

                    // ✅ Make columns fill the grid for a clean look
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                MessageBox.Show("Donors Reloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearchDonor_Click(object sender, EventArgs e)
        {
         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReloadDonors_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Connection string (adjust if needed)
                string path = "Server=localhost;Database=book_exchange_db;Uid=root;Pwd=cmpg223;";

                using (MySqlConnection con = new MySqlConnection(path))
                {
                    con.Open();

                    // ✅ SQL query to retrieve all books
                    string query = "SELECT * FROM donor";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    // ✅ Display data in DataGridView1
                    dataGridView1.DataSource = null;  // clear previous binding (optional but safe)
                    dataGridView1.Rows.Clear();       // clear rows before reloading
                    dataGridView1.DataSource = dt;

                    // ✅ Make columns fill the grid for a clean look
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                MessageBox.Show("Donors Reloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchApp_Click(object sender, EventArgs e)
        {
            // Read search text from the textbox you specified
            string searchText = txtSearchApplicant.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter search terms.", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connStr = "Server=localhost;Database=book_exchange_db;Uid=root;Pwd=cmpg223;";

                // Split into words so multi-word partial searches work
                var words = searchText
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(w => w.Trim())
                    .ToArray();

                if (words.Length == 0)
                {
                    MessageBox.Show("Please enter valid search terms.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Columns to search (book_id cast to string so numeric IDs match text search)
                var columns = new[] { "CAST(book_id AS CHAR)", "Title", "Author_FName", "Author_LName", "Edition", "Year_Published", "Book_Condition", "Campus_ID"};

                // Build WHERE clause: for each search word require it to match at least one column (AND between words)
                var whereParts = new List<string>();
                for (int i = 0; i < words.Length; i++)
                {
                    var orParts = columns.Select(c => $"{c} LIKE @p{i}").ToArray();
                    whereParts.Add("(" + string.Join(" OR ", orParts) + ")");
                }

                string sql = "SELECT Book_ID, title, author_FName, author_LName, Edition, Year_Published, Book_Condition, Campus_ID FROM books WHERE " + string.Join(" AND ", whereParts) + " LIMIT 500;";

                using (var con = new MySqlConnection(connStr))
                using (var cmd = new MySqlCommand(sql, con))
                {
                    // Add parameters for each word (used across all columns for that word)
                    for (int i = 0; i < words.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@p{i}", "%" + words[i] + "%");
                    }

                    var da = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);

                    // Display results
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No matching books found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReloadApplicants_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Connection string (adjust if needed)
                string path = "Server=localhost;Database=book_exchange_db;Uid=root;Pwd=cmpg223;";

                using (MySqlConnection con = new MySqlConnection(path))
                {
                    con.Open();

                    // ✅ SQL query to retrieve all books
                    string query = "SELECT * FROM applicant";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    // ✅ Display data in DataGridView1
                    dataGridView1.DataSource = null;  // clear previous binding (optional but safe)
                    dataGridView1.Rows.Clear();       // clear rows before reloading
                    dataGridView1.DataSource = dt;

                    // ✅ Make columns fill the grid for a clean look
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                MessageBox.Show("Applicants Reloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
