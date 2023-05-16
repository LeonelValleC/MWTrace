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
    public partial class Reports : Form
    {
        private readonly OrdenModelo om = new OrdenModelo();

        public Reports()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string salida_datos = "";
            _ = this.txt_Search.Text.Split(' ');
            /*
            Scan Modem
            Scan Sim
             Modelo
            */
            if (cb_Filter.Text == "Serial Number")
            {
                int id_modelorden = int.Parse(om.ReturnID("select id_modeloOrden from tb_ModeloOrden where serialNumber = '" + txt_Search.Text + "'"));
                salida_datos = "select om.id_Omodelo, mo.Serialnumber,mo.scanmodem, mo.scansim, sa.FechaRegistro, om.workorder, m.modelo ,pcb.pcb, sim.sim, o.Revision, o.RevisionFirmware, op.numeroempleado from tb_SecondAssy sa join tb_Orden o on sa.id_Orden = o.id_orden join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_PCB pcb on pcb.id_pcb = o.id_pcb join tb_SIM sim on sim.id_sim = o.id_sim join tb_Operador op on op.id_operador = sa.id_operador join tb_Modelo m on m.id_modelo = om.id_modelo where mo.id_modeloOrden = " + id_modelorden + " order by mo.id_modeloOrden asc";

            }
            if (cb_Filter.Text == "Scan Modem")
            {
                int id_modelorden = int.Parse(om.ReturnID("select id_modeloOrden from tb_ModeloOrden where scanmodem = '" + txt_Search.Text + "'"));
                salida_datos = "select om.id_Omodelo, mo.Serialnumber,mo.scanmodem, mo.scansim, sa.FechaRegistro, om.workorder, m.modelo ,pcb.pcb, sim.sim, o.Revision, o.RevisionFirmware, op.numeroempleado from tb_SecondAssy sa join tb_Orden o on sa.id_Orden = o.id_orden join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_PCB pcb on pcb.id_pcb = o.id_pcb join tb_SIM sim on sim.id_sim = o.id_sim join tb_Operador op on op.id_operador = sa.id_operador join tb_Modelo m on m.id_modelo = om.id_modelo where mo.id_modeloOrden = " + id_modelorden + " order by mo.id_modeloOrden asc";
            }

            if (cb_Filter.Text == "Scan Sim")
            {
                int id_modelorden = int.Parse(om.ReturnID("select id_modeloOrden from tb_ModeloOrden where scansim = '" + txt_Search.Text + "'"));
                salida_datos = "select om.id_Omodelo, mo.Serialnumber,mo.scanmodem, mo.scansim, sa.FechaRegistro, om.workorder, m.modelo ,pcb.pcb, sim.sim, o.Revision, o.RevisionFirmware, op.numeroempleado from tb_SecondAssy sa join tb_Orden o on sa.id_Orden = o.id_orden join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_PCB pcb on pcb.id_pcb = o.id_pcb join tb_SIM sim on sim.id_sim = o.id_sim join tb_Operador op on op.id_operador = sa.id_operador join tb_Modelo m on m.id_modelo = om.id_modelo where mo.id_modeloOrden = " + id_modelorden + " order by mo.id_modeloOrden asc";

            }

            if (cb_Filter.Text == "Orden")
            {
                int id_orden = int.Parse(om.ReturnValue("select id_Omodelo from tb_OrdenModelo where workorder = '" + txt_Search.Text + "'"));
                salida_datos = "select om.id_Omodelo, mo.Serialnumber,mo.scanmodem, mo.scansim, sa.FechaRegistro, om.workorder, m.modelo ,pcb.pcb, sim.sim, o.Revision, o.RevisionFirmware, op.numeroempleado from tb_SecondAssy sa join tb_Orden o on sa.id_Orden = o.id_orden join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_PCB pcb on pcb.id_pcb = o.id_pcb join tb_SIM sim on sim.id_sim = o.id_sim join tb_Operador op on op.id_operador = sa.id_operador join tb_Modelo m on m.id_modelo = om.id_modelo where om.id_Omodelo = " + id_orden + " order by om.id_Omodelo asc";
            }

            if (cb_Filter.Text == "Modelo")
            {
                int id_modelo = int.Parse(om.ReturnValue("select id_modelo from tb_Modelo where modelo = '" + txt_Search.Text + "'"));
                salida_datos = "select om.id_Omodelo, mo.Serialnumber,mo.scanmodem, mo.scansim, sa.FechaRegistro, om.workorder, m.modelo ,pcb.pcb, sim.sim, o.Revision, o.RevisionFirmware, op.numeroempleado from tb_SecondAssy sa join tb_Orden o on sa.id_Orden = o.id_orden join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_PCB pcb on pcb.id_pcb = o.id_pcb join tb_SIM sim on sim.id_sim = o.id_sim join tb_Operador op on op.id_operador = sa.id_operador join tb_Modelo m on m.id_modelo = om.id_modelo where m.id_modelo = '" + id_modelo + "'";
            }

            if (cb_Filter.Text == "Fecha Registro")
            {
                DateTime fecha = Convert.ToDateTime(txt_Search.Text);
                string buscar = fecha.ToString("yyyy-MM-dd");
                salida_datos = "select om.id_Omodelo, mo.Serialnumber,mo.scanmodem, mo.scansim, sa.FechaRegistro, om.workorder, m.modelo ,pcb.pcb, sim.sim, o.Revision, o.RevisionFirmware, op.numeroempleado from tb_SecondAssy sa join tb_Orden o on sa.id_Orden = o.id_orden join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_PCB pcb on pcb.id_pcb = o.id_pcb join tb_SIM sim on sim.id_sim = o.id_sim join tb_Operador op on op.id_operador = sa.id_operador join tb_Modelo m on m.id_modelo = om.id_modelo where CONVERT(varchar(255),sa.fecharegistro,126) LIKE '%" + buscar + "%' order by om.id_Omodelo asc";
            }

            _ = new DataSet();

            DataSet ds = om.LlenarDG(salida_datos);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                //dg_buscar.DataSource = modeloorden.LlenarDG(salida_datos).Tables[0];
                dg_Reports.DataSource = ds.Tables[0];
                this.dg_Reports.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("No se encontro!");
            }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            if (dg_Reports.Rows.Count != 0)
            {
                //ExportarExcel(dataGridView1);

                SaveToCSV(dg_Reports);

                //ExportTxt(dataGridView1);
                SaveToTxt(dg_Reports);
            }
            else
            {
                MessageBox.Show("No data!", "ERROR!");
            }
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
                    for (int n = 1; n < DGV.Columns.Count - 8; n++)
                    {
                        //si es la última columna no poner el ;
                        if (n == DGV.Columns.Count - 7)
                        {
                            //if (DGV.Rows[m].Cells[n] == DGV.Rows[m].Cells[2] && DGV.Rows[m].Cells[n].Value.ToString() != "")
                            //{
                            //    string a = DGV.Rows[m].Cells[n].Value.ToString().Substring(0, 15);
                            //    csvMemoria.Append(String.Format("\"{0}\",", a));
                            //    //csvMemoria.Append(String.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value).Substring(0, 18));
                            //}
                            //else
                            csvMemoria.Append(String.Format("\"{0}\"", DGV.Rows[m].Cells[n].Value));
                        }
                        else
                        {
                            //if (DGV.Rows[m].Cells[n] == DGV.Rows[m].Cells[2] && DGV.Rows[m].Cells[n].Value.ToString() != "" && DGV.Rows.Count - 1 == m)
                            if (DGV.Rows[m].Cells[n] == DGV.Rows[m].Cells[2] && DGV.Rows[m].Cells[n].Value.ToString() != "")
                            {
                                string a = DGV.Rows[m].Cells[n].Value.ToString().Substring(0, 15);
                                csvMemoria.Append(String.Format("\"{0}\",", a));

                                //csvMemoria.Append(String.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value).Substring(0, 18));
                            }
                            else
                            {
                                if (n == 3)
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
                for (int i = 1; i < DGV.Columns.Count - 8; i++)
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
                    for (int n = 1; n < DGV.Columns.Count - 8; n++)
                    {
                        //si es la última columna no poner el ;
                        if (n == DGV.Columns.Count - 1)
                        {
                            csvMemoria.AppendFormat(string.Format("\"{0}\"", DGV.Rows[m].Cells[n].Value + "", string.Empty));
                        }
                        else
                        {
                            //if (n == 3 || n == 4)
                            if (n == 3)
                                csvMemoria.AppendFormat(string.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value + ";", string.Empty));
                            else
                                csvMemoria.AppendFormat(string.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value + "", string.Empty));
                        }
                    }
                    csvMemoria.AppendLine();
                }

                System.IO.File.WriteAllText(dlGuardar.FileName.ToString(), csvMemoria.ToString(), System.Text.Encoding.Default);
                //File.AppendText(csvMemoria.ToString());
                //sw.Close();
            }
        }

    }
}
