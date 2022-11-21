using CRUP_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_Ejercicio3_MAUI.ViewModel
{
    internal class recogerPersona : INotifyPropertyChanged
    {
        
        private String nombre;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; NotifyPropertyChanged(""); }
        }

        public recogerPersona()
        {
            clsPersona persona = new clsPersona();
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
