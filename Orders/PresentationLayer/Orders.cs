using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            _tableBindingSource.DataSource = OrderVMRepository.GetOrderVM();
            _tableBindingSource2.DataSource = _customerRepository.GetAll();
            _tableBindingSource3.DataSource = _productVMRepository.GetProducts();
            _tablebindingSource4.DataSource = _suppliereRepository.GetAll();
        }

        private OrderRepository _orderRepository = new OrderRepository();
        private CustomerRepository _customerRepository = new CustomerRepository();
        private ProductRepository _productRepository = new ProductRepository();
        private SuppliereRepository _suppliereRepository = new SuppliereRepository();
        private ProductVMRepository _productVMRepository = new ProductVMRepository();
        private OrderVMRepository OrderVMRepository = new OrderVMRepository();
        private BindingSource _tableBindingSource = new BindingSource();
        private BindingSource _tableBindingSource2 = new BindingSource();
        private BindingSource _tableBindingSource3 = new BindingSource();
        private BindingSource _tablebindingSource4 = new BindingSource();

        private void Orders_Load(object sender, EventArgs e)
        {
            dataGridViewOrders.DataSource = _tableBindingSource;
            dataGridViewCustomers.DataSource = _tableBindingSource2;
            dataGridViewProducts.DataSource = _tableBindingSource3;
            dataGridViewSuppliers.DataSource = _tablebindingSource4;

            DataGridViewImageColumn Button = new DataGridViewImageColumn();

            Button.Image = Image.FromFile(@"C:\Users\38599\source\repos\orders\pic.png");
            Button.Width = 20;
            Button.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //Button.Name = "Vidi kosaricu";
            dataGridViewOrders.Columns.Add(Button);
            dataGridViewOrders.AutoGenerateColumns = false;
        }

        private void dataGridViewOrders_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewOrders.Rows[e.RowIndex].Selected = true;
            if (dataGridViewOrders.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                FormOrderItems FormOrderItems = new FormOrderItems();
                FormOrderItems.lblId.Text = dataGridViewOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormOrderItems.lblId.Hide();
                FormOrderItems.Show();
            }
        }
    }
}

