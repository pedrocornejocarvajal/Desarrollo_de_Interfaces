using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Personas_DAL.Conexion;
using CRUD_Personas_Entidades;
using Microsoft.Data.SqlClient;

namespace CRUD_Personas_DAL.Listados
{
    public class clsListadoDepartamentos
    {

        #region Atributos
        private clsMyConnection miConexion;
        #endregion

        #region Constructores
        public clsListadoDepartamentos()
        {

            miConexion = new clsMyConnection();
        }
        #endregion

        /// <summary>
        /// Accedemos a la base de datos y devolvemos un listado completo de los departamentos
        /// Precondiciones: la base de datos esta disponible
        /// Postcondiciones: ninguna
        /// </summary>
        /// <returns> List<clsDepartamento> </returns>
        /// 
        public List<clsDepartamento> ListadoCompletoDepartamentos()
        {
            List<clsDepartamento> lista = new List<clsDepartamento>();


            try
            {
                SqlConnection cnn = miConexion.getConnection(); // Crea la conexion
                SqlCommand comando = new SqlCommand();  // Guarda el comando sql
                SqlDataReader miLector;  // Abre el lector

                comando.CommandText = "Select * From Departamentos"; // creamos el comando

                comando.Connection = cnn; //le metemos el comando a nuestra conexion

                miLector = comando.ExecuteReader(); //Ejecutamos el comando en nuestra bbdd

                while (miLector.Read())
                {
                    if (miLector.HasRows)
                    {
                        lista.Add(new clsDepartamento(
                        miLector.GetInt32(0),
                        miLector.GetString(1)
                        ));
                    }
                }
            }
            catch (Exception) { throw; }
            return lista;
        }
    }
}
