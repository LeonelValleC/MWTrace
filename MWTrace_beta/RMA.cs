using System;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class RMA : Form
    {
        Orden orden = new Orden();
        ModeloOrden mo = new ModeloOrden();
        Log log = new Log();
        public RMA()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, System.EventArgs e)
        {
            try
            {
                var leer = orden.Leer("select mo.id_modeloOrden, mo.Problema, sim.sim, mo.Serialnumber, mo.scanmodem, mo.scansim, o.orden, mo.fecharegistro, o.Revision, o.RevisionFirmware from tb_Orden o join tb_ModeloOrden mo on o.id_orden = mo.id_orden join tb_PCB pcb on pcb.id_pcb = o.id_pcb join tb_SIM sim on sim.id_sim = o.id_sim where Serialnumber = '" + txt_SearchSN.Text.ToUpper() + "'");

                if (leer.Read() == true)
                {

                    mo.Id_modeloOrden = int.Parse(leer["id_modeloOrden"].ToString());
                    txt_sacanmodem.Text = mo.Id_scanmodem = leer["scanmodem"].ToString();
                    txt_scansim.Text = mo.Id_scansim = leer["scansim"].ToString();
                    txt_WO.Text = orden.Ordenes = leer["orden"].ToString();
                    mo.Datescan = DateTime.Parse(leer["fecharegistro"].ToString());
                    txt_DateScan.Text = leer["fecharegistro"].ToString();
                    txt_Rev.Text = orden.Revision = leer["Revision"].ToString();
                    txt_Firmware.Text = orden.Firmware = leer["RevisionFirmware"].ToString();
                    txt_problema.Text = mo.Problema = leer["Problema"].ToString();

                    orden.Id_orden = int.Parse(orden.ReturnID("select id_orden from tb_Orden where orden = '" + orden.Ordenes + "'"));
                }
                else
                {

                    txt_sacanmodem.Text = "";
                    txt_scansim.Text = "";
                    txt_Firmware.Text = "";
                    txt_DateScan.Text = "";
                    txt_Rev.Text = "";
                    txt_WO.Text = "";
                    txt_problema.Text = "";

                }
                orden.Cerrar();
            }
            catch (System.InvalidOperationException)
            {
                orden.Cerrar();
                throw;
            }
        }

        private void txt_Edit_Click(object sender, System.EventArgs e)
        {
            //IF PARA VALIDAR QUE NO ESTEN VACIOS LOS CAMPOS
            if (!(string.IsNullOrEmpty(txt_SearchSN.Text)) && !(string.IsNullOrEmpty(txt_SearchSN.Text)) && !(string.IsNullOrEmpty(txt_problema.Text)))
            {
                //Validar que el IMEI sea de 36 caracteres de largo
                if (txt_sacanmodem.TextLength == 36 && txt_scansim.TextLength == 20)
                {
                    //IF PARA SABER QUE EL MODEM NO ESTA REPETIDO
                    if (!(mo.Existe("select COUNT(*) from tb_ModeloOrden where scanmodem = '" + txt_sacanmodem.Text.Trim() + "'")) || mo.Id_scanmodem == txt_sacanmodem.Text.Trim())
                    {
                        //IF PARA SABER QUE LA SIM NUMBER NO ESTA REPETIDO
                        if (!mo.Existe("select COUNT(*) from tb_ModeloOrden where scansim = '" + txt_scansim.Text.Trim() + "'") || mo.Id_scansim == txt_scansim.Text.Trim())
                        {
                            if (orden.Existe("select COUNT(*) from tb_Orden where orden = '" + txt_WO.Text.Trim() + "'"))
                            {
                                orden.Id_orden = int.Parse(orden.ReturnID("select id_orden from tb_Orden where orden = '" + txt_WO.Text.Trim() + "'"));

                                mo.Crud("update tb_ModeloOrden set scanmodem = '" + txt_sacanmodem.Text + "' , scansim = '" + txt_scansim.Text + "' , id_orden = '" + orden.Id_orden + "' , Problema = '" + txt_problema.Text + "' , fecharegistro = '" + DateTime.Now + "' where Serialnumber = '" + txt_SearchSN.Text + "'");
                                log.Crud("insert into tb_Log (id_modeloOrden,scanmodem,scansim,Serialnumber,id_orden,fecharegistro,problema,status) values('" + mo.Id_modeloOrden + "','" + mo.Id_scanmodem + "','" +
                                    mo.Id_scansim + "','" + txt_SearchSN.Text + "','" + orden.Id_orden + "','" + mo.Datescan + "','" + mo.Problema + "','RMA')");
                                //Retrabajo_Load(sender, e);
                                TextBoxToEmpty();

                            }
                            else { MessageBox.Show("WO not exist!", "ERROR!"); }

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

        private void TextBoxToEmpty()
        {
            txt_problema.Text = "";
            txt_sacanmodem.Text = "";
            txt_scansim.Text = "";
            txt_DateScan.Text = "";
            txt_Rev.Text = "";
            txt_Firmware.Text = "";
            txt_WO.Text = "";
        }

        private void RMA_Load(object sender, EventArgs e)
        {

        }
    }
}
