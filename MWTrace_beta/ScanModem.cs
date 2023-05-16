namespace MWTrace_beta
{
    internal class ScanModem : Conexion
    {
        private int id_Scanmodem;
        private string scanmodem;
        private string serialModem;
        private string Modelo;
        private int id_PM;

        public int Id_Scanmodem { get => id_Scanmodem; set => id_Scanmodem = value; }
        public string Scanmodem { get => scanmodem; set => scanmodem = value; }
        public string SerialModem { get => serialModem; set => serialModem = value; }
        public string Modelo1 { get => Modelo; set => Modelo = value; }
        public int Id_PM { get => id_PM; set => id_PM = value; }
    }
}