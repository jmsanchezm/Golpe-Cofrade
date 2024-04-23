using API_GolpeCofrade.Models;
using Capa_BL;
using Capa_DAL;
using Capa_Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace API_GolpeCofrade.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class HermandadController : Controller
    {
        // GET: API/<HermandadController>
        [HttpGet]
        public List<clsHermandad> getHermandades()
        {
            return clsListadoHermandadesBL.listadoHermandades();
        }

        // GET API/<HermandadController>/id
        [HttpGet("{id}")]
        public clsHermandad getHermandadById(int id)
        {
            return clsListadoHermandadesBL.hermandadById(id);
        }

        // GET API/<HermandadController>/diaProcesion
        [HttpGet("dia/{diaProcesion}")]
        public List<clsHermandad> getHermandadesByDiaProcesion(string diaProcesion)
        {
            return clsListadoHermandadesBL.listadoHermandadByDiaProcesion(diaProcesion);
        }
    }
}
