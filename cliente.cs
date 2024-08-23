namespace cliente
{
    class Cliente
    {
        private string Nombre;
        private string direccion;
        private string tel;
        private string datosReferenciaDireccion;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Tel { get => tel; set => tel = value; }
        public string DatosReferenciaDireccion { get => datosReferenciaDireccion; set => datosReferenciaDireccion = value; }
    }
}