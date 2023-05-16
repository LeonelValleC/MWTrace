using System;
using System.Windows.Forms;

namespace BoxPacking
{
    public partial class Form1 : Form
    {
        private readonly OrdenModelo om = new OrdenModelo();
        private readonly Operador op = new Operador();
        private readonly Caja caja = new Caja();
        private readonly Pallette pallette = new Pallette();
        int consecutive;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadLB()
        {
            om.Id_Omodelo = int.Parse(om.ReturnID("select id_Omodelo from tb_OrdenModelo where workorder = '" + om.Workorder + "'"));
            lbl_FinalWO.Text = om.Workorder;
            //lbl_TOPWO.Text = om.ReturnValue("select o.orden from tb_OrdenModelo om join tb_Orden o on om.id_orden = o.id_orden where o.id_orden = " + orden.Id_orden);
            lbl_Empleado.Text = om.ReturnValue("select o.numeroempleado from tb_Operador o where o.id_operador =  " + op.Id_operador);
            lbl_Assy.Text = om.ReturnValue("select m.modelo from tb_Modelo m join tb_OrdenModelo om on om.id_modelo = m.id_modelo where om.id_Omodelo = " + om.Id_Omodelo);
            om.UCaja = int.Parse(om.ReturnValue("select UCaja from tb_OrdenModelo where om.id_Omodelo = " + om.Id_Omodelo));
            om.Cantidad = int.Parse(om.ReturnValue("select cantidad from tb_OrdenModelo where om.id_Omodelo = " + om.Id_Omodelo));
            caja.Id_caja = int.Parse(caja.ReturnValue("select top 1 id_caja from tb_caja order by caja desc"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLB();

            //dataGridView1.DataSource = om.LlenarDG("select * from tb_SecondAssy where scan = 1 and id_Omodelo = " + om.Id_Omodelo).Tables[0];
            dataGridView1.DataSource = om.LlenarDG("select mo.Serialnumber, om.workorder from tb_SecondAssy sa join tb_ModeloOrden mo on sa.id_ModeloOrden = mo.id_modeloOrden join tb_OrdenModelo om on sa.id_Omodelo = om.id_Omodelo where sa.scan = 1 and sa.id_Omodelo = " + om.Id_Omodelo).Tables[0];

            //caja.Cajas = int.Parse(caja.ReturnValue("select count(*) from tb_SecondAssy where id_caja = " + caja.Id_caja));

            //if (caja.Cajas < om.UCaja)
            //{

            //}
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

        }

        private void SiguienteCaja()
        {
            caja.Cajas = int.Parse(caja.ReturnValue("select TOP 1 caja from tb_caja order by id_caja desc"));

            caja.Cajas++;

            caja.Id_caja = int.Parse(caja.ReturnID("insert into tb_caja(caja) values('" + caja.Cajas + "'); SELECT SCOPE_IDENTITY();"));
        }

        private void SiguientePallette()
        {
            pallette.Pallettes = int.Parse(pallette.ReturnValue("select TOP 1 pallette from tb_Pallete order by id_pallette desc"));

            pallette.Pallettes++;

            pallette.Id_pallette = int.Parse(pallette.ReturnID("insert into tb_caja(caja) values('" + caja.Cajas + "'); SELECT SCOPE_IDENTITY();"));
        }
    }
}