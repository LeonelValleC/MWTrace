using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MWTrace_Part2
{
    public partial class Identificar_Operador : Form
    {
        private readonly Operador operador = new Operador();
        private readonly OrdenModelo orden = new OrdenModelo();
        public Identificar_Operador()
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
                operador.Numeroempleado = Convert.ToInt32(txt_empleado.Text);
                if (txt_empleado.Text == "")
                    throw new Exception();

                operador.Id_operador = int.Parse(operador.ReturnValue("select id_operador from tb_operador where numeroempleado = " + txt_empleado.Text));

                if (operador.Id_operador > 0)
                {
                    //orden.Crud("update tb_OrdenModelo set id_operador = " + operador.Id_operador + " where workorder = " + orden.Workorder);
                    Assemble ee = new Assemble();
                    //this.Close();
                    //ee.Show();
                    Form Next;

                    if ((Next = IsFormAlreadyOpen(typeof(Assemble))) == null)
                    {
                        ee.ShowDialog(this);
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
                    txt_empleado.Text = "";
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
                MessageBox.Show("Inserte un Operador!");
            }
        }

        private void txt_empleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_aceptar_Click(this, new EventArgs());
            }
        }

        private void Identificar_Operador_Load(object sender, EventArgs e)
        {

        }
    }
}
