namespace Entidades


{
    public class clsMision
    {
        #region

        public String NombreMision { get; set; }
        public String Descripcion { get; set; }
        public String Recompensa { get; set; }

        public int IdMision { get; set; }

        #endregion

        #region constructores

        public clsMision() { }

        public clsMision(int idMision, String nombreMision, String descripcion, String recompensa)
        {

            this.IdMision = idMision;
            this.NombreMision = nombreMision;
            this.Descripcion = descripcion;
            this.Recompensa = recompensa;

        }

        #endregion
    }
}