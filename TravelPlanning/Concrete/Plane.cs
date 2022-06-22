using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using TravelPlanning.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace TravelPlanning.Concrete
{
    public class Plane : ITransportation
    {
        TransportVehicleManager transportVehicleManager = new TransportVehicleManager(new EfTransportVehicleDal());

        public List<TransportVehicle> GetAllTransportVehicles()
        {
            return transportVehicleManager.GetAllByTypeId(1).Data;
        }
    }
}
