using System;
using System.Collections.Generic;
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

        public async Task Criar(Pedido pedido)
        {
            await _context.Pedido.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task Deletar(Pedido pedido)
        {
            _context.Pedido.Remove(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task<Pedido> ObterPorId(Guid id)
        {
            return await this._context.Pedido.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Atualizar(Pedido pedido)
        {
            _context.Entry(pedido).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pedido>> ObterTodos()
        {
            return await this._context.Pedido.ToListAsync();
        }
    }
}