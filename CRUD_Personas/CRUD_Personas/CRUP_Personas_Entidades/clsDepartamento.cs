using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUP_Personas_Entidades
{
    public class clsDepartamento
    {

        #region Atributos

        private int idDepartamento;
        private String nombreDepartamento;

        public int IdDepartamento { get { return idDepartamento; }}
        public String NombreDepartamento { get { return nombreDepartamento; } set { nombreDepartamento = value; } }


        #endregion

        #region constructores

        public clsDepartamento() { }

        public clsDepartamento(int idDepartamento, String nombre)
        {
            this.idDepartamento = idDepartamento;
            this.nombreDepartamento = nombre;


        }

        #endregion
    }
}
