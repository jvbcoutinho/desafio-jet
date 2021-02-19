using System.Collections.Generic;
using System.Linq;
using BlueModas.Shared.Exceptions;

namespace BlueModas.Domain.Pedido
{
    public class Pedido : Entity
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public IList<PedidoItem> Itens { get; private set; }

        public Pedido() { }
        public Pedido(string nome, string email, string telefone, IList<PedidoItem> itens)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Itens = itens;
            Validar();
        }

        public void Validar()
        {
            if (Itens.Count() == 0)
                throw new DomainException("Lista de itens não pode ser vazia!");
        }
    }
}