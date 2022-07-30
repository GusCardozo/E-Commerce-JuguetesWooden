using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuguetesWooden.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class RolMap : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(s => s.Descripcion).HasColumnName("Descripcion").HasMaxLength(200).IsRequired();
        }
    }
}
