using System;

namespace MWTrace_beta
{
    class Log : Conexion
    {
		public int id_log { get; set; }
		public int id_modeloOrden { get; set; }
		public string scanmodem { get; set; }
		public string scansim { get; set; }
		public string Serialnumber { get; set; }
		public int id_orden { get; set; }
		public DateTime fecharegistro { get; set; }
		public string problema { get; set; }
		public int id_operador { get; set; }
		public int id_caja { get; set; }
		public string status { get; set; }
	}
}
