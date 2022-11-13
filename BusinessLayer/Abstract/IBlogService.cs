using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogRemove(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> GetAllBlogs();
        Blog GetById(int id);
        List<Blog> GetBlogsWithCategory();
        List<Blog> GetBlogWithWriter(int id);
    }
}
