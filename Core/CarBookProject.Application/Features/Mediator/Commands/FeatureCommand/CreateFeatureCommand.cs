﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.FeatureCommand
{
    public class CreateFeatureCommand:IRequest
    {
        public string FeatureName { get; set; }
    }
}
