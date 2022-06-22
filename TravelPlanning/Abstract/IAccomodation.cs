using Entities.Concrete;
using System.Collections.Generic;

namespace TravelPlanning.Abstract
{
    public interface IAccomodation
    {
        List<AccommodationTool> GetAllAccommodationTools();
        
    }
}