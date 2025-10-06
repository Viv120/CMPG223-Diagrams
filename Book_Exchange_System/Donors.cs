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
    public partial class Donors: Form
    {
        public Donors()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            DeleteDonor.Visible = false;
            UpdateDonor.Visible = false;
            AddDonors.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //open login form
            Login loginForm = new Login();
            loginForm.Show();

            //Close current form(Donors)
            this.Close();
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
    }
}
