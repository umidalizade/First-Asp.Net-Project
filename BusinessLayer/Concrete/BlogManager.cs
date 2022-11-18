using BusinessLayer.Abstract;
using EntityLayer.Concrate;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IGenericService<Blog>
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        //public void BlogAdd(Blog blog)
        //{
        //    throw new NotImplementedException();
        //}

        //public void BlogRemove(Blog blog)
        //{
        //    throw new NotImplementedException();
        //}

        //public void BlogUpdate(Blog blog)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Blog> GetAllBlogs()
        //{
        //   return _blogDal.GetListAll();
        //}
        public List<Blog> GetLast3Blogs()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetBlogsWithCategory()
        {
            return _blogDal.GetBlogsWithCategory();
        }

        public Blog TGetById(int id)
        {
            return _blogDal.GetTById(id);
        }
        public List<Blog> GetBlogWithWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id);
        }
        public List<Blog> GetBlogId(int id)
        {
            return _blogDal.GetListAll(x => x.BlogId == id);
        }


        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TRemove(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }
        public List<Blog> GetListByWriterbm(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }
    }
}
