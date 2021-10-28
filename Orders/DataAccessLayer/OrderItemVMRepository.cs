using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderItemVMRepository
    {
        public OrderVMRepository repository = new OrderVMRepository();
        public ProductRepository product = new ProductRepository();
        public List<OrderItemVM> GetOrderItemsofOrder(int orderID)
        {
            var orders = repository.GetOrderVM();
            var products = product.GetAll();
            List<OrderItemVM> orderItemsVMs = new List<OrderItemVM>();
            foreach (OrderVM order in orders)
            {

                if (order.OrderId == orderID)
                {
                    foreach (OrderItems orderItem in order.OrderItems)
                    {
                        orderItemsVMs.Add(new OrderItemVM()
                        {
                            OrderItemVMId = orderItem.OrderItemId,
                            OrderItemVMProductName = products.Where(x => x.ProductId == orderItem.ProductId2).Select(y => y.ProductName).FirstOrDefault().ToString(),
                            OrderItemVMProductPackage = products.Where(x => x.ProductId == orderItem.ProductId2).Select(y => y.Package).FirstOrDefault().ToString(),
                            OrderItemVMUnitPrice = (decimal)orderItem.OrderItemsUnitPrice,
                            OrderItemVMQuantity = orderItem.Quantity
                        });
                    }
                }
            }
            return orderItemsVMs;

        }
    }
}
