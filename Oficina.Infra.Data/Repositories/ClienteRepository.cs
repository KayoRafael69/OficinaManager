using Oficina.Domain.Interfaces;
using Oficina.Infra.Data.ContextDb;
using Oficina.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Oficina.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        private readonly OficinaDbContext _context;
        public ClienteRepository(OficinaDbContext context) : base(context)
        {
        }

        public async Task<Cliente> ObterPorCpfAsync(string cpf)
        {
            return await _dbSet.FirstOrDefaultAsync(c => c.Cpf == cpf);
        }

        public async Task<Cliente> ObterComVeiculosAsync(int id)
        {
            return await _dbSet
                .Include(c => c.Veiculos)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
