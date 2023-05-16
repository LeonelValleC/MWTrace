namespace MWTrace_beta
{
    internal class Sim : Conexion
    {
        private int id_sim;
        private string sim;
        private int digitos;
        public int Id_sim { get => id_sim; set => id_sim = value; }
        public string Sims { get => sim; set => sim = value; }
        public int Digitos { get => digitos; set => digitos = value; }
    }
}