using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TravelManager: ITravelService
    {
        ITravelDal _travelDal;
       
        public TravelManager(ITravelDal travelDal)
        {
            _travelDal = travelDal;
        }

        public IResult Add(Travel travel)
        {
            _travelDal.Add(travel);
            return new SuccessResult();
        }

        public IResult Delete(Travel travel)
        {
            _travelDal.Delete(travel);
            return new SuccessResult();
        }

        public IDataResult<List<Travel>> GetAll()
        {
            return new SuccessDataResult<List<Travel>>(_travelDal.GetAll());
        }

        public IDataResult<Travel> GetByUserId(int Id)
        {
            if (_travelDal.Get(t => t.UserId == Id)==null)
            {
                return new ErrorDataResult<Travel>();
            }
            return new SuccessDataResult<Travel>(_travelDal.Get(t => t.UserId == Id));
        }

        public IDataResult<PriceDetails> PriceDetailsByUserId(int userId)
        {
            return new SuccessDataResult<PriceDetails>(_travelDal.PriceDetailsByUserId(userId));
        }

        public IDataResult<TravelDetails> TravelDetailsByUserId(int userId)
        {
            return new SuccessDataResult<TravelDetails>(_travelDal.TravelDetailsByUserId(userId));
        }

        public IDataResult<TravelVehicleDetails> TravelVehicleDetailsByUserId(int userId)
        {
            return new SuccessDataResult<TravelVehicleDetails>(_travelDal.TravelVehicleDetailsByUserId(userId));
        }

    }
}
