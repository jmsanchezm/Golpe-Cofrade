using Capa_Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL
{
    public class clsHandlerUser
    {

        /// <summary>
        /// Función que devuelve un usuario por su username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static clsUsuario GetUsuarioByUsername(string username)
        {
            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            clsUsuario usuario = new clsUsuario();

            try
            {
                //Abrimos la conexión
                miConexion.ConnectionString = clsConexion.getConnection();

                miConexion.Open();

                miComando.Parameters.Add("@username", System.Data.SqlDbType.Int).Value = username;

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "SELECT * FROM Usuario WHERE username = @username";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                if (miLector.Read())
                {
                    //Leemos el resultado de la consulta y lo guardamos en una lista
                    usuario.Id = (int)miLector["id"];
                    usuario.NombreUsuario = (string)miLector["usuario"];
                    usuario.Contraseña = (string)miLector["contraseña"];
                    usuario.Email = (string)miLector["email"];
                    usuario.Nombre = (string)miLector["nombre"];
                    usuario.Apellido = (string)miLector["apellidos"];
                    usuario.Telefono = (string)miLector["numTelefono"];
                    usuario.NumTarjetaBancaria = (string)miLector["numTarjetaBancaria"];
                    usuario.Validez = (string)miLector["validez"];
                    usuario.Cvv = (int)miLector["CVV"];

                }

                miLector.Close();
                miConexion.Close();

            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return usuario;
        }


        /// <summary>
        /// Función que registra un usuario en la base de datos
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int registerUser(clsUsuario user)
        {
            int filas = 0;

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            try
            {
                miConexion.ConnectionString = clsConexion.getConnection();

                //Abrimos la conexión
                miConexion.Open();

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "INSERT INTO Usuario (usuario, contraseña, email, nombre, apellidos, numTelefono, numTarjetaBancaria, validez, CVV) " +
                                        "VALUES (@usuario, @contraseña, @email, @nombre, @apellidos, @numTelefono, @numTarjetaBancaria, @validez, @CVV)";

                miComando.Parameters.Add("@usuario", System.Data.SqlDbType.VarChar).Value = user.NombreUsuario;
                miComando.Parameters.Add("@contraseña", System.Data.SqlDbType.VarChar).Value = user.Contraseña;
                miComando.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = user.Email;
                miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = user.Nombre;
                miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = user.Apellido;
                miComando.Parameters.Add("@numTelefono", System.Data.SqlDbType.VarChar).Value = user.Telefono;
                miComando.Parameters.Add("@numTarjetaBancaria", System.Data.SqlDbType.VarChar).Value = user.NumTarjetaBancaria;
                miComando.Parameters.Add("@validez", System.Data.SqlDbType.VarChar).Value = user.Validez;
                miComando.Parameters.Add("@CVV", System.Data.SqlDbType.Int).Value = user.Cvv;

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
        /// Función que actualiza un usuario en la base de datos
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int updateUser(clsUsuario user)
        {
            int filas = 0;

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            try
            {
                miConexion.ConnectionString = clsConexion.getConnection();

                //Abrimos la conexión
                miConexion.Open();

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "UPDATE Usuario " +
                                        "SET usuario = @usuario, contraseña = @contraseña, email = @email, nombre = @nombre, " +
                                        "apellidos = @apellidos, numTelefono = @numTelefono, numTarjetaBancaria = @numTarjetaBancaria, " +
                                        "validez = @validez, CVV = @CVV WHERE usuario = @usuario";

                miComando.Parameters.Add("@usuario", System.Data.SqlDbType.VarChar).Value = user.NombreUsuario;
                miComando.Parameters.Add("@contraseña", System.Data.SqlDbType.VarChar).Value = user.Contraseña;
                miComando.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = user.Email;
                miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = user.Nombre;
                miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = user.Apellido;
                miComando.Parameters.Add("@numTelefono", System.Data.SqlDbType.VarChar).Value = user.Telefono;
                miComando.Parameters.Add("@numTarjetaBancaria", System.Data.SqlDbType.VarChar).Value = user.NumTarjetaBancaria;
                miComando.Parameters.Add("@validez", System.Data.SqlDbType.VarChar).Value = user.Validez;
                miComando.Parameters.Add("@CVV", System.Data.SqlDbType.Int).Value = user.Cvv;
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = user.Id;

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
        /// Función que elimina un usuario de la base de datos
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static int deleteUser(int id)
        {
            int filas = 0;

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            try
            {
                miConexion.ConnectionString = clsConexion.getConnection();

                //Abrimos la conexión
                miConexion.Open();

                //Definimos la consulta y ejecutamos el comando
                miComando.CommandText = "DELETE FROM Usuario WHERE usuario = @id";

                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

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
