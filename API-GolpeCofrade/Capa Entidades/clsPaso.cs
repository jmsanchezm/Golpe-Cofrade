namespace Capa_Entidades
{
    public class clsPaso
    {

        #region atributos
        private int id;

        private string nombrePaso;

        private string banda;

        private string autor;

        private string capataz;

        private string fotoPaso;

        private int idHermandad;
        #endregion

        #region constructores
        public clsPaso()
        {
            this.id = 0;
            this.nombrePaso = "";
            this.banda = "";
            this.autor = "";
            this.capataz = "";
            this.fotoPaso = "";
            this.idHermandad = 0;
        }
        public clsPaso(int id, string nombrePaso, string banda, string autor, string capataz, string fotoPaso, int idHermandad)
        {
            this.id = id;
            this.nombrePaso = nombrePaso;
            this.banda = banda;
            this.autor = autor;
            this.capataz = capataz;
            this.fotoPaso = fotoPaso;
            this.idHermandad = idHermandad;
        }
        #endregion

        #region propiedades
        public int Id { get => id; set => id = value; }
        public string NombrePaso { get => nombrePaso; set => nombrePaso = value; }
        public string Banda { get => banda; set => banda = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Capataz { get => capataz; set => capataz = value; }
        public string FotoPaso { get => fotoPaso; set => fotoPaso = value; }
        public int IdHermandad { get => idHermandad; set => idHermandad = value; }
        #endregion
    }
}
