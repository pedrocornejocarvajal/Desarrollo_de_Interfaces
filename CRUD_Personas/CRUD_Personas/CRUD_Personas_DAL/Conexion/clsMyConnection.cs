using Microsoft.Data.SqlClient;

// Esta clase contiene los métodos necesarios para trabajar con el acceso a una base de datos SQL Server
//PROPIEDADES
//   _server: cadena 
//   _database: cadena, básica. Consultable/modificable.
//   _user: cadena, básica. Consultable/modificable.
//   _pass: cadena, básica. Consultable/modificable.

// MÉTODOS
//   Function getConnection() As SqlConnection
//       Este método abre una conexión con la base de datos. Lanza excepciones de tipo: SqlExcepion, InvalidOperationException y Exception.
//   
//   Sub closeConnection(ByRef connection As SqlConnection)
//       Este método cierra una conexión con la base de datos. Lanza excepciones de tipo: SqlExcepion, InvalidOperationException y Exception.
//



namespace CRUD_Personas_DAL.Conexion
{
    public class clsMyConnection
    {
        //Atributos
        public string server { get; set; }
        public string dataBase { get; set; }
        public string user { get; set; }
        public string pass { get; set; }

        //Constructores

        public clsMyConnection()
        {
            /*
            server = "falbinana.database.windows.net";
            dataBase = "PACOBBDD";
            user = "falbinana";
            pass = "Mandaloriano69";
            */

            server = "107-21\\SQLEXPRESS";
            dataBase = "examen";
            user = "prueba";
            pass = "123";

        }
        //Con parámetros por si quisiera cambiar las conexiones
        public clsMyConnection(string server, string database, string user, string pass)
        {
            this.server = server;
            dataBase = database;
            this.user = user;
            this.pass = pass;
        }


        //METODOS

        /// <summary>
        /// Método que abre una conexión con la base de datos
        /// </summary>
        /// <pre>Nada.</pre>
        /// <returns>Una conexión abierta con la base de datos</returns>
        public SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection();

            try
            {

                connection.ConnectionString = $"server={server};database={dataBase};uid={user};pwd={pass}; ";
                connection.Open();
            }
            catch (SqlException)
            {
                throw;
            }

            return connection;

        }




        /// <summary>
        /// Este metodo cierra una conexión con la Base de datos
        /// </summary>
        /// <post>La conexion es cerrada</post>
        /// <param name="connection">SqlConnection pr referencia. Conexion a cerrar
        /// </param>
        public void closeConnection(ref SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }

}
