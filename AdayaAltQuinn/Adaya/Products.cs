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
    public partial class Products : Form
    {
        public static ListBox FoodList;
        public static ListBox DrinkList;

        public Products()
        {
            InitializeComponent();
            FoodList = lstFoods;
            DrinkList = lstDrinks;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            new AddFood().Show();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            new RemoveFood().Show();
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            new AddDrink().Show();
        }

        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            new RemoveDrink().Show();
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }
    }
}
