using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ReyphillDuarte_AP1_P2.Models
{
	public class Modelo_Detalles
	{
		[Key]
		public int DetalleId { get; set; }

		public int Modelo { get; set; }
    
	}
}
