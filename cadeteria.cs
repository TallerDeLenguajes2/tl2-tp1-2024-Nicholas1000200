using cadete;
namespace cadeteria
{
    class Cadeteria
    {
        private string Nombre;
        private string Telefono;
        private List<Cadete>listaCadetes;

        public Cadeteria()
        {
            this.listaCadetes = new List<Cadete>();
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
    }
}