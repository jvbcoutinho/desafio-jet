using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlueModas.Application.PedidoAggregate.Dto;
using BlueModas.Domain.Pedido;

namespace BlueModas.Application.PedidoAggregate
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public PedidoService(IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;

            _mapper = mapper;
        }

        public async Task<PedidoOutputDto> RegistrarPedido(RegistrarPedidoInputDto dto)
        {
            if (dto.Itens.Count() == 0)
                throw new Exception();

            var listItens = dto.Itens.Select(x => new PedidoItem(x.ProdutoId, x.ProdutoNome, x.Quantidade, x.ValorUnitario));

            var pedido = new Pedido(dto.Nome, dto.Email, dto.Telefone, listItens.ToList());

            await _pedidoRepository.Criar(pedido);

            var result = _mapper.Map<PedidoOutputDto>(pedido);

            return result;
        }

        public async Task<PedidoOutputDto> ObterPorId(Guid id)
        {
            var pedido = await _pedidoRepository.ObterPorId(id);
            return _mapper.Map<PedidoOutputDto>(pedido);
        }
    }
}