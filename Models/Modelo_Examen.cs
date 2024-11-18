using System.ComponentModel.DataAnnotations;

namespace ReyphillDuarte_AP1_P2.Models;

public class Modelo_Examen
{
	[Key]
	public int EntidadId { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    [StringLength(50)]
    [RegularExpression("^[a-zA-ZÀ-ÿ\\s]+$", ErrorMessage = "Solo se permiten letras.")]
    public string? Nombres { get; set; }
    [Required(ErrorMessage = "Campo obligatorio")]
    public DateTime Fecha {  get; set; }
    [Required(ErrorMessage = "Campo obligatorio")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El sueldo por hora debe ser mayor a 0.")]
    [RegularExpression(@"^\d+$", ErrorMessage = "Solo se permiten números.")]
    public int Sueldo { get; set; }

	public ICollection<Modelo_Detalles> Detalles { get; set; } = new List<Modelo_Detalles>();
}
