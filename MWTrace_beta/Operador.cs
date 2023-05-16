namespace MWTrace_beta
{
    internal class Operador : Conexion
    {
        private static int id_operador;
        private string nombre;
        private static int numeroempleado;

        public int Id_operador { get => id_operador; set => id_operador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Numeroempleado { get => numeroempleado; set => numeroempleado = value; }
    }
}