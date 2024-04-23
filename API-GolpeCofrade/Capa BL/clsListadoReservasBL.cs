using Capa_DAL;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BL
{
    public class clsListadoReservasBL
    {
        /// <summary>
        /// Funcion que devuelve un listado de reservas de un mismo usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<clsReserva> getListadoReservas(int id)
        {
            return clsHandlerReservas.listadoReservasPorUser(id);
        }

        /// <summary>
        /// Funcion que inserta una reserva en la base de datos
        /// </summary>
        /// <param name="reserva"></param>
        /// <returns></returns>
        public static int insertReserva(clsReserva reserva)
        {
            return clsHandlerReservas.insertReserva(reserva);
        }

        /// <summary>
        /// Funcion que elimina una reserva de la base de datos
        /// Y setea la silla como disponible
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idSilla"></param>
        /// <returns></returns>
        public static int deleteReserva(int id, int idSilla)
        {
            return clsHandlerReservas.deleteReserva(id, idSilla);
        }

    }
}
