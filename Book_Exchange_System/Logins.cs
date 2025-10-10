using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Book_Exchange_System
{
    public partial class Logins : Form
    {
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public Logins()
        {
            InitializeComponent();
        }

        private bool TestMySqlConnection()
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=book_exchange_db;Uid=root;Pwd=12123;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error" + ex.Message,"Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            bool valid = true;

            String emailAdmin = txtAdminEmail.Text.Trim();
            String password = txtAdminPass.Text;

            if (string.IsNullOrEmpty(emailAdmin) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in required information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;  
            }

            if (!Regex.IsMatch(emailAdmin, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                txtAdminEmail.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAdminEmail, "Invalid email, please enter a valid email (e.g., john.doe@example.com)");
                valid = false;
            }
            else
            {
                valid = true;
            }

            if (!Regex.IsMatch(txtAdminPass.Text, @"^(?=.[A-Z])(?=.*\d)(?=.*[@$!%?&]).{8,}$"))
            {
                txtAppPass.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAdminPass, "Password must be 8+ characters with uppercase, number and special character!");
                valid = false;
            }
            else if (valid = true)
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                Admin.ActiveForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }

            //DB validation
            string connectionString = "Server=127.0.0.1;Port=3306;Database=book_exchange_db;Uid=root;Pwd=12123;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM admin_login WHERE email=@Email AND password=@Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", emailAdmin);
                    cmd.Parameters.AddWithValue("@Password", password);

                    var result = cmd.ExecuteScalar();
                    int matchCount = Convert.ToInt32(result);

                    if (matchCount > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        Admin.ActiveForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }

        private void btnLoginDonor_Click(object sender, EventArgs e)
        {
            bool valid = true;

            String password = txtDonorPass.Text;
            String emailDonor = txtDonorEmail.Text.Trim();

            if (string.IsNullOrEmpty(emailDonor) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in required information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (!Regex.IsMatch(emailDonor, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                txtDonorEmail.BackColor = Color.LightPink;
                errorProvider1.SetError(txtDonorEmail, "Invalid email, please enter a valid email (e.g., john.doe@example.com)");
                valid = false;
            }
            else
            {
                valid = true;
            }

            if (!Regex.IsMatch(txtDonorPass.Text, @"^(?=.[A-Z])(?=.*\d)(?=.*[@$!%?&]).{8,}$"))
            {
                txtDonorPass.BackColor = Color.LightPink;
                errorProvider1.SetError(txtDonorPass, "Password must be 8+ characters with uppercase, number and special character!");
                valid = false;
            }
            else if (valid = true)
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                Donors.ActiveForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }

            //DB validation
            string connectionString = "Server=127.0.0.1;Port=3306;Database=book_exchange_db;Uid=root;Pwd=12123;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM admin_login WHERE email=@Email AND password=@Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", emailDonor);
                    cmd.Parameters.AddWithValue("@Password", password);

                    var result = cmd.ExecuteScalar();  
                    int matchCount = Convert.ToInt32(result);

                    if (matchCount > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        Donors.ActiveForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }

        private void btnLoginApp_Click(object sender, EventArgs e)
        {
            bool valid = true;

            String emailApplicants = txtAppEmail.Text.Trim();
            String password = txtAppPass.Text;

            if (string.IsNullOrEmpty(emailApplicants) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in required information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (!Regex.IsMatch(emailApplicants, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                txtAppEmail.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAppEmail, "Invalid email, please enter a valid email (e.g., john.doe@example.com)");
                valid = false;
            }
            else
            {
                valid = true;
            }

            if (!Regex.IsMatch(txtAppPass.Text, @"^(?=.[A-Z])(?=.*\d)(?=.*[@$!%?&]).{8,}$"))
            {
                txtAppPass.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAppPass, "Password must be 8+ characters with uppercase, number and special character!");
                valid = false;
            }
            else if (valid = true)
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                Applicants.ActiveForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }

            //DB validation
            string connectionString = "Server=127.0.0.1;Port=3306;Database=book_exchange_db;Uid=root;Pwd=12123;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM admin_login WHERE email=@Email AND password=@Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", emailApplicants);
                    cmd.Parameters.AddWithValue("@Password", password);

                    var result = cmd.ExecuteScalar();
                    int matchCount = Convert.ToInt32(result);

                    if (matchCount > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        Applicants.ActiveForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }

        private void ShowResetPasswordPopup()
        {
            //small dialog for resetting the password
            Form resetPopup = new Form();
            resetPopup.Text = "Reset Password";
            resetPopup.Size = new Size(350, 250);
            resetPopup.StartPosition = FormStartPosition.CenterParent;
            resetPopup.FormBorderStyle = FormBorderStyle.FixedDialog;
            resetPopup.MaximizeBox = false;
            resetPopup.MinimizeBox = false;

            Label lblEmail = new Label() { Text = "Email:", Left = 20, Top = 20, Width = 100 };
            TextBox inputEmail = new TextBox() { Left = 130, Top = 20, Width = 180 };
            Label lblPass = new Label() { Text = "New Password:", Left = 20, Top = 60, Width = 100 };
            TextBox inputPass = new TextBox() { Left = 130, Top = 60, Width = 180, UseSystemPasswordChar = true };
            Button btnReset = new Button() { Text = "Reset", Left = 130, Top = 110, Width = 80 };
            Button btnCancel = new Button() { Text = "Cancel", Left = 230, Top = 110, Width = 80 };

            resetPopup.Controls.Add(lblEmail);
            resetPopup.Controls.Add(inputEmail);
            resetPopup.Controls.Add(lblPass);
            resetPopup.Controls.Add(inputPass);
            resetPopup.Controls.Add(btnReset);
            resetPopup.Controls.Add(btnCancel);

            btnCancel.Click += (s, e) => resetPopup.Close();

            btnReset.Click += (s, e) =>
            {
                String email = inputEmail.Text.Trim();
                String newPass = inputPass.Text.Trim();

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPass))
                {
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("That doesn't seem like a valid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(newPass, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%?&]).{8,}$"))
                {
                    MessageBox.Show("Password must be 8+ chars with uppercase, number, and special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string dbConnStr = "Server=127.0.0.1;Port=3306;Database=book_exchange_db;Uid=root;Pwd=12123;";

                bool wasUpdated = false;

                using (var conn = new MySqlConnection(dbConnStr))
                {
                    try
                    {
                        conn.Open();
                        var userTables = new[] { "admin_login", "donor_login", "applicant_login" };

                        foreach (var tbl in userTables)
                        {
                            string checkSql = $"SELECT COUNT(*) FROM {tbl} WHERE email=@Email";
                            var checkCmd = new MySqlCommand(checkSql, conn);
                            checkCmd.Parameters.AddWithValue("@Email", email);

                            int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                            if (exists > 0)
                            {
                                string updateSql = $"UPDATE {tbl} SET password=@NewPassword WHERE email=@Email";
                                var updateCmd = new MySqlCommand(updateSql, conn);
                                updateCmd.Parameters.AddWithValue("@NewPassword", newPass);
                                updateCmd.Parameters.AddWithValue("@Email", email);
                                updateCmd.ExecuteNonQuery();

                                MessageBox.Show($"Password reset successful for {tbl.Replace("_login", "")}!",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                wasUpdated = true;
                                resetPopup.Close(); 
                                break;
                            }
                        }

                        if (!wasUpdated)
                        {
                            MessageBox.Show("No account found with that email.",
                                "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message,
                            "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            resetPopup.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            ShowResetPasswordPopup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowResetPasswordPopup();
        }

        private void btnNewPassApp_Click(object sender, EventArgs e)
        {
            ShowResetPasswordPopup();
        }

        private void ShowRegisterPopup(string userType)
        {
            Form popup = new Form(); 
            popup.Text = $"{userType} Registration";
            popup.Size = new Size(350, 250);
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.FormBorderStyle = FormBorderStyle.FixedDialog;
            popup.MaximizeBox = false;
            popup.MinimizeBox = false;

            Label lblEmail = new Label() { Text = "Email:", Left = 20, Top = 20, Width = 100 };
            TextBox txtEmail = new TextBox() { Left = 130, Top = 20, Width = 180 };
            Label lblPwd = new Label() { Text = "Password:", Left = 20, Top = 60, Width = 100 };
            TextBox txtPwd = new TextBox() { Left = 130, Top = 60, Width = 180, UseSystemPasswordChar = true };
            Label lblRePwd = new Label() { Text = "Confirm Password:", Left = 20, Top = 100, Width = 120 };
            TextBox txtRePwd = new TextBox() { Left = 130, Top = 100, Width = 180, UseSystemPasswordChar = true };
            Button btnSubmit = new Button() { Text = "Register", Left = 130, Top = 150, Width = 80 };
            Button btnExit = new Button() { Text = "Cancel", Left = 230, Top = 150, Width = 80 };

            popup.Controls.Add(lblEmail);
            popup.Controls.Add(txtEmail);
            popup.Controls.Add(lblPwd);
            popup.Controls.Add(txtPwd);
            popup.Controls.Add(lblRePwd);
            popup.Controls.Add(txtRePwd);
            popup.Controls.Add(btnSubmit);
            popup.Controls.Add(btnExit);

            btnExit.Click += (object sender, EventArgs args) =>
            {
                popup.Close();  
            };

            btnSubmit.Click += (object sender, EventArgs args) =>
            {
                string enteredEmail = txtEmail.Text.Trim();
                string enteredPwd = txtPwd.Text;
                string repeatedPwd = txtRePwd.Text;

                if (string.IsNullOrWhiteSpace(enteredEmail) || string.IsNullOrEmpty(enteredPwd))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(enteredEmail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("Password invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (enteredPwd != repeatedPwd)
                {
                    MessageBox.Show("Passwords don't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(enteredPwd, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%?&]).{8,}$"))
                {
                    MessageBox.Show("Password should be at least 8 chars long and include uppercase, number, and symbol.","Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string dbTable = userType == "Donor" ? "donor_login" : "applicant_login";
                string connString = "Server=127.0.0.1;Port=3306;Database=book_exchange_db;Uid=root;Pwd=12123;";

                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    try
                    {
                        connection.Open();

                        string checkQuery = $"SELECT COUNT(*) FROM {dbTable} WHERE email = @Email";
                        MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                        checkCmd.Parameters.AddWithValue("@Email", enteredEmail);

                        int emailExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (emailExists > 0)
                        {
                            MessageBox.Show("Email already exists in system.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string insertQuery = $"INSERT INTO {dbTable} (email, password) VALUES (@Email, @Password)";
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                        insertCmd.Parameters.AddWithValue("@Email", enteredEmail);
                        insertCmd.Parameters.AddWithValue("@Password", enteredPwd);  
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show($"{userType} registered successfully!", "Nice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        popup.Close();
                    }
                    catch (MySqlException dbEx)
                    {
                        MessageBox.Show("Database error occurred: " + dbEx.Message, "DB Error");
                    }
                }
            };

            popup.ShowDialog();
        }

        private void btnRegisterApp_Click(object sender, EventArgs e)
        {
            ShowRegisterPopup("Applicant");
        }

        private void btnRegisterDonor_Click(object sender, EventArgs e)
        {
            ShowRegisterPopup("Donor");
        }
    }
}
