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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetByID(int id)
        {
            return _productDal.GetByID(b => b.ProductID == id);
        }

        public List<Product> GetByIDList(int id)
        {
            return _productDal.List(n => n.ProductID == id);
        }

        public List<Product> List()
        {
            return _productDal.List();
        }

        public void TAdd(Product t)
        {
            _productDal.Insert(t);
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
