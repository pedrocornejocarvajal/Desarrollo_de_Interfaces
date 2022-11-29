using _18_CRUD_Personas_UWP_UI.ViewModels.Utilidades;
using CRUD_Personas_DAL;
using CRUP_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_Maui.ViewModels
{
    public class clsEditarAnhadirPersonaVM
    {
        #region Atributos
        private clsPersona personaSeleccionada;
        #endregion

        #region Constructores
        public clsEditarAnhadirPersonaVM()
        {

            personaSeleccionada = new clsPersona();

        }
        #endregion

        public DelegateCommand cancelarPersona()
        {

        }

        public DelegateCommand guardarPersona()
        {

        }


    }
}
