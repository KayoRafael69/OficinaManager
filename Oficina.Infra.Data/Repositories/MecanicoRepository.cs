using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Entities;
using Oficina.Domain.Enums;
using Oficina.Domain.Interfaces;
using Oficina.Infra.Data.ContextDb;

namespace Oficina.Infra.Data.Repositories
{
    public class MecanicoRepository : RepositoryBase<Mecanico>, IMecanicoRepository
    {
        public MecanicoRepository(OficinaDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Mecanico>> ObterPorEspecialidadeAsync(EspecialidadeMecanico especialidade)
        {
            return await _dbSet
                .Where(m => m.Especialidade == especialidade && m.Ativo == true)
                .ToListAsync();
        }
    }
}
