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
        private String nombreDepartamento { get; set; }

        private int idDepartamento { get; set; }


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
