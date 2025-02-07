﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Project.Schema;

namespace Entity_Project
{
    public partial class AdminForm : Form
    {
        
        public AdminForm( )
        {
            InitializeComponent();
           
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsersForm usersForm = new ManageUsersForm();
            usersForm.Show();
        }

        private void btnManageItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageRentalItemsForm itemsForm = new ManageRentalItemsForm();
            itemsForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
