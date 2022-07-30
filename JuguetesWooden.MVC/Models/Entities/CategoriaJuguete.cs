using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace JuguetesWooden.Models
{
    public class CategoriaJuguete
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Juguete> Juguetes { get; set; }
    }

    public class CategoriaJugueteMap : IEntityTypeConfiguration<CategoriaJuguete>
    {
        public void Configure(EntityTypeBuilder<CategoriaJuguete> builder)
        {
            builder.ToTable("CategoriasJuguetes");
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Id).HasColumnName("id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(s => s.Nombre).HasColumnName("Nombre").HasMaxLength(100);

            builder.HasMany(x => x.Juguetes).WithOne();
        }
    }
}
