using System;

namespace BoxPacking
{
    internal class Orden : Conexion
    {
        private int id_orden;
        private static double orden;
        private int cantidad;
        private int id_pcb;
        private int id_modelo;
        private int id_sim;
        private DateTime fechaOrden;

        public int Id_orden { get => id_orden; set => id_orden = value; }
        public double Ordenes { get => orden; set => orden = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id_pcb { get => id_pcb; set => id_pcb = value; }
        public int Id_modelo { get => id_modelo; set => id_modelo = value; }
        public DateTime FechaOrden { get => fechaOrden; set => fechaOrden = value; }
        public int Id_sim { get => id_sim; set => id_sim = value; }
    }
}