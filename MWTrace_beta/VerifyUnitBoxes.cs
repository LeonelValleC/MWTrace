using System;
using System.Drawing;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class VerifyUnitBoxes : Form
    {

        ModeloOrden serials = new ModeloOrden();
        Box boxes = new Box();
        //Orden wo = new Orden();

        public VerifyUnitBoxes()
        {
            InitializeComponent();
        }

        private void txt_Serial_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {

                if (boxes.Id_box == 0 && VerifyScan() == false)
                {
                    boxes.Id_box = int.Parse(serials.ReturnID("select box from tb_ModeloOrden where Serialnumber = '" + txt_Serial.Text.Trim() + "'"));

                    serials.Crud("update tb_ModeloOrden set VerifyBox = '" + DateTime.Now + "' where Serialnumber = '" + txt_Serial.Text.Trim() + "'");

                    dgv_UnitsOnBoxes.DataSource = serials.LlenarDG("select mo.Serialnumber, box.box, mo.VerifyBox from tb_ModeloOrden mo join box on mo.box = box.id_box where box.id_box = " + boxes.Id_box).Tables[0];
                    txt_Serial.Text = "";
                    txt_Serial.Focus();
                }
                else if (boxes.Id_box == 0 && VerifyScan() == true)
                {
                    boxes.Id_box = int.Parse(serials.ReturnID("select box from tb_ModeloOrden where Serialnumber = '" + txt_Serial.Text.Trim() + "'"));

                    //serials.Crud("update tb_ModeloOrden set VerifyBox = '" + DateTime.Now + "' where Serialnumber = '" + txt_Serial.Text.Trim() + "'");

                    dgv_UnitsOnBoxes.DataSource = serials.LlenarDG("select mo.Serialnumber, box.box, mo.VerifyBox from tb_ModeloOrden mo join box on mo.box = box.id_box where box.id_box = " + boxes.Id_box).Tables[0];
                    txt_Serial.Text = "";
                    txt_Serial.Focus();
                }
                else
                {
                    boxes.Id_box_compare = int.Parse(serials.ReturnID("select box from tb_ModeloOrden where Serialnumber = '" + txt_Serial.Text.Trim() + "'"));

                    if (boxes.Id_box == boxes.Id_box_compare)
                    {
                        serials.Crud("update tb_ModeloOrden set VerifyBox = '" + DateTime.Now + "' where Serialnumber = '" + txt_Serial.Text.Trim() + "'");

                        dgv_UnitsOnBoxes.DataSource = serials.LlenarDG("select mo.Serialnumber, box.box, mo.VerifyBox from tb_ModeloOrden mo join box on mo.box = box.id_box where box.id_box = " + boxes.Id_box).Tables[0];
                        txt_Serial.Text = "";
                        txt_Serial.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Esta unidad no va en la misma caja", "Error de Caja");
                    }

                }

                CloseBox();


            }

        }

        //Validar que se hayan escaneado y validado todos las unidades por caja
        private void CloseBox()
        {
            if (int.Parse(serials.ReturnValue("select count(*) from tb_ModeloOrden where box = '" + boxes.Id_box + "' and VerifyBox is null")) == 0)
            {
                MessageBox.Show("Caja completa!\n cierrela y escanee la siguiente!");
                dgv_UnitsOnBoxes.Columns.Clear();
                dgv_UnitsOnBoxes.Refresh();

                boxes.Id_box = 0;
                boxes.Id_box_compare = 0;
                txt_Serial.Text = "";
                txt_Serial.Focus();

            }
        }

        private bool VerifyScan()
        {
            boxes.IsVerified = true;

            if (serials.ReturnValue("select verifyBox from tb_ModeloOrden where Serialnumber = '" + txt_Serial.Text.Trim() + "'") == "-1" && serials.Existe("select count(*) from tb_ModeloOrden where Serialnumber = '" + txt_Serial.Text.Trim() + "' and labelsVerified is not null") == true)
            {
                boxes.IsVerified = false;

            }


            return boxes.IsVerified;
        }

        private void dgv_UnitsOnBoxes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (string.IsNullOrEmpty(e.Value.ToString()) == false)
                {
                    //e.CellStyle.BackColor = Color.Green;
                    dgv_UnitsOnBoxes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        private void VerifyUnitBoxes_Load(object sender, EventArgs e)
        {

            //wo.Id_orden = int.Parse(wo.ReturnValue("select id_orden from tb_Orden where orden = " + wo.Ordenes));

            //lbl_wo.Text = wo.Ordenes;


        }
    }
}
