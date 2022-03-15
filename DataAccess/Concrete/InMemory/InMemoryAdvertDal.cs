using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryAdvertDal : IAdvertDal
    {
        List<Advert> _products;
        public InMemoryAdvertDal()
        {
            _products = new List<Advert>
            {
                new Advert{Id=1,CategoryId=1,ProductName="bardak",Description="aaaaaa" },
                new Advert{Id=2,CategoryId=1,ProductName="qqqq",Description="aaaaaa",Price=11,IsSold=false},
                new Advert{Id=3,CategoryId=1,ProductName="barssdak",Description="aaaaaa",Price=300,IsSold=true}
            };
        }

        public void Add(Advert product)
        {
            _products.Add(product);
        }

        public void Delete(Advert product)
        {
            Advert productToDelete = null;
            productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);

            _products.Remove(productToDelete);
        }

        public Advert Get(Expression<Func<Advert, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<AdvertDetailDTO> GetAdvertDetails()
        {
            throw new NotImplementedException();
        }

        public List<Advert> GetAll()
        {
            return _products;
        }

        public List<Advert> GetAll(Expression<Func<Advert, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Advert> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Advert product)
        {
            Advert productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.Price = product.Price;
            productToUpdate.IsSold = product.IsSold;
            productToUpdate.Description = product.Description;
        }
    }
}
