using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuguetesWooden.Models
{
    public class DetalleCompra
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int IdJuguete { get; set; }
        public int IdCarritoCompra { get; set; }
        public decimal Subtotal { get; set; }
        public virtual Juguete Juguete { get; set; }
        public virtual CarritoCompra CarritoCompra { get; set; }

        public class DetalleCompraMap : IEntityTypeConfiguration<DetalleCompra>
        {
            public void Configure(EntityTypeBuilder<DetalleCompra> builder)
            {
                builder.ToTable("DetalleCompras");
                builder.HasKey(x => x.Id);
                builder.Property(s => s.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
                builder.Property(s => s.Cantidad).HasColumnName("Cantidad").IsRequired();
                builder.Property(s => s.Subtotal).HasColumnName("Subtotal").HasColumnType("decimal(18, 4)").IsRequired();
                builder.Property(s => s.IdJuguete).HasColumnName("IdJuguete").IsRequired();
                builder.Property(s => s.IdCarritoCompra).HasColumnName("IdCarritoCompra").IsRequired();

                builder.HasOne(x => x.Juguete).WithMany().HasForeignKey(x => x.IdJuguete).IsRequired().HasConstraintName("FK_DetalleCompras_Juguetes");
                builder.HasOne(x => x.CarritoCompra).WithMany().HasForeignKey(x => x.IdCarritoCompra).IsRequired().HasConstraintName("FK_DetalleCompras_CarritoCompras");
            }
        }
    }
}
