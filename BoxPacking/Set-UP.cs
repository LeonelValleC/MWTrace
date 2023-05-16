using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxPacking
{
    public partial class Set_UP : Form
    {
        Operador operador = new Operador();
        OrdenModelo om = new OrdenModelo();
        public Set_UP()
        {
            InitializeComponent();
        }

        private void Set_UP_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            om.Id_Omodelo = int.Parse(om.ReturnID("select id_Omodelo from tb_OrdenModelo where workorder = '" + txt_WO.Text + "'"));
            om.Workorder = txt_WO.Text;
            operador.Numeroempleado = int.Parse(txt_NEmpleado.Text);
            Sp_SnBox();
            Packing packing = new Packing();
            packing.Show();
        }

        private void Sp_SnBox()
        {
            Conexion con = new Conexion();

            try
            {
                con.Abrir();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_SnBox", con.Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SN", txt_SNInit.Text);
                cmd.Parameters.AddWithValue("@WO", txt_WO.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Cerrar();
            }
        }

    }
}
