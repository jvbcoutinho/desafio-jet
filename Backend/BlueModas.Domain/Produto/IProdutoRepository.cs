using System;
using System.Threading.Tasks;

namespace BlueModas.Domain.Produto
{
    public interface IProdutoRepository
    {
        Task Create(Produto produto);
        Task Update(Produto produto);
        Task Delete(Produto produto);
        Task<Produto> GetById(Guid id);
    }
}