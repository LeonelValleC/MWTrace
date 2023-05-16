namespace MWTrace_Part2
{
    partial class Assemble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assemble));
            this.lbl_SN = new System.Windows.Forms.Label();
            this.txt_SerialNumber = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_SerialNumber1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Assy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SN
            // 
            this.lbl_SN.AutoSize = true;
            this.lbl_SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SN.Location = new System.Drawing.Point(422, 348);
            this.lbl_SN.Name = "lbl_SN";
            this.lbl_SN.Size = new System.Drawing.Size(120, 18);
            this.lbl_SN.TabIndex = 1;
            this.lbl_SN.Text = "Serial Number:";
            // 
            // txt_SerialNumber
            // 
            this.txt_SerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SerialNumber.Location = new System.Drawing.Point(97, 369);
            this.txt_SerialNumber.Name = "txt_SerialNumber";
            this.txt_SerialNumber.Size = new System.Drawing.Size(758, 22);
            this.txt_SerialNumber.TabIndex = 3;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(432, 397);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(93, 28);
            this.btn_Submit.TabIndex = 9;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            this.btn_Submit.Enter += new System.EventHandler(this.Btn_Submit_Enter);
            // 
            // txt_SerialNumber1
            // 
            this.txt_SerialNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SerialNumber1.Location = new System.Drawing.Point(97, 323);
            this.txt_SerialNumber1.Name = "txt_SerialNumber1";
            this.txt_SerialNumber1.Size = new System.Drawing.Size(758, 22);
            this.txt_SerialNumber1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Serial Number:";
            // 
            // txt_Assy
            // 
            this.txt_Assy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Assy.Location = new System.Drawing.Point(97, 273);
            this.txt_Assy.Name = "txt_Assy";
            this.txt_Assy.Size = new System.Drawing.Size(758, 24);
            this.txt_Assy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Assambly:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Assemble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Assy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SerialNumber1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_SerialNumber);
            this.Controls.Add(this.lbl_SN);
            this.Name = "Assemble";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Verification [V1.1]";
            this.Load += new System.EventHandler(this.Assemble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_SN;
        private System.Windows.Forms.TextBox txt_SerialNumber;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_SerialNumber1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Assy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}