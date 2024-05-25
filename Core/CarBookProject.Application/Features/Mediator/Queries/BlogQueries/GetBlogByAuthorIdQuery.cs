using CarBookProject.Application.Features.Mediator.Results.BlogResult;
using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByAuthorIdQuery : IRequest<List<GetBlogByAuthorIdQueryResult>>
    {
        public int Id { get; set; }
        public GetBlogByAuthorIdQuery(int id)
        {
            Id = id;
        }
    }
}