
namespace Pedidosya
{
    enum Estado
    {
        Proceso,
        Entregado,
        EnCamino
    }
    public class Pedidos
    {
        public string Numero { get; private set; }
        public string Observaciones { get; private set; }

        public Cliente Cliente { get; private set; }

        public Cadete CadeteAsignado { get; private set; }


        private Random rnd = new Random();

        public Pedidos(string observaciones, string nombre, string tel, string direcc, string refdirecc)
        {
            this.Cliente = new Cliente(nombre, direcc, tel, refdirecc);
            this.Numero = rnd.Next(0, 10000).ToString();
            this.Observaciones = observaciones;
        }

        private enum Estado;

        public static Pedidos DarAlta()
        {
            Console.WriteLine("Dar de alta un pedido");
            Console.WriteLine("Escriba las observaciones del pedido");
            string observaciones = Console.ReadLine();
            Console.WriteLine("Escriba el nombre del cliente");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba la direccion del cliente");
            string direccion = Console.ReadLine();
            Console.WriteLine("Escriba el telefono del cliente");
            string telefono = Console.ReadLine();
            Console.WriteLine("Escriba la referencia del cliente");
            string referencia = Console.ReadLine();
            Pedidos pedido = new Pedidos(observaciones, nombre, direccion, telefono, referencia);

            return pedido;
        }
        public void AsignarCadete(Cadete cadete)
        {
            this.CadeteAsignado = cadete;
        }
        public string ObtenerNumero()
        {
            return this.Numero;
        }
        public static void MostrarPedido(Pedidos pedido)
        {
            Console.WriteLine("/-------------\\");
            Console.WriteLine("Numero de pedido: " + pedido.Numero);
            Console.WriteLine("Nombre de cliente del pedido: " + pedido.Cliente.Nombre);
            Console.WriteLine("Observacion del pedido: " + (pedido.Observaciones == "" ? "no observacion" : pedido.Observaciones));
            Console.WriteLine("\\-------------/");
        }
        /*         public string VerDireccionCliente()
                {
                    return cliente.Direccion;
                }

                public void VerDatosCliente()
                {
                    Cliente cliente = new Cliente();
                    Console.WriteLine(cliente.Nombre);
                    Console.WriteLine(cliente.Tel);
                    Console.WriteLine(cliente.Direccion);
                    Console.WriteLine(cliente.DatosReferenciaDireccion);
                } */
    }
}