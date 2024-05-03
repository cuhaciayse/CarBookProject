using CarBookProject.Application.Features.Mediator.Results.FooterAddressResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.FooterAddresQueries
{
    public class GetFooterAddresByIdQuery:IRequest<GetFooterAddresByIdQueryResult>
    {
        public GetFooterAddresByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
