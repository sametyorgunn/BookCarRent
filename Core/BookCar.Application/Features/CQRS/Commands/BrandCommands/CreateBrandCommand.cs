﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Commands.BrandCommands
{
    public class CreateBrandCommand
    {
        public string BrandName { get; set; }
    }
}
