using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BlueModas.Application.ProdutoAggregate.Dto;
using BlueModas.Domain.Produto;

namespace BlueModas.Application.ProdutoAggregate
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<ProdutoOutputDto> RegistrarProduto(RegistrarProdutoInputDto dto)
        {
            var produto = new Produto(dto.Nome, dto.ImagemUrl, dto.Preco);

            await _produtoRepository.Criar(produto);

            var outputDto = _mapper.Map<ProdutoOutputDto>(produto);

            return outputDto;
        }

        public async Task<IEnumerable<ProdutoOutputDto>> ObterTodosProdutos()
        {
            var produtos = await _produtoRepository.ObterTodos();
            return _mapper.Map<IEnumerable<ProdutoOutputDto>>(produtos);
        }
    }
}