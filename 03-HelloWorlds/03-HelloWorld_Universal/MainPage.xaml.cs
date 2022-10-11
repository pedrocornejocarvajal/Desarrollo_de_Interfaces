using _03_HelloWorld_EntidadesStandard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace _03_HelloWorld_Universal
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private void botonSaludar_Click_1(object sender, RoutedEventArgs e)
        {
 
                clsPersona persona;
            MessageDialog mensaje;

                if (cajaTexto.Text == "")
                {

                    mensajeError.Visibility = Visibility.Visible;
                    
                }
                else
                {
                    persona = new clsPersona(cajaTexto.Text);
                    mensajeError.Visibility = Visibility.Collapsed;
                    mensaje = new MessageDialog ("Hola" + persona.Nombre);
                    _ = mensaje.ShowAsync ();
            }
        }
    }
}
