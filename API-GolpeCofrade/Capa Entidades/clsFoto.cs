using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class clsFoto
    {
        #region Atributos
        private int id;

        private string url;

        private string pieFoto;

        private int idUsuario;

        #endregion

        #region Constructores
        public clsFoto()
        {
            this.id = 0;
            this.url = "";
            this.pieFoto = "";
            this.idUsuario = 0;
        }
        public clsFoto(int id, string url, string pieFoto, int idUsuario){
            this.id = id;
            this.url = url;
            this.pieFoto = pieFoto;
            this.idUsuario = idUsuario;
        }
        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Url { get => url; set => url = value; }
        public string PieFoto { get => pieFoto; set => pieFoto = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        #endregion
    }
}
