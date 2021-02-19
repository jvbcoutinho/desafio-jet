using AutoMapper;
using BlueModas.Application.ProdutoAggregate.Dto;

namespace BlueModas.Api.Controllers.Produto.ViewModel
{
    public class ProdutoVMProfile : Profile
    {
        public ProdutoVMProfile()
        {
            CreateMap<RegistrarProdutoRequest, RegistrarProdutoInputDto>();
        }
    }
}