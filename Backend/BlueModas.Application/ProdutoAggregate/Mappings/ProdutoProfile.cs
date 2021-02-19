using AutoMapper;
using BlueModas.Application.ProdutoAggregate.Dto;
using BlueModas.Domain.Produto;

namespace BlueModas.Application.ProdutoAggregate.Mappings
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<Produto, ProdutoOutputDto>();
        }
    }
}