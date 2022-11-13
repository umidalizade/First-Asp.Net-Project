using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        //EfCategoryRepository efCategoryRepository;

        ICategoryDal categoryDal;

        //public CategoryManager()
        //{
        //    //efCategoryRepository = new EfCategoryRepository();
        //}

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            //efCategoryRepository.Insert(category);
            categoryDal.Insert(category);
        }

        public void CategoryRemove(Category category)
        {
            //efCategoryRepository.Delete(category);
            categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            //efCategoryRepository.Update(category);
            categoryDal.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return categoryDal.GetListAll();
        }

        public Category GetById(int id)
        {
             return categoryDal.GetTById(id);
        }
    }
}
