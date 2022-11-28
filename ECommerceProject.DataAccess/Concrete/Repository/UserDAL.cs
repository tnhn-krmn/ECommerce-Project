using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DataAccess.Concrete.Repository
{
    public class UserDAL : Repository<User>,IUserDAL
    {
    }
}
