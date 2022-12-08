namespace Assignment_Applciation
{
    using Microsoft.EntityFrameworkCore;
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        public DbSet<Context> MyClasses { get; set; }

    }
}

