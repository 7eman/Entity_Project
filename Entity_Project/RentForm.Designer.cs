namespace Entity_Project
{
    partial class RentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentForm));
            lblItemName = new Label();
            lblDisplayItemName = new Label();
            lblDays = new Label();
            lblPricePerDay = new Label();
            lblDisplayPrice = new Label();
            lblTotalPrice = new Label();
            txtDays = new TextBox();
            btnConfirmRent = new Button();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = Color.Blue;
            lblItemName.Location = new Point(404, 44);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(97, 15);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Selected Item";
            // 
            // lblDisplayItemName
            // 
            lblDisplayItemName.AutoSize = true;
            lblDisplayItemName.Location = new Point(638, 44);
            lblDisplayItemName.Name = "lblDisplayItemName";
            lblDisplayItemName.Size = new Size(38, 15);
            lblDisplayItemName.TabIndex = 1;
            lblDisplayItemName.Text = "label2";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDays.ForeColor = Color.Blue;
            lblDays.Location = new Point(404, 103);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(86, 15);
            lblDays.TabIndex = 2;
            lblDays.Text = "Rental Days";
            // 
            // lblPricePerDay
            // 
            lblPricePerDay.AutoSize = true;
            lblPricePerDay.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPricePerDay.ForeColor = Color.Blue;
            lblPricePerDay.Location = new Point(404, 172);
            lblPricePerDay.Name = "lblPricePerDay";
            lblPricePerDay.Size = new Size(95, 15);
            lblPricePerDay.TabIndex = 4;
            lblPricePerDay.Text = "Price Per Day";
            // 
            // lblDisplayPrice
            // 
            lblDisplayPrice.AutoSize = true;
            lblDisplayPrice.Location = new Point(638, 172);
            lblDisplayPrice.Name = "lblDisplayPrice";
            lblDisplayPrice.Size = new Size(38, 15);
            lblDisplayPrice.TabIndex = 5;
            lblDisplayPrice.Text = "label6";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Blue;
            lblTotalPrice.Location = new Point(486, 254);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(80, 15);
            lblTotalPrice.TabIndex = 6;
            lblTotalPrice.Text = "Total Price";
            // 
            // txtDays
            // 
            txtDays.Location = new Point(612, 100);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(100, 23);
            txtDays.TabIndex = 7;
            txtDays.TextChanged += txtDays_TextChanged;
            // 
            // btnConfirmRent
            // 
            btnConfirmRent.BackColor = SystemColors.GradientActiveCaption;
            btnConfirmRent.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConfirmRent.ForeColor = Color.Blue;
            btnConfirmRent.Location = new Point(434, 322);
            btnConfirmRent.Name = "btnConfirmRent";
            btnConfirmRent.Size = new Size(92, 23);
            btnConfirmRent.TabIndex = 8;
            btnConfirmRent.Text = "Confirm Rent";
            btnConfirmRent.UseVisualStyleBackColor = false;
            btnConfirmRent.Click += btnConfirmRent_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.GradientActiveCaption;
            btnCancel.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Blue;
            btnCancel.Location = new Point(586, 322);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // RentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmRent);
            Controls.Add(txtDays);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblDisplayPrice);
            Controls.Add(lblPricePerDay);
            Controls.Add(lblDays);
            Controls.Add(lblDisplayItemName);
            Controls.Add(lblItemName);
            Name = "RentForm";
            Text = "RentForm";
            Load += RentForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemName;
        private Label lblDisplayItemName;
        private Label lblDays;
        private Label lblPricePerDay;
        private Label lblDisplayPrice;
        private Label lblTotalPrice;
        private TextBox txtDays;
        private Button btnConfirmRent;
        private Button btnCancel;
        private PictureBox pictureBox1;
    }
}