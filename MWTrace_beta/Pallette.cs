namespace MWTrace_beta
{
    internal class Pallette : Conexion
    {
        private int id_pallette;
        private int pallette;
        private int top;
        private int contador;

        public int Id_pallette { get => id_pallette; set => id_pallette = value; }
        public int Pallettes { get => pallette; set => pallette = value; }
        public int Top { get => top; set => top = value; }
        public int Contador { get => contador; set => contador = value; }
    }
}