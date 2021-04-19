using Microsoft.AspNetCore.Mvc;
using NHibernate;
using TrnNHibernate.Entidades;

namespace TrnNHibernate.Api.Controllers
{
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly ISession _session;

        public ClienteController(ISession session)
        {
            _session = session;
        }

        [HttpPost]
        [Route("novo")]
        public IActionResult NovoCliente([FromBody] Cliente cliente)
        {
            //return View();
            return Ok();
        }
    }
}
