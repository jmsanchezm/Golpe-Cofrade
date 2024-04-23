using Capa_Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL
{
    public class clsHandlerReservas
    {

        /// <summary>
        /// Funcion que devuelve un listado de reservas de un mismo usuario
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public static List<clsReserva> listadoReservasPorUser(int idUser)
        {
            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            List<clsReserva> listado = new List<clsReserva>();

            clsReserva reserva;

            try
            {
                //Abrimos la conexión
                miConexion.ConnectionString = clsConexion.getConnection();

                miComando.Parameters.Add("@idUser", System.Data.SqlDbType.Int).Value = idUser;

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "SELECT * FROM Reserva WHERE idUsuario = @idUser";

                miComando.Connection = miConexion;

                miConexion.Open();

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        reserva = new clsReserva();

                        reserva.Id = (int)miLector["id"];
                        reserva.IdSilla = (int)miLector["fila"];
                        reserva.IdUsuario = (int)miLector["asiento"];
                        reserva.Fecha = (string)miLector["lugar"];

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
        /// Funcion que inserta una reserva en la base de datos
        /// Y actualiza la silla a reservada
        /// </summary>
        /// <param name="reserva"></param>
        /// <returns></returns>
        public static int insertReserva(clsReserva reserva)
        {
            int filas = 0;

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            try
            {
                miConexion.ConnectionString = clsConexion.getConnection();

                //Abrimos la conexión
                miConexion.Open();

                miComando.Parameters.Add("@idSilla", System.Data.SqlDbType.Int).Value = reserva.IdSilla;

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "INSERT INTO Reserva (id, idUsuario, idSilla, fecha) VALUES (@id, @idUsuario, @idSilla, @fecha)" +
                    "UPDATE Silla SET reservada = 1 WHERE idSilla = @idSilla";

                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = reserva.Id;
                miComando.Parameters.Add("@idUsuario", System.Data.SqlDbType.Int).Value = reserva.IdUsuario;
                miComando.Parameters.Add("@idSilla", System.Data.SqlDbType.Int).Value = reserva.IdSilla;
                miComando.Parameters.Add("@fecha", System.Data.SqlDbType.VarChar).Value = reserva.Fecha;

                miComando.Connection = miConexion;

                filas = miComando.ExecuteNonQuery();

                miConexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }


        /// <summary>
        /// Funcion que elimina una reserva de la base de datos
        /// Y actualiza la silla a no reservada
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idSilla"></param>
        /// <returns></returns>
        public static int deleteReserva(int id, int idSilla)
        {
            int filas = 0;

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            try
            {
                miConexion.ConnectionString = clsConexion.getConnection();

                //Abrimos la conexión
                miConexion.Open();

                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                miComando.Parameters.Add("@idSilla", System.Data.SqlDbType.Int).Value = idSilla;

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "DELETE FROM Reserva WHERE id = @id" +
                    "UPDATE Silla SET reservada = 0 WHERE id = @idSilla";

                miComando.Connection = miConexion;

                filas = miComando.ExecuteNonQuery();

                miConexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

            return filas;
        }

    }
}
