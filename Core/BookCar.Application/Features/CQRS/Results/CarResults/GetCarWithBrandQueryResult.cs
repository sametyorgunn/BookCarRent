using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Results.CarResults
{
    public class GetCarWithBrandQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string BrandCountry { get; set; }
        public string BrandLogo { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public int BrandId { get; set; }
    }
}
