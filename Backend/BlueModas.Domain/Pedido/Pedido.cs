using System.Collections.Generic;

namespace BlueModas.Domain.Pedido
{
    public class Pedido : Entity
    {
        public IList<PedidoItem> Itens { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
    }
}