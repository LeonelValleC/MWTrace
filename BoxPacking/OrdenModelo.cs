using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxPacking
{
    class OrdenModelo : Conexion
    {
        static int id_Omodelo;
        static string workorder;
        int cantidad;
        int id_modelo;
        int id_modeloOrden;
        int uCaja;
        //local variables
        bool exist;


        public int Id_Omodelo { get => id_Omodelo; set => id_Omodelo = value; }
        public string Workorder { get => workorder; set => workorder = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id_modelo { get => id_modelo; set => id_modelo = value; }
        public int Id_modeloOrden { get => id_modeloOrden; set => id_modeloOrden = value; }
        public int UCaja { get => uCaja; set => uCaja = value; }

        public bool VerificationSN(string sn, int id_orden)
        {
            try
            {
                Abrir();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_GetSerialNumbers", Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@sn", sn);
                cmd.Parameters.AddWithValue("@id_orden", id_orden);
                SqlParameter parm = new SqlParameter("@return", SqlDbType.Bit);
                parm.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(parm);

                cmd.ExecuteNonQuery();

                exist = Convert.ToBoolean(int.Parse(parm.Value.ToString()));

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                Cerrar();
            }

            return exist;
        }
    }
}
