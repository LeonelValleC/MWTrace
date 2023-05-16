using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoxPacking
{
    public partial class Packing : Form
    {
        private readonly OrdenModelo om = new OrdenModelo();
        private readonly ModeloOrden mo = new ModeloOrden();
        private readonly Caja caja = new Caja();
        Operador op = new Operador();

        public Packing()
        {
            InitializeComponent();
        }

        private void Packing_Load(object sender, EventArgs e)
        {

            om.Id_Omodelo = int.Parse(om.ReturnID("select id_Omodelo from tb_OrdenModelo where workorder = '" + om.Workorder + "'"));
            //dg_Packing.DataSource = om.LlenarDG("select mo.id_modeloOrden, LEAD(mo.Serialnumber) OVER (ORDER BY sa.id_modeloOrden) NextValue, mo.Serialnumber, c.caja,sa.FechaRegistro, o.orden as 'Sub-Workorder' from tb_SecondAssy sa left join tb_Orden o on sa.id_Orden = o.id_orden join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_caja c on c.id_caja = sa.id_caja where om.id_Omodelo = '" + om.Id_Omodelo + "'").Tables[0];
            dg_Packing.DataSource = om.LlenarDG("select mo.id_modeloOrden, LEAD(sa.SN) OVER (ORDER BY sa.id_second) NextValue, LAG(c.box) OVER (ORDER BY sa.id_second) PreviusBox, sa.SN, c.Box,sa.FechaRegistro, o.orden as 'Sub-Workorder' from tb_SecondAssy sa left join tb_Orden o on sa.id_Orden = o.id_orden left join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_caja c on c.id_caja = sa.id_caja where om.id_Omodelo = '" + om.Id_Omodelo + "'").Tables[0];
            dg_Packing.Columns[0].Visible = false;
            dg_Packing.Columns[1].Visible = false;
            dg_Packing.Columns[2].Visible = false;

            mo.ActualSN = dg_Packing.Rows[0].Cells[3].Value.ToString();

            lbl_Records.Text = mo.ReturnValue("select count(*) from tb_SecondAssy where id_Omodelo = '" + om.Id_Omodelo + "' and FechaRegistro is not null");
            //int index = dg_Packing.Columns[3].Index;
            lbl_WO.Text = om.Workorder;
            //mo.Id_modeloOrden = int.Parse(mo.ReturnValue("select top 1 mo.id_modeloOrden from tb_SecondAssy sa left join tb_Orden o on sa.id_Orden = o.id_orden join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo where om.id_Omodelo = '" + om.Id_Omodelo + "' and sa.FechaRegistro is null"));


            if (ValidateBox() == true || lbl_Records.Text == "0")
            {
                txt_Box.Enabled = true;
                txt_SN.Enabled = false;
            }
            else
            {
                txt_Box.Enabled = false;
                txt_SN.Enabled = true;
            }

            label4.Text = mo.ReturnValue("select top 1 sa.SN from tb_SecondAssy sa left join tb_Orden o on sa.id_Orden = o.id_orden left join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_caja c on c.id_caja = sa.id_caja where om.id_Omodelo = '" + om.Id_Omodelo + "' and sa.FechaRegistro is null");
            DGFormat();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            //if (ValidateBox() == false || txt_Box.Enabled == false )
            if (txt_SN.Enabled == true)// && ValidateSNActual() == true)
            {
                if (!string.IsNullOrEmpty(txt_SN.Text) && ValidateSN() == true && mo.Existe("select count(*) from tb_ModeloOrden where Serialnumber = '" + txt_SN.Text.Trim() + "'"))
                {
                    mo.Crud("update tb_SecondAssy set FechaRegistro = GETDATE(), scan = 1 , id_operador = '" + op.Id_operador + "' where SN = '" + txt_SN.Text.Trim() + "'");
                    txt_SN.Text = "";
                    ActualRow();
                    Packing_Load(sender, e);
                    txt_SN.Focus();
                }
                else
                {
                    MessageBox.Show("Has not been scanned!");
                }
            }
            else if (ValidateBox() == true && caja.ActualBox == txt_Box.Text)
            {
                txt_Box.Enabled = false;
                txt_SN.Enabled = true;
                txt_Box.Text = "";
            }
            else
            {
                MessageBox.Show("Don't Match!");
                txt_Box.Focus();
                txt_SN.Focus();
            }

        }

        private void ActualRow()
        {
            foreach (DataGridViewRow row in dg_Packing.Rows)
            {
                if (row.Cells[3].Value.ToString().Equals(mo.ActualSN.ToString()))
                {

                    dg_Packing.Rows[row.Index].Selected = true;
                    dg_Packing.FirstDisplayedScrollingRowIndex = row.Index;
                    dg_Packing.Focus();
                    break;

                }
                row.DefaultCellStyle.BackColor = Color.LightGreen;

            }
            //dg_Packing.Rows[rowIndex].Selected = true;
        }


        private bool ValidateSN()
        {
            bool isValid = false;

            foreach (DataGridViewRow row in dg_Packing.Rows)
            {
                if (row.Cells[3].Value.ToString().Equals(txt_SN.Text))
                {

                    dg_Packing.Rows[row.Index].Selected = true;

                    isValid = true;
                    break;


                }
                row.DefaultCellStyle.BackColor = Color.LightGreen;
                isValid = false;
            }
            return isValid;
        }

        private bool ValidateBox()
        {
            bool isValid = false;
            int isZero = -1;
            isZero = int.Parse(mo.ReturnValue("select count(*) from tb_SecondAssy where id_Omodelo = '" + om.Id_Omodelo + "' and FechaRegistro is not null"));
            if (isZero > 0)
                caja.ActualBox = caja.ReturnValue("select top 1 c.Box from tb_SecondAssy sa left join tb_Orden o on sa.id_Orden = o.id_orden left join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_caja c on c.id_caja = sa.id_caja where om.id_Omodelo = '" + om.Id_Omodelo + "' and sa.FechaRegistro is null");
            caja.PreviousBox = BoxActual();
            //caja.Box = BoxActual2();

            if (isZero == 0)
                caja.ActualBox = caja.ReturnValue("select top 1 lead(c.Box) OVER (ORDER BY sa.id_second)  from tb_SecondAssy sa left join tb_Orden o on sa.id_Orden = o.id_orden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_caja c on c.id_caja = sa.id_caja where om.id_Omodelo = '" + om.Id_Omodelo + "' and sa.scan is null");

            //if (ValidateBoxActual2() == false)
            //    caja.PreviousBox = caja.ReturnValue("select top 1 lead(c.Box) OVER (ORDER BY sa.id_modeloOrden desc)  from tb_SecondAssy sa left join tb_Orden o on sa.id_Orden = o.id_orden join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_caja c on c.id_caja = sa.id_caja where om.id_Omodelo = '" + om.Id_Omodelo + "' and sa.scan is not null");
            //if (ValidateBoxActual() == true && caja.PreviousBox != caja.ActualBox && caja.ActualBox != caja.Box)
            if (BoxActual2() == true && isZero > 0)
                caja.PreviousBox = caja.ReturnValue("select top 1 lead(c.Box) OVER (ORDER BY sa.id_second desc)  from tb_SecondAssy sa left join tb_Orden o on sa.id_Orden = o.id_orden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo join tb_caja c on c.id_caja = sa.id_caja where om.id_Omodelo = '" + om.Id_Omodelo + "' and sa.scan is not null");


            if (caja.ActualBox != caja.PreviousBox || caja.ActualBox == txt_Box.Text)
                isValid = true;
            else
                isValid = false;

            return isValid;
        }

        private string BoxActual()
        {
            //bool isValid = false;
            string ActualBox = "";
            foreach (DataGridViewRow row in dg_Packing.Rows)
            {
                try
                {
                    //if (row.Cells[0].Value.ToString().Equals(mo.Id_modeloOrden.ToString()))
                    if (row.Cells[4].Value.ToString() != dg_Packing.Rows[row.Index - 1].Cells[4].Value.ToString() && row.Cells[5].Value.ToString() == string.Empty)
                    {
                        ActualBox = row.Cells[2].Value.ToString();
                        break;
                    }
                    //else
                    // ActualBox = "";
                }
                catch (Exception) { }

            }
            return ActualBox;
        }

        private bool BoxActual2()
        {
            bool isValid = false;
            //string ActualBox = "";
            foreach (DataGridViewRow row in dg_Packing.Rows)
            {
                try
                {
                    //if (row.Cells[0].Value.ToString().Equals(mo.Id_modeloOrden.ToString()))
                    if (row.Cells[5].Value.ToString() == string.Empty && row.Cells[4].Value.ToString() == caja.ActualBox && row.Cells[4].Value.ToString() != dg_Packing.Rows[row.Index].Cells[2].Value.ToString())
                    {
                        isValid = true;
                        //ActualBox = row.Cells[4].Value.ToString();
                        break;
                    }
                    //else
                    // ActualBox = "";
                }
                catch (Exception) { }

            }
            return isValid;
        }

        private void btn_Submit_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }


        private void PrintLabel()
        {
            BarTender.Application btapp;
            BarTender.Format btformat;
            btapp = new BarTender.Application();
            //btformat = btapp.Formats.Open(@"C:\Users\leonel.valle\Documents\BarTender\BarTender Documents\Voyager-Test.btw", false, "");
            btformat = btapp.Formats.Open(@"C:\Users\leonel.valle\Documents\BarTender\BarTender Documents\USAT\CHARGEPOINT_LABEL - Copy.btw", false, "");
            //btformat.PrintSetup.NumberSerializedLabels = 1;

            //btformat.SetNamedSubStringValue("PN", pn.Pn);
            //btformat.SetNamedSubStringValue("SN", inprocess.SerialNumber);

            //int Toprint = 1;
            //btformat.PrintSetup.NumberSerializedLabels = Toprint;
            btformat.PrintSetup.NumberSerializedLabels = 1;


            //btformat.SetNamedSubStringValue("SN", inprocess.SerialNumber);
            btformat.PrintOut(false, false);

            //btformat.PrintOut(true, true);

        }

        private void DGFormat()
        {
            int count = 0;
            foreach (DataGridViewRow row in dg_Packing.Rows)
            {
                // if (row.Cells[5].Value.ToString().Equals(string.IsNullOrEmpty(row.Cells[5].Value.ToString())))
                if (row.Cells[5].Value.ToString() != "")
                {
                    //int x = dg_Packing.SelectedRows[0].DisplayIndex;

                    dg_Packing.Rows[row.Index].Selected = true;
                    //dg_Packing.FirstDisplayedScrollingRowIndex = dg_Packing.SelectedRows[0].Index / 2;
                    dg_Packing.Focus();
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    count++;
                }
                else
                {
                    dg_Packing.CurrentCell = dg_Packing.Rows[count].Cells[5];

                    break;
                }
            }
        }
    }
}
