using System.ComponentModel.DataAnnotations;

namespace BlueModas.Api.Controllers.Produto.ViewModel
{
    public class RegistrarProdutoRequest
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "ImagemUrl é um campo obrigatório")]
        public string ImagemUrl { get; set; }

        [Required(ErrorMessage = "Preco é um campo obrigatório")]
        public decimal Preco { get; set; }
    }
}