using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DataAccess.Concrete.Repository
{
    public class Repository<T> where T : class
    {
        DbSet<T> obj;
        Context con = new Context();

        public Repository()
        {
            obj = con.Set<T>();
        }

        public int Add(T entity)
        {
            obj.Add(entity);
            return con.SaveChanges();
        }

        public List<T> ListAll(Expression<Func<T, bool>> filter = null)
        {
            return obj.ToList();
        }

        public int Update(T entity)
        {
            obj.Update(entity);
            return con.SaveChanges();
        }


        public int Delete(T entity)
        {
            obj.Remove(entity);
            return con.SaveChanges();
        }

        public T GetById(int id)
        {
            return obj.Find(id);
        }
    }
}
