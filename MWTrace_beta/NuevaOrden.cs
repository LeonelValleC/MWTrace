using System;
using System.Linq;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class NuevaOrden : Form
    {
        private Conexion con = new Conexion();
        private Orden orden = new Orden();
        private ConfiguracionSistema cs = new ConfiguracionSistema();
        private DateTime fecha = DateTime.Now;

        public NuevaOrden()
        {
            InitializeComponent();
        }

        private void NuevaOrden_Load(object sender, EventArgs e)
        {
            cb_pcb.DataSource = con.LlenarComboBox("select * from tb_PCB");
            cb_pcb.DisplayMember = "pcb";
            cb_pcb.ValueMember = "id_pcb";

            cb_sim.DataSource = con.LlenarComboBox("select * from tb_Sim");
            cb_sim.ValueMember = "id_sim";
            cb_sim.DisplayMember = "sim";

            cb_Model.DataSource = con.LlenarComboBox("select * from tb_Modelo");
            cb_Model.ValueMember = "id_modelo";
            cb_Model.DisplayMember = "modelo";

            cb_operador.DataSource = con.LlenarComboBox("select * from tb_Operador");
            cb_operador.DisplayMember = "numeroempleado";
            cb_operador.ValueMember = "id_operador";

            lbl_fecha.Text = fecha.ToString("MM/dd/yyyy");

            this.cb_pcb.SelectedItem = null;
            // this.cb_modelo.SelectedItem = null;
            this.cb_sim.SelectedItem = null;
            this.cb_operador.SelectedItem = null;
            this.cb_Model.SelectedItem = null;

            try
            {
                dataGridView1.DataSource = con.LlenarDG("select orden,fechaOrden from tb_Orden where FechaCierre IS NULL").Tables[0];
                //int nRowIndex = dataGridView1.Rows.Count - 1;
                //dataGridView1.Rows[nRowIndex].Selected = true;
                //dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
                //dataGridView1.CurrentCell = dataGridView1.Rows[nRowIndex].Cells[0];
                //dataGridView1.Refresh();
            }
            catch { MessageBox.Show("ERROR!", "no se encontro la base de datos!"); }
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //Se obtinen el consecutivo y la nomclatura de la base de datos de la tabla ConfiguracionSistema
            //Insercion en la tabla tb_Orden
            if (!string.IsNullOrEmpty(txt_cantidad.Text.Trim()) && !string.IsNullOrEmpty(txt_orden.Text.Trim()) && !string.IsNullOrEmpty(txt_revision.Text.Trim()) && !string.IsNullOrEmpty(txt_RevisionFirmware.Text.Trim()) &&
                cb_Model.SelectedIndex != -1 && cb_operador.SelectedIndex != -1 && cb_pcb.SelectedIndex != -1 && cb_sim.SelectedIndex != -1)
            {
            if (!orden.Existe("select COUNT(*) from tb_Orden where orden = '" + txt_orden.Text + "'"))
            {

                //orden.Crud("insert into tb_orden (orden, cantidad, fechaOrden, id_modelo, id_pcb, id_sim, id_operador, RevisionFirmware, Revision) values(" + txt_orden.Text + " , " + txt_cantidad.Text + " , '" + fecha.ToString("MM/dd/yyyy") + "'," + cb_modelo.SelectedValue + "," + cb_pcb.SelectedValue + "," + cb_sim.SelectedValue + "," + cb_operador.SelectedValue + ",'" + txt_RevisionFirmware.Text + "','" + txt_revision.Text + "')");
                orden.Crud("insert into tb_orden (orden, cantidad, fechaOrden, id_pcb, id_sim, id_modelo,RevisionFirmware, Revision) values(" + txt_orden.Text + " , " + txt_cantidad.Text + " , '" + fecha.ToString("MM/dd/yyyy") + "'," + cb_pcb.SelectedValue + "," + cb_sim.SelectedValue + "," + cb_Model.SelectedValue + ",'" + txt_RevisionFirmware.Text + "','" + txt_revision.Text + "')");

                MessageBox.Show("Nueva orden registrada!");
                txt_cantidad.Text = "";
                txt_orden.Text = "";
                //cb_modelo.SelectedItem = null;
                cb_pcb.SelectedItem = null;
                cb_Model.SelectedItem = null;
                cb_sim.SelectedItem = null;
                cb_operador.SelectedItem = null;
                //txt_CajaPallette.Text = "";
                //txt_Ucaja.Text = "";
                txt_RevisionFirmware.Text = "";
                txt_revision.Text = "";
                NuevaOrden_Load(sender, e);
            }
            else { MessageBox.Show("Esta orden ya existe!", "ERROR!"); }

            }else
                MessageBox.Show("Campos Vacios!", "ERROR!");


            //}
            //catch (SqlException)
            //{
            //    MessageBox.Show("ERROR!","WARNING!");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Llena la info!", "ERROR!");
            //}
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void Cb_pcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cb_pcb.SelectedValue.ToString() != null)
            {
                //string sql = string.Format("select m.* from tb_Modelo m join tb_PCBModelo pm  on pm.id_modelo = m.id_modelo right join tb_PCB p on pm.id_pcb = p.id_pcb where p.id_pcb = " + cb_pcb.SelectedValue);
                //cb_modelo.DataSource = con.LlenarComboBox(sql);
                //cb_modelo.DisplayMember = "modelo";
                //cb_modelo.ValueMember = "id_modelo";
                //cb_modelo.Enabled = true;
            }
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Find last visible row
            DataGridViewRow row = dataGridView1.Rows.Cast<DataGridViewRow>().Where(r => r.Visible).Last();
            // scroll to last row if necessary
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.IndexOf(row);
            // select row
            row.Selected = true;
        }
    }
}