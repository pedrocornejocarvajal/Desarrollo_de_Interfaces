namespace CRUP_Personas_Entidades
{
    public class clsPersona
    {
        #region

        private String nombre { get; set; }
        private String apellidos { get; set; }
        private String dni { get; set; }


        #endregion

        #region constructores

        public clsPersona() { }

        public clsPersona( String nombre, String apellidos, String dni)
        {


            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;

        }

        #endregion
    }
}