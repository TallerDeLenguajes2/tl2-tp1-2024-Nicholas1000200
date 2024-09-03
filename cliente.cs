namespace Pedidosya
{
    class Cliente
    {
        private string Nombre{get;set;}
        private string Direccion{get;set;}
        private string Tel{get;set;}
        private string DatosReferenciaDireccion{get;set;}

        public Cliente(string nombre, string direccion, string tel, string datosReferenciaDireccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Tel = tel;
            this.DatosReferenciaDireccion = datosReferenciaDireccion;
        }
    }
}