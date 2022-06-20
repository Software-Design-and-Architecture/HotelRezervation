using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AccommodationToolManager : IAccommodationToolService
    {
        IAccommodationToolDal _accommodationToolDal;
        public AccommodationToolManager(IAccommodationToolDal accommodationToolDal)
        {
            _accommodationToolDal = accommodationToolDal;
        }
        public IDataResult<List<AccommodationTool>> GetAll()
        {
            return new SuccessDataResult<List<AccommodationTool>>(_accommodationToolDal.GetAll());
        }

        public IDataResult<List<AccommodationTool>> GetAllByTypeId(int typeId)
        {
            return new SuccessDataResult<List<AccommodationTool>>(_accommodationToolDal.GetAll(a=>a.TypeId==typeId));
        }

        public IDataResult<AccommodationTool> GetById(int Id)
        {
            return new SuccessDataResult<AccommodationTool>(_accommodationToolDal.Get(a => a.Id == Id));
        }
    }
}
