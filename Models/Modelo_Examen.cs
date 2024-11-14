using System.ComponentModel.DataAnnotations;

namespace ReyphillDuarte_AP1_P2.Models;

public class Modelo_Examen
{
	[Key]
	public int EntidadId { get; set; }

    public string Nombres { get; set; }

    public int Sueldo { get; set; }

	public ICollection<Modelo_Detalles> Detalles { get; set; } = new List<Modelo_Detalles>();
}
