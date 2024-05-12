using CarBookProject.Application.Features.Mediator.Queries.BlogQueries;
using CarBookProject.Application.Features.Mediator.Results.BlogResult;
using CarBookProject.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAllBlogsWithAuthors();
            return values.Select(x=> new GetAllBlogsWithAuthorQueryResult
            {
                AuthorID = x.AuthorID,
                AuthorDescription = x.Author.Description,
                AuthorName = x.Author.Name,
                Description = x.Description,
                BlogID = x.BlogID,
                AuthorImageUrl = x.Author.ImageUrl,
                CategoryID = x.CategoryID,
                Title = x.Title,
                CreatedDate = x.CreatedDate,
                CoverImageUrl = x.CoverImageUrl,
            }).ToList();
        }
    }
}
