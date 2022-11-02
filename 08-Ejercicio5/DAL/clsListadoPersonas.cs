using Entidades;
namespace DAL
{
    public class clsListadoPersonas
    {
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


            lista.Add(new clsPersona("Pedro", "Cornejo", "25621303Q"));
            lista.Add(new clsPersona("Jose", "Cornejo", "45789654W"));
            lista.Add(new clsPersona("Monica", "Carvajal", "25017836F"));
            lista.Add(new clsPersona("Carmelo", "Aguilar", "98523645H"));
            lista.Add(new clsPersona("Antonio", "Gallardo", "78250364E"));
            lista.Add(new clsPersona("Francisco", "Gallardo", "45012367J"));
            lista.Add(new clsPersona("Pepe", "Perez", "98147632P"));
            lista.Add(new clsPersona("Miguel", "Hernandez", "78023645L"));
            lista.Add(new clsPersona("Nabil", "Fekir", "78953416L"));
            lista.Add(new clsPersona("Joaquin", "Sanchez", "1205463C"));
            lista.Add(new clsPersona("Sergio", "Canales", "45210369Q"));
            lista.Add(new clsPersona("Borja", "Iglesias", "36521348Ñ"));
            lista.Add(new clsPersona("Marc", "Bartra", "45107896L"));
            lista.Add(new clsPersona("Alex", "Moreno", "78369478P"));
            lista.Add(new clsPersona("Luiz", "Henrique", "25314598H"));


            return lista;
        }
    }
}