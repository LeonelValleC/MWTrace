using System;
using System.Data;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class Status : Form
    {
        private Orden orden = new Orden();

        public Status()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            EjecutarSP();
            dataGridView1.DataSource = orden.LlenarDG("select orden, p.pcb,FechaOrden,cantidad, Restantes from tb_orden o join tb_PCB p on o.id_pcb = p.id_pcb where FechaCierre is null and Restantes != 0").Tables[0];
            dataGridView2.DataSource = orden.LlenarDG("select orden, p.pcb,FechaOrden,cantidad, Restantes from tb_orden o join tb_PCB p on o.id_pcb = p.id_pcb where Restantes = 0").Tables[0];
        }

        private void EjecutarSP()
        {
            Conexion con = new Conexion();

            try
            {
                con.Abrir();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_EstatusOrdenes", con.Con1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_orden", 0);

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