namespace MWTrace_beta
{
    internal class ConfiguracionSistema : Conexion
    {
        private int id_cs;
        private int consecutivo;
        private string nomenclatura;
        private int numerocaja;

        public int Id_cs { get => id_cs; set => id_cs = value; }
        public int Consecutivo { get => consecutivo; set => consecutivo = value; }
        public string Nomenclatura { get => nomenclatura; set => nomenclatura = value; }
        public int Numerocaja { get => numerocaja; set => numerocaja = value; }
    }
}