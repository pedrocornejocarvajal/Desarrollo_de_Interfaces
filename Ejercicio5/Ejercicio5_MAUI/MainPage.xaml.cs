using Entidades;
using DAL;
using System.Collections.ObjectModel;

namespace Ejercicio5_MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        ObservableCollection<clsPersona> Personas = new ObservableCollection<clsPersona>();


        clsListadoPersonas clsListadoPersonas = new clsListadoPersonas();


        List<clsPersona> lista = clsListadoPersonas.ListadoCompletoDepartamentos();

        foreach (var item in lista)
        {
            Personas.Add(item);
        }

        PersonListView.ItemsSource = Personas;


    }
}

