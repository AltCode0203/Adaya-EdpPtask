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
    public partial class RemoveDrink : Form
    {
        public RemoveDrink()
        {
            InitializeComponent();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string keyword = txtRemove.Text.Trim().ToLower();
            bool removed = false;

            for (int i = Products.DrinkList.Items.Count - 1; i >= 0; i--)
            {
                string item = Products.DrinkList.Items[i].ToString().ToLower();
                if (item.Contains(keyword))
                {
                    Products.DrinkList.Items.RemoveAt(i);
                    removed = true;
                }
            }

            lblResult.Text = removed ? "Drink removed successfully!" : "No matching drink found.";
            lblResult.ForeColor = removed ? Color.Green : Color.Red;
            txtRemove.Clear();
        }
        private void RemoveDrink_Load(object sender, EventArgs e)
        {

        }
    }
}
