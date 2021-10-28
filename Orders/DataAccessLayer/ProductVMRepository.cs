using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductVMRepository
    {
        private ProductRepository _productRepository = new ProductRepository();
        private SuppliereRepository _suppliereRepository = new SuppliereRepository();

        public List<ProductVM> GetProducts()
        {
            List<ProductVM> novi2 = new List<ProductVM>();
            var products = _productRepository.GetAll();
            var suppliers = _suppliereRepository.GetAll();
            int i = 0;
            foreach (var item in products)
            { 
            var novi = products.Select(o => new ProductVM
               {
                ProductId = o.ProductId,
                ProductName = o.ProductName,
                SupplierCompanyName = suppliers.Where(s => s.SupplierId == o.SupplierId).Select(s => s.CompanyName).FirstOrDefault(),
                UnitPrice = o.UnitPrice,
                Package = o.Package,
                isDiscounted = o.isDiscounted,
             }).ElementAt(i);

                i += 1;
                novi2.Add(novi);
            }
            return novi2;
        }
    }
}
