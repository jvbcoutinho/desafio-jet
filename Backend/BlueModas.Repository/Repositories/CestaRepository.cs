using System;
using System.Linq;
using System.Threading.Tasks;
using BlueModas.Domain.Cesta;
using BlueModas.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlueModas.Repository.Repositories
{
    public class CestaRepository : ICestaRepository
    {
        private readonly ModaContext _context;
        private readonly IConfiguration _configuration;

        public CestaRepository(ModaContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task Create(Cesta cesta)
        {
            await _context.Cesta.AddAsync(cesta);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Cesta cesta)
        {
            _context.Cesta.Remove(cesta);
            await _context.SaveChangesAsync();
        }

        public async Task<Cesta> GetById(Guid id)
        {
            return await this._context.Cesta.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Update(Cesta cesta)
        {
            _context.Entry(cesta).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}