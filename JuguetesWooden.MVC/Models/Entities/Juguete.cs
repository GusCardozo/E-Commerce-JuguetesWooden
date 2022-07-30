using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuguetesWooden.Models
{
    public class Juguete
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int IdCategoria { get; set; }
        public virtual CategoriaJuguete Categoria { get; set; }
    }

    public class JugueteMap : IEntityTypeConfiguration<Juguete>
    {
        public void Configure(EntityTypeBuilder<Juguete> builder)
        {
            builder.ToTable("Juguetes");
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(s => s.Nombre).HasColumnName("Nombre").HasMaxLength(100);
            builder.Property(s => s.Foto).HasColumnName("Foto").HasMaxLength(500);
            builder.Property(s => s.Descripcion).HasColumnName("Descripcion").HasMaxLength(1000);
            builder.Property(s => s.Precio).HasColumnName("Precio").HasColumnType("decimal(18, 4)");
            builder.Property(s => s.IdCategoria).HasColumnName("IdCategoria").IsRequired();

            builder.HasOne(x => x.Categoria).WithMany().HasForeignKey(x => x.IdCategoria).IsRequired().HasConstraintName("FK_Juguetes_CategoriasJuguetes");
        }
    }
}
