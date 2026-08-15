using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Entities;
using Oficina.Domain.Enums;
using Oficina.Domain.Interfaces;
using Oficina.Infra.Data.ContextDb;

namespace Oficina.Infra.Data.Repositories
{
    public class OrdemServicoRepository : IOrdemServicoRepository
    {
        private readonly OficinaDbContext _context;
        private readonly DbSet<OrdemServico> _dbSet;

        public OrdemServicoRepository(OficinaDbContext context)
        {
            _context = context;
            _dbSet = context.Set<OrdemServico>();
        }

        public async Task<OrdemServico> ObterPorIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<OrdemServico>> ObterTodosAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task AdicionarAsync(OrdemServico entidade)
        {
            await _dbSet.AddAsync(entidade);
        }

        public void Atualizar(OrdemServico entidade)
        {
            _dbSet.Update(entidade);
        }

        public void Remover(OrdemServico entidade)
        {
            entidade.Status = StatusOrdemServico.Cancelada;
            _dbSet.Update(entidade);
        }

        public async Task<OrdemServico> ObterComDetalhesAsync(int id)
        {
            return await _dbSet
                .Include(os => os.Veiculo)
                    .ThenInclude(v => v.Cliente)
                .Include(os => os.Mecanico)
                .Include(os => os.Pecas)
                    .ThenInclude(p => p.Peca)
                .FirstOrDefaultAsync(os => os.Id == id);
        }

        public async Task<IEnumerable<OrdemServico>> ObterPorStatusAsync(StatusOrdemServico status)
        {
            return await _dbSet
                .Where(os => os.Status == status)
                .Include(os => os.Veiculo)
                .Include(os => os.Mecanico)
                .ToListAsync();
        }

        public async Task<IEnumerable<OrdemServico>> ObterPorVeiculoIdAsync(int veiculoId)
        {
            return await _dbSet
                .Where(os => os.VeiculoId == veiculoId)
                .ToListAsync();
        }

        public async Task<IEnumerable<OrdemServico>> ObterPorMecanicoIdAsync(int mecanicoId)
        {
            return await _dbSet
                .Where(os => os.MecanicoId == mecanicoId)
                .ToListAsync();
        }

        public async Task<string> GerarProximoNumeroOrdemAsync()
        {
            var ano = DateTime.UtcNow.Year;
            var quantidadeNoAno = await _dbSet.CountAsync(os => os.DataAbertura.Year == ano);
            var proximoNumero = quantidadeNoAno + 1;
            return $"OS-{ano}-{proximoNumero:D4}";
        }
    }
}