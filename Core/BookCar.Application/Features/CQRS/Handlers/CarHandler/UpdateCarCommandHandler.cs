using BookCar.Application.Features.CQRS.Commands.CarCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.CarHandler
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
            var car = await _repository.GetByIdAsync(command.BrandID);
            car.Model = command.Model;
            car.CoverImgUrl = command.CoverImgUrl;
            car.Km = command.Km;
            car.Transmission = command.Transmission;
            car.Seat = command.Seat;
            car.Luggage = command.Luggage;
            car.Fuel = command.Fuel;
            car.BigImageUrl = command.BigImageUrl;
            await _repository.UpdateAsync(car);
            
        }
    }
}
