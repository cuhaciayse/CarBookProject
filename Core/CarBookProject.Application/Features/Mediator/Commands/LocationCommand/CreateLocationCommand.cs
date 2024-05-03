﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.LocationCommand
{
    public class CreateLocationCommand:IRequest
    {
        public string LocationName { get; set; }
    }
}
