using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWTrace_Part2
{
    public partial class Status : Form
    {
        private readonly OrdenModelo om = new OrdenModelo();
        public Status()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            Estatus();
            dg_Status.DataSource = om.LlenarDG("SELECT om.workorder, m.modelo, om.fecha, om.cantidad, om.Restantes from tb_OrdenModelo om join tb_Modelo m on om.id_modelo = m.id_modelo where om.Restantes != 0").Tables[0];
            dg_Cerradas.DataSource = om.LlenarDG("SELECT om.workorder, m.modelo, om.fecha, om.cantidad, om.Restantes from tb_OrdenModelo om join tb_Modelo m on om.id_modelo = m.id_modelo where om.Restantes = 0").Tables[0];
        }

        private void Estatus()
        {
            //Conexion con = new Conexion();

            try
            {
                om.Abrir();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_Estatus", om.Con1)
                {
                    CommandType = CommandType.StoredProcedure
                };


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                om.Cerrar();
            }
        }
    }
}
