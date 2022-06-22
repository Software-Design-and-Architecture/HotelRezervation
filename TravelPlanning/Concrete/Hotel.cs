using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using TravelPlanning.Abstract;

namespace TravelPlanning.Concrete
{
    public class Hotel : IAccomodation
    {
        AccommodationToolManager accommodationToolManager = new AccommodationToolManager(new EfAccommodationToolDal());
        public List<AccommodationTool> GetAllAccommodationTools()
        {
            return accommodationToolManager.GetAllByTypeId(1).Data;
        }
    }
}
