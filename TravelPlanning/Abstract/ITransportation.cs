using Entities.Concrete;
using System.Collections.Generic;

namespace TravelPlanning.Abstract
{
    public interface ITransportation
    {
        List<TransportVehicle> GetAllTransportVehicles();
    }
}
