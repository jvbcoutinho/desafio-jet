using System.Collections.Generic;
using BlueModas.Domain.Pedido;
using AutoMapper;
using Moq;
using Xunit;
using System;
using BlueModas.Application.PedidoAggregate;
using BlueModas.Application.PedidoAggregate.Dto;

namespace BlueModas.Tests.Application
{
    public class PedidoServiceTests
    {
        public PedidoService PedidoService { get; set; }
        public Mock<IPedidoRepository> PedidoRepository { get; set; }
        public Mock<IMapper> Mapper;
        public PedidoOutputDto PedidoOutputValido { get; set; }

        public PedidoServiceTests()
        {
            PedidoRepository = new Mock<IPedidoRepository>();
            Mapper = new Mock<IMapper>();
            PedidoService = new PedidoService(PedidoRepository.Object, Mapper.Object);

            var pedidoItem = new PedidoItemDto();
            PedidoOutputValido = new PedidoOutputDto()
            {
                Id = Guid.NewGuid(),
                Nome = "João",
                Email = "joao@jet.com.br",
                Telefone = "22999999999",
                Itens = new List<PedidoItemDto>() { pedidoItem }
            };
        }

        [Fact]
        public async void Quando_RegistrarPedidoSemNenhumItem_Deve_LancarException()
        {
            // Arrange
            var input = new RegistrarPedidoInputDto();
            input.Nome = PedidoOutputValido.Nome;
            input.Email = PedidoOutputValido.Email;
            input.Telefone = PedidoOutputValido.Telefone;
            input.Itens = new List<PedidoItemDto>();

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(async () => await PedidoService.RegistrarPedido(input));
        }

        [Fact]
        public async void Quando_RegistrarPedido_Deve_RetornarRegistrarPedidoOutputDto()
        {
            // Arrange
            var input = new RegistrarPedidoInputDto();
            input.Nome = PedidoOutputValido.Nome;
            input.Email = PedidoOutputValido.Email;
            input.Telefone = PedidoOutputValido.Telefone;
            input.Itens = PedidoOutputValido.Itens;

            Mapper.Setup(c => c.Map<PedidoOutputDto>(It.IsAny<Pedido>()))
                .Returns(PedidoOutputValido);

            // Act
            var result = await PedidoService.RegistrarPedido(input);

            // Act & Assert
            Assert.IsType<PedidoOutputDto>(result);
        }
    }
}