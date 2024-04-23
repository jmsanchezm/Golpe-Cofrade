using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class clsUsuario
    {

        #region Atributos
        private int id;

        private string nombreUsuario;

        private string contraseña;

        private string email;

        private string nombre;  

        private string apellido;

        private string telefono;

        private string numTarjetaBancaria;

        private string validez;

        private int cvv;

        public clsUsuario()
        {
        }
        #endregion

        #region Constructores

        public clsUsuario(int id, string usuario, string contraseña, string email, string nombre, string apellido, string telefono, string numTarjetaBancaria, string validez, int cvv)
        {
            this.id = id;
            this.nombreUsuario = usuario;
            this.contraseña = contraseña;
            this.email = email;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.numTarjetaBancaria = numTarjetaBancaria;
            this.validez = validez;
            this.cvv = cvv;
        }
        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Email { get => email; set => email = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string NumTarjetaBancaria { get => numTarjetaBancaria; set => numTarjetaBancaria = value; }
        public string Validez { get => validez; set => validez = value; }
        public int Cvv { get => cvv; set => cvv = value; }
        #endregion

    }
}
