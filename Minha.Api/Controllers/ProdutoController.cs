using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Minha.Api.Models;
using Minha.Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minha.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(ILogger<ProdutoController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Save")]
        public IActionResult Save([FromBody] Produto produto)
        {
            var existingProduct = ProdutoRepository.Produtos.SingleOrDefault(x => x.Id == produto.Id);

            if (existingProduct == null)
            {
                ProdutoRepository.Produtos.Add(produto);
            }
            else
            {
                ProdutoRepository.Produtos.Remove(existingProduct);
                ProdutoRepository.Produtos.Add(produto);
            }
            //ProdutoRepository.Produtos.Add(produto);
            return Ok();        
        }


        [HttpPost]
        public IActionResult Teste()
        {
            return Ok();
            //  return Json(new { mensagem = "ok" }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return ProdutoRepository.Produtos;
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var produto = ProdutoRepository.Produtos.FirstOrDefault(x => x.Id == id);
            ProdutoRepository.Produtos.Remove(produto);
            return Ok();
        }
    }
}
