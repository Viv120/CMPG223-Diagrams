using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();

            this.Hide();
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            DeleteDonor.Visible = false;
            UpdateDonor.Visible = false;
            AddDonors.Visible = true;
            
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            DeleteDonor.Visible = false;
            AddDonors.Visible = false;
            UpdateDonor.Visible = true;
            
        }

        private void btnDeleteBooks_Click(object sender, EventArgs e)
        {
            AddDonors.Visible = false;
            UpdateDonor.Visible = false;
            DeleteDonor.Visible = true;
            
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            string phoneNum = txtSP_Num.Text;
            string studName = txtName.Text;
            string studEmail = txtEmail.Text;
            bool validate =true;
            int campusID=0;

            errorProvider1.Clear();

            if (rdoM.Checked == true)
            {
                campusID = 2;
            }
            else if(rdoP.Checked == true)
            {
                campusID = 1;
            }
            else if(rdoV.Checked == true)
            {
                campusID = 3;
            }
            else
            {
                MessageBox.Show("Please choose a campus!");
                validate = false;
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
                MessageBox.Show("Please choose a donor type!");
                validate = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Please enter a email!");
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(txtSP_Num.Text))
            {
                errorProvider1.SetError(txtSP_Num, "Please enter a number!");
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Please enter a name!");
                validate = false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^([a-zA-Z0-9]{1,50})@([a-zA-Z0-9]{1,50}).(.{3,6})"))
            {
                errorProvider1.SetError(txtEmail,"Please enter a VALID email!");
                validate = false;
            }
            else if (!Regex.IsMatch(txtSP_Num.Text, @"^([0-9]{5,10})"))
            {
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
                        string sqlQuery = @"INSERT INTO donor(Email, Donor_Type_ID , Name, Campus_ID,SP_Number ) VALUES(@Email, @DonorType, @Name, @Campus, @Number)";

                        cmd = new MySqlCommand(sqlQuery, conn);
                        cmd.Parameters.AddWithValue("@Email", studEmail);
                        cmd.Parameters.AddWithValue("@DonorType", donorType);
                        cmd.Parameters.AddWithValue("@Name", studName);
                        cmd.Parameters.AddWithValue("@Campus", campusID);
                        cmd.Parameters.AddWithValue("@Number", phoneNum);
                        cmd.ExecuteNonQuery();


                    // long Donor_ID = cmd.LastInsertedId;
                    // string sqlQuery2 = @"INSERT INTO donor_login(Email,Donor_ID ) VALUES(@Email,@Donor_ID )";

                    // MySqlCommand cmd2 = new MySqlCommand(sqlQuery2, conn);
                    // cmd2.Parameters.AddWithValue("@Email", studEmail);
                    // cmd2.Parameters.AddWithValue("@Donor_ID", Donor_ID);
                    // cmd2.ExecuteNonQuery();

                    MessageBox.Show("Donor added successfully!");
                        conn.Close();

                    RefreshComboboxes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding Donor: " + ex.Message);
                }

            txtEmail.Clear();
            txtSP_Num.Clear();
            txtName.Clear();
            
            rdoP.Checked = false;
            rdoM.Checked = false;
            rdoV.Checked = false;

            rdoInd.Checked = false;
            rdoOrg.Checked = false;

        }

        private void RefreshComboboxes()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT Donor_ID,Name FROM donor";

                    cmd = new MySqlCommand(sqlQuery, conn);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();

                    da.Fill(dt);

                    cbBookID.DataSource = dt;
                    cbBookID.DisplayMember = "Donor_ID";
                    cbBookID.ValueMember = "Donor_ID";

                    cbDeleteDonor.DataSource = dt;
                    cbDeleteDonor.DisplayMember = "Donor_ID";
                    cbDeleteDonor.ValueMember = "Donor_ID";

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ID's: " + ex.Message);

            }
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
        private void Donors_Load(object sender, EventArgs e)
        {
            LoadDonors();
            RefreshComboboxes();
            
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtSearchDonor.Text = string.Empty;
            LoadDonors() ;
        }

        private void btnSearchDonor_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                string search = txtSearchDonor.Text;
                
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM donor WHERE (Name LIKE @search " +
                        "                                   OR Email LIKE @search )";
                        
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");
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

        private void btnReloadDonors_Click(object sender, EventArgs e)
        {
            LoadDonors();
        }

        private void btnUpdateDonor_Click(object sender, EventArgs e)
        {
            if (cbBookID.SelectedItem == null)
            {
                MessageBox.Show("Please select an Donor ID");
                return;
            }


            int selectedID = Convert.ToInt32(cbBookID.SelectedValue.ToString());
            string Name = txtNewName.Text;
            string studNum = txtNewSP_Number.Text;
            string Email = txtNewEmail.Text;
            bool validate = true;

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
            else
            {
                MessageBox.Show("Please choose a campus!");
                validate = false;
            }

            if (string.IsNullOrWhiteSpace(txtNewEmail.Text))
            {
                errorProvider1.SetError(txtNewEmail, "Please enter a email!");
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(txtNewSP_Number.Text))
            {
                errorProvider1.SetError(txtNewSP_Number, "Please enter a number!");
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(txtNewName.Text))
            {
                errorProvider1.SetError(txtNewName, "Please enter a name!");
                validate = false;
            }


            if(!validate)
            {
                return;
            }



            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string updateQuery = @"UPDATE donor SET Name = @Name, SP_Number = @Num, Email = @Email, Campus_ID = @Campus_ID WHERE Donor_ID = @ID";

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

                    conn.Close();

                    txtNewName.Clear();
                    txtNewSP_Number.Clear();
                    txtNewEmail.Clear();
                    cbBookID.SelectedIndex = -1;
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

        private void btnDeleteDonor_Click(object sender, EventArgs e)
        {
            if (cbDeleteDonor.SelectedItem == null)
            {
                MessageBox.Show("Please select an donor to delete");
                return;
            }


            int donorID = Convert.ToInt32(cbDeleteDonor.SelectedValue.ToString());

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
                    cbDeleteDonor.SelectedIndex = -1;

                }
                RefreshComboboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing donor: " + ex.Message);
            }
        }
    }
}
