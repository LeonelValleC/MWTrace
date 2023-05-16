using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class OrdenBoxes : Form
    {
        private readonly Conexion con = new Conexion();
        private readonly Orden orden = new Orden();

        public OrdenBoxes()
        {
            InitializeComponent();
        }
        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }


        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                orden.Ordenes = txt_serial.Text;
                if (txt_serial.Text == "")
                    throw new Exception();

                SqlCommand cmd = new SqlCommand("select orden from tb_Orden where orden = " + orden.Ordenes, con.Con1);
                con.Abrir();
                cmd.ExecuteNonQuery();
                double regreso = Convert.ToDouble(cmd.ExecuteScalar());
                if (regreso > 0)
                {
                    //this.Close();
                    //Ensamble_Etiquetado ee = new Ensamble_Etiquetado();
                    VerifyUnitBoxes io = new VerifyUnitBoxes();

                    Form Next;

                    if ((Next = IsFormAlreadyOpen(typeof(VerifyUnitBoxes))) == null)
                    {
                        io.ShowDialog(this);
                        this.Close();
                    }
                    else
                    {
                        Next.WindowState = FormWindowState.Normal;
                        Next.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro");
                    txt_serial.Text = "";
                }

                con.Cerrar();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existe ese registro", "ERROR!");
                con.Cerrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Inserte una orden");
            }
        }

        private void OrdenBoxes_Load(object sender, EventArgs e)
        {

        }

        private void txt_serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_aceptar_Click(this, new EventArgs());
            }
        }
    }
}
