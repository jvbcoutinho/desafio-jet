using System.Threading.Tasks;
using BlueModas.Application.PedidoAggregate.Dto;

namespace BlueModas.Application.PedidoAggregate
{
    public interface IPedidoService
    {
        Task<PedidoOutputDto> RegistrarPedido(RegistrarPedidoInputDto dto);
    }
}