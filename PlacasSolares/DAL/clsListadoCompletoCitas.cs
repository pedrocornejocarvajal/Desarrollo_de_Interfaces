using ENTIDADES;
namespace DAL

{
    public class clsListadoCompletoCitas
    {
        /// <summary>
        /// Accedemos a la base de datos y devolvemos un listado completo de las citas
        /// Precondiciones: la base de datos esta disponible
        /// Postcondiciones: ninguna
        /// </summary>
        /// <returns> List<clsCita> </returns>
        /// 
        public List<clsCita> ListadoCompletoCitas()
        {
            List<clsCita> lista = new List<clsCita>();

            lista.Add(new clsCita("Pedro", "Cornejo", "658741239", "Calle Felipe, Nº25"));
            lista.Add(new clsCita("Borja", "Iglesias", "625169875", "Calle Betis, Nº102"));
            lista.Add(new clsCita("Nabil", "Fekir", "632059045", "Calle Rosa, Nº78"));
            lista.Add(new clsCita("Alex", "Moreno", "603789245", "Calle Margarita, Nº236"));
            lista.Add(new clsCita("Sergio", "Canales", "637840394", "Calle Pasedilla, Nº545"));
            lista.Add(new clsCita("Tony", "Stark", "632104578", "Calle Santo Cristo, Nº2"));
            lista.Add(new clsCita("Juanmi", "Jimenez", "615109546", "Calle Palmera, Nº19"));

            return lista;
        }
    }
}