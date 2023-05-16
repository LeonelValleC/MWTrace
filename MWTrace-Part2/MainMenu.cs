using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWTrace_Part2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            SubOrder sub = new SubOrder();

            Form next;
            if ((next = IsFormAlreadyOpen(typeof(SubOrder))) == null)
            {
                sub.ShowDialog(this);
            }
            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WO wo = new WO();

            Form next;
            if ((next = IsFormAlreadyOpen(typeof(WO))) == null)
            {
                wo.ShowDialog(this);
            }
            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            Status status = new Status();

            Form next;
            if ((next = IsFormAlreadyOpen(typeof(Status))) == null)
            {
                status.ShowDialog(this);
            }
            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            Reportes reports = new Reportes();

            Form next;
            if ((next = IsFormAlreadyOpen(typeof(Reportes))) == null)
            {
                reports.ShowDialog(this);
            }
            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
