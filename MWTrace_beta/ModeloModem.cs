namespace MWTrace_beta
{
    internal class ModeloModem : Conexion
    {
        private int id_mm;
        private string modelo;
        private int numero;

        public int Id_mm { get => id_mm; set => id_mm = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}