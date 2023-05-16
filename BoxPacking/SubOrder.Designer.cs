namespace BoxPacking
{
    partial class SubOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Workorder = new System.Windows.Forms.TextBox();
            this.dg_Orders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Modelo = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_caja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WorkOrder:";
            // 
            // txt_Workorder
            // 
            this.txt_Workorder.Location = new System.Drawing.Point(79, 60);
            this.txt_Workorder.Name = "txt_Workorder";
            this.txt_Workorder.Size = new System.Drawing.Size(247, 20);
            this.txt_Workorder.TabIndex = 2;
            // 
            // dg_Orders
            // 
            this.dg_Orders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Orders.DefaultCellStyle = dataGridViewCellStyle5;
            this.dg_Orders.Location = new System.Drawing.Point(403, 60);
            this.dg_Orders.Name = "dg_Orders";
            this.dg_Orders.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_Orders.Size = new System.Drawing.Size(356, 355);
            this.dg_Orders.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "WorkOrder";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(79, 116);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(247, 20);
            this.txt_Cantidad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TopAssy:";
            // 
            // cb_Modelo
            // 
            this.cb_Modelo.FormattingEnabled = true;
            this.cb_Modelo.Location = new System.Drawing.Point(79, 174);
            this.cb_Modelo.Name = "cb_Modelo";
            this.cb_Modelo.Size = new System.Drawing.Size(247, 21);
            this.cb_Modelo.TabIndex = 4;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(99, 337);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(79, 31);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Salmon;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(221, 337);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(79, 31);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // txt_caja
            // 
            this.txt_caja.Location = new System.Drawing.Point(79, 231);
            this.txt_caja.Name = "txt_caja";
            this.txt_caja.Size = new System.Drawing.Size(247, 20);
            this.txt_caja.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unidad/Caja:";
            // 
            // SubOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.txt_caja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cb_Modelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_Orders);
            this.Controls.Add(this.txt_Workorder);
            this.Controls.Add(this.label1);
            this.Name = "SubOrder";
            this.Text = "SubOrder";
            this.Load += new System.EventHandler(this.SubOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Workorder;
        private System.Windows.Forms.DataGridView dg_Orders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Modelo;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_caja;
        private System.Windows.Forms.Label label5;
    }
}