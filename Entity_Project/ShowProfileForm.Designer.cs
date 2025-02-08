namespace Entity_Project
{
    partial class ShowProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowProfileForm));
            label1 = new Label();
            lblDisplayName = new Label();
            label3 = new Label();
            lblDisplayEmail = new Label();
            btnEditProfile = new Button();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(468, 99);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisplayName.ForeColor = Color.FromArgb(0, 0, 192);
            lblDisplayName.Location = new Point(633, 99);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(52, 17);
            lblDisplayName.TabIndex = 1;
            lblDisplayName.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(468, 182);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // lblDisplayEmail
            // 
            lblDisplayEmail.AutoSize = true;
            lblDisplayEmail.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisplayEmail.ForeColor = Color.FromArgb(0, 0, 192);
            lblDisplayEmail.Location = new Point(633, 182);
            lblDisplayEmail.Name = "lblDisplayEmail";
            lblDisplayEmail.Size = new Size(53, 17);
            lblDisplayEmail.TabIndex = 3;
            lblDisplayEmail.Text = "label4";
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = SystemColors.GradientActiveCaption;
            btnEditProfile.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEditProfile.ForeColor = Color.FromArgb(0, 0, 192);
            btnEditProfile.Location = new Point(633, 326);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(75, 23);
            btnEditProfile.TabIndex = 4;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientActiveCaption;
            btnBack.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(0, 0, 192);
            btnBack.Location = new Point(454, 326);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ShowProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(btnEditProfile);
            Controls.Add(lblDisplayEmail);
            Controls.Add(label3);
            Controls.Add(lblDisplayName);
            Controls.Add(label1);
            Name = "ShowProfileForm";
            Text = "ShowProfileForm";
            Load += ShowProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDisplayName;
        private Label label3;
        private Label lblDisplayEmail;
        private Button btnEditProfile;
        private Button btnBack;
        private PictureBox pictureBox1;
    }
}