using _03_HelloWorld_EntidadesStandard;
namespace _03_HelloWorld_MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Saludar(object sender, EventArgs e)
        {
            clsPersona persona;

            if (String.IsNullOrEmpty())
            {
                mensajeError.IsVisible = true;
            }
            else
            {
                mensajeError.IsVisible=false;
            }

      
        }
    }
}