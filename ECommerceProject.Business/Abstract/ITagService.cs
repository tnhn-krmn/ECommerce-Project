using ECommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.Abstract
{
    public interface ITagService
    {
        public int TagAdd(Tag tag);
        public int TagUpdate(Tag tag);
        public int TagDelete(Tag tag);
        Tag GetById(int tagId);
        List<Tag> GetAllTag();
    }
}
