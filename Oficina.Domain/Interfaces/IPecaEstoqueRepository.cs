using Oficina.Domain.Entities;

namespace Oficina.Domain.Interfaces
{
    public interface IPecaEstoqueRepository
    {
        Task<PecaEstoque> ObterPorCodigoAsync(string codigo);
        Task<IEnumerable<PecaEstoque>> ObterComEstoqueBaixoAsync (int quantidadeMinima);
    }
}