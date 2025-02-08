namespace Entity_Project
{
    partial class ManageUsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUsers = new DataGridView();
            btnAddUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            btnBack = new Button();
            lblFullName = new Label();
            txtEmail = new Label();
            txtPassword = new Label();
            txtFullName = new TextBox();
            textEmail = new TextBox();
            textPassword = new TextBox();
            chkIsAdmin = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(349, 86);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(439, 272);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = SystemColors.GradientActiveCaption;
            btnAddUser.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.Blue;
            btnAddUser.Location = new Point(27, 266);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(120, 23);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = SystemColors.GradientActiveCaption;
            btnEditUser.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEditUser.ForeColor = Color.Blue;
            btnEditUser.Location = new Point(183, 354);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(140, 23);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "Edit Selected User";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = SystemColors.GradientActiveCaption;
            btnDeleteUser.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = Color.Blue;
            btnDeleteUser.Location = new Point(183, 266);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(140, 23);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "Delete Selected User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientActiveCaption;
            btnBack.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Blue;
            btnBack.Location = new Point(27, 354);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.Blue;
            lblFullName.Location = new Point(34, 35);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(77, 17);
            lblFullName.TabIndex = 5;
            lblFullName.Text = "Full Name";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Blue;
            txtEmail.Location = new Point(34, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(46, 17);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Blue;
            txtPassword.Location = new Point(34, 145);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(82, 17);
            txtPassword.TabIndex = 7;
            txtPassword.Text = "Password";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(163, 35);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(140, 23);
            txtFullName.TabIndex = 8;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(163, 86);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(140, 23);
            textEmail.TabIndex = 9;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(163, 144);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(140, 23);
            textPassword.TabIndex = 10;
            // 
            // chkIsAdmin
            // 
            chkIsAdmin.AutoSize = true;
            chkIsAdmin.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkIsAdmin.ForeColor = Color.Blue;
            chkIsAdmin.Location = new Point(215, 209);
            chkIsAdmin.Name = "chkIsAdmin";
            chkIsAdmin.Size = new Size(88, 19);
            chkIsAdmin.TabIndex = 11;
            chkIsAdmin.Text = "Is Admin?";
            chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(chkIsAdmin);
            Controls.Add(textPassword);
            Controls.Add(textEmail);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblFullName);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnAddUser);
            Controls.Add(dgvUsers);
            Name = "ManageUsersForm";
            Text = "ManageUsersForm";
            Load += ManageUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private Button btnBack;
        private Label lblFullName;
        private Label txtEmail;
        private Label txtPassword;
        private TextBox txtFullName;
        private TextBox textEmail;
        private TextBox textPassword;
        private CheckBox chkIsAdmin;
    }
}