using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entities.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
