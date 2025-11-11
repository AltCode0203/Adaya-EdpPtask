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
    public partial class RemoveFood : Form
    {
        public RemoveFood()
        {
            InitializeComponent();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string keyword = txtRemove.Text.Trim().ToLower();
            bool removed = false;

            for (int i = Products.FoodList.Items.Count - 1; i >= 0; i--)
            {
                string item = Products.FoodList.Items[i].ToString().ToLower();
                if (item.Contains(keyword))
                {
                    Products.FoodList.Items.RemoveAt(i);
                    removed = true;
                }
            }

            lblResult.Text = removed ? "Food removed successfully!" : "No matching food found.";
            lblResult.ForeColor = removed ? Color.Green : Color.Red;
            txtRemove.Clear();
        }
        private void RemoveFood_Load(object sender, EventArgs e)
        {

        }
    }
}
