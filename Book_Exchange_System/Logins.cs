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
    public partial class Logins : Form
    {
        string connString = "server=localhost;user id=bookexchange;password=OurProjectPassword;database=book_exchange_db;";

        MySqlCommand cmd;

        public Logins()
        {
            InitializeComponent();
        }

        private void Logins_Load(object sender, EventArgs e)
        {
            txtAdminEmail.Clear();
            txtAdminPass.Clear();
            txtDonorEmail.Clear();
            txtDonorPass.Clear();
            txtAppEmail.Clear();
            txtAppPass.Clear();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            string email = txtAdminEmail.Text;
            string password = txtAdminPass.Text;

            if (!ValidateFields(email, password, txtAdminEmail, txtAdminPass))
            {
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM admin_login WHERE " +
                                   "email=@Email AND password=@Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int matchCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (matchCount > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Admin adminForm = new Admin();
                        adminForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void btnLoginDonor_Click(object sender, EventArgs e)
        {
            string password = txtDonorPass.Text;
            string email = txtDonorEmail.Text;
            string defaultPassword = "Donor123!";

            if (!ValidateFields(email, password, txtDonorEmail, txtDonorPass))
            {
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM donor_login WHERE email=@Email AND password=@Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int matchCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (matchCount > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        DonateBooks donorForm = new DonateBooks(email);
                        donorForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        string resetQuery = "UPDATE donor_login SET Password = @DefaultPassword WHERE Email = @Email";
                        MySqlCommand resetCmd = new MySqlCommand(resetQuery, conn);
                        resetCmd.Parameters.AddWithValue("@DefaultPassword", defaultPassword);
                        resetCmd.Parameters.AddWithValue("@Email", email);
                        int updated = resetCmd.ExecuteNonQuery();

                        if (updated > 0)
                        {
                            MessageBox.Show("Incorrect password. Your password has been reset to the default: " +
                                            $"{defaultPassword}\nPlease log in again and update it in your profile.",
                                            "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Login failed! Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void btnLoginApp_Click(object sender, EventArgs e)
        {
            String email = txtAppEmail.Text;
            String password = txtAppPass.Text;
            string defaultPassword = "Applicant123!";

            if (!ValidateFields(email, password, txtAppEmail, txtAppPass))
            {
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM applicant_login WHERE email=@Email AND password=@Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int matchCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (matchCount > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        RequestBooks requestForm = new RequestBooks(email);
                        requestForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        string resetQuery = "UPDATE applicant_login SET Password = @DefaultPassword WHERE Email = @Email";
                        MySqlCommand resetCmd = new MySqlCommand(resetQuery, conn);
                        resetCmd.Parameters.AddWithValue("@DefaultPassword", defaultPassword);
                        resetCmd.Parameters.AddWithValue("@Email", email);
                        int updated = resetCmd.ExecuteNonQuery();

                        if (updated > 0)
                        {
                            MessageBox.Show("Incorrect password. Your password has been reset to the default: " +
                                            $"{defaultPassword}\nPlease log in again and update it in your profile.",
                                            "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Login failed! Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private bool ValidateFields(string email, string password, TextBox emailBox, TextBox passBox)
        {
            bool valid = true;

            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                emailBox.BackColor = Color.LightPink;
                errorProvider1.SetError(emailBox, "Enter a valid email (e.g., john.doe@example.com)");
                valid = false;
            }
            else
            {
                emailBox.BackColor = Color.White;
                errorProvider1.SetError(emailBox, "");
            }

            if (string.IsNullOrEmpty(password) || !Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%?&]).{8,}$"))
            {
                txtDonorPass.BackColor = Color.LightPink;
                errorProvider1.SetError(txtDonorPass, "Password must be 8+ characters with uppercase, number and special character!");
                valid = false;
            }
            else
            {
                passBox.BackColor = Color.White;
                errorProvider1.SetError(passBox, "");
            }

            return valid;
        }

        private void btnResetAdmin_Click(object sender, EventArgs e)
        {
            string email = txtAdminEmail.Text;
            string newPassword = "Admin123!";

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Enter admin email first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string resetQuery = "UPDATE admin_login SET Password = @Password WHERE Email = @Email";
                    MySqlCommand cmd = new MySqlCommand(resetQuery, conn);
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Email", email);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show($"Password reset successful! New password: {newPassword}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void btnRegisterDonor_Click(object sender, EventArgs e)
        {
            DonateBooks donorForm = new DonateBooks(null);
            donorForm.Show();
            this.Hide();
        }

        private void btnRegisterApp_Click(object sender, EventArgs e)
        {
            RequestBooks requestForm = new RequestBooks(null);
            requestForm.Show();
            this.Hide();
        }
    } 
}

