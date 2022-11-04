using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_Ejercicio2_MAUI.Models
{
    internal class clsPersona : INotifyPropertyChanged
    {
        #region

        private String nombre;
        private String Apellidos { get; set; }
        private String Dni { get; set; }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; NotifyPropertyChanged(""); }
        }



        #endregion

        #region constructores

        public clsPersona() {
            this.Dni = "25621303Q";
            this.Nombre = "Pedro";
            this.Apellidos = "Cornejo Carvajal";
        }

        public clsPersona(String nombre, String apellidos, String dni)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
