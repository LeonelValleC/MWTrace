using System;
using System.Data;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class Retrabajo : Form
    {
        private readonly ModeloOrden modeloorden = new ModeloOrden();
        private DataView filtro;
        private readonly Orden orden = new Orden();
        private int contadorModem = 0, contadorSim = 0;
        Log log = new Log();
        //private readonly Conexion con = new Conexion();
        //private readonly BindingSource bindingsource1 = new BindingSource();
        //private readonly SqlDataAdapter dataAdapter = new SqlDataAdapter();
        //private readonly DataSet res = new DataSet();

        public Retrabajo()
        {
            InitializeComponent();
        }

        private void Retrabajo_Load(object sender, EventArgs e)
        {
            try
            {
                this.filtro = modeloorden.Leer_Datos("select sim.sim, mo.Serialnumber, mo.scanmodem, mo.scansim, o.orden, mo.fecharegistro, mo.Problema , o.Revision, o.RevisionFirmware from tb_Orden o join tb_ModeloOrden mo on o.id_orden = mo.id_orden join tb_PCB pcb on pcb.id_pcb = o.id_pcb join tb_SIM sim on sim.id_sim = o.id_sim ", "tb_ModeloOrden.id_modeloOrden, tb_ModeloOrden.scanmodem, tb_ModeloOrden.scansim , tb_ModeloOrden.fecharegistro, tb_ModeloOrden.id_orden , tb_Orden.orden");
                this.dataGridView1.DataSource = filtro;
            }
            catch { MessageBox.Show("no se encontro la base de datos!", "ERROR!"); }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            //IF PARA VALIDAR QUE NO ESTEN VACIOS LOS CAMPOS
            if (!(string.IsNullOrEmpty(txt_serial.Text)) && !(string.IsNullOrEmpty(txt_serial.Text)) && !(string.IsNullOrEmpty(txt_problema.Text)))
            {
                //Validar que el IMEI sea de 36 caracteres de largo
                if (txt_sacanmodem.TextLength == 36 && txt_scansim.TextLength == 20)
                {
                    //IF PARA SABER QUE EL MODEM NO ESTA REPETIDO
                    if (txt_sacanmodem.Text.Trim() == modeloorden.ReturnValue("select scanmodem from tb_ModeloOrden where Serialnumber = '"+txt_serial.Text.Trim()+"'") || !(modeloorden.Existe("select COUNT(*) from tb_ModeloOrden where scanmodem = '" + txt_sacanmodem.Text.Trim() + "'")))
                    {
                        //IF PARA SABER QUE LA SIM NUMBER NO ESTA REPETIDO
                        if (txt_scansim.Text.Trim() == modeloorden.ReturnValue("select scansim from tb_ModeloOrden where Serialnumber = '" + txt_serial.Text.Trim() + "'") || !modeloorden.Existe("select COUNT(*) from tb_ModeloOrden where scansim = '" + txt_scansim.Text.Trim() + "'"))
                        {


                            modeloorden.Crud("update tb_ModeloOrden set scanmodem = '" + txt_sacanmodem.Text + "' , scansim = '" + txt_scansim.Text + "' , Problema = '" + txt_problema.Text + "' where Serialnumber = '" + txt_serial.Text + "'");
                            log.Crud("insert into tb_Log (id_modeloOrden, scanmodem, scansim, Serialnumber,Problema, id_orden, fecharegistro, id_operador, id_caja, status) values('" + modeloorden.Id_modeloOrden + "','" + modeloorden.Id_scanmodem +
                                "','" + modeloorden.Id_scansim +
                                "','" + modeloorden.Serialnumber1 + "','" + modeloorden.Problema + "','" + orden.Id_orden + "','" + modeloorden.Datescan + "','" + modeloorden.Id_operador +
                                "','" + modeloorden.Id_caja + "','REWORK')");
                            MessageBox.Show("Changes complete!");
                            Retrabajo_Load(sender, e);
                            TextBoxToEmpty();

                        }
                        else
                            MessageBox.Show("Sim Number is already exist!");
                    }
                    else
                        MessageBox.Show("Modem/IMEI Number is already exist!");


                }
                else
                { MessageBox.Show("El IMIE debe de ser de 36 caracteres y el SIM de 20"); }
            }
            else
            { MessageBox.Show("No dejes ningun campo vacio!", "ERROR!"); }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                orden.Cerrar();
                var leer = orden.Leer("Select * from tb_ModeloOrden where Serialnumber = '" + txt_serial.Text.ToUpper() + "'");

                if (leer.Read() == true)
                {

                    txt_sacanmodem.Text = modeloorden.Id_scanmodem = leer["scanmodem"].ToString();
                    txt_scansim.Text = modeloorden.Id_scansim = leer["scansim"].ToString();
                    modeloorden.Id_modeloOrden = int.Parse(leer["id_modeloOrden"].ToString());
                    modeloorden.Problema = leer["Problema"].ToString();
                    orden.Id_orden = int.Parse(leer["id_orden"].ToString());
                    modeloorden.Datescan = DateTime.Parse(leer["fecharegistro"].ToString());
                    modeloorden.Serialnumber1 = leer["Serialnumber"].ToString();
                    modeloorden.Id_caja = int.Parse(leer["id_caja"].ToString());
                    //modeloorden.Id_operador = int.Parse(leer["id_operador"].ToString());

                }
                else
                {
                    txt_sacanmodem.Text = "";
                    txt_scansim.Text = "";
                }
                orden.Cerrar();
            }
            catch (Exception)
            {
                orden.Cerrar();
                //throw;
            }
        }

        private void Txt_sacanmodem_TextChanged(object sender, EventArgs e)
        {
            contadorModem = txt_sacanmodem.Text.Length;
            lbl_scanmodem.Text = contadorModem.ToString();
        }

        private void Txt_scansim_TextChanged(object sender, EventArgs e)
        {
            contadorSim = txt_scansim.Text.Length;
            lbl_scansim.Text = contadorSim.ToString();
        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabra_busqueda = this.txt_buscar.Text.Split(' ');

            foreach (string palabra in palabra_busqueda)
            {
                if (cb_orden.Text == "Serial Number")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = "(Serialnumber LIKE '%" + palabra + "%')";
                    else
                        salida_datos += " AND (Serialnumber LIKE '%" + palabra + "%')";
                }

                if (cb_orden.Text == "Scan Modem")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = "(scanmodem LIKE '%" + palabra + "%')";
                    else
                        salida_datos += " AND (scanmodem LIKE '%" + palabra + "%')";
                }

                if (cb_orden.Text == "Scan Sim")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = "(scansim LIKE '%" + palabra + "%')";
                    else
                        salida_datos += " AND (scansim LIKE '%" + palabra + "%')";
                }

                if (cb_orden.Text == "Orden")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = string.Format("CONVERT(orden, System.String) LIKE '{0}%'", palabra);
                    else
                        salida_datos += " AND (orden LIKE % '" + palabra + " %')";
                }
                if (cb_orden.Text == "Caja")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = string.Format("CONVERT(caja, System.String) LIKE '{0}'", palabra);
                    else
                        salida_datos += " AND (caja LIKE % '" + palabra + " %')";
                }
                if (cb_orden.Text == "Pallette")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = string.Format("CONVERT(pallette, System.String) LIKE '%{0}'", palabra);
                    else
                        salida_datos += " AND (pallette LIKE % '" + palabra + " %')";
                }

                this.filtro.RowFilter = salida_datos;
            }
        }

        private void TextBoxToEmpty()
        {
            txt_problema.Text = "";
            txt_sacanmodem.Text = "";
            txt_scansim.Text = "";
        }
    }
}