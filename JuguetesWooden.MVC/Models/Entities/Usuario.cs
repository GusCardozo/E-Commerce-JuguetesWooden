using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuguetesWooden.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telefono { get; set; }
        public int IdRol { get; set; }
        public virtual Rol Rol { get; set; }
    }

    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(s => s.Nombre).HasColumnName("Nombre").HasMaxLength(100).IsRequired();
            builder.Property(s => s.Apellido).HasColumnName("Apellido").HasMaxLength(100).IsRequired();
            builder.Property(s => s.Email).HasColumnName("Email").HasMaxLength(100).IsRequired();
            builder.Property(s => s.Password).HasColumnName("Password").HasMaxLength(500).IsRequired();
            builder.Property(s => s.Telefono).HasColumnName("Telefono").HasMaxLength(10).IsRequired();
            builder.Property(s => s.IdRol).HasColumnName("IdRol").IsRequired();

            builder.HasOne(x => x.Rol).WithMany().HasForeignKey(x => x.IdRol).IsRequired().HasConstraintName("FK_Usuarios_Roles");
        }

    }
}
