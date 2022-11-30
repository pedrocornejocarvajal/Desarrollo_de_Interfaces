using CRUD_Personas_DAL.Listados;
using CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_BL.Listados
{
	public class clsListadoPersonasBL
	{
		clsListadoPersonas dal;

		public ObservableCollection<clsPersona> getListadoCompletoPersonasBL()
		{
			dal = new clsListadoPersonas();
			ObservableCollection<clsPersona> personas = new ObservableCollection<clsPersona>();
			foreach(clsPersona clsPersona in dal.ListadoCompletoPersonas())
			{
				personas.Add(clsPersona);
			}


			return personas;
		}
	}
}
