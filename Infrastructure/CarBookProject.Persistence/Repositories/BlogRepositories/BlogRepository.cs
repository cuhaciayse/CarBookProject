using CarBookProject.Application.Interfaces.BlogInterfaces;
using CarBookProject.Application.Interfaces.CarInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _carcontext;

        public BlogRepository(CarBookContext carcontext)
        {
            _carcontext = carcontext;
        }

        public List<Blog> GetAllBlogsWithAuthors()
        {
            var values = _carcontext.Blogs.Include(x=>x.Author).ToList();
            return values;  
        }

        public List<Blog> GetBlogByAuthorId(int id)
        {
            var values = _carcontext.Blogs.Include(x=>x.Author).Where(y=>y.BlogID == id).ToList();
            return values;
        }

        public List<Blog> GetLast3BlogsWithAuthors()
        {
            var values = _carcontext.Blogs.Include(x=>x.Author).OrderByDescending(y=>y.BlogID).Take(3).ToList();  
            return values;
        }
    }
}
