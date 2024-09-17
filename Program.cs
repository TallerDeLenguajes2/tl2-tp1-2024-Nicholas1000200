// See https://aka.ms/new-console-template for more information
namespace Pedidosya
{
    class Program
    {
        static void Main()

        {
            AccesoADatos accesoadatos;
            Console.WriteLine("Ingrese el tipo de acceso a los datos:");
            Console.WriteLine("1.CSV:");
            Console.WriteLine("2.JSON");
            int op = 0;
            int.TryParse(Console.ReadLine(), out op);
            if (op == 1)
            {
                accesoadatos = new AccesoCSV("cadeteriacsv.csv","cadetecsv.csv");
            }
            else if (op == 2)
            {
                accesoadatos = new AccesoJSON("cadeteria.json","cadetes.json");
            }
            else
            {
                Console.WriteLine("Seleccion Invalida");
                return;
            }

            Cadeteria cadeteria = accesoadatos.CargarCadeteria();
            List<Cadete> cadetes = accesoadatos.CargarCadetes();
            foreach (var cadete in cadetes)
            {
                cadeteria.AgregarCadetedeCSVaListaCadetes(cadete);
            }
            int opcion = 0;
            Pedidos pedido = null;
            do
            {
                Texto.Menu();

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        pedido = Pedidos.DarAlta();
                        cadeteria.AgregarPedido(pedido);
                        Console.WriteLine(pedido.Numero);
                        break;
                    case 2:
                        cadetes = cadeteria.ObtenerCadetes();
                        Console.WriteLine("Cadetes");
                        foreach (var cadete in cadetes)
                        {
                            Console.WriteLine(cadete.Id);
                            Console.WriteLine("--------");
                        }
                        Console.WriteLine("Ingrese el ID del cadete:");
                        string idCadete = Console.ReadLine();
                        Console.WriteLine("Ingrese el número de pedido:");
                        string numPedido = Console.ReadLine();
                        cadeteria.AsignarPedidoACadete(idCadete,numPedido);
                        break;
                    case 3:
                        cadetes = cadeteria.ObtenerCadetes();
                        Console.WriteLine("Cadetes");
                        foreach (var cadete in cadetes)
                        {
                            Console.WriteLine(cadete.Id);
                            Console.WriteLine("---------");
                        }
                        Console.WriteLine("Ingrese el ID del cadete:");
                        idCadete = Console.ReadLine();
                        double jornal = cadeteria.JornalACobrar(idCadete);
                        Console.WriteLine($"El jornal a cobrar es: {jornal}");
                        break;
                    default:
                        break;
                }
            } while (opcion != 4);

        }
    }
}
