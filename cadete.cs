
namespace Pedidosya
{
    public class Cadete
    {

        public string Id{get; private set;}
        public string Nombre{get; private set;}
        public string Direccion{get; private set;}
        public string Tel{get; private set;}



        private Random rnd = new Random();

        public Cadete(string nombre, string direccion, string tel, List<Pedidos> listadoPedidos = null)
        {
            Id = rnd.Next(0,10000).ToString();
            Nombre = nombre;
            Direccion = direccion;
            Tel = tel;
        }
        
    }
}