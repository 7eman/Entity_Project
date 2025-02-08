namespace Entity_Project
{
    partial class ManageRentalItemsForm
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
            dgvRentalItems = new DataGridView();
            btnEditItem = new Button();
            btnAddItem = new Button();
            btnDeleteItem = new Button();
            btnBack = new Button();
            lblItemName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            txtItemName = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            chkIsAvailable = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvRentalItems).BeginInit();
            SuspendLayout();
            // 
            // dgvRentalItems
            // 
            dgvRentalItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalItems.Location = new Point(362, 83);
            dgvRentalItems.Name = "dgvRentalItems";
            dgvRentalItems.Size = new Size(426, 284);
            dgvRentalItems.TabIndex = 0;
            dgvRentalItems.CellClick += dgvRentalItems_CellClick;
            // 
            // btnEditItem
            // 
            btnEditItem.BackColor = SystemColors.GradientActiveCaption;
            btnEditItem.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEditItem.ForeColor = Color.Blue;
            btnEditItem.Location = new Point(196, 284);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(143, 23);
            btnEditItem.TabIndex = 1;
            btnEditItem.Text = "Edit Selected Item";
            btnEditItem.UseVisualStyleBackColor = false;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = SystemColors.GradientActiveCaption;
            btnAddItem.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = Color.Blue;
            btnAddItem.Location = new Point(33, 284);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(127, 23);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.BackColor = SystemColors.GradientActiveCaption;
            btnDeleteItem.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeleteItem.ForeColor = Color.Blue;
            btnDeleteItem.Location = new Point(199, 379);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(140, 23);
            btnDeleteItem.TabIndex = 3;
            btnDeleteItem.Text = "Delete Selected Item";
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientActiveCaption;
            btnBack.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Blue;
            btnBack.Location = new Point(33, 379);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = Color.Blue;
            lblItemName.Location = new Point(33, 45);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(78, 17);
            lblItemName.TabIndex = 5;
            lblItemName.Text = "Item Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.Blue;
            lblCategory.Location = new Point(33, 101);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(77, 17);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Blue;
            lblPrice.Location = new Point(33, 169);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(104, 17);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price Per Day";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(194, 45);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(138, 23);
            txtItemName.TabIndex = 8;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(194, 100);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(138, 23);
            txtCategory.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(196, 169);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(136, 23);
            txtPrice.TabIndex = 10;
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkIsAvailable.ForeColor = Color.Blue;
            chkIsAvailable.Location = new Point(216, 225);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(107, 19);
            chkIsAvailable.TabIndex = 11;
            chkIsAvailable.Text = "Is Available?";
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // ManageRentalItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(chkIsAvailable);
            Controls.Add(txtPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtItemName);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblItemName);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnAddItem);
            Controls.Add(btnEditItem);
            Controls.Add(dgvRentalItems);
            Name = "ManageRentalItemsForm";
            Text = "ManageRentalItemsForm";
            Load += ManageRentalItemsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentalItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRentalItems;
        private Button btnEditItem;
        private Button btnAddItem;
        private Button btnDeleteItem;
        private Button btnBack;
        private Label lblItemName;
        private Label lblCategory;
        private Label lblPrice;
        private TextBox txtItemName;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private CheckBox chkIsAvailable;
    }
}