using Oficina.Domain.Entities;

namespace Oficina.Domain.Interfaces
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        Task<Cliente> ObterPorCpfAsync(string cpf);
        Task<Cliente> ObterComVeiculosAsync(int Id);
    }
}