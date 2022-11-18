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

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //public CategoryManager()
        //{
        //    //efCategoryRepository = new EfCategoryRepository();
        //}


        public Category TGetById(int id)
        {
             return _categoryDal.GetTById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TRemove(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}

        //public void CategoryAdd(Category category)
        //{
        //    //efCategoryRepository.Insert(category);
        //    categoryDal.Insert(category);
        //}

        //public void CategoryRemove(Category category)
        //{
        //    //efCategoryRepository.Delete(category);
        //    categoryDal.Delete(category);
        //}

        //public void CategoryUpdate(Category category)
        //{
        //    //efCategoryRepository.Update(category);
        //    categoryDal.Update(category);
        //}

        //public List<Category> GetAllCategories()
        //{
        //    return categoryDal.GetListAll();
        //}
