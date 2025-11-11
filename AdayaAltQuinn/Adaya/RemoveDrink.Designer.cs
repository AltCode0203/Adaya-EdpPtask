namespace Adaya
{
    partial class RemoveDrink
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private TextBox txtRemove;
        private Label lblResult;
        private Button btnRemove;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.txtRemove = new TextBox();
            this.lblResult = new Label();
            this.btnRemove = new Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Size = new System.Drawing.Size(200, 20);
            this.lblTitle.Text = "REMOVE DRINK";
            this.lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(30, 50);
            this.txtRemove.Size = new System.Drawing.Size(200, 22);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(30, 80);
            this.lblResult.Size = new System.Drawing.Size(200, 20);
            this.lblResult.ForeColor = Color.Green;
            this.lblResult.Text = "";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(30, 110);
            this.btnRemove.Size = new System.Drawing.Size(200, 30);
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.Click += new EventHandler(this.btnRemove_Click);
            // 
            // RemoveDrink
            // 
            this.ClientSize = new System.Drawing.Size(270, 170);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRemove);
            this.Text = "REMOVE DRINK";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}