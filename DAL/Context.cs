using Microsoft.EntityFrameworkCore;
using RegistroTecnicos.Models;
using ReyphillDuarte_AP1_P2.Models;

namespace ReyphillDuarte_AP1_P2.DAL;
public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Combo> Combos { get; set; }
    public DbSet<ComboDetalles> ComboDetalles { get; set; }
    public DbSet<Articuloss> Articuloss { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Articuloss>().HasData(new List<Articuloss>() {

        new Articuloss() {ArticulosId = 20, Descripcion = "Bocina",
            Costo = 30, Precio = 40,Existencia = 20},
        new Articuloss() {ArticulosId = 50, Descripcion = "Memoria RAM",
            Costo = 100, Precio = 150, Existencia = 10 },
        new Articuloss() {ArticulosId = 60, Descripcion = "Disco duro grafica",
            Costo = 80, Precio = 130, Existencia = 12},
        new Articuloss() {ArticulosId = 70, Descripcion = "Pantalla",
            Costo = 30, Precio = 40,Existencia = 20}
        });

    }
}
