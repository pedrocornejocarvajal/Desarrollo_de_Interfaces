namespace Entidades
{
    public class clsPersona
    {
        #region

        private String nombre { get; set; }
        private String apellidos { get; set; }
        private String dni { get; set; }

        private int idPersona { get; set; }
        private int idDepartamento { get; set; }

        #endregion

        #region constructores

        public clsPersona() { }

        public clsPersona(int idDepartamento, int idPersona, String nombre, String apellidos, String dni)
        {

            this.idDepartamento = idDepartamento;
            this.idPersona = idPersona;
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;

        }

        #endregion
    }
}