using CRUD_Personas_DAL.Listados;
using CRUD_Personas_Entidades;
using System.Collections.ObjectModel;


namespace CRUD_Personas_BL.Listados
{
    public class clsListadoDepartamentosBL
	{

		clsListadoDepartamentos dal;


		/// <summary>
		/// 
		/// Método que llama a capa de acceso a los datos
		/// y devuelve una ObservableCollection de objetos clsDepartamento
		/// 
		/// </summary>
		/// <returns></returns>
		public ObservableCollection<clsDepartamento> getListadoDepartamentosBL()
		{
			dal = new clsListadoDepartamentos();	
			
			return new ObservableCollection<clsDepartamento>(dal.ListadoCompletoDepartamentos());
		}
	}
}
