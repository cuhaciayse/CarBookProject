using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.CarInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _carcontext;

        public CarRepository(CarBookContext carcontext)
        {
            _carcontext = carcontext;
        }

        public List<Car> GetCarsListWithBrand()
        {
            var values = _carcontext.Cars.Include(x => x.Brand).ToList();
            return values;
        }

        public List<Car> GetLast5CarsWithBrand()
        {
            var values = _carcontext.Cars.Include(y=>y.Brand).OrderByDescending(x=>x.CarID).Take(5).ToList();  // Son 5 arabayı göstermek için
            return values;
        }
    }
}
