using Entity_Project.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Project
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var fullName = txtFullName.Text.Trim();
                var email = txtEmail.Text.Trim().ToLower();
                var password = txtPassword.Text;

                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("All fields are required. Please fill in all details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (context.Users.Any(u => u.Email.ToLower() == email))
                {
                    MessageBox.Show("Email is already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var user = new User { FullName = fullName, Email = email, Password = password, IsAdmin = false };
                context.Users.Add(user);
                context.SaveChanges();

                MessageBox.Show("Registration Successful!");
                txtFullName.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                this.Hide();
                login loginForm = new login();
                loginForm.Show();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
           login loginForm = new login();
            loginForm.Show();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
