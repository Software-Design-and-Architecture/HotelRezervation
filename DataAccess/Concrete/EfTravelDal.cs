using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class EfTravelDal : EfEntityRepositoryBase<Travel, HotelRezarvationDb>, ITravelDal
    {
        public PriceDetails PriceDetailsByUserId(int userId)
        {
            using (HotelRezarvationDb context = new HotelRezarvationDb())
            {
                var result = from tv in context.TransportVehicles
                             join t in context.Travels
                             on tv.Id equals t.TransportVehiclesId
                             join at in context.AccommodationTools
                             on t.AccommodationToolsId equals at.Id
                             where t.UserId == userId
                             select new PriceDetails { 
                                 AccommodationToolPrice = at.Price,
                                 TransportVehiclePrice=tv.Price,
                                 TravelPrice=t.Price
                             };
                return result.FirstOrDefault();
            }
        }

        public TravelDetails TravelDetailsByUserId(int userId)
        {
            using (HotelRezarvationDb context = new HotelRezarvationDb())
            {
                var result = from t in context.Travels
                             join u in context.Users
                             on t.UserId equals u.Id
                             where t.UserId == userId
                             select new TravelDetails
                             {
                                 DateOfReturn = t.DateOfReturn,
                                 DepartureDate = t.DepartureDate,
                                 LastName = u.LastName,
                                 Location= t.Location,
                                 Name = u.Name,
                                 Address = u.Address
                             };
                return result.FirstOrDefault();
            }

        }

        public TravelVehicleDetails TravelVehicleDetailsByUserId(int userId)
        {
            using (HotelRezarvationDb context = new HotelRezarvationDb())
            {
                var result = from u in context.Users
                             join t in context.Travels
                             on u.Id equals t.UserId

                             join tv in context.TransportVehicles
                             on t.TransportVehiclesId equals tv.Id
                             
                             join tvt in context.TransportVehiclesTypes
                             on tv.TypeId equals tvt.Id

                             join at in context.AccommodationTools
                             on t.AccommodationToolsId equals at.Id
                             
                             join att in context.AccommodationToolsTypes
                             on at.TypeId equals att.Id

                             where u.Id == userId
                             select new TravelVehicleDetails
                             {
                                 AccommodationToolDetails =at.AccommodationToolsDetails,
                                 AccommodationToolName = at.CompanyName,
                                 AccommodationToolTypeName = att.AccommodationToolTypeName,
                                 TransportVehicleDetails=tv.TransportVehiclesDetails,                                
                                 TransportVehicleName=tv.CompanyName,
                                 TransportVehicleTypeName = tvt.TransportVehicleTypeName

                             };
                return result.FirstOrDefault();
            }
        }
    }
}
