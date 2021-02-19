using System;
using AutoMapper;
using BlueModas.Application.ProdutoAggregate;
using BlueModas.Application.ProdutoAggregate.Dto;
using BlueModas.Domain.Produto;
using Moq;
using Xunit;

namespace BlueModas.Tests.Application
{
    public class ProdutoServiceTests
    {
        public ProdutoService ProdutoService { get; set; }
        public Mock<IProdutoRepository> ProdutoRepository { get; set; }
        public Mock<IMapper> Mapper;
        public ProdutoOutputDto ProdutoOutputValido { get; set; }

        public ProdutoServiceTests()
        {
            ProdutoRepository = new Mock<IProdutoRepository>();
            Mapper = new Mock<IMapper>();
            ProdutoService = new ProdutoService(ProdutoRepository.Object, Mapper.Object);

            ProdutoOutputValido = new ProdutoOutputDto()
            {
                Id = Guid.NewGuid(),
                Nome = "Camiseta",
                ImagemUrl = "images.com/Camiseta.jpg",
                Preco = 10.50m
            };
        }

        [Fact]
        public async void Quando_RegistrarProduto_Deve_RetornarProdutoOutputDto()
        {
            // Arrange
            var input = new RegistrarProdutoInputDto();
            input.Nome = ProdutoOutputValido.Nome;
            input.ImagemUrl = ProdutoOutputValido.ImagemUrl;
            input.Preco = ProdutoOutputValido.Preco;

            Mapper.Setup(c => c.Map<ProdutoOutputDto>(It.IsAny<Produto>()))
                .Returns(ProdutoOutputValido);

            // Act
            var result = await ProdutoService.RegistrarProduto(input);

            // Act & Assert
            Assert.IsType<ProdutoOutputDto>(result);
        }

    }
}