using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Adaya
{
    public partial class ProcessOrders : Form
    {
        private List<string> items;
        private decimal total;

        public ProcessOrders(List<string> orderedItems)
        {
            InitializeComponent();
            items = orderedItems;
            LoadSummary();
        }

        private void LoadSummary()
        {
            lstSummary.Items.Clear();
            total = 0;

            foreach (string item in items)
            {
                lstSummary.Items.Add(item);
                string[] parts = item.Split('-');
                if (parts.Length == 2 && decimal.TryParse(parts[1].Trim(), out decimal price))
                {
                    total += price;
                }
            }

            lblTotal.Text = $"Total: {total}";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPayment.Text.Trim(), out decimal payment))
            {
                MessageBox.Show("Invalid payment amount.");
                return;
            }

            if (payment < total)
            {
                MessageBox.Show("Insufficient payment.");
                return;
            }

            decimal change = payment - total;
            lblChange.Text = $"Change: {change}";

            string receipt = "===== RECEIPT =====\n";
            receipt += $"Date: {DateTime.Now}\n";
            receipt += $"Order #: E{new Random().Next(10000000, 99999999)}\n\n";
            receipt += "Items:\n";
            foreach (string item in items)
            {
                string[] parts = item.Split('-');
                if (parts.Length == 2)
                {
                    string name = parts[0].Trim();
                    string price = parts[1].Trim();
                    receipt += $"- {name} = {price}\n";
                }
            }
            receipt += $"\nTotal: {total}\n";
            receipt += $"Payment: {payment}\n";
            receipt += $"Change: {change}\n";
            receipt += "==================\n";

            string filePath = "AdayaAltQuinn.txt";
            File.WriteAllText(filePath, receipt);
            Process.Start("notepad.exe", filePath);
        }

        private void ProcessOrders_Load(object sender, EventArgs e)
        {

        }
    }
}

