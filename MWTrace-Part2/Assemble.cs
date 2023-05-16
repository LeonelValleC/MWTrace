using System;
using System.Windows.Forms;

namespace MWTrace_Part2
{
    public partial class Assemble : Form
    {
        private readonly ModeloOrden modeloOrden = new ModeloOrden();
        private readonly OrdenModelo om = new OrdenModelo();
        private readonly Modelo modelo = new Modelo();

        readonly System.Drawing.Image pass = MWTrace_Part2.Properties.Resources.great;
        readonly System.Drawing.Image error = MWTrace_Part2.Properties.Resources.bad;

        public Assemble()
        {
            InitializeComponent();
        }


        private bool SearchSN()
        {
            bool Exist = false;
            //modeloOrden.Id_modeloOrden = int.Parse(modeloOrden.ReturnID("select id_modeloOrden from tb_ModeloOrden where Serialnumber = '" + txt_SerialNumber.Text + "' and id_orden = " + orden.Id_orden));
            modeloOrden.Id_modeloOrden = int.Parse(modeloOrden.ReturnID("select id_modeloOrden from tb_ModeloOrden where Serialnumber = '" + txt_SerialNumber.Text + "'"));
            modelo.Modelos = modelo.ReturnValue("select modelo from tb_Modelo m join tb_Orden o on m.id_modelo = o.id_modelo join tb_ModeloOrden mo on o.id_orden = mo.id_orden where id_modeloOrden = '" + modeloOrden.Id_modeloOrden + "'");

            if (modeloOrden.Id_modeloOrden != 0)
                Exist = true;

            return Exist;
        }

        private void Reload()
        {


        }

        private void Assemble_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private bool IsScan()
        {
            bool scan = modeloOrden.Scan = Convert.ToBoolean(modeloOrden.ReturnValueNull("select scan from tb_ModeloOrden where id_modeloOrden = " + modeloOrden.Id_modeloOrden));

            return scan;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {

            if (txt_SerialNumber1.Text.Trim() == txt_SerialNumber.Text.Trim())
            {
                SearchSN();


                om.Crud("update tb_ModeloOrden set  verified = 1 where id_modeloOrden = '" + modeloOrden.Id_modeloOrden + "'");

                Assemble_Load(sender, e);
                pictureBox1.Image = pass;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                txt_SerialNumber.Text = "";
                txt_SerialNumber1.Text = "";
                txt_Assy.Text = "";
                txt_Assy.Focus();
                Reload();

            }
            else
            {
                txt_SerialNumber.Text = "";
                txt_SerialNumber1.Text = "";
                txt_SerialNumber1.Focus();
                MessageBox.Show("Serial Number no son iguales!", "ERROR!");
            }


        }

        private void Btn_Submit_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }



    }
}
