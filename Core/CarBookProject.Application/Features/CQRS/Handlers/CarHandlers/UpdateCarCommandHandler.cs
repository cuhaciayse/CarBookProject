using CarBookProject.Application.Features.CQRS.Commands.CarCommand;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BrandID);
            values.BrandID = command.BrandID;
            values.Fuel = command.Fuel;
            values.BigImageUrl = command.BigImageUrl;
            values.Km = command.Km;
            values.Luggage = command.Luggage;
            values.Model = command.Model;
            values.Seat = command.Seat;   
            values.Transmission = command.Transmission;
            values.CoverImageUrl = command.CoverImageUrl;
        }
    }
}
