using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //DataAccess teki IcategoryDal a ulaşmak için _categoryDal adında field oluşturduk.
        ICategoryDal _categoryDal;

        //_categoryDal a atama yapabilmek için constructer method oluşturuyoruz.
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category); //repository deki Insert metota bağladık.

        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id); // ID den gelen değere eşit mi değil mi ?
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }


    }
}
