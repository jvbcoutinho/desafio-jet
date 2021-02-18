namespace BlueModas.Domain.Produto
{
    public class Produto : Entity
    {
        public string Nome { get; private set; }
        public string ImagemUrl { get; private set; }
        public decimal Preco { get; private set; }
    }
}