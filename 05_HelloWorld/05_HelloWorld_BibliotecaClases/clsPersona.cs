using System;
using System.Xml.Linq;

namespace _05_HelloWorld_EntidadesStandard
{
    public class clsPersona
    {
        #region Atributos
        private string nombre = "N/A";
        private string apellido = "N/A";
        #endregion

        #region Propiedades

        public string Nombre
        
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        #endregion
        #region Constructores
        public clsPersona(String nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;

        }
        public clsPersona()
        {
            this.nombre = "";
            this.apellido = "";

        }
        #endregion
    }
}
