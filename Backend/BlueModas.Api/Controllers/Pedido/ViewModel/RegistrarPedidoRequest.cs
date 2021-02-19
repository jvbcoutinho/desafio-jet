using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlueModas.Application.PedidoAggregate.Dto;

namespace BlueModas.Api.Controllers.Pedido.ViewModel
{
    public class RegistrarPedidoRequest
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "ImagemUrl é um campo obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preco é um campo obrigatório")]
        public decimal Telefone { get; set; }

        [Required(ErrorMessage = "Pedido deve conter pelo menos um item")]
        public IList<PedidoItemDto> Itens { get; set; }

    }
}