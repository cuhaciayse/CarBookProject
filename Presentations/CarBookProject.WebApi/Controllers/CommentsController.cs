using CarBookProject.Application.Features.RepositoryPattern;
using CarBookProject.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentsrepository;

        public CommentsController(IGenericRepository<Comment> commentsrepository)
        {
            _commentsrepository = commentsrepository;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commentsrepository.GetAll();
            return Ok(values);
        }

    }
}
