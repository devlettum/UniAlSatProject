using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAdvertDal : EfEntityRepositoryBase<Advert, UniSellContext>, IAdvertDal
    {
        public List<AdvertDetailDTO> GetAdvertDetails()
        {
            using (var context = new UniSellContext())
            {
                var result = from a in context.Adverts
                             join c in context.Categories
                             on a.CategoryId equals c.Id
                             select new AdvertDetailDTO
                             {
                                 AdvertId = a.Id,
                                 AdvertName = a.AdvertName,
                                 CategoryName = c.CategoryName,
                                 AdvertDate = a.AdvertDate,
                                 Description = a.Description,
                                 ProductName = a.ProductName,
                                 IsSold = a.IsSold,
                                 Price = a.Price
                             };
                return result.ToList();
            }
        }
    }
}
