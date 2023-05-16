namespace BoxPacking
{
    partial class Set_UP
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_WO = new System.Windows.Forms.TextBox();
            this.txt_SNInit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WorkOrder:";
            // 
            // txt_WO
            // 
            this.txt_WO.Location = new System.Drawing.Point(251, 52);
            this.txt_WO.Name = "txt_WO";
            this.txt_WO.Size = new System.Drawing.Size(320, 20);
            this.txt_WO.TabIndex = 1;
            // 
            // txt_SNInit
            // 
            this.txt_SNInit.Location = new System.Drawing.Point(251, 101);
            this.txt_SNInit.Name = "txt_SNInit";
            this.txt_SNInit.Size = new System.Drawing.Size(320, 20);
            this.txt_SNInit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SN Inicial:";
            // 
            // txt_NEmpleado
            // 
            this.txt_NEmpleado.Location = new System.Drawing.Point(251, 150);
            this.txt_NEmpleado.Name = "txt_NEmpleado";
            this.txt_NEmpleado.Size = new System.Drawing.Size(320, 20);
            this.txt_NEmpleado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N# Empleado:";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(303, 213);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(430, 213);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Set_UP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 272);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_NEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SNInit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_WO);
            this.Controls.Add(this.label1);
            this.Name = "Set_UP";
            this.Text = "Set_UP";
            this.Load += new System.EventHandler(this.Set_UP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_WO;
        private System.Windows.Forms.TextBox txt_SNInit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}