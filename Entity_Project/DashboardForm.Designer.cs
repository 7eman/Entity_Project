namespace Entity_Project
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            lblWelcome = new Label();
            btnProfile = new Button();
            btnBrowse = new Button();
            btnHistory = new Button();
            btnReturn = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Blue;
            lblWelcome.Location = new Point(121, 56);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(236, 23);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [User Name]!";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = SystemColors.GradientActiveCaption;
            btnProfile.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.Blue;
            btnProfile.Location = new Point(294, 149);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(135, 23);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Show Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.GradientActiveCaption;
            btnBrowse.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBrowse.ForeColor = Color.Blue;
            btnBrowse.Location = new Point(294, 259);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(135, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse Rental Items";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = SystemColors.GradientActiveCaption;
            btnHistory.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.Blue;
            btnHistory.Location = new Point(47, 243);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(135, 23);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "Rental History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = SystemColors.GradientActiveCaption;
            btnReturn.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.Blue;
            btnReturn.Location = new Point(47, 149);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(131, 23);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return Rental Item";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.GradientActiveCaption;
            btnLogout.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Blue;
            btnLogout.Location = new Point(202, 361);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(454, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnReturn);
            Controls.Add(btnHistory);
            Controls.Add(btnBrowse);
            Controls.Add(btnProfile);
            Controls.Add(lblWelcome);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnProfile;
        private Button btnBrowse;
        private Button btnHistory;
        private Button btnReturn;
        private Button btnLogout;
        private PictureBox pictureBox1;
    }
}