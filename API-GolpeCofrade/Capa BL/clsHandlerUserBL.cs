using Capa_DAL;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BL
{
    public class clsHandlerUserBL
    {
        /// <summary>
        /// Funcion que devuelve un usuario por su username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static clsUsuario getUserByUsername(string username)
        {
            return clsHandlerUser.GetUsuarioByUsername(username);
        }

        /// <summary>
        /// Funcion que inserta un usuario en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static int insertUser(clsUsuario usuario)
        {
            return clsHandlerUser.registerUser(usuario);
        }

        /// <summary>
        /// Funcion que actualiza un usuario en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static int updateUser(clsUsuario usuario)
        {
            return clsHandlerUser.updateUser(usuario);
        }


        /// <summary>
        /// Funcion que elimina un usuario de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int deleteUser(int id)
        {
            return clsHandlerUser.deleteUser(id);
        }
    }
}
