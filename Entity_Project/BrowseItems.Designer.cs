namespace Entity_Project
{
    partial class BrowseItems
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
            lblTitle = new Label();
            dgvItems = new DataGridView();
            btnRent = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(296, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Available Rental Items";
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(26, 209);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(748, 192);
            dgvItems.TabIndex = 1;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // btnRent
            // 
            btnRent.BackColor = SystemColors.GradientActiveCaption;
            btnRent.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRent.ForeColor = Color.Blue;
            btnRent.Location = new Point(170, 152);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(113, 23);
            btnRent.TabIndex = 2;
            btnRent.Text = "Rent Selected Item";
            btnRent.UseVisualStyleBackColor = false;
            btnRent.Click += btnRent_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientActiveCaption;
            btnBack.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Blue;
            btnBack.Location = new Point(590, 152);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // BrowseItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnRent);
            Controls.Add(dgvItems);
            Controls.Add(lblTitle);
            Name = "BrowseItems";
            Text = "BrowseItems";
            Load += BrowseItems_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvItems;
        private Button btnRent;
        private Button btnBack;
    }
}