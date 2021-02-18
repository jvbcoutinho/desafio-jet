using System;
using System.Threading.Tasks;

namespace BlueModas.Domain.Pedido
{
    public interface IPedidoRepository
    {
        Task Create(Pedido pedido);
        Task Update(Pedido pedido);
        Task Delete(Pedido pedido);
        Task<Pedido> GetById(Guid id);
    }
}