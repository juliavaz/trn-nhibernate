using Microsoft.AspNetCore.Mvc;
using NHibernate;
using TrnNHibernate.Api.Core.Requests;
using TrnNHibernate.Entidades;

namespace TrnNHibernate.Api.Controllers
{
    [Route("produtos")]
    public class ProdutoController : ControllerBase
    {
        private readonly ISession _session;

        public ProdutoController(ISession session)
        {
            _session = session;
        }

        [HttpPost]
        [Route("novo")]
        public IActionResult NovoProduto([FromBody] ProdutoRequest produtoRequest)
        {
            var produto = new Produto(produtoRequest.Nome, produtoRequest.PrecoUnitario, produtoRequest.QuantidadeEstoque);
            _session.Save(produto);
            return Ok("Produto gravado com sucesso!");
        }



    }
}
