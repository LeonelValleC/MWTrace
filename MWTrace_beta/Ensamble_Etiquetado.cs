using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class Ensamble_Etiquetado : Form
    {
        private readonly Conexion con = new Conexion();
        private readonly Orden orden = new Orden();
        private readonly ModeloOrden modeloorden = new ModeloOrden();
        private readonly Operador operador = new Operador();
        private readonly Sim sim = new Sim();
        private readonly Caja caja = new Caja();
        private readonly Pallette pallette = new Pallette();
        private readonly Family family = new Family();
        private int contadorIMEI = 0;
        private int contadorSIM = 0;

        public Ensamble_Etiquetado()
        {
            InitializeComponent();

            //timer1.Start();
        }

        private void Ensamble_Etiquetado_Load(object sender, EventArgs e)
        {

            //try
            //{
            LoadParameters();

            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false; // set it to false if not needed
            this.dataGridView1.VirtualMode = true;

            //dataGridView1.DataSource = con.LlenarDG("select distinct mo.id_modeloOrden, mo.scanmodem, mo.scansim, mo.Serialnumber, mo.fecharegistro, o.orden, sm.Modelo from tb_ModeloOrden mo inner join tb_Orden o on mo.id_orden = o.id_orden left join tb_caja c on mo.id_caja = c.id_caja left join tb_Pallette p on c.id_pallette = p.id_pallette left join tb_ScanModem sm on mo.id_modeloOrden = sm.id_modeloOrden where mo.id_orden = " + orden.Id_orden + " order by mo.id_modeloOrden asc ").Tables[0];
            dataGridView1.DataSource = con.LlenarDG("select mo.id_modeloOrden, mo.scanmodem as 'IMEI', mo.scansim as 'SIM', mo.Serialnumber as 'Serial Number', mo.fecharegistro as 'Scan Date', o.orden as 'Work Order', sm.Modelo as 'Model' from tb_ModeloOrden mo inner join tb_Orden o on mo.id_orden = o.id_orden left join tb_ScanModem sm on mo.id_modeloOrden = sm.id_modeloOrden where mo.id_orden = " + orden.Id_orden + " order by mo.id_modeloOrden asc ").Tables[0];
            this.dataGridView1.Columns[0].Visible = false;
            _ = int.Parse(con.ReturnValue("select COUNT(*) from tb_ModeloOrden where scanmodem is not null and scansim is not null and id_orden = " + orden.Id_orden)) - 1;
            if (int.Parse(lbl_registrados.Text) == orden.Cantidad)
            {
                DisableControls();
                MessageBox.Show("Se completo la orden!", "¡Success!");
            }

            LoadConsecutive();

        }

        private void PaintCells()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows[row.Index].Cells[6].Value.ToString() == "")
                    break;

                dataGridView1.Rows[row.Index].Cells[6].Style.BackColor = Color.Purple;
                dataGridView1.Rows[row.Index].Cells[6].Style.ForeColor = Color.White;
            }
        }

        private void LoadParameters()
        {
            orden.Id_orden = int.Parse(orden.ReturnValue("select id_orden from tb_Orden where orden = '" + orden.Ordenes+"'"));

            lbl_serial.Text = orden.Ordenes.ToString();

            lbl_numeroempleado.Text = operador.Numeroempleado.ToString();

            lbl_registrados.Text = modeloorden.ReturnValue("select COUNT(scanmodem) from tb_ModeloOrden where id_orden = " + orden.Id_orden);

            lbl_revision.Text = orden.ReturnValue("select Revision from tb_Orden where id_orden = " + orden.Id_orden);

            lbl_firmware.Text = orden.ReturnValue("select RevisionFirmware from tb_Orden where id_orden = " + orden.Id_orden);

            orden.Cantidad = int.Parse(orden.ReturnValue("select cantidad from tb_Orden where id_orden = " + orden.Id_orden));

            orden.Id_sim = int.Parse(orden.ReturnValue("select id_sim from tb_Orden where id_orden = " + orden.Id_orden));

            sim.Digitos = int.Parse(orden.ReturnValue("select digitos from tb_Sim where id_sim = " + orden.Id_sim));

            //caja.Id_caja = int.Parse(caja.ReturnID("select id_caja from tb_Orden where id_orden = '" + orden.Id_orden + "'"));
            //if (caja.Id_caja < 0)
            //{
            //    SiguienteCaja();
            //    orden.Crud("update tb_Orden set id_caja = '" + caja.Id_caja + "' where id_orden = '" + orden.Id_orden + "'");

            //}

            //caja.Top = int.Parse(orden.ReturnValue(comando: "select Ucaja from tb_Orden where id_orden = " + orden.Id_orden));

            //caja.Contador = int.Parse(modeloorden.ReturnValue("select COUNT(*) from tb_ModeloOrden where id_caja = " + caja.Id_caja));

            //pallette.Id_pallette = int.Parse(pallette.ReturnID("select id_pallette from tb_Orden where id_orden = '" + orden.Id_orden + "'"));
            //if (pallette.Id_pallette < 0)
            //{
            //    SiguientePallette();
            //    orden.Crud("update tb_Orden set id_pallette = '" + pallette.Id_pallette + "' where id_orden = '" + orden.Id_orden + "'");
            //}

            //pallette.Top = int.Parse(orden.ReturnValue(comando: "select Upallette from tb_Orden where id_orden = " + orden.Id_orden));


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int filled, count;
            count = int.Parse(orden.ReturnValue("select cantidad from tb_Orden where id_orden = " + orden.Id_orden));
            filled = int.Parse(modeloorden.ReturnValue("select COUNT(scanmodem) from tb_ModeloOrden where id_orden = " + orden.Id_orden));

            if (filled <= count)
            {
                //IF PARA SABER SI LOS TEXTBOX ESTAN VACIOS
                if (!(string.IsNullOrEmpty(txt_serial.Text)) && !(string.IsNullOrEmpty(txt_serial.Text)))
                {
                    //IF PARA SABER SI EL SERIALNUMER ES EL CONSECUTIVO
                    if (txt_serial.Text == modeloorden.Serialnumber1)
                    {
                        if (!modeloorden.Existe("select COUNT(*) from tb_ModeloOrden where Serialnumber = '" + txt_serial.Text + "'"))
                        {
                            //Validar que el IMEI sea de 36 caracteres de largo
                            if (txt_imei.TextLength == 36)
                            {
                                if (ImeiCorrect().Length == 15)
                                {
                                    //Validar que LA SIM SEA DE 20 / 19 / 16
                                    if (txt_sim.TextLength == sim.Digitos)
                                    {
                                        //Validar que las cajas y pallettes sean consecutivos y sean de la misma orden
                                        //int id_orden = int.Parse(orden.ReturnValue("select id_orden from tb_Orden where orden = " + orden.Ordenes));

                                        //IF PARA SABER QUE EL MODEM NO ESTA REPETIDO
                                        if (!(modeloorden.Existe("select COUNT(*) from tb_ModeloOrden where scanmodem = '" + txt_imei.Text + "'")))
                                        {
                                            //IF PARA SABER QUE LA SIM NUMBER NO ESTA REPETIDO
                                            if (!modeloorden.Existe("select COUNT(*) from tb_ModeloOrden where scansim = '" + txt_sim.Text + "'"))
                                            {
                                                lbl_serialnumber.Text = "CORRECTO";
                                                lbl_serialnumber.BackColor = System.Drawing.Color.Green;

                                                modeloorden.Crud("insert into tb_ModeloOrden(Serialnumber,scanmodem,scansim,fecharegistro,id_orden, id_operador) VALUES('" + txt_serial.Text + "','" + txt_imei.Text + "','" + txt_sim.Text + "','" + DateTime.Now + "' , " + orden.Id_orden + " , " + operador.Id_operador + ")");

                                                //PrintLabel();

                                                IncreaseConsecutive();

                                                Ensamble_Etiquetado_Load(sender, e);

                                                txt_imei.Text = "";
                                                txt_serial.Text = "";
                                                txt_sim.Text = "";

                                                txt_imei.Focus();
                                            }
                                            else
                                            {
                                                //select serialNumber from tb_ModeloOrden where scanmodem = 
                                                string SIMdupiclada = modeloorden.ReturnValue("select serialNumber from tb_ModeloOrden where scansim = '" + txt_sim.Text + "'");
                                                MessageBox.Show("Sim Number is already exist!\nIs belong to Serial: " + SIMdupiclada);
                                                txt_sim.Text = "";
                                                txt_sim.Focus();
                                            }
                                        }
                                        else
                                        {
                                            string IMEIdupiclada = modeloorden.ReturnValue("select serialNumber from tb_ModeloOrden where scanmodem = '" + txt_imei.Text + "'");
                                            MessageBox.Show("Modem/IMEI Number is already exist!\nIs belong to Serial: " + IMEIdupiclada);
                                            txt_imei.Text = "";
                                            txt_imei.Focus();
                                        }
                                    }


                                    else
                                    {
                                        MessageBox.Show("SIM number needs " + sim.Digitos + " characters");
                                        txt_sim.Focus();
                                    }
                                }
                                else
                                {
                                    //MessageBox.Show("No dejes ningun campo vacio!", "ERROR!");
                                    MessageBox.Show("IMEI Number needs 15 characters before ';' ", "ERROR!");
                                    txt_imei.Focus();
                                }
                            }
                            else
                            {
                                //MessageBox.Show("No dejes ningun campo vacio!", "ERROR!");
                                MessageBox.Show("IMEI Number needs 36 characters", "ERROR!");
                                txt_imei.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Serial Number is already exist!", "ERROR");
                            //IncreaseConsecutive();
                            txt_serial.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Serial Number is not consecutive!", "ERROR");
                        txt_serial.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Fiil all data!", "ERROR!");
                    //MessageBox.Show("Orden completada!");
                    //orden.Crud("update tb_Orden set fechacierre = '" + DateTime.Now + "' where id_orden = " + orden.Id_orden);
                    ////this.Close();
                }
            }
            else
            {
                MessageBox.Show("Orden completed!");
                orden.Crud("update tb_Orden set fechacierre = '" + DateTime.Now + "' where id_orden = " + orden.Id_orden);
                //this.Close();
            }
        }

        private void Txt_imei_TextChanged_1(object sender, EventArgs e)
        {
            contadorIMEI = txt_imei.Text.Length;
            lbl_imei.Text = contadorIMEI.ToString();
        }

        private void Txt_sim_TextChanged(object sender, EventArgs e)
        {
            contadorSIM = txt_sim.Text.Length;
            lbl_sim.Text = contadorSIM.ToString();
        }

        private void Button1_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void DisableControls()
        {
            dataGridView1.Enabled = false;
            txt_imei.Enabled = false;
            txt_serial.Enabled = false;
            txt_sim.Enabled = false;
            button1.Enabled = false;
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

        /// <summary>
        /// Metodo para verificar que el IMEI que hay 15 digitos antes del punto y coma.
        /// </summary>
        private string ImeiCorrect()
        {
            string imei15 = "";
            string[] imei = txt_imei.Text.Split(';');
            foreach (var item in imei)
            {
                imei15 = item.ToString();
                break;
            }

            return imei15;
        }

        private void IncreaseConsecutive()
        {
            Conexion con = new Conexion();

            try
            {
                con.Abrir();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("sp_Consecutive", con.Con1)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@id", family.Id_fmaily);

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

        private void LoadConsecutive()
        {
            family.Id_fmaily = int.Parse(modeloorden.ReturnValue("select TOP 1 f.id_family from tb_Orden o join tb_PCB pcb on o.id_pcb = pcb.id_pcb join tb_PCBModelo pm on pm.id_pcb = pcb.id_pcb join tb_Family f on f.id_family = pm.id_family where o.id_orden = " + orden.Id_orden));
            family.Familys = modeloorden.ReturnValue("select TOP 1 f.family from tb_Orden o join tb_PCB pcb on o.id_pcb = pcb.id_pcb join tb_PCBModelo pm on pm.id_pcb = pcb.id_pcb join tb_Family f on f.id_family = pm.id_family where o.id_orden = " + orden.Id_orden);
            family.Consecutivo = int.Parse(modeloorden.ReturnValue("select TOP 1 f.consecutivo from tb_Orden o join tb_PCB pcb on o.id_pcb = pcb.id_pcb join tb_PCBModelo pm on pm.id_pcb = pcb.id_pcb join tb_Family f on f.id_family = pm.id_family where o.id_orden = " + orden.Id_orden));


            modeloorden.Serialnumber1 = family.Familys + family.Consecutivo.ToString().PadLeft(6,'0');

            lbl_consecutive.Text = modeloorden.Serialnumber1;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            family.Id_fmaily = int.Parse(modeloorden.ReturnValue("select TOP 1 f.id_family from tb_Orden o join tb_PCB pcb on o.id_pcb = pcb.id_pcb join tb_PCBModelo pm on pm.id_pcb = pcb.id_pcb join tb_Family f on f.id_family = pm.id_family where o.id_orden = " + orden.Id_orden));
            family.Familys = modeloorden.ReturnValue("select TOP 1 f.family from tb_Orden o join tb_PCB pcb on o.id_pcb = pcb.id_pcb join tb_PCBModelo pm on pm.id_pcb = pcb.id_pcb join tb_Family f on f.id_family = pm.id_family where o.id_orden = " + orden.Id_orden);
            family.Consecutivo = int.Parse(modeloorden.ReturnValue("select TOP 1 f.consecutivo from tb_Orden o join tb_PCB pcb on o.id_pcb = pcb.id_pcb join tb_PCBModelo pm on pm.id_pcb = pcb.id_pcb join tb_Family f on f.id_family = pm.id_family where o.id_orden = " + orden.Id_orden));


            modeloorden.Serialnumber1 = family.Familys + family.Consecutivo;


            //if (family.Consecutivo.ToString().Length == 1)
            //    modeloorden.Serialnumber1 = family.Familys + "00000" + family.Consecutivo;
            //else if (family.Consecutivo.ToString().Length == 2)
            //    modeloorden.Serialnumber1 = family.Familys + "0000" + family.Consecutivo;
            //else if (family.Consecutivo.ToString().Length == 3)
            //    modeloorden.Serialnumber1 = family.Familys + "000" + family.Consecutivo;
            //else if (family.Consecutivo.ToString().Length == 4)
            //    modeloorden.Serialnumber1 = family.Familys + "00" + family.Consecutivo;
            //else if (family.Consecutivo.ToString().Length == 5)
            //    modeloorden.Serialnumber1 = family.Familys + "0" + family.Consecutivo;


            //if (modeloorden.Serialnumber1.Length == 6)
            //    modeloorden.Serialnumber1 += "00000";
            //else if (modeloorden.Serialnumber1.Length == 7)
            //    modeloorden.Serialnumber1 += "0000";
            //else if (modeloorden.Serialnumber1.Length == 8)
            //    modeloorden.Serialnumber1 += "000";
            //else if (modeloorden.Serialnumber1.Length == 8)
            //    modeloorden.Serialnumber1 += "00";
            //else if (modeloorden.Serialnumber1.Length == 9)
            //    modeloorden.Serialnumber1 += "0";

            lbl_consecutive.Text = modeloorden.Serialnumber1;
        }

        private void PrintLabel()
        {
            BarTender.Application btapp;
            BarTender.Format btformat;
            btapp = new BarTender.Application();
            btformat = btapp.Formats.Open(@"C:\Users\leonel.valle\Documents\BarTender\BarTender Documents\testLabel.btw", false, "");
            btformat.PrintSetup.NumberSerializedLabels = 1;
            btformat.SetNamedSubStringValue("SN", txt_serial.Text);
            btformat.PrintOut(true, true);
        }
                
    }
}