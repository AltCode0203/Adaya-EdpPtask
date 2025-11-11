namespace Adaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            Products productsForm = new Products();
            productsForm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Orders ordersForm = new Orders();
            ordersForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
