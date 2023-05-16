using System;
using System.Linq;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class PassRework : Form
    {
        Operador operador = new Operador();
        Conexion con = new Conexion();
        public PassRework()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void PassRework_Load(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                operador.Numeroempleado = Convert.ToInt32(txt_empleado.Text);
                if (txt_empleado.Text == "")
                    throw new Exception();

                operador.Id_operador = int.Parse(operador.ReturnValue("select id_operador from tb_operador where numeroempleado = '" + txt_empleado.Text+ "' and nivel != '5'"));

                if (operador.Id_operador > 0)
                {
                    //orden.Crud("update tb_Orden set id_operador = " + operador.Id_operador + " where orden = " + orden.Ordenes);
                    Retrabajo ee = new Retrabajo();
                    //this.Close();
                    //ee.Show();
                    Form Next;

                    if ((Next = IsFormAlreadyOpen(typeof(Retrabajo))) == null)
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
                    MessageBox.Show("Sin Acceso!");
                    txt_empleado.Text = "";
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
    }
}
