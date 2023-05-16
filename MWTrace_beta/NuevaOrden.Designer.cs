namespace MWTrace_beta
{
    partial class NuevaOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaOrden));
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.cb_pcb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_sim = new System.Windows.Forms.ComboBox();
            this.cb_operador = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_orden = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_RevisionFirmware = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_revision = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Model = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(142, 423);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 34);
            this.btn_aceptar.TabIndex = 10;
            this.btn_aceptar.Text = "Submit";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // cb_pcb
            // 
            this.cb_pcb.DisplayMember = "id_pcb";
            this.cb_pcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pcb.FormattingEnabled = true;
            this.cb_pcb.Location = new System.Drawing.Point(99, 91);
            this.cb_pcb.Name = "cb_pcb";
            this.cb_pcb.Size = new System.Drawing.Size(281, 21);
            this.cb_pcb.TabIndex = 1;
            this.cb_pcb.ValueMember = "id_pcb";
            this.cb_pcb.SelectionChangeCommitted += new System.EventHandler(this.Cb_pcb_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Sim:";
            // 
            // cb_sim
            // 
            this.cb_sim.DisplayMember = "id_sim";
            this.cb_sim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sim.FormattingEnabled = true;
            this.cb_sim.Location = new System.Drawing.Point(99, 137);
            this.cb_sim.Name = "cb_sim";
            this.cb_sim.Size = new System.Drawing.Size(281, 21);
            this.cb_sim.TabIndex = 3;
            this.cb_sim.ValueMember = "id_sim";
            // 
            // cb_operador
            // 
            this.cb_operador.DisplayMember = "id_operador";
            this.cb_operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_operador.FormattingEnabled = true;
            this.cb_operador.Location = new System.Drawing.Point(99, 274);
            this.cb_operador.Name = "cb_operador";
            this.cb_operador.Size = new System.Drawing.Size(281, 21);
            this.cb_operador.TabIndex = 5;
            this.cb_operador.ValueMember = "id_operador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Employee:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "WO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(262, 359);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView1_RowsAdded);
            // 
            // txt_orden
            // 
            this.txt_orden.Location = new System.Drawing.Point(99, 42);
            this.txt_orden.Name = "txt_orden";
            this.txt_orden.Size = new System.Drawing.Size(151, 20);
            this.txt_orden.TabIndex = 0;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(99, 226);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(151, 20);
            this.txt_cantidad.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "WorkOrder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "PCB:/SubAssy: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Create Work Order";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(389, 444);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(35, 13);
            this.lbl_fecha.TabIndex = 41;
            this.lbl_fecha.Text = "label7";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(223, 423);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 34);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancel";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_RevisionFirmware
            // 
            this.txt_RevisionFirmware.Location = new System.Drawing.Point(99, 369);
            this.txt_RevisionFirmware.Name = "txt_RevisionFirmware";
            this.txt_RevisionFirmware.Size = new System.Drawing.Size(151, 20);
            this.txt_RevisionFirmware.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Firmware:";
            // 
            // txt_revision
            // 
            this.txt_revision.Location = new System.Drawing.Point(99, 325);
            this.txt_revision.Name = "txt_revision";
            this.txt_revision.Size = new System.Drawing.Size(151, 20);
            this.txt_revision.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Revision:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Model:";
            // 
            // cb_Model
            // 
            this.cb_Model.DisplayMember = "id_sim";
            this.cb_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Model.FormattingEnabled = true;
            this.cb_Model.Location = new System.Drawing.Point(99, 184);
            this.cb_Model.Name = "cb_Model";
            this.cb_Model.Size = new System.Drawing.Size(281, 21);
            this.cb_Model.TabIndex = 50;
            this.cb_Model.ValueMember = "id_sim";
            // 
            // NuevaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Model);
            this.Controls.Add(this.txt_revision);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_RevisionFirmware);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.cb_pcb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_sim);
            this.Controls.Add(this.cb_operador);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_orden);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevaOrden";
            this.Text = "Work Order";
            this.Load += new System.EventHandler(this.NuevaOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.ComboBox cb_pcb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_sim;
        private System.Windows.Forms.ComboBox cb_operador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_orden;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_RevisionFirmware;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_revision;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Model;
    }
}