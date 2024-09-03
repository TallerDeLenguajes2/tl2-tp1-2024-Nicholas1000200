
namespace Pedidosya
{
    class Cadete
    {

        private string Id{get; set;}
        private string Nombre{get; set;}
        private string Direccion{get; set;}
        private string Tel{get; set;}

        private List<Pedidos>ListadoPedidos{get; set;}

        private Random rnd = new Random();

        public Cadete(string nombre, string direccion, string tel, List<Pedidos> listadoPedidos)
        {
            Id = rnd.Next(0,10000).ToString();
            Nombre = nombre;
            Direccion = direccion;
            Tel = tel;
            ListadoPedidos = listadoPedidos;
        }
        
        public string ObtenerNombre(){
            return this.Nombre;
        }
        public string ObtenerId(){
            return this.Id;
        }
        public List<Pedidos> ObtenerPedidos(){
            return this.ListadoPedidos;
        }

        public void AsignarPedido(Pedidos pedido){
            this.ListadoPedidos.Add(pedido);
        }
    }
}