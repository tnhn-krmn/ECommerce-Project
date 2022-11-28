using ECommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.Abstract
{   public interface IProductService
    {
        public int ProductAdd(Product product);
        public int ProductUpdate(Product product);
        public int ProductDelete(Product Product);
        Product GetById(int productId);
        List<Product> GetAllProduct();
        List<Product> GetWithListCategory();

    }
}
