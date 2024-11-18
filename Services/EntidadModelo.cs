using Microsoft.EntityFrameworkCore;
using ReyphillDuarte_AP1_P2.DAL;
using ReyphillDuarte_AP1_P2.Models;
using System.Linq.Expressions;

namespace ReyphillDuarte_AP1_P2.Services;

public class ModeloService(IDbContextFactory<Context> DbFactory)
{
	public async Task<bool> ExisteModelo()
	{
        await using var contexto = await DbFactory
            .CreateDbContextAsync();
        return  false; 
	}
	public async Task<bool> Guardar() 
	{
        await using var contexto = await DbFactory
            .CreateDbContextAsync();
        return false; 
	}
	public async Task<bool> Insertar() 
	{
        await using var contexto = await DbFactory
            .CreateDbContextAsync();
        return false; 
	}
    public async Task<bool> Modificar()
	{
        await using var contexto = await DbFactory
            .CreateDbContextAsync();
        return false; 
	}
	public async Task<List<Modelo_Examen>> Listar(Expression<Func<Modelo_Examen, bool>> criterio) 
	{
        await using var contexto = await DbFactory
            .CreateDbContextAsync();
        return null; 
	}
	public async Task<bool> Buscar() 
    {
        await using var contexto = await DbFactory
            .CreateDbContextAsync();
        return false; 
    }
	public async Task<bool> Eliminar() 
    {
        await using var contexto = await DbFactory
            .CreateDbContextAsync();
        return false; 
    }
	private async Task AfectarPrestamos(Modelo_Detalles[] detalle, bool resta) 
    {
        await using var contexto = await DbFactory
            .CreateDbContextAsync();
    }
}
