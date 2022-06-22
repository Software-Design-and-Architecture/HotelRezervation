using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using TravelPlanning.Abstract;

namespace TravelPlanning.Concrete
{
    public class Bus : ITransportation
    {

        TransportVehicleManager transportVehicleManager = new TransportVehicleManager(new EfTransportVehicleDal());

        public List<TransportVehicle> GetAllTransportVehicles()
        {
            return transportVehicleManager.GetAllByTypeId(2).Data;
        }
    }
}
