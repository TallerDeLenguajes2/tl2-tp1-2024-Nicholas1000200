using System.ComponentModel;


namespace Pedidosya
{
    public class manejoArchivos
    {
        public static List<Cadeteria> LeerCadeterias(string ruta)
        {
            List<Cadeteria> ListaCadeterias = new List<Cadeteria>();
            try
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (var item in lineas)
                {
                    string[] datos = item.Split(",");
                    Cadeteria cadeteria = new Cadeteria(datos[0],datos[1]);
                    ListaCadeterias.Add(cadeteria);
                }
                return ListaCadeterias;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public static List<Cadete> ListaCadetes(string ruta){
            List<Cadete>ListaCadetes = new List<Cadete>();
            try
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (var item in lineas)
                {
                    string [] datos = item.Split(",");
                    Cadete cadete = new Cadete(datos[0],datos[1],datos[2],new List<Pedidos>());
                    ListaCadetes.Add(cadete);
                }
                return ListaCadetes;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);                
                throw;
            }
        }
                public static Cadeteria ObtenerElPrimerElementoLista(string ruta)
        {
            return LeerCadeterias(ruta).ElementAt(0);
        }
    }
}