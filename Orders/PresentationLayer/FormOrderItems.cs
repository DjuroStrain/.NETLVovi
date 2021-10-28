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
    public partial class FormOrderItems : Form
    {
        public FormOrderItems()
        {
            InitializeComponent();
        }

        private BindingSource _tableBindingSource = new BindingSource();
        private OrderItemVMRepository orderItemVMRepository = new OrderItemVMRepository();

        private void FormOrderItems_Load(object sender, EventArgs e)
        {
            int OrderId = Int32.Parse(lblId.Text);
            _tableBindingSource.DataSource = orderItemVMRepository.GetOrderItemsofOrder(OrderId);
            dataGridViewOrderItems.DataSource = _tableBindingSource;

        }
    }
}
