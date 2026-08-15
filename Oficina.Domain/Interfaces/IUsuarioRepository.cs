using Oficina.Domain.Entities;

namespace Oficina.Domain.Interfaces
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        Task<Usuario> ObterPorEmailAsync(string email);
    }
}