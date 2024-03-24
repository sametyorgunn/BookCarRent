using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Queries.CarQueries
{
    public class GetCarByIdQuery
    {
        public int CarID { get; set; }

        public GetCarByIdQuery(int carID)
        {
            CarID = carID;
        }
    }
}
