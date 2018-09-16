using Microsoft.EntityFrameworkCore;

namespace SistemaRestaurantes.Data.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RestauranteModel>().HasKey(m => m.RestauranteId);
            modelBuilder.Entity<PratoModel>().HasKey(m => m.PratoId);
            modelBuilder.Entity<RestauranteModel>().HasMany(m => m.Pratos).WithOne(e => e.Restaurante);
        }

        public DbSet<RestauranteModel> Restaurantes { get; set; }
        public DbSet<PratoModel> Pratos { get; set; }
    }
}