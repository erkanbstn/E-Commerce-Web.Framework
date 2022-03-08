using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public SubCategory GetByID(int id)
        {
            return _subCategoryDal.GetByID(b => b.CategoryID == id);
        }

        public List<SubCategory> GetByIDList(int id)
        {
            return _subCategoryDal.List(n => n.CategoryID == id);
        }

        public List<SubCategory> List()
        {
            return _subCategoryDal.List();
        }

        public void TAdd(SubCategory t)
        {
            _subCategoryDal.Insert(t);
        }

        public void TDelete(SubCategory t)
        {
            _subCategoryDal.Delete(t);
        }

        public void TUpdate(SubCategory t)
        {
            _subCategoryDal.Update(t);
        }
    }
}
