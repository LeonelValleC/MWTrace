namespace MWTrace_beta
{
    internal class Family : Conexion
    {
        private int id_fmaily;
        private string family;
        private int consecutivo;
        private int code;

        public int Id_fmaily { get => id_fmaily; set => id_fmaily = value; }
        public string Familys { get => family; set => family = value; }
        public int Consecutivo { get => consecutivo; set => consecutivo = value; }
        public int Code { get => code; set => code = value; }
    }
}