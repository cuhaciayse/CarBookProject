﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Results.SocialMediaResult
{
    public class GetSocialMediaByIdQueryResult
    {
        public int SocialMediaID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
