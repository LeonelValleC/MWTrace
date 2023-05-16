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
    public partial class checkSerialsLabel : Form
    {
        ModeloOrden serialnumbers = new ModeloOrden();


        public checkSerialsLabel()
        {
            InitializeComponent();
        }

        private void txt_Serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (serialnumbers.Existe("select count(*) from tb_ModeloOrden where Serialnumber = '" + txt_Serial.Text.Trim() + "'") == true)
                {
                    if (serialnumbers.Existe("select count(*) from tb_ModeloOrden where Serialnumber = '" + txt_Serial.Text.Trim() + "' and box is not null") == true)
                    {
                        txt_SerialBox.Focus();
                        pictureBox1.Image = MWTrace_beta.Properties.Resources.great;
                    }
                    else
                    {
                        pictureBox1.Image = MWTrace_beta.Properties.Resources.bad;
                        MessageBox.Show("Este serial no se escaneo previamente!", "WARNING");
                    }
                }
                else
                {
                    pictureBox1.Image = MWTrace_beta.Properties.Resources.bad;
                    MessageBox.Show("Este serial no existe!", "Error");
                }
            }
        }

        private void txt_SerialBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (serialnumbers.Existe("select count(*) from tb_ModeloOrden where Serialnumber = '" + txt_Serial.Text.Trim() + "' and box is not null") == true)
                {

                    if (txt_Serial.Text.Trim() == txt_SerialBox.Text.Trim())
                    {

                        serialnumbers.Crud("update tb_ModeloOrden set labelsVerified = '" + DateTime.Now + "' where Serialnumber = '" + txt_Serial.Text.Trim() + "'");

                        txt_Serial.Text = "";
                        txt_SerialBox.Text = "";
                        txt_Serial.Focus();

                        pictureBox1.Image = MWTrace_beta.Properties.Resources.great;

                    }
                    else
                    {
                        pictureBox1.Image = MWTrace_beta.Properties.Resources.bad;

                        MessageBox.Show("Los seriales no coinciden!", "Check Serial Numbers!");
                    }
                }
                else
                    MessageBox.Show("Este serial no se escaneo previamente!", "WARNING");

            }

        }

        private void checkSerialsLabel_Load(object sender, EventArgs e)
        {

        }
    }
}
