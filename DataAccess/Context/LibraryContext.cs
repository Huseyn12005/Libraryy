using Library_Models.Entities.Concret;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace DataAccess.Context
{
    internal class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString = new ConfigurationManager().AddJsonFile("appsettings.json").Build().GetConnectionString("DefaultConnection");

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<S_Cart> S_Carts { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<T_Cart> T_Carts { get; set;}
        public virtual DbSet<Teacher> Teachers { get; set; }


    }
}
