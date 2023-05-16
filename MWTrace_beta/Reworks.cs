using System;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class Reworks : Form
    {
        ModeloOrden mo = new ModeloOrden();
        Operador user = new Operador();
        public Reworks()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_SerialBulk.Text.Trim()) && !string.IsNullOrEmpty(txt_SerialBox.Text.Trim()) && !string.IsNullOrEmpty(txt_SerialHousing.Text.Trim()))
            {
                if (mo.Existe("select count(*) from tb_ModeloOrden where Serialnumber = '" + txt_SerialHousing.Text.Trim() + "'"))
                {
                    mo.Id_modeloOrden = int.Parse(mo.ReturnID("select id_modeloOrden from tb_ModeloOrden where Serialnumber = '" + txt_SerialHousing.Text.Trim() + "'"));

                    if (txt_SerialHousing.Text.Trim() == txt_SerialBox.Text.Trim() && txt_SerialBox.Text.Trim() == txt_SerialBulk.Text.Trim())
                    {
                        if (!mo.Existe("select count(*) from tb_rework where sn = '" + txt_SerialHousing.Text.Trim() + "'"))
                        {

                            mo.Crud("insert into tb_rework values('" + txt_SerialBox.Text.Trim() + "','" + mo.Id_modeloOrden + "','" + DateTime.Now + "','" + user.Numeroempleado + "')");
                            txt_SerialBox.Text = "";
                            txt_SerialBulk.Text = "";
                            txt_SerialHousing.Text = "";
                            txt_SerialHousing.Focus();

                            Reworks_Load(sender, e);

                        }
                        else
                            MessageBox.Show("Serial Number already scan!");

                    }
                    else
                        MessageBox.Show("Check Serial Number!");
                }
                else
                    MessageBox.Show("Serial Number not exist!");

            }
            else
            {
                MessageBox.Show("Empty Field!");
            }
        }

        private void Reworks_Load(object sender, EventArgs e)
        {
            lbl_count.Text = mo.ReturnValue("select count(*) from tb_rework");
            lbl_nemploy.Text = user.Numeroempleado.ToString(); ;
            dv_data.DataSource = mo.LlenarDG("select mo.Serialnumber, mo.scanmodem as 'IMEI', mo.scansim as 'SIM', r.date_scan, r.employ from tb_rework r join tb_ModeloOrden mo on r.id_modeloOrden = mo.id_modeloOrden ").Tables[0];
        }

        private void btn_submit_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        //private bool CheckFields()
        //{
        //    bool isValid = false;

        //    mo.Serialnumber1 = mo.ReturnValue("select Serialnumber from tb_ModeloOrden where scanmodem = '" + txt_SerialBulk.Text.Trim() + "'");


        //    if (txt_SerialHousing.Text.Trim() == mo.Serialnumber1 && txt_SerialBox.Text.Trim() == mo.Serialnumber1)
        //    {
        //        isValid = true;
        //        mo.Id_modeloOrden = int.Parse(mo.ReturnID("select id_modeloOrden from tb_ModeloOrden where Serialnumber = '" + mo.Serialnumber1 + "'"));
        //    }


        //    return isValid;
        //}
    }
}
