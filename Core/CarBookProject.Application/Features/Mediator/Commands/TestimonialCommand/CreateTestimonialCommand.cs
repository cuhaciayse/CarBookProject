﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.TestimonialCommand
{
    public class CreateTestimonialCommand:IRequest
    {
        public string Name { get; set; }
        public string Title { get; set; }  // Unvanı
        public string ImageUrl { get; set; }
        public string Comment { get; set; }  // Yorumu
    }
}
