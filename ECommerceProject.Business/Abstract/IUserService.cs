using ECommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.Abstract
{
    public interface IUserService
    {
        public int UserAdd(User user);
        public int UserUpdate(User user);
        public int UserDelete(User user);
        User GetById(int userId);
        List<User> GetAllUser();
    }
}
