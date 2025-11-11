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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            LoadItems();
        }

        private void LoadItems()
        {
            lstFoods.Items.Clear();
            lstDrinks.Items.Clear();

            foreach (var item in Products.FoodList.Items)
                lstFoods.Items.Add(item);

            foreach (var item in Products.DrinkList.Items)
                lstDrinks.Items.Add(item);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            List<string> allItems = new List<string>();

            foreach (var item in lstFoods.Items)
                allItems.Add(item.ToString());

            foreach (var item in lstDrinks.Items)
                allItems.Add(item.ToString());

            ProcessOrders processForm = new ProcessOrders(allItems);
            processForm.Show();
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }
    }
}
