using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUP_Personas_Entidades;

namespace CRUD_Personas_DAL
{
    internal class clsListadoDepartamentos
    {
        /// <summary>
        /// Accedemos a la base de datos y devolvemos un listado completo de los departamentos
        /// Precondiciones: la base de datos esta disponible
        /// Postcondiciones: ninguna
        /// </summary>
        /// <returns> List<clsDepartamento> </returns>
        /// 
        public List<clsDepartamento> ListadoCompletoDepartamentos()
        {
            List<clsDepartamento> lista = new List<clsDepartamento>();


            lista.Add(new clsDepartamento(1, "Finanzas"));
            lista.Add(new clsDepartamento(2, "RRHH"));
            lista.Add(new clsDepartamento(3, "Marqueting"));
            lista.Add(new clsDepartamento(4, "Transportes"));


            return lista;
        }
    }
}
