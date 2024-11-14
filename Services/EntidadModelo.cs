using Microsoft.EntityFrameworkCore;
using ReyphillDuarte_AP1_P2.DAL;

namespace ReyphillDuarte_AP1_P2.Services;

public class ModeloService(IDbContextFactory<Context> DbFactory)
{
	public async Task<bool> ExisteModelo() { return  false; }
	public async Task<bool> Guardar() { return false; }
	public async Task<bool> Insertar() { return false; }
	public async Task<bool> Modificar() { return false; }
	public async Task<bool> Listar() { return false; }
	public async Task<bool> Buscar() { return false; }
	public async Task<bool> Eliminar() { return false; }

}
