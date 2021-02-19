using System;
using System.Threading.Tasks;
using AutoMapper;
using BlueModas.Api.Controllers.Produto.ViewModel;
using BlueModas.Application.ProdutoAggregate;
using BlueModas.Application.ProdutoAggregate.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BlueModas.Api.Controllers.Produto
{
    [ApiController]
    [Route("v1/produto")]
    public class ProdutoController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> ObterTodos(
            [FromServices] IProdutoService storeService
        )
        {
            var result = await storeService.ObterTodosProdutos();
            return Ok(result);
        }

        [Route("")]
        [HttpPost]
        public async Task<IActionResult> Criar(
            [FromBody] RegistrarProdutoRequest request,
            [FromServices] IProdutoService storeService,
            [FromServices] IMapper _mapper
        )
        {
            if (!ModelState.IsValid)
                return await Task.FromResult<IActionResult>(BadRequest(ModelState));

            var inputDto = _mapper.Map<RegistrarProdutoInputDto>(request);
            var result = await storeService.RegistrarProduto(inputDto);
            return Created(string.Empty, result);
        }

    }
}