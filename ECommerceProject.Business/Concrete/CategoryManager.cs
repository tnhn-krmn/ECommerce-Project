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
    public class CategoryManager : ICategoryService
    {
        private ICategoryDAL _categoryDal;
        public CategoryManager(ICategoryDAL categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public int CategoryAdd(Category category)
        {
            return _categoryDal.Add(category);
        }

        public int CategoryDelete(Category category)
        {
            return _categoryDal.Delete(category);
        }

        public int CategoryUpdate(Category category)
        {
            return _categoryDal.Update(category);
        }

        public List<Category> GetAllCategory()
        {
            return _categoryDal.ListAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.GetById(categoryId);
        }
    }
}
