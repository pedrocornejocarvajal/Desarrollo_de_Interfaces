using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mandaloriano_MAUI.ViewModels.Utilidades;

namespace Mandaloriano_MAUI.ViewModels
{
    internal class clsMainPageVM
    {
        #region Atributos
        private List<clsMision> listadoMisionesCompleta;
        private clsMision misionSeleccionada;
        private DelegateCommand mostrarDetallesCommand;
        private Boolean datosMisionEsVisible;
        #endregion


        #region Propiedades
        public List<clsMision> ListadoMisionesCompleta { get { return listadoMisionesCompleta; } }
        public clsMision MisionSeleccionada { get { return misionSeleccionada; } set { misionSeleccionada = value; } }
        public DelegateCommand MostrarDetallesCommand { get {

                mostrarDetallesCommand = new DelegateCommand(mostrarDetallesComand_Execute, mostrarDetallesCommand_CanExecute);
                return mostrarDetallesCommand; } }

        public Boolean DatosMisionEsVisible { get { return datosMisionEsVisible; } }


        #endregion


        #region Constructores

        #endregion


        #region Comandos

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool mostrarDetallesCommand_CanExecute()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Descripcion: Metodo que muestra los detalles de la mision seleccionada  haciendo visible el texto mediante el booleano datosMisionEsVisible
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void mostrarDetallesComand_Execute()
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
