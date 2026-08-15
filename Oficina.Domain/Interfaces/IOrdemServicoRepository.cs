using Oficina.Domain.Entities;
using Oficina.Domain.Enums;

namespace Oficina.Domain.Interfaces
{
    public interface IOrdemServicoRepository
    {
        Task<OrdemServico> ObterPorIdAsync(int id);
        Task<IEnumerable<OrdemServico>> ObterTodosAsync();
        Task AdicionarAsync(OrdemServico entidade);
        void Atualizar(OrdemServico entidade);
        void Remover(OrdemServico entidade);

        Task<OrdemServico> ObterComDetalhesAsync(int id);
        Task<IEnumerable<OrdemServico>> ObterPorStatusAsync(StatusOrdemServico status);
        Task<IEnumerable<OrdemServico>> ObterPorVeiculoIdAsync(int veiculoId);
        Task<IEnumerable<OrdemServico>> ObterPorMecanicoIdAsync(int mecanicoId);
        Task<string> GerarProximoNumeroOrdemAsync();
    }
}