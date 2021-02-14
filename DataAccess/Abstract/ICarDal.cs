using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        //Join ve dto için gerekli işlemleri buraya yazabilirim.

        List<CarDetailDto> GetCarDetails();
    }
}
