using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class clsSilla
    {

        #region Atributos
        private int id;

        private int fila;

        private int asiento;

        private string lugar;

        private double precio;

        private bool reservada;

        private int seccion;

        public clsSilla()
        {
        }
        #endregion

        #region Constructores
        public clsSilla(int id, int fila, int asiento, string lugar, double precio, bool reservada,int seccion)
        {
            this.id = id;
            this.fila = fila;
            this.asiento = asiento;
            this.lugar = lugar;
            this.precio = precio;
            this.reservada = reservada;
            this.seccion = seccion;
        }
        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public int Fila { get => fila; set => fila = value; }
        public int Asiento { get => asiento; set => asiento = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public double Precio { get => precio; set => precio = value; }
        public bool Reservada { get => reservada; set => reservada = value; }
        public int Seccion { get => seccion; set => seccion = value; }

        #endregion

    }
}
