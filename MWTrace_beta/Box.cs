namespace MWTrace_beta
{
    class Box : Conexion
    {
        int id_box;
        int id_box_compare;
        string box;
        bool isVerified;
        int countBox;


        public int Id_box { get => id_box; set => id_box = value; }
        public string Boxes { get => box; set => box = value; }
        public int Id_box_compare { get => id_box_compare; set => id_box_compare = value; }
        public bool IsVerified { get => isVerified; set => isVerified = value; }



        public int CreateNewBox()
        {
            countBox = int.Parse(ReturnValue("select countBox from ConfiguracionSistema where id_cs = 1"));

            box = ReturnValue("select concat('USAT', DATEPART(iso_week, getdate()),format(getdate(),'yy'),right('000000' + cast("+countBox+" as varchar),6))");

            id_box = int.Parse(ReturnID("insert into box values('"+box+ "'); SELECT SCOPE_IDENTITY();"));
            //caja.Id_caja = int.Parse(caja.ReturnID("insert into tb_caja(caja,Modelo) values('" + txt_caja.Text.ToUpper().Trim() + "' , '" + txt_modeloCaja.Text.ToUpper().Trim() + "'); SELECT SCOPE_IDENTITY();"));


            countBox++;

            Crud("update ConfiguracionSistema set countBox = " + countBox + " where id_cs = 1");


            return id_box;
        }
    }
}
