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
            label1 = new Label();
            ManageRentalItems_btn = new Button();
            ShowProfile_btn = new Button();
            ManageUsers_btn = new Button();
            LogOut_btn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(475, 39);
            label1.Name = "label1";
            label1.Size = new Size(146, 27);
            label1.TabIndex = 0;
            label1.Text = "Admin Panel";
            // 
            // ManageRentalItems_btn
            // 
            ManageRentalItems_btn.BackColor = SystemColors.GradientActiveCaption;
            ManageRentalItems_btn.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ManageRentalItems_btn.ForeColor = Color.Blue;
            ManageRentalItems_btn.Location = new Point(605, 120);
            ManageRentalItems_btn.Name = "ManageRentalItems_btn";
            ManageRentalItems_btn.Size = new Size(160, 23);
            ManageRentalItems_btn.TabIndex = 1;
            ManageRentalItems_btn.Text = "Manage Rental Items";
            ManageRentalItems_btn.UseVisualStyleBackColor = false;
            ManageRentalItems_btn.Click += ManageRentalItems_btn_Click;
            // 
            // ShowProfile_btn
            // 
            ShowProfile_btn.BackColor = SystemColors.GradientActiveCaption;
            ShowProfile_btn.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ShowProfile_btn.ForeColor = Color.Blue;
            ShowProfile_btn.Location = new Point(381, 248);
            ShowProfile_btn.Name = "ShowProfile_btn";
            ShowProfile_btn.Size = new Size(110, 23);
            ShowProfile_btn.TabIndex = 2;
            ShowProfile_btn.Text = "Show Profile";
            ShowProfile_btn.UseVisualStyleBackColor = false;
            ShowProfile_btn.Click += ShowProfile_btn_Click;
            // 
            // ManageUsers_btn
            // 
            ManageUsers_btn.BackColor = SystemColors.GradientActiveCaption;
            ManageUsers_btn.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ManageUsers_btn.ForeColor = Color.Blue;
            ManageUsers_btn.Location = new Point(508, 185);
            ManageUsers_btn.Name = "ManageUsers_btn";
            ManageUsers_btn.Size = new Size(113, 23);
            ManageUsers_btn.TabIndex = 3;
            ManageUsers_btn.Text = "Manage Users";
            ManageUsers_btn.UseVisualStyleBackColor = false;
            ManageUsers_btn.Click += ManageUsers_btn_Click;
            // 
            // LogOut_btn
            // 
            LogOut_btn.BackColor = SystemColors.GradientActiveCaption;
            LogOut_btn.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LogOut_btn.ForeColor = Color.Blue;
            LogOut_btn.Location = new Point(684, 327);
            LogOut_btn.Name = "LogOut_btn";
            LogOut_btn.Size = new Size(81, 23);
            LogOut_btn.TabIndex = 4;
            LogOut_btn.Text = "Log Out";
            LogOut_btn.UseVisualStyleBackColor = false;
            LogOut_btn.Click += LogOut_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 452);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(LogOut_btn);
            Controls.Add(ManageUsers_btn);
            Controls.Add(ShowProfile_btn);
            Controls.Add(ManageRentalItems_btn);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ManageRentalItems_btn;
        private Button ShowProfile_btn;
        private Button ManageUsers_btn;
        private Button LogOut_btn;
        private PictureBox pictureBox1;
    }
}