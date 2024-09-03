// See https://aka.ms/new-console-template for more information
namespace Pedidosya
{
    class Program
    {
        static void Main()
        {
            Cadeteria cadeteria = manejoArchivos.ObtenerElPrimerElementoLista("cadeteriacsv.csv");
            List<Cadete> listaCadete = manejoArchivos.ListaCadetes("cadetecsv.csv");
            foreach (var item in listaCadete)
            {
                cadeteria.AgregarCadetedeCSVaListaCadetes(item);
            }
            int opcion = 0;
            Pedidos pedido = null;
            List<Cadete> cadetes = null;
            Cadete cadete = null;
            Random rnd = new Random();
            do
            {
                Texto.Menu();

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        pedido = Pedidos.DarAlta();
                        break;
                    case 2:
                        cadetes = cadeteria.ObtenerCadetes();
                        cadetes[rnd.Next(0, cadetes.Count)].AsignarPedido(pedido);
                        pedido = null;
                        break;
                    case 3:
                        cadetes = cadeteria.ObtenerCadetes();
                        foreach (var item in cadetes)
                        {
                            Console.WriteLine(item.ObtenerId());
                        }
                        Console.WriteLine("Ingrese el numero de Cadete");
                        string numCadete = Console.ReadLine();
                        cadete = cadetes.Find(x => x.ObtenerId() == numCadete);
                        foreach (var item in cadete.ObtenerPedidos())
                        {
                            Console.WriteLine(item.ObtenerNumero());
                        }
                        Console.WriteLine("ingrese eL Numero de pedido");
                        string numPedido = Console.ReadLine();
                        foreach (var item in cadete.ObtenerPedidos())
                        {
                            if (item.ObtenerNumero() == numPedido)
                            {
                                item.CambiarEstado();
                            }
                        }

                        break;
                    case 4:

                        cadetes = cadeteria.ObtenerCadetes();
                        foreach (var item in cadetes)
                        {
                            Console.WriteLine(item.ObtenerId());
                        }
                        Console.WriteLine("Ingrese el numero de Cadete");
                        numCadete = Console.ReadLine();
                        cadete = cadetes.Find(x => x.ObtenerId() == numCadete);
                        foreach (var item in cadete.ObtenerPedidos())
                        {
                            Console.WriteLine(item.ObtenerNumero());
                        }
                        Console.WriteLine("ingrese eL Numero de pedido");
                        numPedido = Console.ReadLine();
                        foreach (var item in cadete.ObtenerPedidos())
                        {
                            if (item.ObtenerNumero() == numPedido)
                            {
                                pedido = item;
                            }
                        }
                        cadetes[rnd.Next(0,cadetes.Count)].AsignarPedido(pedido);
                        pedido = null;
                        break;
                    case 5:
                        break;
                    case 6:
                        return;
                    default:
                        break;
                }
            } while (opcion != 6);

        }
    }
}
