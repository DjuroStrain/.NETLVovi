using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderVMRepository
    {
        private OrderRepository _orderRepository = new OrderRepository();
        private CustomerRepository _customerRepository = new CustomerRepository();
        private OrderItemsRepository _orderItemsRepository = new OrderItemsRepository();
        public List<OrderVM> GetOrderVM()
        {
            var order = _orderRepository.GetOrders();
            var customers = _customerRepository.GetAll();
            var orderitems = _orderItemsRepository.GetOrderItems();
            List<OrderVM> lista = new List<OrderVM>();
            foreach (OrdersClass orders in order)
            {
                lista.Add(new OrderVM()
                {

                    OrderId = orders.OrderId,
                    OrderNumber = orders.OrderNumber,
                    Order = Convert.ToDateTime(orders.OrderDate),
                    TotalAmount = orders.TotalAmount,
                    CustomerFullName = customers.Where(c => c.CustomerId == orders.CustomerID).Select(c => c.FirstName + " " + c.LastName).FirstOrDefault().ToString(),
                    OrderItems = orderitems.Where(x => x.OrderId == orders.OrderId).ToList()
                });
            }
            return lista;
        }


    }
}

       

