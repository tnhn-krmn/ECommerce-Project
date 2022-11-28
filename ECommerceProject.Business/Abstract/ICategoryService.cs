using ECommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.Abstract
{
    public interface ICategoryService
    {
        public int CategoryAdd(Category category);
        public int CategoryUpdate(Category category);
        public int CategoryDelete(Category category);
        Category GetById(int categoryId);
        List<Category> GetAllCategory();
    }
}
