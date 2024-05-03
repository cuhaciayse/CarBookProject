﻿using CarBookProject.Application.Features.Mediator.Results.SocialMediaResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery:IRequest<GetSocialMediaByIdQueryResult>
    {
        public GetSocialMediaByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
