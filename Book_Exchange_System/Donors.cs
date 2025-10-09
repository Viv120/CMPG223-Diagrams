using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
                MessageBox.Show("Please enter a email!");
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(txtSP_Num.Text))
            {
                MessageBox.Show("Please enter a number!");
                validate = false;
            }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name!");
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
                        string sqlQuery = @"INSERT INTO donor(Email, Donor_Type_ID , Name, Campus_ID,SP_Number ) VALUES(@Email, @DonorType, @Name, @Campus, @Number)";

                        cmd = new MySqlCommand(sqlQuery, conn);
                        cmd.Parameters.AddWithValue("@Email", studEmail);
                        cmd.Parameters.AddWithValue("@DonorType", donorType);
                        cmd.Parameters.AddWithValue("@Name", studName);
                        cmd.Parameters.AddWithValue("@Campus", campusID);
                        cmd.Parameters.AddWithValue("@Number", phoneNum);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Donor added successfully!");
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding Donor: " + ex.Message);
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
                    string query = "SELECT * FROM donor WHERE (Name LIKE @search OR Email LIKE @search AND Campus_ID = @search)";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();

                    da.Fill(dt);

                    dgvDonors.DataSource = dt;
                    dgvDonors.Refresh();
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

        }
    }
}
