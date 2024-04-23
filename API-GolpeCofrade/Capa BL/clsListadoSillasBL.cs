using Capa_DAL;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BL
{
    public class clsListadoSillasBL
    {

        /// <summary>
        /// Funcion que devuelve un listado de sillas
        /// </summary>
        /// <returns></returns>
        public static List<clsSilla> getListadoSillas()
        {
            return clsListadoSillas.listadoSillas();
        }   

        /// <summary>
        /// Funcion que devuelve un listado de sillas de un mismo lugar
        /// </summary>
        /// <param name="lugar"></param>
        /// <returns></returns>
        public static List<clsSilla> getListadoSillasByLugar(string lugar)
        {
            return clsListadoSillas.listadoSillasPorLugar(lugar);
        }

    }
}
