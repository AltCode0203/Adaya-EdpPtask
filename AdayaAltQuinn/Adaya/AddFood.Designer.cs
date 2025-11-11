namespace Adaya
{
    partial class AddFood
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
            this.lblTitle = new Label();
            this.txtName = new TextBox();
            this.txtPrice = new TextBox();
            this.lblResult = new Label();
            this.btnAdd = new Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Size = new System.Drawing.Size(200, 20);
            this.lblTitle.Text = "ADD FOOD";
            this.lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 50);
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.PlaceholderText = "Food name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(30, 80);
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.PlaceholderText = "Price";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(30, 110);
            this.lblResult.Size = new System.Drawing.Size(200, 20);
            this.lblResult.ForeColor = Color.Green;
            this.lblResult.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 140);
            this.btnAdd.Size = new System.Drawing.Size(200, 30);
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // AddFood
            // 
            this.ClientSize = new System.Drawing.Size(270, 200);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAdd);
            this.Text = "ADD FOOD";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}