namespace Entidades


{
    public class clsMision
    {
        #region

        private String NombreMision { get; set; }
        private String Descripcion { get; set; }
        private String Recompensa { get; set; }

        private int IdMision { get; set; }

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