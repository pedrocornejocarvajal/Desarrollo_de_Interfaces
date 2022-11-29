using _18_CRUD_Personas_UWP_UI.ViewModels.Utilidades;
using CRUP_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_Maui.ViewModels
{
    public class clsEditarAnhadirDepartamentoVM
    {
            #region Atributos
            private clsDepartamento departamentoSeleccionado;
            #endregion

            #region Constructores
            public clsEditarAnhadirDepartamentoVM()
            {

                departamentoSeleccionado = new clsDepartamento();

            }
            #endregion

            public DelegateCommand cancelarDepartamento()
            {

            }

            public DelegateCommand guardarDepartamento()
            {

            }

        }
    }
