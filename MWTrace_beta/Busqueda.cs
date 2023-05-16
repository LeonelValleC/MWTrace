using System;
using System.Data;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class Busqueda : Form
    {
        private ModeloOrden modeloorden = new ModeloOrden();
        private DataView filtro;
        //private DataSet res = new DataSet();

        public Busqueda()
        {
            InitializeComponent();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            FillDv();
            //try
            //{
            //    //this.filtro = modeloorden.Leer_Datos("select mo.Serialnumber, mo.scanmodem, mo.scansim, o.orden, mo.fecharegistro from tb_ModeloOrden mo, tb_Orden o where mo.id_orden = o.id_orden", "tb_ModeloOrden.scanmodem,tb_ModeloOrden.scansim,tb_Orden.orden,tb_caja.caja,tb_Pallette.pallette");
            //    this.filtro = modeloorden.Leer_Datos("select mo.Serialnumber, mo.scanmodem, mo.scansim, sm.Modelo ,o.orden, mo.fecharegistro, c.caja, p.pallette from tb_ModeloOrden mo join tb_Orden o on mo.id_orden = o.id_orden join tb_caja c on mo.id_caja = c.id_caja join tb_Pallette p on c.id_pallette = p.id_pallette join tb_ScanModem sm on mo.id_modeloOrden = sm.id_modeloOrden", "tb_ModeloOrden.id_modeloOrden, tb_ModeloOrden.scanmodem, tb_ModeloOrden.scansim , tb_ModeloOrden.fecharegistro, tb_ModeloOrden.id_orden , tb_Orden.orden, tb_caja.caja , tb_pallette.pellette, tb_pallette.id_pellette");
            //    this.dg_buscar.DataSource = filtro;
            //}
            //catch (System.Exception)
            //{
            //    MessageBox.Show("Base de datos no encontrada!");
            //}
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
                        salida_datos = string.Format("CONVERT(pallette, System.String) LIKE '%{0}%'", palabra);
                    else
                        salida_datos += " AND (pallette LIKE % '" + palabra + " %')";
                }

                if (cb_filtro.Text == "Fecha")
                {
                    if (salida_datos.Length == 0)
                        salida_datos = string.Format("CONVERT(DateScan, System.String) LIKE '%{0}%'", palabra);
                    else
                        salida_datos += " AND (DateScan LIKE % '" + palabra + " %')";
                }
                this.filtro.RowFilter = salida_datos;
                //FillDv();
            }
        }

        private void FillDv()
        {
            try
            {
                //this.filtro = modeloorden.Leer_Datos("select sim.sim, mo.Serialnumber, mo.scanmodem, mo.scansim, o.orden, mo.fecharegistro, mo.Problema , o.Revision, o.RevisionFirmware from tb_Orden o join tb_ModeloOrden mo on o.id_orden = mo.id_orden join tb_PCB pcb on pcb.id_pcb = o.id_pcb join tb_SIM sim on sim.id_sim = o.id_sim ", "tb_ModeloOrden.id_modeloOrden, tb_ModeloOrden.scanmodem, tb_ModeloOrden.scansim , tb_ModeloOrden.fecharegistro, tb_ModeloOrden.id_orden , tb_Orden.orden");
                this.filtro = modeloorden.Leer_Datos("select  mo.Serialnumber, mo.scanmodem, mo.scansim, sim.sim, o.orden, mo.fecharegistro, o.Revision, o.RevisionFirmware from tb_Orden o right join tb_ModeloOrden mo on o.id_orden = mo.id_orden left join tb_PCB pcb on pcb.id_pcb = o.id_pcb left join tb_SIM sim on sim.id_sim = o.id_sim ", "tb_ModeloOrden.id_modeloOrden, tb_ModeloOrden.scanmodem, tb_ModeloOrden.scansim , tb_ModeloOrden.fecharegistro, tb_ModeloOrden.id_orden , tb_Orden.orden");

                this.dg_buscar.DataSource = filtro;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Base de datos no encontrada!");
            }
        }
    }
}