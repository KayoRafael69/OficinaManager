using Oficina.Domain.Entities;
using Oficina.Domain.Enums;

namespace Oficina.Domain.Interfaces
{
    public interface IMecanicoRepository : IRepositoryBase<Mecanico>
    {
        Task<IEnumerable<Mecanico>> ObterPorEspecialidadeAsync(EspecialidadeMecanico especialidade);
    }
}