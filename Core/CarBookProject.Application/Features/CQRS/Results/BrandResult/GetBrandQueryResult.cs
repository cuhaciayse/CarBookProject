﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Results.BrandResult
{
    public class GetBrandQueryResult
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}
