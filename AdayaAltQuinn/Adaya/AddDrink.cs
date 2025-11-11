using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adaya
{
    public partial class AddDrink : Form
    {
        public AddDrink()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string priceText = txtPrice.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText))
            {
                lblResult.Text = "Please enter both name and price.";
                lblResult.ForeColor = Color.Red;
                return;
            }

            if (decimal.TryParse(priceText, out decimal price))
            {
                Products.DrinkList.Items.Add($"{name} - {price}");
                lblResult.Text = "Drink added successfully!";
                lblResult.ForeColor = Color.Green;
                txtName.Clear();
                txtPrice.Clear();
            }
            else
            {
                lblResult.Text = "Invalid price format.";
                lblResult.ForeColor = Color.Red;
            }
        }
        private void AddDrink_Load(object sender, EventArgs e)
        {

        }

        private void AddDrink_Load_1(object sender, EventArgs e)
        {

        }
    }
}
