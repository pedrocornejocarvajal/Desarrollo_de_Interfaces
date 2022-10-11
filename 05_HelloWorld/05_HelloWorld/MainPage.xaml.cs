using _05_HelloWorld_EntidadesStandard;

namespace _05_HelloWorld;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void clickSaludar(object sender, EventArgs e)
	{
		clsPersona persona;

		if(String.IsNullOrEmpty(cajaTextoNombre.Text) || String.IsNullOrEmpty(cajaTextoApellido.Text))
		{
			DisplayAlert("Error", "Introduce un nombre y apellidos", "Aceptar");
		}
		else
		{
			persona = new clsPersona();
			persona.Nombre = cajaTextoNombre.Text;
			persona.Apellido = cajaTextoApellido.Text;
            DisplayAlert("Cuadro de Saludo", $"Hola {persona.Nombre} {persona.Apellido}", "Aceptar");
        }
	}
	}