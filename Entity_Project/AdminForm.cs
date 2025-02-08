using System;
using System.Collections.Generic;
using System;
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
        private User currentAdmin;
        public AdminForm(User adminUser)
        {
            InitializeComponent();
            currentAdmin = adminUser;

        }

        private void ManageRentalItems_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageRentalItemsForm itemsForm = new ManageRentalItemsForm(currentAdmin);
            itemsForm.Show();
        }

        private void ManageUsers_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsersForm usersForm = new ManageUsersForm(currentAdmin);
            usersForm.Show();
        }

        private void ShowProfile_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowProfileForm profileForm = new ShowProfileForm(currentAdmin);
            profileForm.Show();
        }

        private void LogOut_btn_Click(object sender, EventArgs e)
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
