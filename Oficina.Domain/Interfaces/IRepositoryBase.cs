using Oficina.Domain.Entities;

namespace Oficina.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : EntidadeBase
    {
        Task<T> ObterPorIdAsync(int id);
        Task<IEnumerable<T>> ObterTodosAsync();
        Task<IEnumerable<T>> ObterAtivosAsync();
        Task AdicionarAsync(T entidade);
        void Atualizar(T entidade);
        void Remover(T entidade);
        Task<bool> ExisteAsync(int id);
    }
}