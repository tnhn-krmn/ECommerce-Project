using ECommerceProject.Business.Abstract;
using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public List<Product> GetAllProduct()
        {
            return _productDAL.ListAll();
        }

        public Product GetById(int productId)
        {
            return _productDAL.GetById(productId);
        }

        public List<Product> GetWithListCategory()
        {
            return _productDAL.GetListWithCategory();
        }

        public int ProductAdd(Product product)
        {
            return _productDAL.Add(product);
        }

        public int ProductDelete(Product Product)
        {
            return _productDAL.Delete(Product);
        }

        public int ProductUpdate(Product product)
        {
            return _productDAL.Update(product);
        }
    }
}
