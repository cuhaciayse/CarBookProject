﻿using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Results.TagCloudResult
{
    public class GetTagCloudByIdQueryResult
    {
        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}
