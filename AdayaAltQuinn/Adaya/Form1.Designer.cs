
namespace Adaya
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private Button btnViewProduct;
        private Button btnOrder;

        private void InitializeComponent()
        {
            btnViewProduct = new Button();
            btnOrder = new Button();
            SuspendLayout();
            // 
            // btnViewProduct
            // 
            btnViewProduct.Location = new Point(50, 40);
            btnViewProduct.Name = "btnViewProduct";
            btnViewProduct.Size = new Size(150, 40);
            btnViewProduct.TabIndex = 0;
            btnViewProduct.Text = "VIEW PRODUCT";
            btnViewProduct.Click += btnViewProduct_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(50, 100);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(150, 40);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "ORDER";
            btnOrder.Click += btnOrder_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(250, 180);
            Controls.Add(btnViewProduct);
            Controls.Add(btnOrder);
            Name = "Form1";
            Text = "Main Menu";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        #endregion
    }
}
