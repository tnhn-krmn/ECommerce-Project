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
    public class TagManager : ITagService
    {
        private ITagDAL _tagDAL;

        public TagManager(ITagDAL tagDAL)
        {
            _tagDAL = tagDAL;
        }

        public List<Tag> GetAllTag()
        {
            return _tagDAL.ListAll();
        }

        public Tag GetById(int tagId)
        {
            return _tagDAL.GetById(tagId);
        }

        public int TagAdd(Tag tag)
        {
            return _tagDAL.Add(tag);
        }

        public int TagDelete(Tag tag)
        {
            return _tagDAL.Delete(tag);
        }

        public int TagUpdate(Tag tag)
        {
            return _tagDAL.Update(tag);
        }
    }
}
