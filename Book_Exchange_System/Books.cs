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
    public partial class Books : Form
    {
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
                            cmbBookID.Items.Clear();
                            while (reader.Read())
                            {
                                cmbBookID.Items.Add(reader.GetInt32("Book_ID"));
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
                            cmbDeleteBook.Items.Clear(); //clears old ids in case of changes
                            cmbBookID.Items.Clear();
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("Book_ID");
                                cmbBookID.Items.Add(id);
                                cmbDeleteBook.Items.Add(id);
                            }
                        }
                    }
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
            string findWord = txtSearchBook.Text.Trim();

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching  for book: " + ex.Message);
            }
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        //adds the new book
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool valid = true;

            string bookTitle = txtTitle.Text;
            string authorName = txtAName.Text;
            string authorSurname = txtASurname.Text;
            string bookEdition = txtEdition.Text;
            string yearPublished = txtYear.Text;
            int bookCondition = (int)nudCondition.Value;


            int campusID = 0;
            if (rbMahikeng.Checked)
            {
                campusID = 2;
            }
            else if (rbPotch.Checked)
            {
                campusID = 1;
            }
            else if (rbVaal.Checked)
            {
                campusID = 3;
            }

            errorProvider1.Clear();
            txtTitle.BackColor = SystemColors.Window;
            txtAName.BackColor = SystemColors.Window;
            txtASurname.BackColor = SystemColors.Window;
            txtEdition.BackColor = SystemColors.Window;
            txtYear.BackColor = SystemColors.Window;
            nudCondition.BackColor = SystemColors.Window;
            rbPotch.BackColor = SystemColors.Control;
            rbMahikeng.BackColor = SystemColors.Control;
            rbVaal.BackColor = SystemColors.Control;

            if (string.IsNullOrWhiteSpace(bookTitle))
            {
                txtTitle.BackColor = Color.LightPink;
                errorProvider1.SetError(txtTitle, "Please enter a title!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(authorName))
            {
                txtAName.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAName, "Please enter a name!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(authorSurname))
            {
                txtASurname.BackColor = Color.LightPink;
                errorProvider1.SetError(txtASurname, "Please enter a surname!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(bookEdition))
            {
                txtEdition.BackColor = Color.LightPink;
                errorProvider1.SetError(txtEdition, "Please enter the edition!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(yearPublished))
            {
                txtYear.BackColor = Color.LightPink;
                errorProvider1.SetError(txtYear, "Please enter a year!");
                valid = false;
            }
            if (!Regex.IsMatch(txtYear.Text, @"^\d{4}$"))
            {
                txtYear.BackColor = Color.LightPink;
                errorProvider1.SetError(txtYear, "Year published must be 4 digits!");
                valid = false;
            }
            if (bookCondition <= 0)
            {
                nudCondition.BackColor = Color.LightPink;
                errorProvider1.SetError(nudCondition, "Please enter a valid book condition!");
                valid = false;
            }
            if (campusID == 0)
            {
                rbPotch.BackColor = Color.LightPink;
                rbMahikeng.BackColor = Color.LightPink;
                rbVaal.BackColor = Color.LightPink;
                errorProvider1.SetError(rbPotch, "Please select a campus!");
                valid = false;
            }
            else
            {
                rbPotch.BackColor = SystemColors.Control;
                rbMahikeng.BackColor = SystemColors.Control;
                rbVaal.BackColor = SystemColors.Control;
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

                    MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK);
                    LoadBooks();

                    txtTitle.Clear();
                    txtAName.Clear();
                    txtASurname.Clear();
                    txtEdition.Clear();
                    txtYear.Clear();
                    nudCondition.Value = 1;
                    rbMahikeng.Checked = false;
                    rbPotch.Checked = false;
                    rbVaal.Checked = false;

                    errorProvider1.Clear();
                    txtTitle.BackColor = SystemColors.Window;
                    txtAName.BackColor = SystemColors.Window;
                    txtASurname.BackColor = SystemColors.Window;
                    txtEdition.BackColor = SystemColors.Window;
                    txtYear.BackColor = SystemColors.Window;
                    nudCondition.BackColor = SystemColors.Window;
                    rbPotch.BackColor = SystemColors.Control;
                    rbMahikeng.BackColor = SystemColors.Control;
                    rbVaal.BackColor = SystemColors.Control;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error adding book: " + error);
            }

        }

        private void btnReloadBooks_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void cmbBookID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBookID.SelectedItem == null)
            {
                return;
            }

            int selectedID = Convert.ToInt32(cmbBookID.SelectedItem);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string showQuery = "SELECT * FROM books WHERE Book_ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(showQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedID);

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
                                {
                                    rbUpdatePotch.Checked = true;
                                }
                                else if (campusID == 2)
                                {
                                    rbUpdateMahikeng.Checked = true;
                                }
                                else if (campusID == 3)
                                {
                                    rbUpdateVaal.Checked = true;
                                }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBookID.SelectedItem == null)
            {
                MessageBox.Show("Please select a Book ID to update.");
                return;
            }

            //update the old book details
            int selectedID = Convert.ToInt32(cmbBookID.SelectedItem);
            string bookTitle = txtUpdateTitle.Text;
            string authorFName = txtUpdateAName.Text;
            string authorLName = txtUpdateASurname.Text;
            string edition = txtUpdateEdition.Text;
            string yearPublished = txtUpdateYear.Text;
            int bookCondition = (int)nudUpdateCondition.Value;

            int campusID = 0;
            if (rbUpdatePotch.Checked) 
            {
                campusID = 1;
            }
            else if (rbUpdateMahikeng.Checked)
            {
                campusID = 2;
            }
            else if (rbUpdateVaal.Checked)
            {
                campusID = 3;
            }

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
                        cmd.Parameters.AddWithValue("@id", selectedID);

                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBooks();
                        LoadBookIDs();

                        //clear everything
                        cmbBookID.SelectedIndex = -1;
                        txtUpdateTitle.Clear();
                        txtUpdateAName.Clear();
                        txtUpdateASurname.Clear();
                        txtUpdateEdition.Clear();
                        txtUpdateYear.Clear();
                        nudUpdateCondition.Value = 1;
                        rbUpdateMahikeng.Checked = false;
                        rbUpdatePotch.Checked = false;
                        rbUpdateVaal.Checked = false;
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
            if (cmbDeleteBook.SelectedItem == null)
            {
                MessageBox.Show("Please select a Book ID to delete.");
                return;
            }
            int bookID = Convert.ToInt32(cmbDeleteBook.SelectedItem);

            //make sure the user wants to delete the book
            DialogResult result = MessageBox.Show(
            $"Are you sure you want to delete this Book?",
            "Confirm Delete",
            MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }

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

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBooks();
                        LoadBookIDs();
                        LoadBookIDsDelete();
                        cmbDeleteBook.SelectedIndex = -1;
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
            string findWord = txtSearchBook.Text;

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

                    string searchQuery = @"SELECT * FROM books WHERE (Title LIKE @findWord OR Author_FName LIKE @findWord OR Author_LName LIKE @findWord)";

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for book: " + ex.Message);
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtSearchBook.Clear();

            LoadBooks();
        }
    }
}
