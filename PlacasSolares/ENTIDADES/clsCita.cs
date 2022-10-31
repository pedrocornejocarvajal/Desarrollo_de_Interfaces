namespace ENTIDADES
{
    public class clsCita
    {
        #region

        private String Nombre { get; set; }
        private String Apellidos { get; set; }
        private String Numero { get; set; }
        private String Ubicacion { get; set; }

        #endregion

        #region constructores

        public clsCita() { }

        public clsCita(String nombre, String apellidos, String numero, String ubicacion)
        {
            
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Numero = numero;
            this.Ubicacion = ubicacion; 

        }
        #endregion
    }
}