using Microsoft.EntityFrameworkCore;
using ReyphillDuarte_AP1_P2.DAL;
using ReyphillDuarte_AP1_P2.Models;
using System.Linq.Expressions;

namespace ReyphillDuarte_AP1_P2.Services
{
    public class ArticuloService(IDbContextFactory<Context> DbFactory)
    {
        public async Task<List<Articuloss>> Listar(Expression<Func<Articuloss, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();

            return await contexto.Articuloss
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
