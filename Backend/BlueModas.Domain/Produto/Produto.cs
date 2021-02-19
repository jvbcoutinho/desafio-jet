using BlueModas.Shared.Exceptions;

namespace BlueModas.Domain.Produto
{
    public class Produto : Entity
    {
        public string Nome { get; private set; }
        public string ImagemUrl { get; private set; }
        public decimal Preco { get; private set; }

        private Produto() { }

        public Produto(string nome, string imagemUrl, decimal preco)
        {
            Nome = nome;
            ImagemUrl = imagemUrl;
            Preco = preco;
            Validar();
        }

        public void Validar()
        {
            if (Preco < 0)
                throw new DomainException("Valor do produto não pode ser negativo");
        }
    }
}