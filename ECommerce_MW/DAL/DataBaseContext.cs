using ECommerce_MW.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_MW.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) :base(options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();//define que no pueden haber dos countries con el mismo nombre
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("Name", "CountryId").IsUnique();// indice compuesto, pueden haber dos estados o ciudades que se llamen igual
            modelBuilder.Entity<City>().HasIndex("Name", "StateId").IsUnique();//se cambia la notacion lamda por una normal 
        }
    }
}
