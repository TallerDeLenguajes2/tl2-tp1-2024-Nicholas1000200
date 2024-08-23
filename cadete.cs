using Pedido;
namespace cadete
{
    class Cadete
    {
        private int id;
        private string nombre;
        private string direccion;
        private string tel;

        private List<Pedidos>ListadoPedidos;

        public Cadete()
        {
            this.ListadoPedidos =new List<Pedidos>();
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Tel { get => tel; set => tel = value; }

        public void JornalAcobrar(){}

    }
}