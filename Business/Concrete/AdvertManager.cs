using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class AdvertManager : IAdvertService
    {
        IAdvertDal _advertDal;

        public AdvertManager(IAdvertDal advertDal)
        {
            _advertDal = advertDal;
        }

        public IResult Add(Advert advert)
        {
            if (advert.AdvertName.Length<3)
            {
                return new ErrorResult(Messages.AdvertNameInvalid);
            }
            _advertDal.Add(advert);
            return new SuccessResult(Messages.AdvertAdded);
        }

        public IDataResult<List<AdvertDetailDTO>> GetAdvertDetails()
        {
            return new SuccessDataResult<List<AdvertDetailDTO>>(_advertDal.GetAdvertDetails());
        }

        public IDataResult<List<Advert>> GetAll()
        {
            return new SuccessDataResult<List<Advert>>(_advertDal.GetAll(),Messages.AdvertListed);
        }

        public IDataResult<List<Advert>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Advert>>(_advertDal.GetAll(a => a.CategoryId == id));
        }

        public IDataResult<Advert> GetById(int advertId)
        {
            return new SuccessDataResult<Advert>(_advertDal.Get(a=>a.Id==advertId));
        }

        public IDataResult<List<Advert>> GetByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Advert>>
                (_advertDal.GetAll(a => a.Price >= min && a.Price <= max));
        }

    }
}
