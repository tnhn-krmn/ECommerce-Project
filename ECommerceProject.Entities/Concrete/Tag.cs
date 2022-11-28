﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entities.Concrete
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
