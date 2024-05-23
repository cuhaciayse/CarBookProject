using CarBookProject.Application.Features.Mediator.Queries.TagCloudQueries;
using CarBookProject.Application.Features.Mediator.Results.TagCloudResult;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    //public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagClodByBlogIdQueryResult>>
    //{
    //    private readonly IRepository<TagCloud> _repository;

    //    public GetTagCloudByBlogIdQueryHandler(IRepository<TagCloud> repository)
    //    {
    //        _repository = repository;
    //    }

    //    public async Task<List<GetTagClodByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
    //    {
    //        var values = _repository.GetTagCloudsByBlogID(request.Id);
    //    }
    //}
}
