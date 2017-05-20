using EntityFrameworkCore.Lab.CfAndImt.Models;
using System.Linq;
using System;

namespace EntityFrameworkCore.Lab.CfAndImt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var dbContext = new BloggingContext())
            {
                Console.WriteLine("Creating db if nog exists");
                dbContext.Database.EnsureCreated();

                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                dbContext.Blogs.Add(blog);
                dbContext.SaveChanges();

                // Display all Blogs from the database 
                var query = dbContext.Blogs.OrderBy(b => b.Name);
                var bpService = new BlogPostService(dbContext);
                Console.WriteLine("All blogs in the database:");
                foreach (var item in query.ToList())
                {
                    Console.WriteLine(item.Name);

                    bpService.GetPosts(item.BlogId)
                        .ToList()
                        .ForEach(content => Console.WriteLine($"    {content}"));

                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}