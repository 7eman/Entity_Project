namespace Entity_Project
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            lblAdminPanel = new Label();
            btnManageUsers = new Button();
            btnManageItems = new Button();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAdminPanel.ForeColor = Color.Blue;
            lblAdminPanel.Location = new Point(502, 50);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(132, 23);
            lblAdminPanel.TabIndex = 0;
            lblAdminPanel.Text = "Admin Panel";
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackColor = SystemColors.GradientActiveCaption;
            btnManageUsers.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnManageUsers.ForeColor = Color.Blue;
            btnManageUsers.Location = new Point(476, 227);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(114, 23);
            btnManageUsers.TabIndex = 1;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = false;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnManageItems
            // 
            btnManageItems.BackColor = SystemColors.GradientActiveCaption;
            btnManageItems.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnManageItems.ForeColor = Color.Blue;
            btnManageItems.Location = new Point(611, 161);
            btnManageItems.Name = "btnManageItems";
            btnManageItems.Size = new Size(163, 23);
            btnManageItems.TabIndex = 2;
            btnManageItems.Text = "Manage Rental Items";
            btnManageItems.UseVisualStyleBackColor = false;
            btnManageItems.Click += btnManageItems_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientActiveCaption;
            btnBack.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Blue;
            btnBack.Location = new Point(390, 299);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Log Out";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(btnManageItems);
            Controls.Add(btnManageUsers);
            Controls.Add(lblAdminPanel);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminPanel;
        private Button btnManageUsers;
        private Button btnManageItems;
        private Button btnBack;
        private PictureBox pictureBox1;
    }
}