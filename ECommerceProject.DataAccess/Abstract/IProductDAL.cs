﻿using ECommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DataAccess.Abstract
{
    public interface IProductDAL : IRepository<Product>
    {
        List<Product> GetListWithCategory();
    }
}
