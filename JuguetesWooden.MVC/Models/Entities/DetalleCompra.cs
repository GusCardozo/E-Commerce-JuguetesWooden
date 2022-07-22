namespace JuguetesWooden.Models
{
    public class DetalleCompra
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int IdJuguete { get; set; }
        public int IdCarritoCompra { get; set; }
        public double Subtotal { get; set; }
        public virtual Juguete Juguete { get; set; }
        public virtual CarritoCompra CarritoCompra { get; set; }
    }
}
