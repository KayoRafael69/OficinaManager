using Oficina.Domain.Interfaces;
using Oficina.Infra.Data.ContextDb;
using Oficina.Infra.Data.Repositories;

namespace Oficina.Infra.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OficinaDbContext _context;

        private IClienteRepository? _clientes;
        private IVeiculoRepository? _veiculos;
        private IMecanicoRepository? _mecanicos;
        private IPecaEstoqueRepository? _pecasEstoque;
        private IOrdemServicoRepository? _ordensServico;
        private IUsuarioRepository? _usuarios;

        public UnitOfWork(OficinaDbContext context)
        {
            _context = context;
        }

        public IClienteRepository Clientes =>
            _clientes ??= new ClienteRepository(_context);

        public IVeiculoRepository Veiculos =>
            _veiculos ??= new VeiculoRepository(_context);

        public IMecanicoRepository Mecanicos =>
            _mecanicos ??= new MecanicoRepository(_context);

        public IPecaEstoqueRepository PecasEstoque =>
            _pecasEstoque ??= new PecaEstoqueRepository(_context);

        public IOrdemServicoRepository OrdensServico =>
            _ordensServico ??= new OrdemServicoRepository(_context);

        public IUsuarioRepository Usuarios =>
            _usuarios ??= new UsuarioRepository(_context);

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}