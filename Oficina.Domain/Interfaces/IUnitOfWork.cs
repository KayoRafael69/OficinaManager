namespace Oficina.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IClienteRepository Clientes { get; }
        IVeiculoRepository Veiculos { get; }
        IMecanicoRepository Mecanicos { get; }
        IPecaEstoqueRepository PecasEstoque { get; }
        IOrdemServicoRepository OrdensServico { get; }
        IUsuarioRepository Usuarios { get; }

        Task<int> SaveChangesAsync();
    }
}