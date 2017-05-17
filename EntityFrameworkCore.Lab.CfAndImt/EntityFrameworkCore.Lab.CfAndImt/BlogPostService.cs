using EntityFrameworkCore.Lab.CfAndImt.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EntityFrameworkCore.Lab.CfAndImt
{
   public class BlogPostService
    {
        private readonly BloggingContext _dbContext;

        public BlogPostService(BloggingContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<string> GetPosts(int blogId)
        {
           return _dbContext.Posts
                .Where(p => p.BlogId == blogId)
                .Select(p => p.Content);
        }
    }
}
