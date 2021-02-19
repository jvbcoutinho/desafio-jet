namespace BlueModas.Application.ProdutoAggregate.Dto
{
    public class RegistrarProdutoInputDto
    {
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }
        public decimal Preco { get; set; }
    }
}