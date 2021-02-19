using System;

namespace BlueModas.Application.ProdutoAggregate.Dto
{
    public class ProdutoOutputDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }
        public decimal Preco { get; set; }
    }
}