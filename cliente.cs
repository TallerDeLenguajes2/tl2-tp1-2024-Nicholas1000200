namespace Pedidosya
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }
        public string Tel { get; private set; }
        public string DatosReferenciaDireccion { get; private set; }

        public Cliente(string nombre, string direccion, string tel, string datosReferenciaDireccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Tel = tel;
            this.DatosReferenciaDireccion = datosReferenciaDireccion;
        }
    }
}