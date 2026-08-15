using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Entities;
using Oficina.Domain.Interfaces;
using Oficina.Infra.Data.ContextDb;

namespace Oficina.Infra.Data.Repositories
{
    public class PecaEstoqueRepository : RepositoryBase<PecaEstoque>, IPecaEstoqueRepository
    {
        public PecaEstoqueRepository(OficinaDbContext context) : base(context)
        {
        }

        public async Task<PecaEstoque> ObterPorCodigoAsync(string codigo)
        {
            return await _dbSet
                .FirstOrDefaultAsync(p => p.Codigo == codigo);
        }
        
        public async Task<IEnumerable<PecaEstoque>> ObterComEstoqueBaixoAsync(int quantidadeMinima)
        {
            return await _dbSet
                .Where(p => p.QuantidadeEstoque <= quantidadeMinima && p.Ativo)
                .ToListAsync();
        }
    }
}