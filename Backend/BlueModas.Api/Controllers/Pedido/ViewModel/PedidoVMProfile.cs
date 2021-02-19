using AutoMapper;
using BlueModas.Application.PedidoAggregate.Dto;

namespace BlueModas.Api.Controllers.Pedido.ViewModel
{
    public class PedidoVMProfile : Profile
    {
        public PedidoVMProfile()
        {
            CreateMap<RegistrarPedidoRequest, RegistrarPedidoInputDto>()
                .ForMember(d => d.Itens, o => o.MapFrom(s => s.Itens));
        }
    }
}