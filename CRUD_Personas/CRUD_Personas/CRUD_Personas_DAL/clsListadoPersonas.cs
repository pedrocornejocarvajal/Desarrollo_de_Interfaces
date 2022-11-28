using _07_CRUD_Personas_DAL.Conexion;
using CRUP_Personas_Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_DAL
{
    public class clsListadoPersonas
    {

        #region Atributos
        private clsMyConnection miConexion;
        #endregion

        #region Constructores
        public clsListadoPersonas(){

            miConexion = new clsMyConnection();
        }
        #endregion


        /// <summary>
        /// Accedemos a la base de datos y devolvemos un listado completo de las personas
        /// Precondiciones: la base de datos esta disponible
        /// Postcondiciones: ninguna
        /// </summary>
        /// <returns> List<clsPersona> </returns>
        /// 
        public List<clsPersona> ListadoCompletoDepartamentos()
        {
            List<clsPersona> lista = new List<clsPersona>();

            try
            {
                SqlConnection cnn = miConexion.getConnection(); // Crea la conexion
                SqlCommand comando = new SqlCommand();  // Guarda el comando sql
                SqlDataReader miLector;  // Abre el lector

                comando.CommandText = "Select * From Personas"; // creamos el comando

                comando.Connection = cnn; //le metemos el comando a nuestra conexion

                miLector = comando.ExecuteReader(); //Ejecutamos el comando en nuestra bbdd

                while (miLector.Read())
                {
                    if (miLector.HasRows)
                    {
                        lista.Add(new clsPersona(
                            miLector.GetInt32(0),
                            miLector.GetString(1),
                            miLector.GetString(2),
                            miLector.GetString(3),
                            miLector.GetString(4),
                            miLector.GetDateTime(5),
                            miLector.GetString(6),
                            miLector.GetInt32(7)
                            ));
                    }
                }
            }
            catch (Exception) { throw; }
            


            return lista;
        }
    }
}
