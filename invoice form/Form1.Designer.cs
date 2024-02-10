namespace invoice_form
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnDisplayInvoices = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbPartNumber = new System.Windows.Forms.TextBox();
            this.tbPartDescription = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPricePerItem = new System.Windows.Forms.TextBox();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(18, 14);
            this.btnAddInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(150, 35);
            this.btnAddInvoice.TabIndex = 9;
            this.btnAddInvoice.Text = "Add Invoice";
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // btnDisplayInvoices
            // 
            this.btnDisplayInvoices.Location = new System.Drawing.Point(191, 14);
            this.btnDisplayInvoices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplayInvoices.Name = "btnDisplayInvoices";
            this.btnDisplayInvoices.Size = new System.Drawing.Size(180, 35);
            this.btnDisplayInvoices.TabIndex = 8;
            this.btnDisplayInvoices.Text = "Display Invoices";
            this.btnDisplayInvoices.Click += new System.EventHandler(this.btnDisplayInvoices_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(395, 14);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(180, 35);
            this.btnGenerateReport.TabIndex = 7;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(703, 79);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbPartNumber
            // 
            this.tbPartNumber.Location = new System.Drawing.Point(18, 63);
            this.tbPartNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPartNumber.Name = "tbPartNumber";
            this.tbPartNumber.Size = new System.Drawing.Size(148, 26);
            this.tbPartNumber.TabIndex = 5;
            // 
            // tbPartDescription
            // 
            this.tbPartDescription.Location = new System.Drawing.Point(177, 63);
            this.tbPartDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPartDescription.Name = "tbPartDescription";
            this.tbPartDescription.Size = new System.Drawing.Size(178, 26);
            this.tbPartDescription.TabIndex = 4;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(369, 63);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(88, 26);
            this.tbQuantity.TabIndex = 3;
            // 
            // tbPricePerItem
            // 
            this.tbPricePerItem.Location = new System.Drawing.Point(465, 63);
            this.tbPricePerItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPricePerItem.Name = "tbPricePerItem";
            this.tbPricePerItem.Size = new System.Drawing.Size(110, 26);
            this.tbPricePerItem.TabIndex = 2;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(18, 137);
            this.dgvInvoices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersWidth = 62;
            this.dgvInvoices.Size = new System.Drawing.Size(800, 283);
            this.dgvInvoices.TabIndex = 1;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(705, 23);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(110, 26);
            this.tbSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "part number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "part discription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "priceperitems";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(729, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "invoice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 438);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.tbPricePerItem);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbPartDescription);
            this.Controls.Add(this.tbPartNumber);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnDisplayInvoices);
            this.Controls.Add(this.btnAddInvoice);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Invoice Form";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnDisplayInvoices;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbPartNumber;
        private System.Windows.Forms.TextBox tbPartDescription;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbPricePerItem;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}