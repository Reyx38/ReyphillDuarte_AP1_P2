using Microsoft.EntityFrameworkCore;
using RegistroTecnicos.Models;
using ReyphillDuarte_AP1_P2.DAL;
using ReyphillDuarte_AP1_P2.Models;
using System.Linq.Expressions;

namespace ReyphillDuarte_AP1_P2.Services;

public class ComboServices(IDbContextFactory<Context> DbFactory)
{

    public async Task<bool> ExisteDescripcion(String descripcion)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Combos.AnyAsync(T => T.Descripcion == descripcion);
    }

    public async Task<bool> ExisteId(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Combos.AnyAsync(t => t.ComboId == id);
    }

    private async Task<bool> Insertar(Combo combo)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();

        await AfectarArticulo(combo.Detalles.ToArray());
        await contexto.Combos.AddAsync(combo);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Combo combo)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var Combo = await contexto.Combos
        .Include(t => t.Detalles)
        .AsNoTracking() 
        .FirstOrDefaultAsync(t => t.ComboId == combo.ComboId);

        await AfectarArticulo(Combo.Detalles.ToArray(), false);

        await AfectarArticulo(combo.Detalles.ToArray());

        contexto.Update(combo);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Combo combo)
    {
        if (!await ExisteId(combo.ComboId))
            return await Insertar(combo);

        return await Modificar(combo);
    }

    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        var Combo = contexto.Combos.Find(id);

        await AfectarArticulo(Combo.Detalles.ToArray(), false);

        contexto.ComboDetalles.RemoveRange(Combo.Detalles);
        contexto.Combos.Remove(Combo);

        var cantidad = await contexto.SaveChangesAsync();
        return cantidad > 0;
    }

    public async Task<Combo?> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Combos
            .Include(T => T.Detalles)
            .FirstOrDefaultAsync(t => t.ComboId == id);
    }

    public async Task<List<Combo>> Listar(Expression<Func<Combo, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Combos
            .Include(T => T.Detalles)
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }

    private async Task AfectarArticulo(ComboDetalles[] detalles, bool resta = true)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        foreach (var item in detalles)
        {
            var Articulo = await contexto.Articuloss.SingleAsync(p => p.ArticulosId == item.ArticuloId);
            if (resta)
            {
                Articulo.Existencia -= item.Cantidad;
            }
            else
            {
                Articulo.Existencia += item.Cantidad;
            }

        }
    }

}

