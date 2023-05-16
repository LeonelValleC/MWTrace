namespace BoxPacking
{
    partial class Caja_Inicial
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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Caja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(192, 72);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caja Inicial:";
            // 
            // txt_Caja
            // 
            this.txt_Caja.Location = new System.Drawing.Point(79, 35);
            this.txt_Caja.Name = "txt_Caja";
            this.txt_Caja.Size = new System.Drawing.Size(330, 20);
            this.txt_Caja.TabIndex = 2;
            // 
            // Caja_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 123);
            this.Controls.Add(this.txt_Caja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Aceptar);
            this.Name = "Caja_Inicial";
            this.Text = "Caja_Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Caja;
    }
}