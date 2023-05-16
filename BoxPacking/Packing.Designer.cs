namespace BoxPacking
{
    partial class Packing
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
            this.dg_Packing = new System.Windows.Forms.DataGridView();
            this.txt_SN = new System.Windows.Forms.TextBox();
            this.txt_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Records = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_WO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Packing)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Packing
            // 
            this.dg_Packing.AllowUserToAddRows = false;
            this.dg_Packing.AllowUserToDeleteRows = false;
            this.dg_Packing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Packing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Packing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Packing.Location = new System.Drawing.Point(12, 201);
            this.dg_Packing.MultiSelect = false;
            this.dg_Packing.Name = "dg_Packing";
            this.dg_Packing.ReadOnly = true;
            this.dg_Packing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Packing.Size = new System.Drawing.Size(1608, 408);
            this.dg_Packing.TabIndex = 10;
            this.dg_Packing.VirtualMode = true;
            // 
            // txt_SN
            // 
            this.txt_SN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_SN.Location = new System.Drawing.Point(591, 51);
            this.txt_SN.Name = "txt_SN";
            this.txt_SN.Size = new System.Drawing.Size(480, 20);
            this.txt_SN.TabIndex = 1;
            // 
            // txt_Box
            // 
            this.txt_Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Box.Enabled = false;
            this.txt_Box.Location = new System.Drawing.Point(591, 109);
            this.txt_Box.Name = "txt_Box";
            this.txt_Box.Size = new System.Drawing.Size(480, 20);
            this.txt_Box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serial Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Box:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(797, 150);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            this.btn_Submit.Enter += new System.EventHandler(this.btn_Submit_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Records:";
            // 
            // lbl_Records
            // 
            this.lbl_Records.AutoSize = true;
            this.lbl_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Records.Location = new System.Drawing.Point(89, 182);
            this.lbl_Records.Name = "lbl_Records";
            this.lbl_Records.Size = new System.Drawing.Size(39, 16);
            this.lbl_Records.TabIndex = 7;
            this.lbl_Records.Text = "QTY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Actual:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1305, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "WO:";
            // 
            // lbl_WO
            // 
            this.lbl_WO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_WO.AutoSize = true;
            this.lbl_WO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WO.Location = new System.Drawing.Point(1348, 9);
            this.lbl_WO.Name = "lbl_WO";
            this.lbl_WO.Size = new System.Drawing.Size(51, 16);
            this.lbl_WO.TabIndex = 12;
            this.lbl_WO.Text = "label7";
            // 
            // Packing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 621);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_WO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Records);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Box);
            this.Controls.Add(this.txt_SN);
            this.Controls.Add(this.dg_Packing);
            this.Name = "Packing";
            this.Text = "Packing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Packing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Packing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Packing;
        private System.Windows.Forms.TextBox txt_SN;
        private System.Windows.Forms.TextBox txt_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Records;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_WO;
    }
}