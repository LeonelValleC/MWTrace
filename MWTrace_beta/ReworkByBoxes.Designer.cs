
namespace MWTrace_beta
{
    partial class ReworkByBoxes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_UnitsOnBoxes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Serial = new System.Windows.Forms.TextBox();
            this.btn_CloseBox = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UnitsOnBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_UnitsOnBoxes
            // 
            this.dgv_UnitsOnBoxes.AllowUserToAddRows = false;
            this.dgv_UnitsOnBoxes.AllowUserToDeleteRows = false;
            this.dgv_UnitsOnBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_UnitsOnBoxes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UnitsOnBoxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UnitsOnBoxes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_UnitsOnBoxes.Location = new System.Drawing.Point(12, 184);
            this.dgv_UnitsOnBoxes.Name = "dgv_UnitsOnBoxes";
            this.dgv_UnitsOnBoxes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UnitsOnBoxes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_UnitsOnBoxes.Size = new System.Drawing.Size(1286, 423);
            this.dgv_UnitsOnBoxes.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scan Serial:";
            // 
            // txt_Serial
            // 
            this.txt_Serial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Serial.Location = new System.Drawing.Point(444, 102);
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.Size = new System.Drawing.Size(312, 29);
            this.txt_Serial.TabIndex = 5;
            this.txt_Serial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Serial_KeyDown);
            // 
            // btn_CloseBox
            // 
            this.btn_CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseBox.Location = new System.Drawing.Point(829, 74);
            this.btn_CloseBox.Name = "btn_CloseBox";
            this.btn_CloseBox.Size = new System.Drawing.Size(190, 85);
            this.btn_CloseBox.TabIndex = 10;
            this.btn_CloseBox.Text = "Caja Escaneada";
            this.btn_CloseBox.UseVisualStyleBackColor = true;
            this.btn_CloseBox.Click += new System.EventHandler(this.btn_CloseBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Open Box to Scan Units";
            // 
            // ReworkByBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 619);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_CloseBox);
            this.Controls.Add(this.dgv_UnitsOnBoxes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Serial);
            this.Name = "ReworkByBoxes";
            this.Text = "ReworkByBoxes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UnitsOnBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_UnitsOnBoxes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Serial;
        private System.Windows.Forms.Button btn_CloseBox;
        private System.Windows.Forms.Label label3;
    }
}