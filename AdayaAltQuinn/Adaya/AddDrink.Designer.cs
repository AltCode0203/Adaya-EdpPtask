namespace Adaya
{
    partial class AddDrink
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private TextBox txtName;
        private TextBox txtPrice;
        private Label lblResult;
        private Button btnAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            lblResult = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ADD DRINK";
            // 
            // txtName
            // 
            txtName.Location = new Point(30, 50);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Drink name";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(30, 80);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 2;
            // 
            // lblResult
            // 
            lblResult.ForeColor = Color.Green;
            lblResult.Location = new Point(30, 110);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(200, 20);
            lblResult.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.Click += btnAdd_Click;
            // 
            // AddDrink
            // 
            ClientSize = new Size(270, 200);
            Controls.Add(lblTitle);
            Controls.Add(txtName);
            Controls.Add(txtPrice);
            Controls.Add(lblResult);
            Controls.Add(btnAdd);
            Name = "AddDrink";
            Text = "ADD DRINK";
            Load += AddDrink_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}