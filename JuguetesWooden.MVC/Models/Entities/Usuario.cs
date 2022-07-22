﻿namespace JuguetesWooden.Models
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
}
