using _18_CRUD_Personas_UWP_UI.ViewModels.Utilidades;
using CRUD_Personas_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_Maui.ViewModels
{
    public class clsListadoPersonasVM
    {
        #region Atributos
        private clsListadoPersonas listadoPersonas;
        #endregion

        #region Constructores
        public clsListadoPersonasVM()
        {

            listadoPersonas = new clsListadoPersonas();

        }
        #endregion

        public DelegateCommand anhadirPersona()
        {

        }

        public DelegateCommand eliminarPersona()
        {

        }

        public DelegateCommand editarPersona()
        {

        }

    }
}
