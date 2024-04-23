using Capa_Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL
{
    public class clsListadoPasos
    {
        public static List<clsPaso> getlistadoPasos()
        {
            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            List<clsPaso> listado = new List<clsPaso>();

            try
            {
                //Abrimos la conexión
                miConexion.ConnectionString = clsConexion.getConnection();

                miConexion.Open();

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "SELECT * FROM Paso";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    //Leemos el resultado de la consulta y lo guardamos en una lista
                    while (miLector.Read())
                    {
                        clsPaso paso = new clsPaso();
                        paso.Id = (int)miLector["id"];
                        paso.NombrePaso = (string)miLector["nombrePaso"];
                        paso.Banda = (string)miLector["banda"];
                        paso.IdHermandad = (int)miLector["idHermandad"];
                        paso.Autor = (string)miLector["autor"];
                        paso.Capataz = (string)miLector["capataz"];
                        paso.FotoPaso = (string)miLector["fotoPaso"];
                        listado.Add(paso);
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

        public static List<clsPaso> listadoPasoByHermandad(int idHermandad)
        {
            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            List<clsPaso> listado = new List<clsPaso>();

            try
            {
                //Abrimos la conexión
                miConexion.ConnectionString = clsConexion.getConnection();

                miConexion.Open();

                miComando.Parameters.Add("@idHermandad", System.Data.SqlDbType.Int).Value = idHermandad;


                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "SELECT * FROM Paso WHERE idHermandad = @idHermandad";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    //Leemos el resultado de la consulta y lo guardamos en una lista
                    while (miLector.Read())
                    {
                        clsPaso paso = new clsPaso();
                        paso.Id = (int)miLector["id"];
                        paso.NombrePaso = (string)miLector["nombrePaso"];
                        paso.Banda = (string)miLector["banda"];
                        paso.IdHermandad = (int)miLector["idHermandad"];
                        paso.Autor = (string)miLector["autor"];
                        paso.Capataz = (string)miLector["capataz"];
                        paso.FotoPaso = (string)miLector["fotoPaso"];
                        listado.Add(paso);
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

        public static clsPaso getPasoById(int id)
        {
            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            clsPaso paso = new clsPaso();

            try
            {
                //Abrimos la conexión
                miConexion.ConnectionString = clsConexion.getConnection();

                miConexion.Open();

                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "SELECT * FROM Paso WHERE id = @id";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                if (miLector.Read())
                {
                    //Leemos el resultado de la consulta y lo guardamos en una lista
                    paso.Id = (int)miLector["id"];
                    paso.NombrePaso = (string)miLector["nombrePaso"];
                    paso.Banda = (string)miLector["banda"];
                    paso.IdHermandad = (int)miLector["idHermandad"];
                    paso.Autor = (string)miLector["autor"];
                    paso.Capataz = (string)miLector["capataz"];
                    paso.FotoPaso = (string)miLector["fotoPaso"];

                }

                miLector.Close();
                miConexion.Close();

            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return paso;
        }   
    }
}
