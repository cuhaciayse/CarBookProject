using CarBookProject.Application.Features.CQRS.Results.CarResult;
using CarBookProject.Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarsWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetLast5CarsWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values = _carRepository.GetLast5CarsWithBrand();
            return values.Select(x=> new GetCarWithBrandQueryResult
            {
                BigImageUrl = x.BigImageUrl,
                BrandID = x.BrandID,
                BrandName = x.Brand.BrandName,
                CarID = x.BrandID,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission
            }).ToList();    
        }
    }
}
