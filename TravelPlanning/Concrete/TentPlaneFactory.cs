using System;
using System.Collections.Generic;
using System.Text;
using TravelPlanning.Abstract;

namespace TravelPlanning.Concrete
{
    public class TentPlaneFactory : ITravelFactory
    {
        public IAccomodation Accomodation()
        {
            return new Tent();
        }

        public ITransportation Transportation()
        {
            return new Plane();
        }
    }
}
