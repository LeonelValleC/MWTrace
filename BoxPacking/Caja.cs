﻿namespace BoxPacking
{
    internal class Caja : Conexion
    {
        private int id_caja;
        private int cajas;
        private string box;
        private string previousBox;
        private string actualBox;
        private int id_pallete;
        private int top;
        private int contador;

        public int Id_caja { get => id_caja; set => id_caja = value; }
        public int Cajas { get => cajas; set => cajas = value; }
        public int Id_pallete { get => id_pallete; set => id_pallete = value; }
        public int Top { get => top; set => top = value; }
        public int Contador { get => contador; set => contador = value; }
        public string PreviousBox { get => previousBox; set => previousBox = value; }
        public string ActualBox { get => actualBox; set => actualBox = value; }
        public string Box { get => box; set => box = value; }
    }
}