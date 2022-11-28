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
    public class UserManager : IUserService
    {

        private readonly IUserDAL _userDal;

        public UserManager(IUserDAL userDAL)
        {
            _userDal = userDAL;
        }

        public List<User> GetAllUser()
        {
            return _userDal.ListAll();
        }

        public User GetById(int userId)
        {
            return _userDal.GetById(userId);
        }

        public int UserAdd(User user)
        {
            return _userDal.Add(user);
        }

        public int UserDelete(User user)
        {
            return _userDal.Delete(user);
        }

        public int UserUpdate(User user)
        {
            return _userDal.Update(user);
        }
    }
}
