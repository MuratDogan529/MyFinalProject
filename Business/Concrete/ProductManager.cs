using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        IProductDal _ProductDal;//soyut nesneyle bağlantı kuracağız.

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları
            //Bir iş sınıfı başka sınıfları newlemez injection yapıcaz         
            return _ProductDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _ProductDal.GetAll(p =>p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _ProductDal.GetAll(p => p.UnitPrice>=min && p.UnitPrice<=max);
        }
    }
}
