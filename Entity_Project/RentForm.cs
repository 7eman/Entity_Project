using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Entity_Project.Schema;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Entity_Project
{
    public partial class RentForm : Form
    {
        
        private RentalItem selectedItem;
        private User currentUser;
        public RentForm(User user, RentalItem item)
        {
            InitializeComponent();
            currentUser = user;
            selectedItem = item;

            lblDisplayItemName.Text = selectedItem.Name;
            lblDisplayPrice.Text = selectedItem.PricePerDay.ToString("C");
            lblTotalPrice.Text = "Total Price: $0.00";
            txtDays.TextChanged += txtDays_TextChanged;
        }

        private void btnConfirmRent_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection("Server=DESKTOP-SPT5GG8\\SQLEXPRESS;Database=RentalDB;Trusted_Connection=True;trust server certificate=true"))
            {
                int days;
                if (!int.TryParse(txtDays.Text, out days) || days <= 0)
                {
                    MessageBox.Show("Please enter a valid number of rental days.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalPrice = days * selectedItem.PricePerDay;

                var query = "INSERT INTO RentalTransactions (UserId, RentalItemId, RentDate, TotalPrice) " +
                            "VALUES (@UserId, @RentalItemId, @RentDate, @TotalPrice)";

                connection.Execute(query, new
                {
                    UserId = currentUser.Id,
                    RentalItemId = selectedItem.Id,
                    RentDate = DateTime.Now,
                    TotalPrice = totalPrice
                });

                MessageBox.Show("Item Rented Successfully!");
                this.Hide();
                DashboardForm dash = new DashboardForm(currentUser);
                dash.Show();
            }
        }
        
        private void RentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtDays.Text, out int days) && days > 0)
            {
                decimal totalPrice = days * selectedItem.PricePerDay;
                lblTotalPrice.Text = $"Total Price:            {totalPrice:C}";
            }
            else
            {
                lblTotalPrice.Text = "Total Price:             Invalid Input";
            }
        }
    }
}
