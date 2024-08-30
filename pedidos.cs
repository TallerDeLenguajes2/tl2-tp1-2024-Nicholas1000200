using cliente;
namespace Pedido
{
    enum Estado
    {
        Proceso,
        Entregado,
        EnCamino
    }
    public class Pedidos
    {
        private int nro;
        private string obs;

        private Cliente cliente;

        public Pedidos(string nombre,string tel,string direcc,string refdirecc)
        {
            this.cliente = new Cliente(){
                Nombre1 = nombre,Tel = tel, Direccion = direcc,DatosReferenciaDireccion = refdirecc,
            };

        }

        public int Nro { get => nro; set => nro = value; }
        public string Obs { get => obs; set => obs = value; }

        private enum Estado;

        public string VerDireccionCliente(){
            return cliente.Direccion;
        }

        public void VerDatosCliente(){
            Cliente cliente = new Cliente();
            Console.WriteLine(cliente.Nombre1);
            Console.WriteLine(cliente.Tel);
            Console.WriteLine(cliente.Direccion);
            Console.WriteLine(cliente.DatosReferenciaDireccion);
        }
    }
}