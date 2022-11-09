using System.Collections.ObjectModel;
using Entidades;
using DAL;

namespace Mandaloriano_MAUI;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();


		ObservableCollection<clsMision> Misiones = new ObservableCollection<clsMision>();


		clsListadoMisiones clsListadoMisiones = new clsListadoMisiones();


		List<clsMision> lista = clsListadoMisiones.ListadoCompletoMisiones();
		foreach (var item in lista)
		{
			Misiones.Add(item);
		}

		
		

	}
}
	