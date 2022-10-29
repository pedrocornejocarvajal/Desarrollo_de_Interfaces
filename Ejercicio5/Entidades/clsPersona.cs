namespace Entidades
{
    public class clsPersona
    {
        #region

        private String Nombre { get; set; }
        private String Apellidos { get; set; }
        private String Dni { get; set; }

        #endregion

        #region constructores

        public clsPersona() { }

        public clsPersona(String nombre, String apellidos, String dni)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;

        }
        #endregion
    }
}