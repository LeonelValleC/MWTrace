using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MWTrace_beta
{
    internal class ModeloOrden : Conexion
    {
        private int id_modeloOrden;
        private string id_scanmodem;
        private string id_scansim;
        private String Serialnumber;
        private int id_Orden;
        private bool Checked;
        private int id_caja;
        DateTime datescan;
        string problema;
        int id_operador;
        List<string> seriales = new List<string>();
        DateTime labelVerify;


        public int Id_modeloOrden { get => id_modeloOrden; set => id_modeloOrden = value; }
        public string Id_scanmodem { get => id_scanmodem; set => id_scanmodem = value; }
        public string Id_scansim { get => id_scansim; set => id_scansim = value; }
        public string Serialnumber1 { get => Serialnumber; set => Serialnumber = value; }
        public int Id_Orden { get => id_Orden; set => id_Orden = value; }
        public bool Checked1 { get => Checked; set => Checked = value; }
        public int Id_caja { get => id_caja; set => id_caja = value; }
        public DateTime Datescan { get => datescan; set => datescan = value; }
        public string Problema { get => problema; set => problema = value; }
        public int Id_operador { get => id_operador; set => id_operador = value; }
        public List<string> Seriales { get => seriales; set => seriales = value; }
        public DateTime LabelVerify { get => labelVerify; set => labelVerify = value; }

        public List<ModeloOrden> GetModeloOrden(string comando)
        {
            List<ModeloOrden> ordenes = new List<ModeloOrden>();

            Abrir();
            using (var command = new SqlCommand(comando, Con1))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var MO = new ModeloOrden();
                        MO.Id_modeloOrden = int.Parse(reader["id_modeloOrden"].ToString());
                        MO.Id_Orden = int.Parse(reader["id_orden"].ToString());
                        MO.Serialnumber1 = reader["Serialnumber"].ToString();
                        MO.Id_caja = int.Parse(reader["id_caja"].ToString());
                        ordenes.Add(MO);
                    }
                }
            }

            return ordenes;
        }
    }
}