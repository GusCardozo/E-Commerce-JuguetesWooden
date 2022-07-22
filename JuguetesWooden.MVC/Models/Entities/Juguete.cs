namespace JuguetesWooden.Models
{
    public class Juguete
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Detalle { get; set; }
        public double Precio { get; set; }
        public int IdCategoria { get; set; }
        public virtual CategoriaJuguete Categoria { get; set; }
    }
}
