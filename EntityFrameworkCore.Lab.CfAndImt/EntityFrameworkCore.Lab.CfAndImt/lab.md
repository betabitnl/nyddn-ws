# EF Core code first and in mem testing example

The app will not build initially, you will have to create the dbcontext and two entities from scratch. 

## Step 1 - Setup some entities
- In the models folder create two model classes (Blog, Post)
``` 
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public virtual List<Post> Posts { get; set; }
    } 

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
```

## Step 2 - Create the DbContext
- Also in the models folder create a class called BloggingContext
```
    public class BloggingContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                //It could also be ProjectsV12 or MSSQLLocalDB?
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=CfAndImt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
```

## Step 3 - Run it!
- Run the app
- Check with sql server explorer or sqlmstudio what got created
- Read about conventions, data annotations and the fluent api: https://docs.microsoft.com/nl-nl/ef/core/modeling/keys


## Step 4 - Create an in memory test
- In UnitTest1 -> Test1 uncomment the body
- Try to build
- This didn't work, the inMemory test config needs to be passed in and you should not connect to sqlserver
- Let's add two constructors
```
public BloggingContext(DbContextOptions options) : base(options) {}
public BloggingContext() : base() {}
```
- In the Onconfiguring method put the 'useSqlServer' line in an If statement
```
if (!optionsBuilder.IsConfigured)
{
...
```
- By doing this the context will only configure sqlserver if the context has not been initialized
- Run the Test!

## Step 5 - Play around
- You can change test context scopes
- Xunit runs in parallel, what happens when you use the same test scope? `.UseInMemoryDatabase(databaseName: "Test1_Context")`
- Check out Rowan Millers demo's on EF Core 2.0. => Clone repo: https://github.com/rowanmiller/Demo-EFCore 