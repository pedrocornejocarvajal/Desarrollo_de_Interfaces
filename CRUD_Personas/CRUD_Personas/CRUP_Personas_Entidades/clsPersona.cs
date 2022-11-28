namespace CRUP_Personas_Entidades
{
    public class clsPersona
    {
        #region

        private int id;
        private String nombre;
        private String apellidos;
        private String telefono;
        private String foto;
        private DateTime fecha;
        private String dni;
        private int idDepartamento;



        public int Id { get { return id; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public String Apellidos { get { return apellidos; } set { apellidos = value; } }
        public String NombreCompleto => $"{Nombre} {Apellidos}";
        public String Telefono { get { return telefono; } set { telefono = value; } }
        public String Foto { get { return foto; } set { foto = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public String Dni { get { return dni; } set { dni = value; } }
        public int IdDepartamento { get { return idDepartamento; } set { idDepartamento = value; } }

        #endregion

        #region constructores

        public clsPersona() { }

        public clsPersona(int id, String nombre, String apellidos,String telefono, String foto, DateTime fecha, String dni, int idDepartamento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.foto = foto;
            this.fecha = fecha;
            this.dni = dni;
            this.idDepartamento = idDepartamento;
        }

        #endregion
    }
}