using Capa_BL;
using Capa_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API_GolpeCofrade.Controllers
{
    public class ReservaController
    {

        // GET: API/<HermandadController>
        [HttpGet]
        public List<clsReserva> getReserva(int id)
        {
            return clsListadoReservasBL.getListadoReservas(id); 
        }

        // POST API/<HermandadController>
        [HttpPost]
        public int postReserva(clsReserva reserva)
        {
            return clsListadoReservasBL.insertReserva(reserva);
        }

        // DELETE API/<HermandadController>/id/idSilla
        [HttpDelete("{id}/{idSilla}")]
        public int deleteReserva(int id, int idSilla)
        {
            return clsListadoReservasBL.deleteReserva(id, idSilla);
        }
    }
}
