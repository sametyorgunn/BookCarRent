using BookCar.Application.Features.CQRS.Results.CarResults;
using BookCar.Application.Interfaces.ICarRepository;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.CarHandler
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetCarWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values = _carRepository.GetCarsWithBrand();
            return values.Select(x => new GetCarWithBrandQueryResult
            {
              BrandName = x.Brand.Name,
              BrandId = x.BrandID

            }).ToList();
            
        }
    }
}
