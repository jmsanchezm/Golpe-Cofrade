using Capa_Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL
{
    public class clsListadoHermandades
    {
        /// <summary>
        /// Devuelve un listado de hermandades
        /// </summary>
        /// <returns></returns>
        public static List<clsHermandad> getListadoHermandades()
        {
            List<clsHermandad> listado = new List<clsHermandad>();

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;           

            try
            {

                //Abrimos la conexión
                miConexion.ConnectionString = clsConexion.getConnection();

                miConexion.Open();

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "SELECT * FROM Hermandad";
               
                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    //Leemos el resultado de la consulta y lo guardamos en una lista
                    while (miLector.Read())
                    {
                        clsHermandad hermandad = new clsHermandad();
                        hermandad.Id = (int)miLector["id"];
                        hermandad.Nombre = (string)miLector["nombre"];
                        hermandad.DiaProcesion = (string)miLector["diaProcesion"];
                        hermandad.Sede = (string)miLector["sede"];
                        hermandad.Direccion = (string)miLector["direccion"];
                        hermandad.AñoFundacion = (int)miLector["añoFundacion"];
                        hermandad.SintesisHistorica = (string)miLector["sintesisHistorica"];
                        hermandad.NumHermanos = (int)miLector["numHermanos"];
                        hermandad.NumNazarenos = (int)miLector["numNazarenos"];
                        hermandad.TiempoPasada = (int)miLector["tiempoPasada"];
                        hermandad.FotoEscudo = (string)miLector["fotoEscudo"];
                        listado.Add(hermandad);
                    }
                }

                miLector.Close();
                miConexion.Close();

            }
            catch(SqlException exSql)
            {
                throw exSql;
            }

            return listado;

        }

        /// <summary>
        /// Devuelve un listado de hermandades por dia de procesion
        /// </summary>
        /// <param name="diaProcesion"></param>
        /// <returns></returns>
        public static List<clsHermandad> getListadoHermandadByDiaProcesion(string diaProcesion)
        {
            List<clsHermandad> listado = new List<clsHermandad>();

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            try
            {
                //Abrimos la conexión
                miConexion.ConnectionString = clsConexion.getConnection();

                miComando.Parameters.Add("@diaProcesion", System.Data.SqlDbType.VarChar).Value = diaProcesion;

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "SELECT * FROM Hermandad WHERE diaProcesion = @diaProcesion";

                miComando.Connection = miConexion;

                miConexion.Open();

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    //Leemos el resultado de la consulta y lo guardamos en una lista
                    while (miLector.Read())
                    {
                        clsHermandad hermandad = new clsHermandad();
                        hermandad.Id = (int)miLector["id"];
                        hermandad.Nombre = (string)miLector["nombre"];
                        hermandad.DiaProcesion = (string)miLector["diaProcesion"];
                        hermandad.Sede = (string)miLector["sede"];
                        hermandad.Direccion = (string)miLector["direccion"];
                        hermandad.AñoFundacion = (int)miLector["añoFundacion"];
                        hermandad.SintesisHistorica = (string)miLector["sintesisHistorica"];
                        hermandad.NumHermanos = (int)miLector["numHermanos"];
                        hermandad.NumNazarenos = (int)miLector["numNazarenos"];
                        hermandad.TiempoPasada = (int)miLector["tiempoPasada"];
                        hermandad.FotoEscudo = (string)miLector["fotoEscudo"];
                        listado.Add(hermandad);
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
        /// Devuelve una hermandad por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsHermandad getHermandadById(int id)
        {

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            clsHermandad hermandad = null;

            try
            {
                //Abrimos la conexión
                miConexion.ConnectionString = clsConexion.getConnection();

                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "SELECT * FROM Hermandad WHERE id = @id";

                miComando.Connection = miConexion;

                miConexion.Open();

                miLector = miComando.ExecuteReader();

                if (miLector.Read())
                {
                   hermandad = new clsHermandad();

                    hermandad.Id = (int)miLector["id"];
                    hermandad.Nombre = (string)miLector["nombre"];
                    hermandad.DiaProcesion = (string)miLector["diaProcesion"];
                    hermandad.Sede = (string)miLector["sede"];
                    hermandad.Direccion = (string)miLector["direccion"];
                    hermandad.AñoFundacion = (int)miLector["añoFundacion"];
                    hermandad.SintesisHistorica = (string)miLector["sintesisHistorica"];
                    hermandad.NumHermanos = (int)miLector["numHermanos"];
                    hermandad.NumNazarenos = (int)miLector["numNazarenos"];
                    hermandad.TiempoPasada = (int)miLector["tiempoPasada"];
                    hermandad.FotoEscudo = (string)miLector["fotoEscudo"];
                }

                miLector.Close();
                miConexion.Close();

            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return hermandad;
        }

    }
}
