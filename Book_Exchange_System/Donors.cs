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
    public partial class Donors: Form
    {
        private string connString = ConfigurationManager.ConnectionStrings["BookexchangeConn"].ConnectionString;
        
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlDataReader reader;
        public Donors()
        {
            InitializeComponent();
        }

        private void LoadDonors()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM donor";
                    cmd = new MySqlCommand(query, conn);

                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();

                    da.Fill(dt);

                    dgvDonors.DataSource = dt;
                    dgvDonors.Refresh();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RefreshDonorID()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    cmbDonorID.Items.Clear();
                    cmbDeleteDonor.Items.Clear();

                    conn.Open();

                    string query = "SELECT Donor_ID FROM donor ORDER BY Donor_ID ASC";
                    using (MySqlCommand comm = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = comm.ExecuteReader())
                        {
                            cmbDonorID.Items.Clear();
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("Donor_ID");
                                cmbDonorID.Items.Add(id);
                                cmbDeleteDonor.Items.Add(id);
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Donor IDs: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void btnAddDonors_Click(object sender, EventArgs e)
        {
            AddDonors.Visible = true;
            AddDonors.BringToFront();
            
        }

        private void btnUpdateDonors_Click(object sender, EventArgs e)
        {
            UpdateDonor.Visible = true;
            UpdateDonor.BringToFront();
            RefreshDonorID();
        }

        private void btnDeleteDonors_Click(object sender, EventArgs e)
        {
            DeleteDonor.Visible = true;
            DeleteDonor.BringToFront();
            RefreshDonorID();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = true;

            string phoneNum = txtSP_Num.Text;
            string studName = txtName.Text;
            string studEmail = txtEmail.Text;
            
            int campusID=0;
            if (rdoP.Checked == true)
            {
                campusID = 1;
            }
            else if(rdoM.Checked == true)
            {
                campusID = 2;
            }
            else if(rdoV.Checked == true)
            {
                campusID = 3;
            }
            else
            {
                validate = false;
                rdoP.BackColor = Color.LightPink;
                rdoM.BackColor = Color.LightPink;
                rdoV.BackColor = Color.LightPink;
                errorProvider1.SetError(rdoP, "Please choose a campus!");
            }

            int donorType = 0;
            if (rdoInd.Checked == true)
            {
                donorType = 1;
            }
            else if (rdoOrg.Checked == true)
            {
                donorType = 2;
            }
            else
            {
                validate = false;
                rdoInd.BackColor = Color.LightPink;
                rdoOrg.BackColor = Color.LightPink;
                errorProvider1.SetError(rdoInd, "Please choose a donor type!");
            }


            errorProvider1.Clear();
            txtSP_Num.BackColor = SystemColors.Window;
            txtName.BackColor = SystemColors.Window;
            txtEmail.BackColor = SystemColors.Window;
            rdoP.BackColor = SystemColors.Control;
            rdoM.BackColor = SystemColors.Control;
            rdoV.BackColor = SystemColors.Control;
            rdoInd.BackColor = SystemColors.Control;
            rdoOrg.BackColor = SystemColors.Control;

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.BackColor = Color.LightPink;
                errorProvider1.SetError(txtEmail, "Please enter a email!");
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(txtSP_Num.Text))
            {
                txtSP_Num.BackColor = Color.LightPink;
                errorProvider1.SetError(txtSP_Num, "Please enter a number!");
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.BackColor = Color.LightPink;
                errorProvider1.SetError(txtName, "Please enter a name!");
                validate = false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^([a-zA-Z0-9]{1,50})@([a-zA-Z0-9]{1,50}).(.{3,6})"))
            {
                txtEmail.BackColor = Color.LightPink;
                errorProvider1.SetError(txtEmail,"Please enter a VALID email!");
                validate = false;
            }
            else if (!Regex.IsMatch(txtSP_Num.Text, @"^([0-9]{5,10})"))
            {
                txtSP_Num.BackColor = Color.LightPink;
                errorProvider1.SetError(txtSP_Num, "Please enter a VALID phone number!");
                validate = false;
            }
            if (!validate)
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string sqlQuery = @"INSERT INTO donor(Email, Donor_Type_ID , Name,
                                      Campus_ID,SP_Number ) VALUES(@Email, @DonorType, 
                                      @Name, @Campus, @Number)";

                    cmd = new MySqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@Email", studEmail);
                    cmd.Parameters.AddWithValue("@DonorType", donorType);
                    cmd.Parameters.AddWithValue("@Name", studName);
                    cmd.Parameters.AddWithValue("@Campus", campusID);
                    cmd.Parameters.AddWithValue("@Number", phoneNum);
                    cmd.ExecuteNonQuery();

                    
                    long Donor_ID = cmd.LastInsertedId;

                    string defaultPassword = "Donor123!";
                    string checkQuery = "SELECT COUNT(*) FROM donor_login WHERE Email = @Email";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Email", studEmail);
                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if(exists == 0)
                    {
                        string insertLogin = @"INSERT INTO donor_login(Email,Donor_ID, Password) 
                                               VALUES(@Email,@Donor_ID, @Password )";

                        MySqlCommand insertCmd = new MySqlCommand(insertLogin, conn);
                        insertCmd.Parameters.AddWithValue("@Email", studEmail);
                        insertCmd.Parameters.AddWithValue("@Donor_ID", Donor_ID);
                        insertCmd.Parameters.AddWithValue("@Password", defaultPassword);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show($"Donor added successfully!\nDefault password: {defaultPassword}", "Success", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Donor added successfully! (Existing login found, password not changed)", "Info", MessageBoxButtons.OK);
                    }
                }

                LoadDonors();

                txtEmail.Clear();
                txtSP_Num.Clear();
                txtName.Clear();
                rdoP.Checked = false;
                rdoM.Checked = false;
                rdoV.Checked = false;
                rdoInd.Checked = false;
                rdoOrg.Checked = false;

                errorProvider1.Clear();
                txtSP_Num.BackColor = SystemColors.Window;
                txtName.BackColor = SystemColors.Window;
                txtEmail.BackColor = SystemColors.Window;
                rdoP.BackColor = SystemColors.Control;
                rdoM.BackColor = SystemColors.Control;
                rdoV.BackColor = SystemColors.Control;
                rdoInd.BackColor = SystemColors.Control;
                rdoOrg.BackColor = SystemColors.Control;
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Error adding Donor: " + ex.Message);
            }

        }


        private void Donors_Load(object sender, EventArgs e)
        {
            LoadDonors();
            
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtSearchDonor.Clear();

            rdoFilterP.Checked = false;
            rdoFilterM.Checked = false;
            rdoFilterV.Checked = false;

            LoadDonors() ;
        }

        private void btnSearchDonor_Click(object sender, EventArgs e)
        {
            string search = txtSearchDonor.Text;

            int campusID = 0;

            if (rdoFilterP.Checked)
            {
                campusID = 1;
            }
            else if (rdoFilterM.Checked)
            {
                campusID = 2;
            }
            else if (rdoFilterV.Checked)
            {
                campusID = 3;
            }

            if (string.IsNullOrEmpty(search))
            {
                LoadDonors();
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM donor WHERE (Name LIKE @search " +
                                    "OR Email LIKE @search )";

                    if (campusID != 0)
                    {
                        query += " AND Campus_ID = @campusID";
                    }

                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    if (campusID != 0)
                    {
                        cmd.Parameters.AddWithValue("@campusID", campusID);
                    }

                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();

                    da.Fill(dt);

                    dgvDonors.DataSource = dt;
                    dgvDonors.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for donor: " + ex.Message);
            }
        }

        private void btnReloadDonors_Click(object sender, EventArgs e)
        {
            LoadDonors();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbDonorID.SelectedItem == null)
            {
                MessageBox.Show("Please select a Donor ID to update");
                return;
            }


            int selectedID = Convert.ToInt32(cmbDonorID.SelectedValue.ToString());
            string Name = txtNewName.Text;
            string studNum = txtNewSP_Number.Text;
            string Email = txtNewEmail.Text;

            int campusID = 0;
            if (rdoPotch.Checked)
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
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string updateQuery = @"UPDATE donor SET Name = @Name, SP_Number = @Num, 
                                           Email = @Email, Campus_ID = @Campus_ID WHERE Donor_ID = @ID";

                    cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Num", studNum);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Campus_ID", campusID);
                    cmd.Parameters.AddWithValue("@ID", selectedID);

                    cmd.ExecuteNonQuery();


                     //string sqlQuery2 = @"UPDATE donor_login SET Email = @Email WHERE Donor_ID = @ID";

                     //MySqlCommand cmd2 = new MySqlCommand(sqlQuery2, conn);
                     //cmd2.Parameters.AddWithValue("@Email", Email);
                    // cmd2.Parameters.AddWithValue("@Donor_ID", selectedID);

                     //cmd2.ExecuteNonQuery();

                    MessageBox.Show("Donor updated successfully!");
                    LoadDonors();

                    txtNewName.Clear();
                    txtNewSP_Number.Clear();
                    txtNewEmail.Clear();
                    cmbDonorID.SelectedIndex = -1;
                    rdoPotch.Checked = false;
                    rdoMahikeng.Checked = false;
                    rdoVaal.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating donor: " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbDeleteDonor.SelectedItem == null)
            {
                MessageBox.Show("Please select a donor to delete");
                return;
            }

            int donorID = Convert.ToInt32(cmbDeleteDonor.SelectedValue.ToString());

            DialogResult result = MessageBox.Show("Are you sure you want to delete this donor?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string deleteDLoginQuery = @"DELETE FROM donor_login WHERE Donor_ID = @ID";

                    cmd = new MySqlCommand(deleteDLoginQuery, conn);
                    cmd.Parameters.AddWithValue("@ID", donorID);
                    cmd.ExecuteNonQuery();

                    string deleteDonorQuery = @"DELETE FROM donor WHERE Donor_ID = @ID";

                    cmd = new MySqlCommand(deleteDonorQuery, conn);
                    cmd.Parameters.AddWithValue("@ID", donorID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Applicant deleted successfully!");
                    LoadDonors();
                    RefreshDonorID();
                    cmbDeleteDonor.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing donor: " + ex.Message);
            }
        }

        private void cmbDonorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDonorID.SelectedItem == null)
            {
                return;
            }

            int selectedID = Convert.ToInt32(cmbDonorID.SelectedItem);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM donor WHERE Donor_ID = @ID";

                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", selectedID);

                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNewName.Text = reader["Name"].ToString();
                            txtNewSP_Number.Text = reader["SP_Number"].ToString();
                            txtNewEmail.Text = reader["Email"].ToString();

                            int campusID = Convert.ToInt32(reader["Campus_ID"]);
                            if (campusID == 1)
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

                            int donorType_ID = Convert.ToInt32(reader["Donor_Type_ID"]);
                            if (donorType_ID == 1)
                            {
                                rdoUpdateInd.Checked = true;
                            }
                            else if (donorType_ID == 2)
                            {
                                rdoUpdateOrg.Checked = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
