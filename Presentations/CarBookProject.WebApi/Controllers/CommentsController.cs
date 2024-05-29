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

        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _commentsrepository.Create(comment);
            return Ok("Yorum eklendi");
        }

        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentsrepository.Update(comment);
            return Ok("Yorum düzenlendi");
        }

        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
            var value = _commentsrepository.GetById(id);
            _commentsrepository.Remove(value);
            return Ok("Yorum silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var value = _commentsrepository.GetById(id);
            return Ok(value);
        }
    }

}
