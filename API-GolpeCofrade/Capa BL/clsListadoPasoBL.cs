using Capa_DAL;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BL
{
    public class clsListadoPasoBL
    {
        /// <summary>
        /// Devuelve un listado de pasos
        /// </summary>
        /// <returns></returns>
        public static List<clsPaso> getListadoPasos()
        {
            return clsListadoPasos.getlistadoPasos();
        }

        /// <summary>
        /// Devuelve un paso por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsPaso getPasoById(int id)
        {
            return clsListadoPasos.getPasoById(id);
        }   

        /// <summary>
        /// Devuelve un listado de pasos por id de hermandad
        /// </summary>
        /// <param name="idHermandad"></param>
        /// <returns></returns>
        public static List<clsPaso> getListadoPasosByHermandad(int idHermandad)
        {
            return clsListadoPasos.listadoPasoByHermandad(idHermandad);
        }
    }
}
