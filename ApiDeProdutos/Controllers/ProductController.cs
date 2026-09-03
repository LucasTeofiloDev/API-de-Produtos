using ApiDeProdutos.Model;
using ApiDeProdutos.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDeProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet("{id}")]
        public IActionResult ProdutoPorId(int id)
        {
            var product = _productServices.BuscarPorId(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet]
        public IActionResult TodosProdutos()
        {
            var product = _productServices.BuscarTodos();
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CriarProduto([FromBody] Product product)
        {
            var createProduct = _productServices.CadastrarProduto(product);
            if (createProduct == null) return NotFound();
            return Ok(createProduct);
        }

        [HttpPut]
        public IActionResult AtualizarProdutos([FromBody] Product product)
        {
            var updateProduct = _productServices.AtualizarProduto(product);
            if (updateProduct == null) return NotFound();
            return Ok(updateProduct);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarProduto(int id)
        {
            
            _productServices.ExcluirProduto(id);
            return NoContent();


        }
    }
}
