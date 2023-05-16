namespace MWTrace_beta
{
    internal class PCBModelo : Conexion
    {
        private int id_PM;
        private int id_pcb;
        private int id_modelo;
        private string descripcion;
        private string nomenclatura;

        public int Id_PM { get => id_PM; set => id_PM = value; }
        public int Id_pcb { get => id_pcb; set => id_pcb = value; }
        public int Id_modelo { get => id_modelo; set => id_modelo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nomenclatura { get => nomenclatura; set => nomenclatura = value; }
    }
}