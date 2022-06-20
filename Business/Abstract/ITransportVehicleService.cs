using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITransportVehicleService
    {
        IDataResult<List<TransportVehicle>> GetAll();
        IDataResult<List<TransportVehicle>> GetAllByTypeId(int typeId);
        IDataResult<TransportVehicle> GetById(int Id);
    }
}
