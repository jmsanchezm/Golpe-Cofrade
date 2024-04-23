using Capa_BL;
using Capa_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API_GolpeCofrade.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class UsuarioController
    {
        // GET: API/<HermandadController>
        [HttpGet]
        public clsUsuario getUser(string username)
        {
            return clsHandlerUserBL.getUserByUsername(username);
        }

        // POST API/<HermandadController>
        [HttpPost]
        public int postUser(clsUsuario usuario)
        {
            return clsHandlerUserBL.insertUser(usuario);
        }

        [HttpPut]
        public int putUser(clsUsuario usuario)
        {
            return clsHandlerUserBL.updateUser(usuario);
        }

        [HttpDelete("{id}")]
        public int deleteUser(int id)
        {
            return clsHandlerUserBL.deleteUser(id);
        }

    }
}
