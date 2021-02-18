using System;
using System.Linq;
using System.Threading.Tasks;
using BlueModas.Domain.Pedido;
using BlueModas.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlueModas.Repository.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ModaContext _context;
        private readonly IConfiguration _configuration;

        public PedidoRepository(ModaContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task Create(Pedido pedido)
        {
            await _context.Pedido.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Pedido pedido)
        {
            _context.Pedido.Remove(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task<Pedido> GetById(Guid id)
        {
            return await this._context.Pedido.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Update(Pedido pedido)
        {
            _context.Entry(pedido).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}