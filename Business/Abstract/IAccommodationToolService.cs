using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAccommodationToolService
    {
        IDataResult<List<AccommodationTool>> GetAll();
        IDataResult<List<AccommodationTool>> GetAllByTypeId(int typeId);
        IDataResult<AccommodationTool> GetById(int Id);

    }
}
