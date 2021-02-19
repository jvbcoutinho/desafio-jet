using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueModas.Domain.Produto;
using BlueModas.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlueModas.Repository.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly ModaContext _context;
        private readonly IConfiguration _configuration;

        public ProdutoRepository(ModaContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task Criar(Produto produto)
        {
            await _context.Produto.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        public async Task Deletar(Produto produto)
        {
            _context.Produto.Remove(produto);
            await _context.SaveChangesAsync();
        }

        public async Task<Produto> ObterPorId(Guid id)
        {
            return await this._context.Produto.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Atualizar(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await this._context.Produto.ToListAsync();
        }
    }
}