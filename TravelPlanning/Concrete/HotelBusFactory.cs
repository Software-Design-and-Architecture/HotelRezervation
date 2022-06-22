using System;
using System.Collections.Generic;
using System.Text;
using TravelPlanning.Abstract;

namespace TravelPlanning.Concrete
{
    public class HotelBusFactory : ITravelFactory
    {
        public IAccomodation Accomodation()
        {
            return new Hotel();
        }

        public ITransportation Transportation()
        {
            return new Bus();
        }
    }
}
