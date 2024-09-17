
namespace Pedidosya
{
    public class Cadeteria
    {
        public string Nombre { get; private set; }
        public string Telefono { get; private set; }
        private List<Cadete> ListaCadetes { get; set; }

        private List<Pedidos> Pedidos { get; set; }
        public Cadeteria(string Nombre, string Telefono, List<Cadete> cadetes = null, List<Pedidos> pedidos = null)
        {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.ListaCadetes = cadetes ?? new List<Cadete>();
            this.Pedidos = pedidos ?? new List<Pedidos>();
        }
        public void AgregarCadetedeCSVaListaCadetes(Cadete cadete)
        {
            this.ListaCadetes.Add(cadete);
        }
        public List<Cadete> ObtenerCadetes()
        {
            return this.ListaCadetes;
        }
        public void AgregarPedido(Pedidos pedido)
        {
            this.Pedidos.Add(pedido);
        }
        public List<Pedidos> ObtenerPedidos()
        {
            return this.Pedidos;
        }
        public void AsignarPedidoACadete(string idCadete, string idPedido)
        {
            Cadete cadete = ListaCadetes.Find(c => c.Id == idCadete);
            Pedidos pedido = Pedidos.Find(p => p.Numero == idPedido);

            if (cadete != null && pedido != null)
            {
                pedido.AsignarCadete(cadete);
                Console.WriteLine($"Pedido {idPedido} asignado al cadete {cadete.Nombre}.");
            }
            else
            {
                Console.WriteLine("Error al asignar el pedido");
            }
        }
        public double JornalACobrar(string idCadete){
            Cadete cadete = ListaCadetes.Find(c => c.Id == idCadete);
            if (cadete != null)
            {
                return Pedidos.Where(p => p.CadeteAsignado?.Id == idCadete).Count() * 500;
            }
            return 0;
        }
    }
}