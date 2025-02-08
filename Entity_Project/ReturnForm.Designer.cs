namespace Entity_Project
{
    partial class ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            lblReturnTitle = new Label();
            lblRentalId = new Label();
            txtRentalId = new TextBox();
            btnReturnItem = new Button();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblReturnTitle
            // 
            lblReturnTitle.AutoSize = true;
            lblReturnTitle.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReturnTitle.ForeColor = Color.Blue;
            lblReturnTitle.Location = new Point(462, 39);
            lblReturnTitle.Name = "lblReturnTitle";
            lblReturnTitle.Size = new Size(248, 27);
            lblReturnTitle.TabIndex = 0;
            lblReturnTitle.Text = "Return a Rented Item";
            // 
            // lblRentalId
            // 
            lblRentalId.AutoSize = true;
            lblRentalId.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRentalId.ForeColor = Color.Blue;
            lblRentalId.Location = new Point(462, 165);
            lblRentalId.Name = "lblRentalId";
            lblRentalId.Size = new Size(75, 17);
            lblRentalId.TabIndex = 1;
            lblRentalId.Text = "Rental ID";
            // 
            // txtRentalId
            // 
            txtRentalId.Location = new Point(591, 159);
            txtRentalId.Name = "txtRentalId";
            txtRentalId.Size = new Size(100, 23);
            txtRentalId.TabIndex = 2;
            // 
            // btnReturnItem
            // 
            btnReturnItem.BackColor = SystemColors.GradientActiveCaption;
            btnReturnItem.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReturnItem.ForeColor = Color.Blue;
            btnReturnItem.Location = new Point(598, 293);
            btnReturnItem.Name = "btnReturnItem";
            btnReturnItem.Size = new Size(93, 25);
            btnReturnItem.TabIndex = 3;
            btnReturnItem.Text = "Return Item";
            btnReturnItem.UseVisualStyleBackColor = false;
            btnReturnItem.Click += btnReturnItem_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientActiveCaption;
            btnBack.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Blue;
            btnBack.Location = new Point(462, 293);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 25);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(btnReturnItem);
            Controls.Add(txtRentalId);
            Controls.Add(lblRentalId);
            Controls.Add(lblReturnTitle);
            Name = "ReturnForm";
            Text = "ReturnForm";
            Load += ReturnForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReturnTitle;
        private Label lblRentalId;
        private TextBox txtRentalId;
        private Button btnReturnItem;
        private Button btnBack;
        private PictureBox pictureBox1;
    }
}