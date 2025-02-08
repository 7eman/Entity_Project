using Entity_Project.Schema;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Entity_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var email = txtEmail.Text.Trim();
                var password = txtPassword.Text;

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Email and Password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var user = context.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower() && u.Password == password);

                if (user != null)
                {
                    if (user.IsAdmin)
                    {
                        MessageBox.Show("Admin login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        AdminForm adminForm = new AdminForm(user);
                        adminForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        DashboardForm dashboardForm = new DashboardForm(user);
                        dashboardForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtEmail.Clear();
                txtPassword.Clear();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {

                txtPassword.PasswordChar = '\0';
            }
            else
            {

                txtPassword.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
