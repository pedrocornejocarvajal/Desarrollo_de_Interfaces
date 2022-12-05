
using CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_Maui.Models
{
	public class clsPersonasConDepartamento : clsPersona
	{
		private string nombreDepartamento;

		public string NombreDepartamento { get; set; }

		public clsPersonasConDepartamento(string _nombre, string _apellidos, string _telefono, string _direccion, string _foto, DateTime _fechaNacimiento, string nombreDepartamento)
		{
			
			base.Nombre = _nombre;
			base.Apellidos = _apellidos;
			base.Telefono = _telefono;
			base.Direccion = _direccion;
			base.Foto = _foto;
			base.Fecha = _fechaNacimiento;
			NombreDepartamento = nombreDepartamento;

		}

		public clsPersonasConDepartamento()
		{
		}
	}
}
