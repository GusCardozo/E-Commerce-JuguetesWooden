using System.Collections.Generic;

namespace JuguetesWooden.Models
{
    public class CarritoCompra
    {
        public int Id { get; set; }
        public double TotalCompra { get; set; }
        public List<DetalleCompra> Detalles { get; set; }
    }
}
