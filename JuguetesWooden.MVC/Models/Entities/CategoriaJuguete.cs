using System.Collections.Generic;

namespace JuguetesWooden.Models
{
    public class CategoriaJuguete
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Juguete> Juguetes { get; set; }
    }
}
