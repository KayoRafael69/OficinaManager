using Oficina.Domain.Entities;

namespace Oficina.Domain.Interfaces
{
    public interface IVeiculoRepository : IRepositoryBase<Veiculo>
    {
        Task<Veiculo> ObterPorPlacaAsync(string placa);
        Task<IEnumerable<Veiculo>> ObterPorClienteIdAsync(int clienteId);
    }
}