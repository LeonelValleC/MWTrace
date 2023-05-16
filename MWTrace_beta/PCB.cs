namespace MWTrace_beta
{
    internal class PCB : Conexion
    {
        private int id_pcb;
        private string pcb;

        public int Id_pcb { get => id_pcb; set => id_pcb = value; }
        public string Pcb { get => pcb; set => pcb = value; }
    }
}