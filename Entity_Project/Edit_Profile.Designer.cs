namespace Entity_Project
{
    partial class Edit_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Profile));
            lblFullName = new Label();
            lblEmail = new Label();
            lblOldPassword = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtOldPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNewPassword = new TextBox();
            txtConfirm = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.Blue;
            lblFullName.Location = new Point(434, 56);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(77, 17);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Blue;
            lblEmail.Location = new Point(434, 124);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 17);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOldPassword.ForeColor = Color.Blue;
            lblOldPassword.Location = new Point(434, 207);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(112, 17);
            lblOldPassword.TabIndex = 2;
            lblOldPassword.Text = "Old Password";
            lblOldPassword.Click += lblOldPassword_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(611, 55);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(142, 23);
            txtFullName.TabIndex = 3;
            txtFullName.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(611, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(142, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(611, 207);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(142, 23);
            txtOldPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(463, 377);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.GradientActiveCaption;
            btnCancel.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Blue;
            btnCancel.Location = new Point(599, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(434, 256);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 8;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(434, 301);
            label2.Name = "label2";
            label2.Size = new Size(144, 17);
            label2.TabIndex = 9;
            label2.Text = "Confirm Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(611, 250);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(142, 23);
            txtNewPassword.TabIndex = 10;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(611, 295);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(142, 23);
            txtConfirm.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Edit_Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtConfirm);
            Controls.Add(txtNewPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtOldPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblOldPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Name = "Edit_Profile";
            Text = "Edit_Profile";
            Load += Edit_Profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private Label lblEmail;
        private Label lblOldPassword;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtOldPassword;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private TextBox txtNewPassword;
        private TextBox txtConfirm;
        private PictureBox pictureBox1;
    }
}