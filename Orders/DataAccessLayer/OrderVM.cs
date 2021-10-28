using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderVM
    {
        public int OrderId { get; set; }
        public DateTime Order { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerFullName { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItems> OrderItems { get; set; }

    }
}
