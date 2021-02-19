using System.Collections.Generic;
using System.Threading.Tasks;
using BlueModas.Application.ProdutoAggregate.Dto;

namespace BlueModas.Application.ProdutoAggregate
{
    public interface IProdutoService
    {
        Task<ProdutoOutputDto> RegistrarProduto(RegistrarProdutoInputDto dto);
        Task<IEnumerable<ProdutoOutputDto>> ObterTodosProdutos();
    }
}