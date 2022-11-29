using _07_CRUD_Personas_DAL.Conexion;
using CRUP_Personas_Entidades;
using Microsoft.Data.SqlClient;

namespace CRUD_Personas_DAL
{
    public class clsManejadoraPersona
    {

        #region Atributos
        private clsMyConnection miConexion;
        #endregion

        #region Constructores
        public clsManejadoraPersona()
        {

            miConexion = new clsMyConnection();
        }
        #endregion



        /// <summary>
        /// Descripcion: inserta una nueva persona en la base de datos
        /// Precondiciones: Ninguna
        /// Postcondiciones: Numero de filas afectadas es mayor o igual a 0
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int guardarPersona(clsPersona persona)
        {

            SqlConnection cnn = miConexion.getConnection(); // Crea la conexion
            SqlCommand comando = new SqlCommand();  // Guarda el comando sql

            comando.CommandText = "Insert into personas values(@id, @nombre, @apellidos, @telefono, @foto, @fecha, @dni, @idDepartamento)"; // creamos el comando

            //Bindeamos los parametros
            comando.Parameters.AddWithValue("@id", persona.Id);
            comando.Parameters.AddWithValue("@nombre", persona.Nombre);
            comando.Parameters.AddWithValue("@apellidos", persona.Apellidos);
            comando.Parameters.AddWithValue("@telefono", persona.Telefono);
            comando.Parameters.AddWithValue("@foto", persona.Foto);
            comando.Parameters.AddWithValue("@dni", persona.Dni);
            comando.Parameters.AddWithValue("@idDepartamento", persona.IdDepartamento);

            comando.Connection = cnn; //le metemos el comando a nuestra conexion


            int numFilasAfectadas = 0;
            numFilasAfectadas = comando.ExecuteNonQuery(); //Ejecutamos el comando en nuestra bbdd y devuelve el numero de filas afectadas

            return numFilasAfectadas;


        }

        /// <summary>
        /// Descripcion: Borra una persona en la base de datos
        /// Precondiciones: La persona a borrar debe existir en la base de datos
        /// Postcondiciones: Numero de filas afectadas es mayor o igual a 0
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int borrarPersona(clsPersona persona)
        {

            SqlConnection cnn = miConexion.getConnection(); // Crea la conexion
            SqlCommand comando = new SqlCommand();  // Guarda el comando sql

            comando.CommandText = "Delete * From Personas Where id = @id"; // creamos el comando

            //Bindeamos los parametros
            comando.Parameters.AddWithValue("@id", persona.Id);



            comando.Connection = cnn; //le metemos el comando a nuestra conexion


            int numFilasAfectadas = 0;
            numFilasAfectadas = comando.ExecuteNonQuery(); //Ejecutamos el comando en nuestra bbdd y devuelve el numero de filas afectadas

            return numFilasAfectadas;
        }

        /// <summary>
        /// Descripcion: Actualiza  una persona en la base de datos
        /// Precondiciones: la persona a actualizar debe existir en la base de datos
        /// Postcondiciones: Numero de filas afectadas es mayor o igual a 0
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int actualizarPersona(clsPersona persona)
        {
            SqlConnection cnn = miConexion.getConnection(); // Crea la conexion
            SqlCommand comando = new SqlCommand();  // Guarda el comando sql

            comando.CommandText = "Update Personas set nombre = @nombre, apellidos = @apellidos, telefono = @telefono, foto = @foto, fechaNacimiento = @fecha, dni = @dni,idDepartamento = @idDepartamento  where id = @id"; // creamos el comando

            //Bindeamos los parametros
            comando.Parameters.AddWithValue("@id", persona.Id);
            comando.Parameters.AddWithValue("@nombre", persona.Nombre);
            comando.Parameters.AddWithValue("@apellidos", persona.Apellidos);
            comando.Parameters.AddWithValue("@telefono", persona.Telefono);
            comando.Parameters.AddWithValue("@foto", persona.Foto);
            comando.Parameters.AddWithValue("@dni", persona.Dni);
            comando.Parameters.AddWithValue("@idDepartamento", persona.IdDepartamento);

            comando.Connection = cnn; //le metemos el comando a nuestra conexion


            int numFilasAfectadas = 0;
            numFilasAfectadas = comando.ExecuteNonQuery(); //Ejecutamos el comando en nuestra bbdd y devuelve el numero de filas afectadas

            return numFilasAfectadas;
        }


    }
}