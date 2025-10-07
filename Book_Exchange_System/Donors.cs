﻿using System;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDonateBooks_Click(object sender, EventArgs e)
        {
            
            DeleteDonor.Visible = false;
            UpdateDonor.Visible = false;
            AddDonors.Visible = false;
            DonateBooks.Visible = true;
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            DeleteDonor.Visible = false;
            UpdateDonor.Visible = false;
            AddDonors.Visible = true;
            DonateBooks.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //open login form
            Logins loginForm = new Logins();
            loginForm.Show();

            //Close current form(Donors)
            this.Hide();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            DeleteDonor.Visible = false;
            AddDonors.Visible = false;
            UpdateDonor.Visible = true;
            DonateBooks.Visible = false;
        }

        private void btnDeleteBooks_Click(object sender, EventArgs e)
        {
            AddDonors.Visible = false;
            UpdateDonor.Visible = false;
            DeleteDonor.Visible = true;
            DonateBooks.Visible = false;
        }
    }
}
