using Core.Utilities.Results;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITravelService
    {
        IDataResult<List<Travel>> GetAll();
        IDataResult<Travel> GetByUserId(int Id);
        IResult Add(Travel travel);
        IResult Delete(Travel travel);
        IDataResult<PriceDetails> PriceDetailsByUserId(int userId);
        IDataResult<TravelDetails> TravelDetailsByUserId(int userId);
        IDataResult<TravelVehicleDetails> TravelVehicleDetailsByUserId(int userId);
        
    }
}
