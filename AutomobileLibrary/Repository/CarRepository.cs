using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void AddNew(Car car) => CarDBContext.Instance.AddNew(car);

        public void Delete(int carId) => CarDBContext.Instance.Remove(carId);

        public IEnumerable<Car> GetAll() => CarDBContext.Instance.GetCarList();

        public Car getCarByID(int carId) => CarDBContext.Instance.GetCarByID(carId);

        public void Update(Car car) => CarDBContext.Instance.Update(car);
    }
}
