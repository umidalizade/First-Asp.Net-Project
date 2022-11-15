using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IGenericDal<About>
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Delete(About t)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
           return _aboutDal.GetListAll();
        }

        public List<About> GetListAll()
        {
            throw new NotImplementedException();
        }

        public List<About> GetListAll(Expression<Func<About, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public About GetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(About t)
        {
            throw new NotImplementedException();
        }

        public void Update(About t)
        {
            throw new NotImplementedException();
        }
    }
}
