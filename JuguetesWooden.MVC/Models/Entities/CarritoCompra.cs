using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace JuguetesWooden.Models
{
    public class CarritoCompra
    {
        public int Id { get; set; }
        public decimal TotalCompra { get; set; }
        public virtual ICollection<DetalleCompra> Detalles { get; set; }
    }

    public class CarritoCompraMap : IEntityTypeConfiguration<CarritoCompra>
    {
        public void Configure(EntityTypeBuilder<CarritoCompra> builder)
        {
            builder.ToTable("CarritoCompras");
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(s => s.TotalCompra).HasColumnName("TotalCompra").IsRequired().HasColumnType("decimal(18, 4)");
            builder.Property(s => s.Detalles).HasColumnName("Detalles").IsRequired();

            builder.HasMany(x => x.Detalles).WithOne(x => x.CarritoCompra);
        }
    }
}
