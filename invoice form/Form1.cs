using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoice_form
{
    public partial class Form1 : Form
    {
        private List<Invoice> invoices;

        public Form1()
        {
            InitializeComponent();
            invoices = new List<Invoice>();

            
            dgvInvoices.Columns.Add("PartNumber", "Part Number");
            dgvInvoices.Columns.Add("PartDescription", "Part Description");
            dgvInvoices.Columns.Add("Quantity", "Quantity");
            dgvInvoices.Columns.Add("PricePerItem", "Price Per Item");
            dgvInvoices.Columns.Add("Discount", "Discount");
            dgvInvoices.Columns.Add("InvoiceAmount", "Invoice Amount");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            string partNumber = tbPartNumber.Text;
            string partDescription = tbPartDescription.Text;
            int quantity = int.Parse(tbQuantity.Text);
            double pricePerItem = double.Parse(tbPricePerItem.Text);

            Invoice invoice = new Invoice(partNumber, partDescription, quantity, pricePerItem);
            invoices.Add(invoice);

            MessageBox.Show("Invoice added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInvoiceFields();
        }

        private void btnDisplayInvoices_Click(object sender, EventArgs e)
        {
            dgvInvoices.Rows.Clear();

            foreach (Invoice invoice in invoices)
            {
                dgvInvoices.Rows.Add(invoice.PartNumber, invoice.PartDescription,
                    invoice.Quantity, invoice.PricePerItem, invoice.GetDiscount(), invoice.GetInvoiceAmount());
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            double totalRevenue = 0;
            double totalDiscount = 0;

            foreach (Invoice invoice in invoices)
            {
                totalRevenue += invoice.GetInvoiceAmount();
                totalDiscount += invoice.GetDiscount();
            }

            MessageBox.Show($"Total Revenue: {totalRevenue}\nTotal Discount: {totalDiscount}",
                "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text;

            dgvInvoices.ClearSelection();

            foreach (DataGridViewRow row in dgvInvoices.Rows)
            {
                if (row.Cells[0].Value.ToString() == searchTerm || row.Cells[1].Value.ToString() == searchTerm)
                {
                    row.Selected = true;
                    dgvInvoices.FirstDisplayedScrollingRowIndex = row.Index;
                    MessageBox.Show("Invoice found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Invoice not found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ClearInvoiceFields()
        {
            tbPartNumber.Text = "";
            tbPartDescription.Text = "";
            tbQuantity.Text = "";
            tbPricePerItem.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

    public class Invoice
    {
        public string PartNumber { get; private set; }
        public string PartDescription { get; private set; }
        public int Quantity { get; private set; }
        public double PricePerItem { get; private set; }

        public Invoice(string partNumber, string partDescription, int quantity, double pricePerItem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PricePerItem = pricePerItem;
        }

        public double GetDiscount()
        {
            int extraItems = Quantity > 10 ? Quantity - 10 : 0;
            double discount = extraItems * PricePerItem * 0.1;
            return discount;
        }

        public double GetInvoiceAmount()
        {
            double discount = GetDiscount();
            double totalAmount = Quantity * PricePerItem - discount;
            return totalAmount;
        }
    }
}