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
    public partial class SubOrder : Form
    {
        private readonly Modelo modelo = new Modelo();
        private readonly OrdenModelo ordenModelo = new OrdenModelo();
        private readonly Orden orden = new Orden();

        public SubOrder()
        {
            InitializeComponent();
        }

        private void SubOrder_Load(object sender, EventArgs e)
        {
            //dg_Orders.DataSource = orden.LlenarDG("select orden from tb_Orden").Tables[0];
            //dg_Orders.DataSource = orden.LlenarDG("select distinct o.orden, count(mo.scan) as 'Scanning', o.cantidad from tb_Orden o join tb_ModeloOrden mo  on mo.id_orden = o.id_orden where mo.scan is not null group by o.orden, o.cantidad, mo.scan having count(mo.scan) < o.cantidad").Tables[0];
            dg_Orders.DataSource = orden.LlenarDG("select workorder, modelo from tb_OrdenModelo om  join tb_Modelo m on m.id_modelo = om.id_modelo where Restantes > 0 or Restantes is null").Tables[0];

            cb_Modelo.DataSource = modelo.LlenarComboBox("select * from tb_Modelo");
            cb_Modelo.DisplayMember = "modelo";
            cb_Modelo.ValueMember = "id_modelo";
            cb_Modelo.SelectedItem = null;

        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Workorder.Text) && !string.IsNullOrEmpty(txt_Cantidad.Text) && !string.IsNullOrEmpty(txt_caja.Text))
            {
                //if (!ordenModelo.Existe("select COUNT(*) from tb_Orden where orden = '" + txt_TopWO.Text + "'"))
                //{
                //orden.Id_orden = int.Parse(orden.ReturnID("Select id_orden from tb_Orden where orden ='" + txt_TopWO.Text + "'"));
                if (!ordenModelo.Existe("select COUNT(*) from tb_OrdenModelo where workorder = '" + txt_Workorder.Text + "'"))
                {
                    //CantidadOrden();
                    //if (int.Parse(txt_Cantidad.Text) <= orden.Cantidad)
                    //{
                    //if (int.Parse(txt_Cantidad.Text) <= CountScanning() && int.Parse(txt_Cantidad.Text) > 0)
                    //{
                    //ordenModelo.Crud("insert into tb_OrdenModelo(workorder, cantidad, id_modelo, id_orden) values('" + txt_Workorder.Text + "','" + txt_Cantidad.Text + "','" + cb_Modelo.SelectedValue + "','" + orden.Id_orden + "')");
                    ordenModelo.Crud("insert into tb_OrdenModelo(workorder, cantidad, id_modelo, fecha, UCaja) values('" + txt_Workorder.Text + "','" + txt_Cantidad.Text + "','" + cb_Modelo.SelectedValue + "','" + DateTime.Now + "','" + txt_caja.Text + "')");
                    MessageBox.Show("Nueva WorkOrder Registrada!");
                    SubOrder_Load(sender, e);
                    ClearTextBox();
                    //}
                    //else
                    //    MessageBox.Show("No hay suficientes Sub-Ensambles para la orden");
                    //}
                    //else { MessageBox.Show("La workorder es mayor a la Top-workorder!", "ERROR!"); }
                }
                else { MessageBox.Show("Esta Top WorkOrder ya existe!", "ERROR!"); }
                //}
                //else { MessageBox.Show("Esta orden ya existe!", "ERROR!"); }
            }
            else { MessageBox.Show("Llene todos los campos!", "ERROR!"); }
        }

        //private void CantidadOrden()
        //{
        //    orden.Cantidad = int.Parse(orden.ReturnValue("select cantidad from tb_Orden where id_orden = " + orden.Id_orden));
        //}

        //private int CountScanning()
        //{
        //    int total;

        //    total = int.Parse(orden.ReturnValue("select o.cantidad - count(mo.scan) as RES from tb_ModeloOrden mo join tb_Orden o on o.id_orden = mo.id_orden where o.id_orden = " + orden.Id_orden + " group by o.cantidad"));

        //    return total;
        //}


        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Text = "";
                }
            }
            //txt_Cantidad.Text = "";
            //txt_TopWO.Text = "";
            //txt_Workorder.Text = "";
            cb_Modelo.SelectedItem = null;
        }
    }
}
