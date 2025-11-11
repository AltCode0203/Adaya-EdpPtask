namespace Adaya
{
    partial class Products
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFoods;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.ListBox lstFoods;
        private System.Windows.Forms.ListBox lstDrinks;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.Button btnDeleteDrink;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFoods = new Label();
            lblDrinks = new Label();
            lstFoods = new ListBox();
            lstDrinks = new ListBox();
            btnAddFood = new Button();
            btnDeleteFood = new Button();
            btnAddDrink = new Button();
            btnDeleteDrink = new Button();
            SuspendLayout();
            // 
            // lblFoods
            // 
            lblFoods.Location = new Point(30, 20);
            lblFoods.Name = "lblFoods";
            lblFoods.Size = new Size(100, 20);
            lblFoods.TabIndex = 0;
            lblFoods.Text = "FOODS";
            // 
            // lblDrinks
            // 
            lblDrinks.Location = new Point(270, 20);
            lblDrinks.Name = "lblDrinks";
            lblDrinks.Size = new Size(100, 20);
            lblDrinks.TabIndex = 1;
            lblDrinks.Text = "DRINKS";
            // 
            // lstFoods
            // 
            lstFoods.FormattingEnabled = true;
            lstFoods.ItemHeight = 15;
            lstFoods.Location = new Point(30, 50);
            lstFoods.Name = "lstFoods";
            lstFoods.Size = new Size(200, 169);
            lstFoods.TabIndex = 2;
            // 
            // lstDrinks
            // 
            lstDrinks.FormattingEnabled = true;
            lstDrinks.ItemHeight = 15;
            lstDrinks.Location = new Point(270, 50);
            lstDrinks.Name = "lstDrinks";
            lstDrinks.Size = new Size(200, 169);
            lstDrinks.TabIndex = 3;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(30, 240);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(90, 30);
            btnAddFood.TabIndex = 4;
            btnAddFood.Text = "ADD";
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(140, 240);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(90, 30);
            btnDeleteFood.TabIndex = 5;
            btnDeleteFood.Text = "DELETE";
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnAddDrink
            // 
            btnAddDrink.Location = new Point(270, 240);
            btnAddDrink.Name = "btnAddDrink";
            btnAddDrink.Size = new Size(90, 30);
            btnAddDrink.TabIndex = 6;
            btnAddDrink.Text = "ADD";
            btnAddDrink.Click += btnAddDrink_Click;
            // 
            // btnDeleteDrink
            // 
            btnDeleteDrink.Location = new Point(380, 240);
            btnDeleteDrink.Name = "btnDeleteDrink";
            btnDeleteDrink.Size = new Size(90, 30);
            btnDeleteDrink.TabIndex = 7;
            btnDeleteDrink.Text = "DELETE";
            btnDeleteDrink.Click += btnDeleteDrink_Click;
            // 
            // Products
            // 
            ClientSize = new Size(500, 300);
            Controls.Add(lblFoods);
            Controls.Add(lblDrinks);
            Controls.Add(lstFoods);
            Controls.Add(lstDrinks);
            Controls.Add(btnAddFood);
            Controls.Add(btnDeleteFood);
            Controls.Add(btnAddDrink);
            Controls.Add(btnDeleteDrink);
            Name = "Products";
            Text = "PRODUCTS";
            Load += Products_Load;
            ResumeLayout(false);
        }
    }
}