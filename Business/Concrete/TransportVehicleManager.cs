using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TransportVehicleManager: ITransportVehicleService
    {
        ITransportVehicleDal _transportVehicleDal;
        
        public TransportVehicleManager(ITransportVehicleDal transportVehicleDal)
        {
            _transportVehicleDal = transportVehicleDal;
        }

        public IDataResult<List<TransportVehicle>> GetAll()
        {
            return new SuccessDataResult<List<TransportVehicle>>(_transportVehicleDal.GetAll());
        }

        public IDataResult<List<TransportVehicle>> GetAllByTypeId(int typeId)
        {
            return new SuccessDataResult<List<TransportVehicle>>(_transportVehicleDal.GetAll(t=>t.TypeId==typeId));
        }

        public IDataResult<TransportVehicle> GetById(int Id)
        {
            return new SuccessDataResult<TransportVehicle>(_transportVehicleDal.Get(t => t.Id == Id));
        }
    }
}
