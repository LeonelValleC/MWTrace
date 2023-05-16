using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class ReworkByBoxes : Form
    {
        /// <summary>
        /// En este modulo se verifican las unidades por caja 
        /// se crea la caja (Box en la tabla tb_modeloOrden)
        /// </summary>
        ModeloOrden serialnumbers = new ModeloOrden();
        Box boxes = new Box();
        //List<ModeloOrden> seriales = new List<ModeloOrden>();
        List<string> seriales = new List<string>();
        DataTable dt_Serials = new DataTable();
        public ReworkByBoxes()
        {
            InitializeComponent();
        }

        private void btn_CloseBox_Click(object sender, EventArgs e)
        {
            boxes.Id_box = boxes.CreateNewBox();
            foreach (var item in seriales)
            {
                serialnumbers.Crud("update tb_ModeloOrden set box = '" + boxes.Id_box + "' where Serialnumber = '" + item.Trim() + "'");

            }
            MessageBox.Show("Caja completa!!");
            //dgv_UnitsOnBoxes.Columns.Clear();
            dgv_UnitsOnBoxes.DataSource = null;
            dgv_UnitsOnBoxes.Rows.Clear();
            dgv_UnitsOnBoxes.Refresh();

            seriales.Clear();
            dt_Serials.Clear();

            boxes.Id_box = 0;
            txt_Serial.Text = "";
            txt_Serial.Focus();

        }

        private void txt_Serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (serialnumbers.Existe("select count(*) from tb_ModeloOrden where Serialnumber = '" + txt_Serial.Text.Trim() + "'") == true)
                {
                    if (seriales.Count() < 4)
                    {
                        if (seriales.Contains(txt_Serial.Text.Trim()) == false)
                        {
                            if (serialnumbers.Existe("select count(*) from tb_ModeloOrden where Serialnumber = '" + txt_Serial.Text.Trim() + "' and box is null") == true)
                            {

                                seriales.Add(txt_Serial.Text.Trim());
                                dt_Serials.Merge(serialnumbers.LlenarDG("select Serialnumber, scanmodem as MAC, scansim as SIM, fecharegistro from tb_ModeloOrden where Serialnumber = '" + txt_Serial.Text.Trim() + "'").Tables[0]);
                                dgv_UnitsOnBoxes.DataSource = dt_Serials;

                                txt_Serial.Text = "";
                                txt_Serial.Focus();

                            }
                            else
                                MessageBox.Show("Esta unidad ya a sido escaneada!");

                        }
                        else
                        {
                            MessageBox.Show("Serial ya fue ingresado!");
                        }
                    }
                    else
                        MessageBox.Show("Caja llena!");
                }
                else
                    MessageBox.Show("Serial Number not Exist!", "Error Scan!");
            }
        }
    }
}
