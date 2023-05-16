﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace MWTrace_beta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void NuevaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaOrden no = new NuevaOrden();

            Form NuevaOrden;
            if ((NuevaOrden = IsFormAlreadyOpen(typeof(NuevaOrden))) == null)
            {
                no.ShowDialog(this);
            }
            else
            {
                NuevaOrden.WindowState = FormWindowState.Normal;
                NuevaOrden.BringToFront();
            }
        }

        private void EnsambleEEtiquetadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialNumber sn = new SerialNumber();
            //NuevaOrden no = new NuevaOrden();

            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(SerialNumber))) == null)
            {
                sn.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }

        private void RetrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassRework r = new PassRework();
            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(PassRework))) == null)
            {
                r.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PCBModelo pm = new PCBModelo();
            //try
            //{
            //    dataGridView1.DataSource = pm.LlenarDG("select * from tb_ModeloOrden").Tables[0];
            //}
            //catch { MessageBox.Show("ERROR!", "no se encontro la base de datos!"); }
        }

        private void BusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda b = new Busqueda();
            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(Busqueda))) == null)
            {
                b.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }

        private void MantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento manto = new Mantenimiento();
            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(Mantenimiento))) == null)
            {
                manto.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes repos = new Reportes();
            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(Reportes))) == null)
            {
                repos.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }

        private void EstatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status estatus = new Status();
            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(Status))) == null)
            {
                estatus.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }

        private void ShippingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shipping shipping = new Shipping();

            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(Shipping))) == null)
            {
                shipping.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }

        private void rMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassRMA shipping = new PassRMA();

            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(PassRMA))) == null)
            {
                shipping.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }

        private void reProgramingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            identify_Rework identify = new identify_Rework();

            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(identify_Rework))) == null)
            {
                identify.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }

        private void reScanBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void scanBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReworkByBoxes identify = new ReworkByBoxes();

            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(ReworkByBoxes))) == null)
            {
                identify.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }

        private void scanUnitsByBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
           checkSerialsLabel identify = new checkSerialsLabel();

            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(checkSerialsLabel))) == null)
            {
                identify.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }

        private void closeBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerifyUnitBoxes identify = new VerifyUnitBoxes();

            Form Next;
            if ((Next = IsFormAlreadyOpen(typeof(VerifyUnitBoxes))) == null)
            {
                identify.ShowDialog(this);
            }
            else
            {
                Next.WindowState = FormWindowState.Normal;
                Next.BringToFront();
            }
        }
    }
}