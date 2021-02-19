using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueModas.Domain.Pedido
{
    public interface IPedidoRepository
    {
        Task Criar(Pedido pedido);
        Task Atualizar(Pedido pedido);
        Task Deletar(Pedido pedido);
        Task<Pedido> ObterPorId(Guid id);
        Task<IEnumerable<Pedido>> ObterTodos();
    }
}