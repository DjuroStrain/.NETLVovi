namespace PresentationLayer
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDiscounted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOrders);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.dataGridViewOrders);
            this.tabOrders.Location = new System.Drawing.Point(4, 25);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(793, 420);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Narudzbe";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderNumber,
            this.OrderDate,
            this.TotalAmount2,
            this.CustomerFullName});
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(793, 420);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick_1);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.dataGridViewCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 25);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(793, 420);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "Kupci";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId2,
            this.FirstName,
            this.LastName,
            this.City,
            this.Country,
            this.Phone});
            this.dataGridViewCustomers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(797, 420);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // CustomerId2
            // 
            this.CustomerId2.DataPropertyName = "CustomerId";
            this.CustomerId2.HeaderText = "ID";
            this.CustomerId2.MinimumWidth = 6;
            this.CustomerId2.Name = "CustomerId2";
            this.CustomerId2.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Ime";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Prezime";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Grad";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.Width = 125;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Drzava";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.Width = 125;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Telefon";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.dataGridViewProducts);
            this.tabProducts.Location = new System.Drawing.Point(4, 25);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(793, 420);
            this.tabProducts.TabIndex = 2;
            this.tabProducts.Text = "Proizvodi";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.SupplierCompanyName,
            this.UnitPrice,
            this.Package,
            this.isDiscounted});
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(793, 424);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ID";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Ime proizvoda";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // SupplierCompanyName
            // 
            this.SupplierCompanyName.DataPropertyName = "SupplierCompanyName";
            this.SupplierCompanyName.HeaderText = "Ime tvrtke";
            this.SupplierCompanyName.MinimumWidth = 6;
            this.SupplierCompanyName.Name = "SupplierCompanyName";
            this.SupplierCompanyName.Width = 125;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Cijena";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 125;
            // 
            // Package
            // 
            this.Package.DataPropertyName = "Package";
            this.Package.HeaderText = "Vrsta";
            this.Package.MinimumWidth = 6;
            this.Package.Name = "Package";
            this.Package.Width = 125;
            // 
            // isDiscounted
            // 
            this.isDiscounted.DataPropertyName = "isDiscounted";
            this.isDiscounted.HeaderText = "Popust";
            this.isDiscounted.MinimumWidth = 6;
            this.isDiscounted.Name = "isDiscounted";
            this.isDiscounted.Width = 125;
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.dataGridViewSuppliers);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 25);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppliers.Size = new System.Drawing.Size(793, 420);
            this.tabSuppliers.TabIndex = 3;
            this.tabSuppliers.Text = "Dobavljaci";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.CompanyName,
            this.ContactName,
            this.ContactTitle,
            this.City2,
            this.Country2,
            this.Phone2,
            this.Fax});
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.RowHeadersWidth = 51;
            this.dataGridViewSuppliers.RowTemplate.Height = 24;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(793, 420);
            this.dataGridViewSuppliers.TabIndex = 0;
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "ID";
            this.SupplierId.MinimumWidth = 6;
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.Width = 125;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "Ime tvrke";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 125;
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "ContactName";
            this.ContactName.HeaderText = "Ime dobavljaca";
            this.ContactName.MinimumWidth = 6;
            this.ContactName.Name = "ContactName";
            this.ContactName.Width = 125;
            // 
            // ContactTitle
            // 
            this.ContactTitle.DataPropertyName = "ContactTitle";
            this.ContactTitle.HeaderText = "Naslov";
            this.ContactTitle.MinimumWidth = 6;
            this.ContactTitle.Name = "ContactTitle";
            this.ContactTitle.Width = 125;
            // 
            // City2
            // 
            this.City2.DataPropertyName = "City";
            this.City2.HeaderText = "Grad";
            this.City2.MinimumWidth = 6;
            this.City2.Name = "City2";
            this.City2.Width = 125;
            // 
            // Country2
            // 
            this.Country2.DataPropertyName = "Country";
            this.Country2.HeaderText = "Drzava";
            this.Country2.MinimumWidth = 6;
            this.Country2.Name = "Country2";
            this.Country2.Width = 125;
            // 
            // Phone2
            // 
            this.Phone2.DataPropertyName = "Phone";
            this.Phone2.HeaderText = "Telefon";
            this.Phone2.MinimumWidth = 6;
            this.Phone2.Name = "Phone2";
            this.Phone2.Width = 125;
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.MinimumWidth = 6;
            this.Fax.Name = "Fax";
            this.Fax.Width = 125;
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "ID";
            this.OrderId.MinimumWidth = 6;
            this.OrderId.Name = "OrderId";
            this.OrderId.Width = 125;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "Broj narudzbe";
            this.OrderNumber.MinimumWidth = 6;
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Width = 125;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "Order";
            this.OrderDate.HeaderText = "Datum";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 125;
            // 
            // TotalAmount2
            // 
            this.TotalAmount2.DataPropertyName = "TotalAmount";
            this.TotalAmount2.HeaderText = "Ukupni iznos";
            this.TotalAmount2.MinimumWidth = 6;
            this.TotalAmount2.Name = "TotalAmount2";
            this.TotalAmount2.Width = 125;
            // 
            // CustomerFullName
            // 
            this.CustomerFullName.DataPropertyName = "CustomerFullName";
            this.CustomerFullName.HeaderText = "Ime i prezime kupca";
            this.CustomerFullName.MinimumWidth = 6;
            this.CustomerFullName.Name = "CustomerFullName";
            this.CustomerFullName.Width = 125;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Orders";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.tabSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDiscounted;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn City2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFullName;
    }
}

