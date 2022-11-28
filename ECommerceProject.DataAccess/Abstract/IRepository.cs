using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        public int Add(T entity);

        public int Delete(T entity);

        public int Update(T entity);

        T GetById(int id);

        List<T> ListAll(Expression<Func<T, bool>> filter = null);
    }
}
