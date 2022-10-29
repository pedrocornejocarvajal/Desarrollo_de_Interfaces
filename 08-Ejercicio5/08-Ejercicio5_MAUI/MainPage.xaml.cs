using DAL;
using Entidades;
using System.Collections.ObjectModel;

namespace _08_Ejercicio5_MAUI;

public partial class MainPage : ContentPage
{
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

