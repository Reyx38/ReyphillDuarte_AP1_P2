using System.ComponentModel.DataAnnotations;

namespace RegistroTecnicos.Models
{
    public class ComboDetalles
    {
        [Key]
        public int DetallesId { get; set; }

        public int ComboId { get; set; }

        public int ArticuloId { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set; }
    }
}
