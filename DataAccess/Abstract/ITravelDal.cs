using Core.DataAccess;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ITravelDal:IEntityRepository<Travel>
    {
        TravelDetails TravelDetailsByUserId(int userId);
        TravelVehicleDetails TravelVehicleDetailsByUserId(int userId);
        PriceDetails PriceDetailsByUserId(int userId);
    }
}
