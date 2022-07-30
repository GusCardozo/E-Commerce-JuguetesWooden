using JuguetesWooden.Models;
using Microsoft.EntityFrameworkCore;

namespace JuguetesWooden.Repository
{
    public class WoodenContext : DbContext
    {
        public WoodenContext(DbContextOptions<WoodenContext> options) : base(options)
        {
        }

        public DbSet<CarritoCompra> CarritoCompras { get; set; }
        public DbSet<CategoriaJuguete> CategoriaJuguetes { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }
        public DbSet<Juguete> Juguetes { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
