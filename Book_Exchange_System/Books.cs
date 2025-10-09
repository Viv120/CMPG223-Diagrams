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
    public partial class Books : Form
    {
        //works with code in App.config
        string connString = ConfigurationManager.ConnectionStrings["BookExchangeConn"].ConnectionString;
        public Books()
        {
            InitializeComponent();
        }

        //loads books from the database
        private void LoadBooks()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM books";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvBooks.DataSource = dt;
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error loading books: " + error.Message);
            }
        }

        //loads book ids into combobox in update panel
        private void LoadBookIDs()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT Book_ID FROM books ORDER BY Book_ID ASC";
                    using (MySqlCommand comm = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = comm.ExecuteReader())
                        {
                            cbBookID.Items.Clear();
                            while (reader.Read())
                            {
                                cbBookID.Items.Add(reader.GetInt32("Book_ID"));
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Book IDs: " + ex.Message);
            }
        }

        //
        //loads book ids into combo box in delete panel
        private void LoadBookIDsDelete()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string selectQuery = "SELECT Book_ID FROM books ORDER BY Book_ID ASC";
                    using (MySqlCommand comm = new MySqlCommand(selectQuery, conn))
                    {
                        using (MySqlDataReader reader = comm.ExecuteReader())
                        {
                            cbDeleteBook.Items.Clear(); //clears old ids in case of changes
                            while (reader.Read())
                            {
                                cbDeleteBook.Items.Add(reader.GetInt32("Book_ID"));
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Book IDs: " + ex.Message);
            }
        }

        //allows user to search for a specific book using: title, author name and lastname
        private void SearchBooks()
        {
            string findWord = txtSearchApp.Text.Trim();

            if (string.IsNullOrEmpty(findWord))
            {
                LoadBooks();
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();

                    string searchQuery = @"SELECT * FROM books WHERE Title LIKE @findWord OR Author_FName LIKE @findWord OR Author_LName LIKE @findWord";

                    using (MySqlCommand cmd = new MySqlCommand(searchQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@findWord", "%" + findWord + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvBooks.DataSource = dt;
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching  for book: " + ex.Message);
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        //opens add books panel
        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            AddBooks.Visible = true;
            AddBooks.BringToFront();
        }

        //opens update books panel
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBook.Visible = true;
            UpdateBook.BringToFront();
            LoadBookIDs(); //makes sure updated book ids are loaded

        }
        //opens delete books panel
        private void btnDeleteBooks_Click(object sender, EventArgs e)
        {
            Deletebooks.Visible = true;
            Deletebooks.BringToFront();
            LoadBookIDsDelete(); //makes sure updated book ids are loaded
        }

        //returns to login form
        private void button7_Click(object sender, EventArgs e)
        {
            Logins loginForm = new Logins();
            loginForm.Show();
            this.Hide();
        }

        //adds the new book
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bookTitle = txtTitle.Text;
            string authorName = txtAName.Text;
            string authorSurname = txtASurname.Text;
            string bookEdition = txtEdition.Text;
            string yearPublished = txtYear.Text;
            int bookCondition = (int)nudCondition.Value;


            int campusID = 0;
            if (rbMahikeng.Checked)
            {
                campusID = 3;
            }
            else if (rbPotch.Checked)
            {
                campusID = 1;
            }
            else if (rbVaal.Checked)
            {
                campusID = 2;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string addQuery = "INSERT INTO books (Title, Author_FName, Author_LName, Edition, Year_Published, Book_Condition, Campus_ID) " + "VALUES (@title, @fname, @lname, @edition, @year, @condition, @campusid)";

                    using (MySqlCommand comm = new MySqlCommand(addQuery, conn))
                    {
                        comm.Parameters.AddWithValue("@title", bookTitle);
                        comm.Parameters.AddWithValue("@fname", authorName);
                        comm.Parameters.AddWithValue("@lname", authorSurname);
                        comm.Parameters.AddWithValue("@edition", bookEdition);
                        comm.Parameters.AddWithValue("@year", yearPublished);
                        comm.Parameters.AddWithValue("@condition", bookCondition);
                        comm.Parameters.AddWithValue("@campusid", campusID);

                        comm.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBooks();

                    conn.Close();

                    txtTitle.Text = "";
                    txtAName.Text = "";
                    txtASurname.Text = "";
                    txtEdition.Text = "";
                    txtYear.Text = "";
                    nudCondition.Value = 1;
                    rbMahikeng.Checked = false;
                    rbPotch.Checked = false;
                    rbVaal.Checked = false;

                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error adding the book into database: " + error);
            }

        }

        private void btnReloadApplicants_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void cbBookID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBookID.SelectedItem != null)
            {
                int bookID = (int)cbBookID.SelectedItem;

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        string showQuery = "SELECT * FROM books WHERE Book_ID = @id";

                        using (MySqlCommand cmd = new MySqlCommand(showQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", bookID);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtUpdateTitle.Text = reader["Title"].ToString();
                                    txtUpdateAName.Text = reader["Author_FName"].ToString();
                                    txtUpdateASurname.Text = reader["Author_LName"].ToString();
                                    txtUpdateEdition.Text = reader["Edition"].ToString();
                                    txtUpdateYear.Text = reader["Year_Published"].ToString();
                                    nudUpdateCondition.Value = Convert.ToInt32(reader["Book_Condition"]);

                                    int campusID = Convert.ToInt32(reader["Campus_ID"]);
                                    if (campusID == 1)
                                        rbUpdatePotch.Checked = true;
                                    else if (campusID == 2)
                                        rbUpdateVaal.Checked = true;
                                    else if (campusID == 3)
                                        rbUpdateMahikeng.Checked = true;
                                }
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error loading book details " + error);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbBookID.SelectedItem == null)
            {
                MessageBox.Show("Please select a Book ID to update.");
                return;
            }

            //update the old book details
            int bookID = (int)cbBookID.SelectedItem;
            string bookTitle = txtUpdateTitle.Text;
            string authorFName = txtUpdateAName.Text;
            string authorLName = txtUpdateASurname.Text;
            string edition = txtUpdateEdition.Text;
            string yearPublished = txtUpdateYear.Text;
            int bookCondition = (int)nudUpdateCondition.Value;

            int campusID = 0;
            if (rbUpdateMahikeng.Checked) campusID = 3;
            else if (rbUpdatePotch.Checked) campusID = 1;
            else if (rbUpdateVaal.Checked) campusID = 2;

            try
            {
                //add new updated details into the database
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string updateQuery = @"UPDATE books SET Title=@title, Author_FName=@fname, Author_LName=@lname, Edition=@edition, Year_Published=@year, Book_Condition=@condition, Campus_ID=@campusid WHERE Book_ID=@id";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", bookTitle);
                        cmd.Parameters.AddWithValue("@fname", authorFName);
                        cmd.Parameters.AddWithValue("@lname", authorLName);
                        cmd.Parameters.AddWithValue("@edition", edition);
                        cmd.Parameters.AddWithValue("@year", yearPublished);
                        cmd.Parameters.AddWithValue("@condition", bookCondition);
                        cmd.Parameters.AddWithValue("@campusid", campusID);
                        cmd.Parameters.AddWithValue("@id", bookID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooks();
                            LoadBookIDs();

                            //clear everything
                            cbBookID.SelectedIndex = 0;
                            txtUpdateTitle.Text = "";
                            txtUpdateAName.Text = "";
                            txtUpdateASurname.Text = "";
                            txtUpdateEdition.Text = "";
                            txtUpdateYear.Text = "";
                            nudUpdateCondition.Value = 1;
                            rbUpdateMahikeng.Checked = false;
                            rbUpdatePotch.Checked = false;
                            rbUpdateVaal.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please check the Book ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book: " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbDeleteBook.SelectedItem == null)
            {
                MessageBox.Show("Please select a Book ID to delete.");
                return;
            }
            int bookID = (int)cbDeleteBook.SelectedItem;

            //make sure the user wants to delete the book
            DialogResult result = MessageBox.Show(
            $"Are you sure you want to delete Book ID {bookID}?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            try
            {
                //delete a specific book using its book id
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM books WHERE Book_ID=@id";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", bookID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooks();
                            LoadBookIDs();
                            LoadBookIDsDelete();
                            cbDeleteBook.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. Check the Book ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting book: " + ex.Message);
            }


        }

        private void btnSearchApplicant_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }
    }
}
