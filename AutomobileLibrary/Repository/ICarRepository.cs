using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAll();
        Car getCarByID(int carId);
        void AddNew(Car car);
        void Update(Car car);
        void Delete(int carId);
    }
}
