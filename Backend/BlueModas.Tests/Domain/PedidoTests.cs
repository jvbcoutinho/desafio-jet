using System;
using System.Collections.Generic;
using BlueModas.Domain.Pedido;
using BlueModas.Shared.Exceptions;
using Xunit;

namespace BlueModas.Tests.Domain
{
    public class PedidoTests
    {
        [Fact]
        public void Quando_CriarPedidoSemItem_Deve_LancarException()
        {
            Assert.Throws<DomainException>(() => new Pedido("João", "jv@jet.com", "22999999999", new List<PedidoItem>()));
        }
    }
}