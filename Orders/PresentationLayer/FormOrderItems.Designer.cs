namespace PresentationLayer
{
    partial class FormOrderItems
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
            this.lblId = new System.Windows.Forms.Label();
            this.dataGridViewOrderItems = new System.Windows.Forms.DataGridView();
            this.OrderItemVMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemVMProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemVMProductPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemVMUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(575, 336);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(46, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "label1";
            // 
            // dataGridViewOrderItems
            // 
            this.dataGridViewOrderItems.AllowUserToOrderColumns = true;
            this.dataGridViewOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderItemVMID,
            this.OrderItemVMProductName,
            this.OrderItemVMProductPackage,
            this.OrderItemVMUnitPrice,
            this.Quantity});
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.RowHeadersWidth = 51;
            this.dataGridViewOrderItems.RowTemplate.Height = 24;
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(802, 438);
            this.dataGridViewOrderItems.TabIndex = 1;
            // 
            // OrderItemVMID
            // 
            this.OrderItemVMID.DataPropertyName = "OrderItemVMID";
            this.OrderItemVMID.HeaderText = "ID proizvoda";
            this.OrderItemVMID.MinimumWidth = 6;
            this.OrderItemVMID.Name = "OrderItemVMID";
            this.OrderItemVMID.Width = 125;
            // 
            // OrderItemVMProductName
            // 
            this.OrderItemVMProductName.DataPropertyName = "OrderItemVMProductName";
            this.OrderItemVMProductName.HeaderText = "Naziv proizvoda";
            this.OrderItemVMProductName.MinimumWidth = 6;
            this.OrderItemVMProductName.Name = "OrderItemVMProductName";
            this.OrderItemVMProductName.Width = 125;
            // 
            // OrderItemVMProductPackage
            // 
            this.OrderItemVMProductPackage.DataPropertyName = "OrderItemVMProductPackage";
            this.OrderItemVMProductPackage.HeaderText = "Paket";
            this.OrderItemVMProductPackage.MinimumWidth = 6;
            this.OrderItemVMProductPackage.Name = "OrderItemVMProductPackage";
            this.OrderItemVMProductPackage.Width = 125;
            // 
            // OrderItemVMUnitPrice
            // 
            this.OrderItemVMUnitPrice.DataPropertyName = "OrderItemVMUnitPrice";
            this.OrderItemVMUnitPrice.HeaderText = "Cijena";
            this.OrderItemVMUnitPrice.MinimumWidth = 6;
            this.OrderItemVMUnitPrice.Name = "OrderItemVMUnitPrice";
            this.OrderItemVMUnitPrice.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "OrderItemVMQuantity";
            this.Quantity.HeaderText = "Kolicina";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // FormOrderItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewOrderItems);
            this.Controls.Add(this.lblId);
            this.Name = "FormOrderItems";
            this.Text = "FormOrderItems";
            this.Load += new System.EventHandler(this.FormOrderItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.DataGridView dataGridViewOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemVMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemVMProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemVMProductPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemVMUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}