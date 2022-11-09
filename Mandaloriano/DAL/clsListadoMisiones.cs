using Entidades;
namespace DAL
{
    public class clsListadoMisiones
    {


        /// <summary>
        /// Accedemos a la base de datos y devolvemos un listado completo de las misiones
        /// Precondiciones: la base de datos esta disponible
        /// Postcondiciones: ninguna
        /// </summary>
        /// <returns> List<clsMision> </returns>
        /// 
        public List<clsMision> ListadoCompletoMisiones()
        {
            List<clsMision> lista = new List<clsMision>();


            lista.Add(new clsMision(1, "Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamien", "5000 créditos"));
            lista.Add(new clsMision(2, "Recuperar armadura Beskar", "La armadura de Bershka ha sido robada. Debes encontrarla.", "2000 créditos"));
            lista.Add(new clsMision(3, "Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.", "500 créditos."));
            lista.Add(new clsMision(4, "Renacuajos", "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", "500 créditos\r\n"));

            return lista;
        }
    }
    
}
