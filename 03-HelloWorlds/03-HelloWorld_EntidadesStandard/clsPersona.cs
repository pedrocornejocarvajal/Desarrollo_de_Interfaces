using System;
using System.Xml.Linq;

namespace _03_HelloWorld_EntidadesStandard
{
    public class clsPersona
    {
        #region Atributos
        private string nombre = "N/A";
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
        #endregion
        #region Constructores
        public clsPersona(String nombre)
        {
            this.nombre = nombre;

        }
        public clsPersona()
        {
            this.nombre = "";

        }
        #endregion
    }
}
