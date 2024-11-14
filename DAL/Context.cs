using Microsoft.EntityFrameworkCore;
using ReyphillDuarte_AP1_P2.Models;

namespace ReyphillDuarte_AP1_P2.DAL
{
	public class Context(DbContextOptions<Context> options) : DbContext(options)
	{
		public DbSet<Modelo_Examen> Modelo { get; set; }
		public DbSet<Modelo_Detalles> Detalles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
