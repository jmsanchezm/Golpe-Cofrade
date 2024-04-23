using Capa_DAL;
using Capa_Entidades;

namespace Capa_BL
{
    public class clsListadoHermandadesBL
    {
        /// <summary>
        /// Devuelve un listado de hermandades  
        /// </summary>
        /// <returns></returns>
        public static List<clsHermandad> listadoHermandades()
        {
            return clsListadoHermandades.getListadoHermandades();
        }

        /// <summary>
        /// Devuelve una hermandad por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsHermandad hermandadById(int id)
        {
            return clsListadoHermandades.getHermandadById(id);
        }

        /// <summary>
        /// Devuelve un listado de hermandades por dia de procesion
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static List<clsHermandad> listadoHermandadByDiaProcesion(string nombre)
        {
            return clsListadoHermandades.getListadoHermandadByDiaProcesion(nombre);
        }
    }
}
