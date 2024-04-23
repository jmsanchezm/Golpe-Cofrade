using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class clsHermandad
    {
        #region Atributos
        private int id;

        private string nombre;

        private string diaProcesion;

        private string sede;

        private string direccion;

        private int añoFundacion;

        private string sintesisHistorica;

        private int numHermanos;

        private int numNazarenos;

        private int tiempoPasada;

        private string fotoEscudo;
        #endregion


        #region Constructores
        public clsHermandad()
        {
            this.id = 0;
            this.nombre = "";
            this.diaProcesion = "";
            this.sede = "";
            this.direccion = "";
            this.añoFundacion = 0;
            this.sintesisHistorica = "";
            this.numHermanos = 0;
            this.numNazarenos = 0;
            this.tiempoPasada = 0;
            this.fotoEscudo = "";
        }

        public clsHermandad(int id, string nombre, string diaProcesion, string sede, string direccion, int añoFundacion, string sintesisHistorica, int numHermanos, int numNazarenos, int tiempoPasada, string fotoEscudo)
        {
            this.id = id;
            this.nombre = nombre;
            this.diaProcesion = diaProcesion;
            this.sede = sede;
            this.direccion = direccion;
            this.añoFundacion = añoFundacion;
            this.sintesisHistorica = sintesisHistorica;
            this.numHermanos = numHermanos;
            this.numNazarenos = numNazarenos;
            this.tiempoPasada = tiempoPasada;
            this.fotoEscudo = fotoEscudo;
        }
        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string DiaProcesion { get => diaProcesion; set => diaProcesion = value; }
        public string Sede { get => sede; set => sede = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int AñoFundacion { get => añoFundacion; set => añoFundacion = value; }
        public string SintesisHistorica { get => sintesisHistorica; set => sintesisHistorica = value; }
        public int NumHermanos { get => numHermanos; set => numHermanos = value; }
        public int NumNazarenos { get => numNazarenos; set => numNazarenos = value; }
        public int TiempoPasada { get => tiempoPasada; set => tiempoPasada = value; }
        public string FotoEscudo { get => fotoEscudo; set => fotoEscudo = value; }
        #endregion
    }
}
