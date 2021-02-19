using BlueModas.Domain.Produto;
using BlueModas.Shared.Exceptions;
using Xunit;

namespace BlueModas.Tests.Domain
{
    public class ProdutoTests
    {
        [Fact]
        public void Quando_CriarProdutoComPrecoNegativo_Deve_LancarException()
        {
            Assert.Throws<DomainException>(() => new Produto("João", "imagem.com/jpg", -1));
        }
    }
}