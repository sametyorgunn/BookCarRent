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
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarQueryResult
            {
               CarID = x.CarID,
               BrandID = x.BrandID,
               Model = x.Model,
               BigImageUrl = x.BigImageUrl,
               CoverImgUrl = x.CoverImgUrl,
               Fuel = x.Fuel,
               Km = x.Km,
               Luggage = x.Luggage,
               Seat = x.Seat,
               Transmission = x.Transmission    
            }).ToList();
        }
    }
}
