namespace _09_BoletinEjercicios_MAUI;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void enteros(object sender, TextChangedEventArgs e)
	{
		if(!int.TryParse(e.NewTextValue, out int value))
		{
			txtTamano.Text = e.OldTextValue;
		}
	}
}

