using EntityFrameworkCore.Lab.CfAndImt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace EntityFrameworkCore.Lab.CfAndImt.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //var options = new DbContextOptionsBuilder()
            //    .UseInMemoryDatabase(databaseName: "Test1_Context")
            //    .Options;

            //using (var dbContext = new BloggingContext(options))
            //{
            //    dbContext.Add(new Blog
            //    {
            //        Name = "blog1",
            //        Posts = new List<Post>
            //        {
            //            new Post { Content = "content post 1 blog 1" },
            //            new Post { Content = "content post 2 blog 1" },
            //            new Post { Content = "content post 3 blog 1" },
            //        }
            //    });
            //    dbContext.Add(new Blog
            //    {
            //        Name = "blog2",
            //        Posts = new List<Post>
            //        {
            //            new Post { Content = "content post 1 blog 2" },
            //            new Post { Content = "content post 2 blog 2" },

            //        }
            //    });
            //    dbContext.SaveChanges();
            //}

            //using (var dbContext = new BloggingContext(options))
            //{
            //    var sut = new BlogPostService(dbContext);
            //    var results = sut.GetPosts(2);

            //    Assert.Equal(2, results.Count());
            //    Assert.True(results.Any(p => p == "content post 1 blog 2"));
            //    Assert.True(results.Any(p => p == "content post 2 blog 2"));
            //}

        }
    }
}
