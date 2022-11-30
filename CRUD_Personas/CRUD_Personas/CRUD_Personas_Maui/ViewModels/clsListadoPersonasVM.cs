using CRUD_Personas_BL.Listados;
using CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Personas_Maui.Models;
using _18_CRUD_Personas_UWP_UI.ViewModels.Utilidades;

namespace UI.ViewModels
{
	public class clsListadoPersonasVM : clsVMBase
	{
		#region Atributos
		private ObservableCollection<clsPersonasConDepartamento> personas;

		private clsPersonasConDepartamento personaSeleccionada;

		private DelegateCommand insert_Command;

		private DelegateCommand edit_Command;

		private DelegateCommand delete_Command;
		#endregion

		#region Propiedades

		public ObservableCollection<clsPersonasConDepartamento> Personas { get { return personas; } set { personas = value; } }

		public clsPersonasConDepartamento PersonaSeleccionada
		{
			get
			{
				return personaSeleccionada;
			}
			set
			{
				personaSeleccionada = value;
				NotifyPropertyChanged(nameof(PersonaSeleccionada));
			}
		}

		public DelegateCommand Insert_Command
		{
			get
			{
				insert_Command = new DelegateCommand(InsertCommand_Executed, InsertCommand_CanExecute);
				return insert_Command;
			}
		}

		public DelegateCommand Edit_Command
		{
			get
			{
				insert_Command = new DelegateCommand(EditCommand_Executed, EditCommand_CanExecute);
				return insert_Command;
			}
		}

		public DelegateCommand Delete_Command
		{
			get
			{
				insert_Command = new DelegateCommand(DeleteCommand_Executed, DeleteCommand_CanExecute);
				return insert_Command;
			}
		}

		#endregion


		#region Constructores

		public clsListadoPersonasVM()
		{
			clsListadoPersonasBL personasBL = new();
			clsListadoDepartamentosBL departamentosBL = new();
			ObservableCollection<clsDepartamento> departamentos = departamentosBL.getListadoDepartamentosBL();
			Personas = new ObservableCollection<clsPersonasConDepartamento>();
			foreach (clsPersona p in personasBL.getListadoCompletoPersonasBL())
			{

				for (int i = 0; i < departamentos.Count; i++)
				{

					if (departamentos.ElementAt(i).IdDepartamento == p.IdDepartamento)
					{

						Personas.Add( new(p.Nombre, p.Apellidos, p.Telefono, p.Dni, p.Fecha, departamentos.ElementAt(i).NombreDepartamento));

					}
				}
			}

		}

		#endregion


		#region CommandImplementation
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		private bool EditCommand_CanExecute()
		{
			throw new NotImplementedException();
		}

		private void EditCommand_Executed()
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		private bool DeleteCommand_CanExecute()
		{
			return false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		private void DeleteCommand_Executed()
		{
			throw new NotImplementedException();
		}





		/// <summary>
		/// Método que 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		private bool InsertCommand_CanExecute()
		{

			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		private void InsertCommand_Executed()
		{
			throw new NotImplementedException();
		}



		#endregion











	}
}
