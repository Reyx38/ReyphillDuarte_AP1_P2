using ReyphillDuarte_AP1_P2.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroTecnicos.Models
{
    public class ComboDetalles
    {
        [Key]
        public int DetallesId { get; set; }

        public int ComboId { get; set; }

        public int ArticuloId { get; set; }
        [ForeignKey("Producto")]
        public Producto? Articulo { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set; }
    }
}
