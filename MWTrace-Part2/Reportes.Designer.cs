namespace MWTrace_Part2
{
    partial class Reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_Busqueda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Busqueda = new System.Windows.Forms.TextBox();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Busqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Busqueda
            // 
            this.dg_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Busqueda.Location = new System.Drawing.Point(12, 137);
            this.dg_Busqueda.Name = "dg_Busqueda";
            this.dg_Busqueda.Size = new System.Drawing.Size(1110, 426);
            this.dg_Busqueda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter:";
            // 
            // cb_Filtro
            // 
            this.cb_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Filtro.FormattingEnabled = true;
            this.cb_Filtro.Items.AddRange(new object[] {
            "Orden",
            "Fecha Registro",
            "Serial Number",
            "Scan Modem",
            "Scan Sim",
            "Modelo"});
            this.cb_Filtro.Location = new System.Drawing.Point(12, 39);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(160, 21);
            this.cb_Filtro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search:";
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.Location = new System.Drawing.Point(208, 40);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Size = new System.Drawing.Size(405, 20);
            this.txt_Busqueda.TabIndex = 4;
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reporte.Location = new System.Drawing.Point(1047, 92);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(75, 39);
            this.btn_Reporte.TabIndex = 6;
            this.btn_Reporte.Text = "Report";
            this.btn_Reporte.UseVisualStyleBackColor = true;
            this.btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "MM/DD/YYYY";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(644, 39);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(71, 21);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 575);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.txt_Busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Filtro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Busqueda);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Busqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Filtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Busqueda;
        private System.Windows.Forms.Button btn_Reporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Search;
    }
}