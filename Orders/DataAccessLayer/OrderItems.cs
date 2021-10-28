using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderItems
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId2 { get; set; }
        public decimal OrderItemsUnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
