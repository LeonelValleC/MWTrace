namespace MWTrace_beta
{
    internal class Modelo : Conexion
    {
        private int id_modelo;
        private string modelo;

        public int Id_modelo { get => id_modelo; set => id_modelo = value; }
        public string Modelos { get => modelo; set => modelo = value; }
    }
}