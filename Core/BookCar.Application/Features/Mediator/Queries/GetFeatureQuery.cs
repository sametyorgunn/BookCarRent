﻿using BookCar.Application.Features.Mediator.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Queries
{
    public class GetFeatureQuery:IRequest<List<GetFeatureQueryResult>>
    {
    }
}
