namespace Adaya
{
    partial class ProcessOrders
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox lstSummary;
        private Label lblTotal;
        private TextBox txtPayment;
        private Label lblChange;
        private Button btnPrint;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstSummary = new ListBox();
            lblTotal = new Label();
            txtPayment = new TextBox();
            lblChange = new Label();
            btnPrint = new Button();
            SuspendLayout();
            // 
            // lstSummary
            // 
            lstSummary.FormattingEnabled = true;
            lstSummary.ItemHeight = 15;
            lstSummary.Location = new Point(30, 30);
            lstSummary.Name = "lstSummary";
            lstSummary.Size = new Size(300, 169);
            lstSummary.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(30, 220);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(300, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: ";
            // 
            // txtPayment
            // 
            txtPayment.Location = new Point(30, 250);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(300, 23);
            txtPayment.TabIndex = 2;
            // 
            // lblChange
            // 
            lblChange.Location = new Point(30, 280);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(300, 20);
            lblChange.TabIndex = 3;
            lblChange.Text = "Change: ";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(30, 310);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(300, 35);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "PRINT";
            btnPrint.Click += btnPrint_Click;
            // 
            // ProcessOrders
            // 
            ClientSize = new Size(370, 370);
            Controls.Add(lstSummary);
            Controls.Add(lblTotal);
            Controls.Add(txtPayment);
            Controls.Add(lblChange);
            Controls.Add(btnPrint);
            Name = "ProcessOrders";
            Text = "PROCESS ORDER";
            Load += ProcessOrders_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}