﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.FeatureCommand
{
    public class UpdateFeatureCommand:IRequest
    {
        public int FeatureID { get; set; }
        public string FeatureName { get; set; }
    }
}
