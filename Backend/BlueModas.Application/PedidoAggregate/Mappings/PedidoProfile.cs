using AutoMapper;
using BlueModas.Application.PedidoAggregate.Dto;
using BlueModas.Domain.Pedido;

namespace BlueModas.Application.PedidoAggregate.Mappings
{
    public class PedidoProfile : Profile
    {
        public PedidoProfile()
        {
            CreateMap<PedidoItem, PedidoItemDto>();
            CreateMap<Pedido, PedidoOutputDto>()
                .ForMember(d => d.Itens, o => o.MapFrom(s => s.Itens));
        }

    }
}