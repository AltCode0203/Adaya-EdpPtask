namespace Adaya
{
    partial class Orders
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private ListBox lstFoods;
        private ListBox lstDrinks;
        private Button btnOrder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lstFoods = new ListBox();
            this.lstDrinks = new ListBox();
            this.btnOrder = new Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(200, 20);
            this.lblTitle.Size = new System.Drawing.Size(100, 20);
            this.lblTitle.Text = "ORDERS";
            this.lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstFoods
            // 
            this.lstFoods.FormattingEnabled = true;
            this.lstFoods.ItemHeight = 16;
            this.lstFoods.Location = new System.Drawing.Point(30, 50);
            this.lstFoods.Size = new System.Drawing.Size(200, 180);
            // 
            // lstDrinks
            // 
            this.lstDrinks.FormattingEnabled = true;
            this.lstDrinks.ItemHeight = 16;
            this.lstDrinks.Location = new System.Drawing.Point(270, 50);
            this.lstDrinks.Size = new System.Drawing.Size(200, 180);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(180, 250);
            this.btnOrder.Size = new System.Drawing.Size(120, 35);
            this.btnOrder.Text = "ORDER";
            this.btnOrder.Click += new EventHandler(this.btnOrder_Click);
            // 
            // Orders
            // 
            this.ClientSize = new System.Drawing.Size(500, 310);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstFoods);
            this.Controls.Add(this.lstDrinks);
            this.Controls.Add(this.btnOrder);
            this.Text = "ORDERS";
            this.ResumeLayout(false);
        }
    }
}