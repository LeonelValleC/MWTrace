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

namespace BoxPacking
{
    public partial class WO : Form
    {
        //Orden orden = new Orden();
        private readonly OrdenModelo orden = new OrdenModelo();

        public WO()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                orden.Workorder = txt_Orden.Text;
                if (txt_Orden.Text == "")
                    throw new Exception();

                //SqlCommand cmd = new SqlCommand("select workorder from tb_OrdenModelo where workorder = '" + orden.Workorder + "'", orden.Con1);
                SqlCommand cmd = new SqlCommand("select id_Omodelo from tb_OrdenModelo where workorder = '" + orden.Workorder + "'", orden.Con1);
                orden.Abrir();
                cmd.ExecuteNonQuery();
                double regreso = Convert.ToDouble(cmd.ExecuteScalar());
                if (regreso > 0)
                {
                    //this.Close();
                    //Ensamble_Etiquetado ee = new Ensamble_Etiquetado();
                    Identificar_Operador io = new Identificar_Operador();

                    Form Next;

                    if ((Next = IsFormAlreadyOpen(typeof(Identificar_Operador))) == null)
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
                    txt_Orden.Text = "";
                }

                orden.Cerrar();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existe ese registro", "ERROR!");
                orden.Cerrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Inserte una orden");
            }
        }

        private void WO_Load(object sender, EventArgs e)
        {
            ActiveControl = txt_Orden;
            txt_Orden.Focus();
        }

        private void Txt_Orden_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_aceptar_Click(this, new EventArgs());
            }
        }
    }
}
