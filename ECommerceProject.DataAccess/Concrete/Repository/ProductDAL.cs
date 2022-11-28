using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DataAccess.Concrete.Repository
{
    public class ProductDAL : Repository<Product>, IProductDAL
    {
        public List<Product> GetListWithCategory()
        {
            using(var context = new Context())
            {
                return context.Products.Include(x => x.Category).ToList();
            }
        }
    }
}
