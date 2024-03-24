using BookCar.Application.Features.CQRS.Queries.BrandQueries;
using BookCar.Application.Features.CQRS.Queries.CarQueries;
using BookCar.Application.Features.CQRS.Results.BrandResults;
using BookCar.Application.Features.CQRS.Results.CarResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.CarHandler
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.CarID);
            return new GetCarByIdQueryResult
            {
                CarID = values.CarID,
                BrandID = values.BrandID,
                Model = values.Model,
                Km = values.Km,
                Transmission = values.Transmission,
                Seat = values.Seat,
                Luggage = values.Luggage,
                Fuel = values.Fuel,
                CoverImgUrl = values.CoverImgUrl,
                BigImageUrl = values.BigImageUrl
            };
        }
    }
}
