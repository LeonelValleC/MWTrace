using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class Reportes : Form
    {
        //private readonly Conexion con = new Conexion();
        //private readonly Orden orden = new Orden();
        private readonly ModeloOrden modeloorden = new ModeloOrden();
        private DataView filtro;

        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                this.filtro = modeloorden.Leer_Datos("select mo.Serialnumber, mo.scanmodem, mo.scansim, sim.sim, o.orden, mo.fecharegistro, mo.Problema , o.Revision, o.RevisionFirmware from tb_Orden o join tb_ModeloOrden mo on o.id_orden = mo.id_orden join tb_PCB pcb on pcb.id_pcb = o.id_pcb join tb_SIM sim on sim.id_sim = o.id_sim ", "tb_ModeloOrden.id_modeloOrden, tb_ModeloOrden.scanmodem, tb_ModeloOrden.scansim , tb_ModeloOrden.fecharegistro, tb_ModeloOrden.id_orden , tb_Orden.orden");
                this.dg_buscar.DataSource = filtro;
            }
            catch { MessageBox.Show("no se encontro la base de datos!", "ERROR!"); }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

            string salida_datos = "";
            string[] palabra_busqueda = this.txt_buscar.Text.Split(' ');

            foreach (string palabra in palabra_busqueda)
            {
                if (cb_filtro.Text == "Serial Number")
                    salida_datos = "select distinct mo.id_modeloOrden as ID e.ensamble, mo.Serialnumber, mo.scanmac, mo.scanimei, mo.qr, o.orden, mo.fecharegistro, c.caja, mo.turno, mo.revision, op.numeroempleado from tb_ModeloOrden mo join tb_Orden o on o.id_orden = mo.id_orden join tb_ModeloOrdenCaja moc on o.id_orden = moc.id_orden join tb_Ensamble e on e.id_ensamble = o.id_ensamble join tb_caja c on c.id_caja = mo.id_caja and c.id_caja = moc.id_caja join tb_Operador op on op.id_operador = o.id_operador join tbUnion_MoCaja u on u.id_modeloOrden = mo.id_modeloOrden and u.id_mocaja = moc.id_mocaja where mo.Serialnumber = '" + txt_buscar.Text + "' OR moc.SerialNumberCaja = '" + txt_buscar.Text + "' order by mo.id_modeloOrden asc";

                if (cb_filtro.Text == "MAC Address")
                    salida_datos = "select distinct mo.id_modeloOrden as ID e.ensamble, mo.Serialnumber, mo.scanmac, mo.scanimei, mo.qr, o.orden, mo.fecharegistro, c.caja, mo.turno, mo.revision, op.numeroempleado from tb_ModeloOrden mo join tb_Orden o on o.id_orden = mo.id_orden join tb_ModeloOrdenCaja moc on o.id_orden = moc.id_orden join tb_Ensamble e on e.id_ensamble = o.id_ensamble join tb_caja c on c.id_caja = mo.id_caja and c.id_caja = moc.id_caja join tb_Operador op on op.id_operador = o.id_operador join tbUnion_MoCaja u on u.id_modeloOrden = mo.id_modeloOrden and u.id_mocaja = moc.id_mocaja where mo.scanmac = '" + txt_buscar.Text + "' OR moc.scanmacCaja = '" + txt_buscar.Text + "' order by mo.id_modeloOrden asc";

                if (cb_filtro.Text == "IMEI Number")
                    salida_datos = "select distinct mo.id_modeloOrden as ID, e.ensamble, mo.Serialnumber, mo.scanmac, mo.scanimei, mo.qr, o.orden, mo.fecharegistro, c.caja, mo.turno, mo.revision, op.numeroempleado from tb_ModeloOrden mo join tb_Orden o on o.id_orden = mo.id_orden join tb_ModeloOrdenCaja moc on o.id_orden = moc.id_orden join tb_Ensamble e on e.id_ensamble = o.id_ensamble join tb_caja c on c.id_caja = mo.id_caja and c.id_caja = moc.id_caja join tb_Operador op on op.id_operador = o.id_operador join tbUnion_MoCaja u on u.id_modeloOrden = mo.id_modeloOrden and u.id_mocaja = moc.id_mocaja where mo.scanimei = '" + txt_buscar.Text + "' OR moc.scanimeiCaja = '" + txt_buscar.Text + "' order by mo.id_modeloOrden asc";

                if (cb_filtro.Text == "Orden")
                    salida_datos = "select distinct mo.id_modeloOrden as ID, e.ensamble, mo.Serialnumber, mo.scanmac, mo.scanimei, mo.qr, o.orden, mo.fecharegistro, c.caja, mo.turno, mo.revision, op.numeroempleado from tb_ModeloOrden mo join tb_Orden o on o.id_orden = mo.id_orden join tb_ModeloOrdenCaja moc on o.id_orden = moc.id_orden join tb_Ensamble e on e.id_ensamble = o.id_ensamble join tb_caja c on c.id_caja = mo.id_caja and c.id_caja = moc.id_caja join tb_Operador op on op.id_operador = o.id_operador join tbUnion_MoCaja u on u.id_modeloOrden = mo.id_modeloOrden and u.id_mocaja = moc.id_mocaja where o.orden = '" + txt_buscar.Text + "' order by mo.id_modeloOrden asc";

                if (cb_filtro.Text == "Caja")
                    salida_datos = "select distinct mo.id_modeloOrden as ID, e.ensamble, mo.Serialnumber, mo.scanmac, mo.scanimei, mo.qr, o.orden, mo.fecharegistro, c.caja, mo.turno, mo.revision, op.numeroempleado from tb_ModeloOrden mo join tb_Orden o on o.id_orden = mo.id_orden join tb_ModeloOrdenCaja moc on o.id_orden = moc.id_orden join tb_Ensamble e on e.id_ensamble = o.id_ensamble join tb_caja c on c.id_caja = mo.id_caja and c.id_caja = moc.id_caja join tb_Operador op on op.id_operador = o.id_operador join tbUnion_MoCaja u on u.id_modeloOrden = mo.id_modeloOrden and u.id_mocaja = moc.id_mocaja where c.caja = '" + txt_buscar.Text + "' order by mo.id_modeloOrden asc";

                if (cb_filtro.Text == "Ensamble")
                    salida_datos = "select distinct mo.id_modeloOrden as ID, mo.partnumber, mo.Serialnumber, mo.scanmac, mo.scanimei, mo.qr, o.orden, mo.fecharegistro, c.caja, mo.turno, mo.revision, op.numeroempleado from tb_ModeloOrden mo join tb_Orden o on o.id_orden = mo.id_orden join tb_ModeloOrdenCaja moc on o.id_orden = moc.id_orden join tb_Ensamble e on e.id_ensamble = o.id_ensamble join tb_caja c on c.id_caja = mo.id_caja and c.id_caja = moc.id_caja join tb_Operador op on op.id_operador = o.id_operador join tbUnion_MoCaja u on u.id_modeloOrden = mo.id_modeloOrden and u.id_mocaja = moc.id_mocaja where mo.partnumber = '" + txt_buscar.Text + "' order by mo.id_modeloOrden asc";
                //salida_datos = "select distinct mo.id_modeloOrden as ID, moc.id_mocaja as IdCaja, e.ensamble, mo.Serialnumber, mo.scanmac, mo.scanimei, mo.qr, moc.SerialNumberCaja, moc.scanmacCaja, moc.scanimeiCaja, moc.qrCaja, o.orden, mo.fecharegistro, c.caja, mo.turno, mo.revision, op.numeroempleado from tb_ModeloOrden mo join tb_Orden o on o.id_orden = mo.id_orden join tb_ModeloOrdenCaja moc on o.id_orden = moc.id_orden join tb_Ensamble e on e.id_ensamble = o.id_ensamble join tb_caja c on c.id_caja = mo.id_caja and c.id_caja = moc.id_caja join tb_Operador op on op.id_operador = o.id_operador join tbUnion_MoCaja u on u.id_modeloOrden = mo.id_modeloOrden and u.id_mocaja = moc.id_mocaja where e.ensamble = '" + txt_buscar.Text + "' order by mo.id_modeloOrden asc";

                if (cb_filtro.Text == "Fecha Registro")
                {
                    DateTime fecha = Convert.ToDateTime(txt_buscar.Text);
                    string buscar = fecha.ToString("yyyy-MM-dd");
                    salida_datos = "select distinct mo.id_modeloOrden as ID, moc.id_mocaja as IdCaja, e.ensamble, mo.Serialnumber, mo.scanmac, mo.scanimei, mo.qr, moc.SerialNumberCaja, moc.scanmacCaja, moc.scanimeiCaja, moc.qrCaja, o.orden, mo.fecharegistro, c.caja, mo.turno, mo.revision, op.numeroempleado from tb_ModeloOrden mo join tb_Orden o on o.id_orden = mo.id_orden join tb_ModeloOrdenCaja moc on o.id_orden = moc.id_orden join tb_Ensamble e on e.id_ensamble = o.id_ensamble join tb_caja c on c.id_caja = mo.id_caja and c.id_caja = moc.id_caja join tb_Operador op on op.id_operador = o.id_operador join tbUnion_MoCaja u on u.id_modeloOrden = mo.id_modeloOrden and u.id_mocaja = moc.id_mocaja where CONVERT(varchar(255),mo.fecharegistro,126) LIKE '%" + buscar + "%' order by mo.id_modeloOrden asc";
                }

                dg_buscar.DataSource = modeloorden.LlenarDG(salida_datos).Tables[0];
                //dg_buscar.DataSource = modeloorden.GetDataTable(salida_datos);
                this.dg_buscar.Columns[0].Visible = false;
                this.dg_buscar.Columns[1].Visible = false;
            }
        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            if (dg_buscar.Rows.Count != 0)
            {
                //ExportarExcel(dataGridView1);
                SaveToCSV(dg_buscar);
                //ExportTxt(dataGridView1);
                SaveToTxt(dg_buscar);
            }
            else
                MessageBox.Show("No hay ninguna orden cargada!", "ERROR!");
        }

        private void SaveToTxt(DataGridView DGV)
        {
            SaveFileDialog dlGuardar = new SaveFileDialog
            {
                Filter = "Text File|*.txt",
                FileName = "",
                Title = "Exportar a TXT"
            };
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                //para los títulos de las columnas, encabezado
                //for (int i = 2; i < DGV.Columns.Count - 7; i++)
                //{
                //    if (i == DGV.Columns.Count - 9)
                //    {
                //        csvMemoria.Append(String.Format("\"{0}\"", DGV.Columns[i].HeaderText));
                //    }
                //    else
                //    {
                //        csvMemoria.Append(String.Format("\"{0}\",", DGV.Columns[i].HeaderText));
                //    }
                //}

                //csvMemoria.AppendLine();

                for (int m = 0; m < DGV.Rows.Count - 1; m++)
                {
                    for (int n = 0; n < DGV.Columns.Count - 6; n++)
                    {
                        //si es la última columna no poner el ;
                        if (n == DGV.Columns.Count - 8)
                        {
                            if (DGV.Rows[m].Cells[n] == DGV.Rows[m].Cells[1] && DGV.Rows[m].Cells[n].Value.ToString() != "")
                            {
                                string a = DGV.Rows[m].Cells[n].Value.ToString().Substring(0, 15);
                                csvMemoria.Append(String.Format("\"{0}\",", a));
                                //csvMemoria.Append(String.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value).Substring(0, 18));
                            }
                            else
                                csvMemoria.Append(String.Format("\"{0}\"", DGV.Rows[m].Cells[n].Value));
                        }
                        else
                        {
                            //if (DGV.Rows[m].Cells[n] == DGV.Rows[m].Cells[1] && DGV.Rows[m].Cells[n].Value.ToString() != "" && DGV.Rows.Count - 1 == m)
                            if (DGV.Rows[m].Cells[n] == DGV.Rows[m].Cells[1] && DGV.Rows[m].Cells[n].Value.ToString() != "" || DGV.Rows.Count - 1 == m)
                            {
                                string a = DGV.Rows[m].Cells[n].Value.ToString().Substring(0, 15);
                                csvMemoria.Append(String.Format("\"{0}\"", a));

                                //csvMemoria.Append(String.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value).Substring(0, 18));
                            }
                            else
                            {
                                if (n == 2)
                                    csvMemoria.Append(String.Format("\"{0}\"", DGV.Rows[m].Cells[n].Value));
                                else
                                    csvMemoria.Append(String.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value));
                            }
                        }
                    }
                    csvMemoria.AppendLine();
                }
                System.IO.StreamWriter sw =
                    new System.IO.StreamWriter(dlGuardar.FileName, false,
                       System.Text.Encoding.Default);
                sw.Write(csvMemoria.ToString());
                sw.Close();
            }
        }

        private void SaveToCSV(DataGridView DGV)
        {
            SaveFileDialog dlGuardar = new SaveFileDialog
            {
                Filter = "Fichero CSV (*.csv)|*.csv",
                FileName = "",
                Title = "Exportar a CSV"
            };
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                //para los títulos de las columnas, encabezado
                for (int i = 0; i < DGV.Columns.Count - 6; i++)
                {
                    if (i == DGV.Columns.Count - 1)
                        csvMemoria.Append(String.Format("\"{0}\"", DGV.Columns[i].HeaderText));
                    else
                        csvMemoria.Append(String.Format("\"{0}\",", DGV.Columns[i].HeaderText));
                    //csvMemoria.AppendFormat(String.Format("\"{0}\",", DGV.Columns[i].HeaderText), String.Empty);
                }

                csvMemoria.AppendLine();

                for (int m = 0; m < DGV.Rows.Count - 1; m++)
                {
                    for (int n = 0; n < DGV.Columns.Count - 6; n++)
                    {
                        //si es la última columna no poner el ;
                        if (n == DGV.Columns.Count - 1)
                        {
                            _ = csvMemoria.AppendFormat(string.Format("\"{0}\"", DGV.Rows[m].Cells[n].Value + "", string.Empty));
                        }
                        else
                        {
                            //if (n == 3 || n == 4)
                            if (n == 2)
                                _ = csvMemoria.AppendFormat(string.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value + ";", string.Empty));
                            else
                                _ = csvMemoria.AppendFormat(string.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value + "", string.Empty));
                        }
                    }
                    csvMemoria.AppendLine();
                }

                File.WriteAllText(dlGuardar.FileName.ToString(), csvMemoria.ToString(), System.Text.Encoding.Default);
                //File.AppendText(csvMemoria.ToString());
                //sw.Close();
            }
        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabra_busqueda = this.txt_buscar.Text.Split(' ');

            foreach (string palabra in palabra_busqueda)
            {
                if (cb_filtro.Text == "Serial Number")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = "(Serialnumber LIKE '%" + palabra + "%')";
                    else
                        salida_datos += " AND (Serialnumber LIKE '%" + palabra + "%')";
                }

                if (cb_filtro.Text == "Scan Modem")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = "(scanmodem LIKE '%" + palabra + "%')";
                    else
                        salida_datos += " AND (scanmodem LIKE '%" + palabra + "%')";
                }

                if (cb_filtro.Text == "Scan Sim")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = "(scansim LIKE '%" + palabra + "%')";
                    else
                        salida_datos += " AND (scansim LIKE '%" + palabra + "%')";
                }

                if (cb_filtro.Text == "Orden")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = string.Format("CONVERT(orden, System.String) LIKE '{0}'", palabra);
                    else
                        salida_datos += " AND (WorkOrder LIKE % '" + palabra + " %')";
                }
                if (cb_filtro.Text == "Caja")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = string.Format("CONVERT(Box, System.String) LIKE '{0}'", palabra);
                    else
                        salida_datos += " AND (Box LIKE % '" + palabra + " %')";
                }
                if (cb_filtro.Text == "Pallette")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = string.Format("CONVERT(pallette, System.String) LIKE '%{0}'", palabra);
                    else
                        salida_datos += " AND (pallette LIKE % '" + palabra + " %')";
                }
                if (cb_filtro.Text == "Modelo")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = string.Format("CONVERT(Model, System.String) LIKE '%{0}%'", palabra);
                    else
                        salida_datos += " AND (Model LIKE % '" + palabra + " %')";
                }
                if (cb_filtro.Text == "Fecha Registro")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = string.Format("CONVERT(DateScan, System.String) LIKE '%" + palabra + "%'");
                    else
                        salida_datos += " AND (DateScan LIKE % '" + palabra + " %')";
                }

                this.filtro.RowFilter = salida_datos;
            }
        }
    }
}