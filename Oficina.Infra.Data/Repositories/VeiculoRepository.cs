using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Entities;
using Oficina.Domain.Interfaces;
using Oficina.Infra.Data.ContextDb;

namespace Oficina.Infra.Data.Repositories
{
    public class VeiculoRepository : RepositoryBase<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(OficinaDbContext context) : base(context)
        {
        }

        public async Task<Veiculo> ObterPorPlacaAsync(string placa)
        {
            return await _context.Veiculos.FirstOrDefaultAsync(v => v.Placa == placa);
        }

        public async Task<IEnumerable<Veiculo>> ObterPorClienteIdAsync(int clienteId)
        {
            return await _dbSet
                .Where(v => v.ClienteId == clienteId)
                .ToListAsync();
        }
    }
}
