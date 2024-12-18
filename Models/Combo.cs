﻿using RegistroTecnicos.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReyphillDuarte_AP1_P2.Models;

public class Combo
{
	[Key]
	public int ComboId { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    [StringLength(50)]
    [RegularExpression("^[a-zA-ZÀ-ÿ\\s]+$", ErrorMessage = "Solo se permiten letras.")]
    public string? Descripcion { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    public DateTime Fecha {  get; set; } = DateTime.Now;
   
    public bool Vendido { get; set; } = false;

    [ForeignKey("ComboId")]
	public ICollection<ComboDetalles> Detalles { get; set; } = new List<ComboDetalles>();
}
