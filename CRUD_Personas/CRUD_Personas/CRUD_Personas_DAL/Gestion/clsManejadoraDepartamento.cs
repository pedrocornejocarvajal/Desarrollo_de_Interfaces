using CRUD_Personas_DAL.Conexion;
using CRUD_Personas_Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_DAL.Gestion
{
    internal class clsManejadoraDepartamento
    {

        #region Atributos
        private clsMyConnection miConexion;
        #endregion

        #region Constructores
        public clsManejadoraDepartamento()
        {

            miConexion = new clsMyConnection();
        }
        #endregion


        /// <summary>
        /// Descripcion: Inserta un nuevo departamento en la base de datos
        /// Precondiciones: Ninguna
        /// Postcondiciones: Numero de filas afectadas es mayor o igual a 0
        /// </summary>
        /// <param name="departamento"></param>
        /// <returns></returns>
        public int guardarDepartamento(clsDepartamento departamento)
        {

            SqlConnection cnn = miConexion.getConnection(); // Crea la conexion
            SqlCommand comando = new SqlCommand();  // Guarda el comando sql

            comando.CommandText = "Insert into departamentos values(@idDepartamento, @nombreDepartamento)"; // creamos el comando

            //Bindeamos los parametros
            comando.Parameters.AddWithValue("@idDepartamento", departamento.IdDepartamento);
            comando.Parameters.AddWithValue("@nombreDepartamento", departamento.NombreDepartamento);

            comando.Connection = cnn; //le metemos el comando a nuestra conexion


            int numFilasAfectadas = 0;
            numFilasAfectadas = comando.ExecuteNonQuery(); //Ejecutamos el comando en nuestra bbdd y devuelve el numero de filas afectadas

            return numFilasAfectadas;


        }

        /// <summary>
        /// Descripcion: Borra un departamento en la base de datos
        /// Precondiciones: El departamento a borrar debe existir en la base de datos
        /// Postcondiciones: Numero de filas afectadas es mayor o igual a 0
        /// </summary>
        /// <param name="departamento"></param>
        /// <returns></returns>
        public int borrarDepartamento(clsDepartamento departamento)
        {

            SqlConnection cnn = miConexion.getConnection(); // Crea la conexion
            SqlCommand comando = new SqlCommand();  // Guarda el comando sql

            comando.CommandText = "Delete * From Departamentos Where id = @idDepartamento"; // creamos el comando

            //Bindeamos los parametros
            comando.Parameters.AddWithValue("@idDepartamento", departamento.IdDepartamento);

            comando.Connection = cnn; //le metemos el comando a nuestra conexion


            int numFilasAfectadas = 0;
            numFilasAfectadas = comando.ExecuteNonQuery(); //Ejecutamos el comando en nuestra bbdd y devuelve el numero de filas afectadas

            return numFilasAfectadas;
        }

        /// <summary>
        /// Descripcion: Actualiza un departamento existente en la base de datos
        /// Precondiciones: El departamento a actualizar debe existir en la Base de datos
        /// Postcondiciones: Numero de filas afectadas es mayor o igual a 0
        /// </summary>
        /// <param name="departamento"></param>
        /// <returns></returns>
        public int actualizarDepartamento(clsDepartamento departamento)
        {
            SqlConnection cnn = miConexion.getConnection(); // Crea la conexion
            SqlCommand comando = new SqlCommand();  // Guarda el comando sql

            comando.CommandText = "Update Departamento set idDepartamento = @idDepartamento, nombre = @nombre where id = @idDepartamento"; // creamos el comando

            //Bindeamos los parametros
            comando.Parameters.AddWithValue("@idDepartamento", departamento.IdDepartamento);
            comando.Parameters.AddWithValue("@nombreDepartamento", departamento.NombreDepartamento);


            comando.Connection = cnn; //le metemos el comando a nuestra conexion


            int numFilasAfectadas = 0;
            numFilasAfectadas = comando.ExecuteNonQuery(); //Ejecutamos el comando en nuestra bbdd y devuelve el numero de filas afectadas

            return numFilasAfectadas;
        }

    }
}
