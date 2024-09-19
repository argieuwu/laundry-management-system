﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem.auth_pages
{
    public partial class AdminOrStaff : Form
    {
        public AdminOrStaff()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStaffRouteLogin_Click(object sender, EventArgs e)
        {
            StaffLoginForm login = new StaffLoginForm();
            this.Hide();
            login.ShowDialog();
        }

        private void btnAdminRouteLogin_Click(object sender, EventArgs e)
        {
            AdminLoginForm loginAdmin = new AdminLoginForm();
            this.Hide();
            loginAdmin.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
