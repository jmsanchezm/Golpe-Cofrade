using Capa_BL;
using Capa_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API_GolpeCofrade.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class PasoController
    {
        [HttpGet]
        public List<clsPaso> getPasos()
        {
            return clsListadoPasoBL.getListadoPasos();
        }

        [HttpGet("{id}")]   
        public clsPaso getPasoById(int id)
        {
            return clsListadoPasoBL.getPasoById(id);
        }

        [HttpGet("pasosHermandad/{idHermandad}")]
        public List<clsPaso> getPasosByHermandad(int idHermandad)
        {
            return clsListadoPasoBL.getListadoPasosByHermandad(idHermandad);
        }

    }
}
