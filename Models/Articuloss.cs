using System.ComponentModel.DataAnnotations;

namespace ReyphillDuarte_AP1_P2.Models
{
    public class Articuloss
    {
        [Key]
        public int ArticulosId  { get; set; }

        public int? Existencia { get; set; }

        public string? Descripcion { get; set; }

        public float? Precio { get; set; }

        public float? Costo {  get; set; }
    }
}
