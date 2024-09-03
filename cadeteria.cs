
namespace Pedidosya 
{
    class Cadeteria
    {
        private string Nombre {get; set;}
        private string Telefono {get; set;}
        private List<Cadete> ListaCadetes {get; set;}
        public Cadeteria(string Nombre, string Telefono)
        {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.ListaCadetes = new List<Cadete>();
        }
        public void AgregarCadetedeCSVaListaCadetes(Cadete cadete){
            this.ListaCadetes.Add(cadete);
        }
        public List<Cadete> ObtenerCadetes(){
            return this.ListaCadetes;
        }
    }
}