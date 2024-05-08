using CarBookProject.Application.Interfaces.BlogInterfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    { 
        private IBlogRepository _blogRepository;

        public BlogRepository(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public List<Blog> GetAllBlogsWithAuthors()
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogByAuthorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetLast3BlogsWithAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
