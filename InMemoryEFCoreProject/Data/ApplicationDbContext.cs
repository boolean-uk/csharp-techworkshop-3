    using Microsoft.EntityFrameworkCore;
    using InMemoryEFCoreProject.Models;

    namespace InMemoryEFCoreProject.Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Product> Products { get; set; }
        }
    }
    
