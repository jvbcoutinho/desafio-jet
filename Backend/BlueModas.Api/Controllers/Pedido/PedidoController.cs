using System;
using System.Threading.Tasks;
using AutoMapper;
using BlueModas.Api.Controllers.Pedido.ViewModel;
using BlueModas.Application.PedidoAggregate;
using BlueModas.Application.PedidoAggregate.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BlueModas.Api.Controllers.Pedido
{
    [ApiController]
    [Route("v1/pedido")]
    public class PedidoController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> ObterPorId(
            [FromQuery] Guid id,
            [FromServices] IPedidoService pedidoService
        )
        {
            var result = await pedidoService.ObterPorId(id);
            return Ok(result);
        }

        [Route("")]
        [HttpPost]
        public async Task<IActionResult> Criar(
            [FromBody] RegistrarPedidoRequest request,
            [FromServices] IPedidoService storeService,
            [FromServices] IMapper _mapper
        )
        {
            if (!ModelState.IsValid)
                return await Task.FromResult<IActionResult>(BadRequest(ModelState));

            var inputDto = _mapper.Map<RegistrarPedidoInputDto>(request);
            var result = await storeService.RegistrarPedido(inputDto);
            return Created(string.Empty, result);
        }

    }
}