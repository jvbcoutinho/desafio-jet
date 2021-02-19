using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueModas.Domain.Produto
{
    public interface IProdutoRepository
    {
        Task Criar(Produto produto);
        Task Atualizar(Produto produto);
        Task Deletar(Produto produto);
        Task<Produto> ObterPorId(Guid id);
        Task<IEnumerable<Produto>> ObterTodos();
    }
}