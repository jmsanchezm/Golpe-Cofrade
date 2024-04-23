using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class clsReserva
    {
        #region Atributos
        private int id;

        private int idSilla;

        private int idUsuario;

        private string fecha;

        public clsReserva()
        {
        }
        #endregion

        #region Constructores
        public clsReserva(int id, int idSilla, int idUsuario, string fecha)
        {
            this.id = id;
            this.idSilla = idSilla;
            this.idUsuario = idUsuario;
            this.fecha = fecha;
        }
        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public int IdSilla { get => idSilla; set => idSilla = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        #endregion
    }
}
