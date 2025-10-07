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
using System.Text.RegularExpressions;

namespace Book_Exchange_System
{
    public partial class Applicants : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=book_exchange_db;Uid=root;Pwd=Viv20050209!");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader reader;

        public Applicants()
        {
            InitializeComponent();
        }

        private void Applicants_Load(object sender, EventArgs e)
        {
            ShowPanels(Search);
            LoadApplicants();
        }

        private void LoadApplicants()
        { 
            try
            {
                string query = "SELECT * FROM applicant";
                cmd = new MySqlCommand(query, conn);

                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();

                da.Fill(dt);

                dgvApplicants.DataSource = dt;
                dgvApplicants.Refresh();

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ShowPanels(Panel panel) 
        {
            AddApplicants.Visible = false;
            UpdateApplicants.Visible = false;
            DeleteApplicants.Visible = false;
            RequestBooks.Visible = false;
            Search.Visible = false;            

            panel.Visible = true;
            panel.BringToFront();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddApplicants_Click(object sender, EventArgs e)
        {
            ShowPanels(AddApplicants);
        }

        private void btnUpdateApplicants_Click(object sender, EventArgs e)
        {
            ShowPanels(UpdateApplicants);

            try
            {
                conn.Open();

                string query = "SELECT Applicant_ID FROM applicant";

                cmd = new MySqlCommand(query, conn);

                using(reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        int App_ID = reader.GetInt32("Applicant_ID");
                        cmbAppID.Items.Add(App_ID);
                    }
                }

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnDeleteApplicants_Click(object sender, EventArgs e)
        {
            ShowPanels(DeleteApplicants);

            try
            {
                conn.Open();

                string query = "SELECT Applicant_ID FROM applicant";

                cmd = new MySqlCommand(query, conn);

                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int App_ID = reader.GetInt32("Applicant_ID");
                        cmbDeleteApp.Items.Add(App_ID);
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            ShowPanels(RequestBooks);
        }

        private void cmbAppID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAppID.SelectedItem == null)
            {
                return;
            }

            int selectedID = Convert.ToInt32(cmbAppID.SelectedItem);

            try
            {
                conn.Open();

                string query = "SELECT * FROM applicant WHERE Applicant_ID = @ID";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", selectedID);

                using(reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        txtNewName.Text = reader["First_Name"].ToString();
                        txtNewSurname.Text = reader["Last_Name"].ToString();
                        txtNewEmail.Text = reader["Email"].ToString();

                        int campusID = Convert.ToInt32(reader["Campus_ID"]);

                        if(campusID == 1)
                        {
                            rdoPotch.Checked = true;
                        }
                        else if (campusID == 2)
                        {
                            rdoMahikeng.Checked = true;
                        }
                        else if (campusID == 3)
                        {
                            rdoVaal.Checked = true;
                        }
                    }
                }

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cmbAppID.SelectedItem == null)
            {
                MessageBox.Show("Please select an applicant");
                return;
            }


            int selectedID = Convert.ToInt32(cmbAppID.SelectedItem);
            string Name = txtNewName.Text;
            string Surname = txtNewSurname.Text;
            string Email = txtNewEmail.Text;

            int campusID = 0;
            if(rdoPotch.Checked)
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

            try
            {
                conn.Open();

                string updateQuery = @"UPDATE applicant SET First_Name = @FirstName, Last_Name = @LastName, Email = @Email, Campus_ID = @Campus_ID WHERE Applicant_ID = @ID";

                cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@FirstName", Name);
                cmd.Parameters.AddWithValue("@LastName", Surname);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Campus_ID", campusID);
                cmd.Parameters.AddWithValue("@ID", selectedID);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Applicant updated successfully!");
                LoadApplicants();
                conn.Close();

                txtNewName.Clear();
                txtNewSurname.Clear();
                txtNewEmail.Clear();
                cmbAppID.SelectedIndex = -1;
                rdoPotch.Checked = false;
                rdoMahikeng.Checked = false;
                rdoVaal.Checked = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error updating applicant: " + ex.Message);
            }
        }

        private void btnReloadApplicants_Click(object sender, EventArgs e)
        {
            LoadApplicants();
        }

        private void btnAddApplicant_Click(object sender, EventArgs e)
        {
            bool valid = true;

            string name = txtAName.Text;
            string surname = txtASurname.Text;
            string studentNum = txtStudents.Text;
            string email = txtEmail.Text;
            string password = txtAppPass.Text;

            int campusID = 0;
            if (rdoP.Checked)
            {
                campusID = 1;
            }
            else if (rdoM.Checked)
            {
                campusID = 2;
            }
            else if (rdoV.Checked)
            {
                campusID = 3;
            }

            errorProvider1.Clear();

            txtAName.BackColor = SystemColors.Window;
            txtASurname.BackColor = SystemColors.Window;
            txtStudents.BackColor = SystemColors.Window;
            txtEmail.BackColor = SystemColors.Window;
            txtAppPass.BackColor = SystemColors.Window;
            rdoP.BackColor = SystemColors.Control;
            rdoM.BackColor = SystemColors.Control;
            rdoV.BackColor = SystemColors.Control;

            if (string.IsNullOrWhiteSpace(name))
            {
                txtAName.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAName, "Please enter a name!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                txtASurname.BackColor = Color.LightPink;
                errorProvider1.SetError(txtASurname, "Please enter a surname!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(studentNum))
            {
                txtStudents.BackColor = Color.LightPink;
                errorProvider1.SetError(txtStudents, "Please enter a student number!");
                valid = false;
            }
            if(!Regex.IsMatch(txtStudents.Text, @"^\d{8}$"))
            {
                txtStudents.BackColor = Color.LightPink;
                errorProvider1.SetError(txtStudents, "Student number must be 8 digits!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                txtEmail.BackColor = Color.LightPink;
                errorProvider1.SetError(txtEmail, "Please enter a email!");
                valid = false;
            }
            if (!email.Contains("@"))
            {
                txtEmail.BackColor = Color.LightPink;
                errorProvider1.SetError(txtEmail, "Please enter a valid email containing @!");
                valid = false;
            }
            if(!Regex.IsMatch(txtAppPass.Text, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$"))
            {
                txtAppPass.BackColor = Color.LightPink;
                errorProvider1.SetError(txtAppPass, "Password must be 8+ characters with uppercase, number and special character!");
                valid = false;
            }
            if (campusID == 0)
            {
                rdoP.BackColor = Color.LightPink;
                rdoM.BackColor = Color.LightPink;
                rdoV.BackColor = Color.LightPink;
                errorProvider1.SetError(rdoP, "Please select a campus!");
                valid = false;
            }
            else
            {
                rdoP.BackColor = SystemColors.Control;
                rdoM.BackColor = SystemColors.Control;
                rdoV.BackColor = SystemColors.Control;
            }
            
            if(!valid)
            {
                return;
            }

            try
            {
                conn.Open();

                string queryApplicant = @"INSERT INTO applicant (First_Name, Last_Name, Student_Num, Email, Campus_ID) VALUES (@FirstName, @LastName, @StudentNum, @Email, @CampusID)";

                cmd = new MySqlCommand(queryApplicant, conn);
                cmd.Parameters.AddWithValue("@FirstName", name);
                cmd.Parameters.AddWithValue("@LastName", surname);
                cmd.Parameters.AddWithValue("@StudentNum", studentNum);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@CampusID", campusID);
                cmd.ExecuteNonQuery();

                long newApplicantID = cmd.LastInsertedId;

                string queryLogin = @"INSERT INTO applicant_login (Applicant_ID, Email, Password) VALUES (@ApplicantID, @Email, @Password)";

                cmd = new MySqlCommand(queryLogin, conn);
                cmd.Parameters.AddWithValue("@ApplicantID", newApplicantID);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Applicant added successfully!");
                LoadApplicants();

                txtAName.Clear();
                txtASurname.Clear();
                txtStudents.Clear();
                txtEmail.Clear();
                txtAppPass.Clear();
                rdoP.Checked = false;
                rdoM.Checked = false;
                rdoV.Checked = false;

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error adding applicant: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbDeleteApp.SelectedItem == null)
            {
                MessageBox.Show("Please select an applicant to delete");
                return;
            }


            int applicantID = Convert.ToInt32(cmbDeleteApp.SelectedItem);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this applicant?", "Confirm Delete", MessageBoxButtons.YesNo);

            if(result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                conn.Open();

                string deleteLoginQuery = @"DELETE FROM applicant_login WHERE Applicant_ID = @ApplicantID";

                cmd = new MySqlCommand(deleteLoginQuery, conn);
                cmd.Parameters.AddWithValue("@ApplicantID", applicantID);
                cmd.ExecuteNonQuery();

                string deleteApplicantQuery = @"DELETE FROM applicant WHERE Applicant_ID = @ApplicantID";

                cmd = new MySqlCommand(deleteApplicantQuery, conn);
                cmd.Parameters.AddWithValue("@ApplicantID", applicantID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Applicant deleted successfully!");
                LoadApplicants();
                cmbDeleteApp.SelectedIndex = -1;
                conn.Close();

                txtNewName.Clear();
                txtNewSurname.Clear();
                txtNewEmail.Clear();
                cmbAppID.SelectedIndex = -1;
                rdoPotch.Checked = false;
                rdoMahikeng.Checked = false;
                rdoVaal.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating applicant: " + ex.Message);
            }
        }
    }
}
