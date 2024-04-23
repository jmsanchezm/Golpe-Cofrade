using Capa_Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL
{
    public class clsListadoSillas
    {
        /// <summary>
        /// Función que devuelve el listado de sillas completo
        /// </summary>
        /// <returns></returns>
        public static List<clsSilla> listadoSillas()
        {
            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;
            
            List<clsSilla> listado = new List<clsSilla>();

            clsSilla silla;

            try
            {
                //Abrimos la conexión
                miConexion.ConnectionString = clsConexion.getConnection();

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "SELECT * FROM Silla";

                miComando.Connection = miConexion;

                miConexion.Open();

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        silla = new clsSilla();

                        silla.Id = (int)miLector["id"];
                        silla.Fila = (int)miLector["fila"];
                        silla.Asiento = (int)miLector["asiento"];
                        silla.Lugar = (string)miLector["lugar"];
                        silla.Precio = (double)miLector["precio"];
                        silla.Reservada = (bool)miLector["reservada"];
                        silla.Seccion = (int)miLector["seccion"];

                    }
                }
                
                miLector.Close();
                miConexion.Close();

            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return listado;
        }

        /// <summary>
        /// Función que devuelve un listado de sillas por lugar
        /// </summary>
        /// <param name="lugar"></param>
        /// <returns></returns>
        public static List<clsSilla> listadoSillasPorLugar(string lugar)
        {
            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            List<clsSilla> listado = new List<clsSilla>();
            
            clsSilla silla;

            try
            {
                //Abrimos la conexión
                miConexion.ConnectionString = clsConexion.getConnection();

                miComando.Parameters.Add("@lugar", System.Data.SqlDbType.VarChar).Value = lugar;

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "SELECT * FROM Silla WHERE lugar = @lugar";

                miComando.Connection = miConexion;

                miConexion.Open();

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        silla = new clsSilla();

                        silla.Id = (int)miLector["id"];
                        silla.Fila = (int)miLector["fila"];
                        silla.Asiento = (int)miLector["asiento"];
                        silla.Lugar = (string)miLector["lugar"];
                        silla.Precio = (double)miLector["precio"];
                        silla.Reservada = (bool)miLector["reservada"];
                        silla.Seccion = (int)miLector["seccion"];

                    }
                }

                miLector.Close();
                miConexion.Close();

            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return listado;
        }
    }
}

