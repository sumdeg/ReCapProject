using Core.Utilities.Results;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetByCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetByCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
