using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxPacking
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


        private void btn_LoadWO_Click(object sender, EventArgs e)
        {
            SubOrder next= new SubOrder();

            Form NuevaOrden;
            if ((NuevaOrden = IsFormAlreadyOpen(typeof(SubOrder))) == null)
            {
                next.ShowDialog(this);
            }
            else
            {
                NuevaOrden.WindowState = FormWindowState.Normal;
                NuevaOrden.BringToFront();
            }
        }

        private void btn_SetupWO_Click(object sender, EventArgs e)
        {
            Set_UP next= new Set_UP();

            Form NuevaOrden;
            if ((NuevaOrden = IsFormAlreadyOpen(typeof(Set_UP))) == null)
            {
                next.ShowDialog(this);
            }
            else
            {
                NuevaOrden.WindowState = FormWindowState.Normal;
                NuevaOrden.BringToFront();
            }
        }

        private void btn_Packing_Click(object sender, EventArgs e)
        {
            WO next = new WO();

            Form NuevaOrden;
            if ((NuevaOrden = IsFormAlreadyOpen(typeof(WO))) == null)
            {
                next.ShowDialog(this);
            }
            else
            {
                NuevaOrden.WindowState = FormWindowState.Normal;
                NuevaOrden.BringToFront();
            }
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            Reports next = new Reports();

            Form NuevaOrden;
            if ((NuevaOrden = IsFormAlreadyOpen(typeof(Reports))) == null)
            {
                next.ShowDialog(this);
            }
            else
            {
                NuevaOrden.WindowState = FormWindowState.Normal;
                NuevaOrden.BringToFront();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
