using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string SupplierCompanyName { get; set; }
        public decimal UnitPrice { get; set; }
        public string Package { get; set; }
        public bool isDiscounted { get; set; }
    }
}
