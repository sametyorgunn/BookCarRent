﻿using BookCar.Application.Features.CQRS.Commands.BrandCommands;
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
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
           await _repository.CreateAsync(new Car
           {
                BrandID = command.BrandID,
                Model = command.Model,
                CoverImgUrl = command.CoverImgUrl,
                Km = command.Km,
                Transmission = command.Transmission,
                Seat = command.Seat,
                Luggage = command.Luggage,
                Fuel = command.Fuel,
                BigImageUrl = command.BigImageUrl
            });
        }
    }
}
