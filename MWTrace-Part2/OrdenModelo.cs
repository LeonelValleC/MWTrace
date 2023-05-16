using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWTrace_Part2
{
    class OrdenModelo : Conexion
    {
        int id_Omodelo;
        static string workorder;
        int cantidad;
        int id_Modelo;
        int id_ModeloOrden;
        int restantes;
        //local variables
        bool exist;
        int total;

        public int Id_Omodelo { get => id_Omodelo; set => id_Omodelo = value; }
        public string Workorder { get => workorder; set => workorder = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id_Modelo { get => id_Modelo; set => id_Modelo = value; }
        public int Id_ModeloOrden { get => id_ModeloOrden; set => id_ModeloOrden = value; }
        public int Total { get => total; set => total = value; }
        public int Restantes { get => restantes; set => restantes = value; }

        public bool VerificationSN(string sn)
        {
            try
            {
                Abrir();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_GetSerialNumbers", Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@sn", sn);
                //cmd.Parameters.AddWithValue("@id_orden", id_orden);
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
