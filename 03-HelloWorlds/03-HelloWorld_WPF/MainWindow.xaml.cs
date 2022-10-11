using _03_HelloWorld_EntidadesStandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _03_HelloWorld_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// prototipo: 
        /// comentario: Evento asociado al boton aludar para saludar a la persona introducida
        /// precondiciones:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonSaludar_Click(object sender, RoutedEventArgs e)
        {
            clsPersona persona ;

            if(cajaTexto.Text =="")
            {
                
                mensajeError.Visibility = Visibility.Visible;
                mensajeError.Content = "Error, el nombre no puede estar vacio";
            }
            else
            {
                persona = new clsPersona(cajaTexto.Text);
                mensajeError.Visibility = Visibility.Collapsed;
                MessageBox.Show("Hola" + persona.Nombre);
            }
        }
    }
}
