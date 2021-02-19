using System;
using System.Collections.Generic;

namespace BlueModas.Application.PedidoAggregate.Dto
{
    public class PedidoOutputDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public IList<PedidoItemDto> Itens { get; set; }

    }
}