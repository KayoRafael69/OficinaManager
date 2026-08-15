using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Entities;
using Oficina.Domain.Interfaces;
using Oficina.Infra.Data.ContextDb;

namespace Oficina.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntidadeBase
    {
        protected readonly OficinaDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public RepositoryBase(OficinaDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> ObterPorIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> ObterTodosAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> ObterAtivosAsync()
        {
            return await _dbSet.Where(e => e.Ativo).ToListAsync();
        }

        public async Task AdicionarAsync(T entidade)
        {
            await _dbSet.AddAsync(entidade);
        }

        public void Atualizar(T entidade)
        {
            entidade.DataAtualizacao = DateTime.UtcNow;
            _dbSet.Update(entidade);
        }

        public void Remover(T entidade)
        {
            entidade.Ativo = false;
            entidade.DataAtualizacao = DateTime.UtcNow;
            _dbSet.Update(entidade);
        }

        public async Task<bool> ExisteAsync(int id)
        {
            return await _dbSet.AnyAsync(e => e.Id == id);
        }
    }
}
