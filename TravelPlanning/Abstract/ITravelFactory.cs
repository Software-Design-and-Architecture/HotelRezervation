using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPlanning.Abstract
{
    public interface ITravelFactory
    {
        abstract ITransportation Transportation();
        abstract IAccomodation Accomodation();
    }
}
