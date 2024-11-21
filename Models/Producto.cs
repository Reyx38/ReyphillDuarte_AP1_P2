using System.ComponentModel.DataAnnotations;

namespace ReyphillDuarte_AP1_P2.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId  { get; set; }

        public int Existencia { get; set; }

        public string Descripcion { get; set; }

        public double Precio { get; set; }

        public double Costo { get; set; }
    }
}
