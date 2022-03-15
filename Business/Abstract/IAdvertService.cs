using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdvertService
    {
        IDataResult<List<Advert>> GetAll();
        IDataResult<List<Advert>> GetAllByCategoryId(int id);
        IDataResult<List<Advert>> GetByPrice(decimal min, decimal max);
        IDataResult<List<AdvertDetailDTO>> GetAdvertDetails();
        IResult Add(Advert advert);
        IDataResult<Advert> GetById(int advertId);

    }
}
