
namespace MWTrace_beta
{
    partial class CloseReworkBox
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
            this.dgv_UnitsOnBoxes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Serial = new System.Windows.Forms.TextBox();
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
            this.dgv_UnitsOnBoxes.Location = new System.Drawing.Point(12, 124);
            this.dgv_UnitsOnBoxes.Name = "dgv_UnitsOnBoxes";
            this.dgv_UnitsOnBoxes.ReadOnly = true;
            this.dgv_UnitsOnBoxes.Size = new System.Drawing.Size(1213, 529);
            this.dgv_UnitsOnBoxes.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scan Serial:";
            // 
            // txt_Serial
            // 
            this.txt_Serial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Serial.Location = new System.Drawing.Point(478, 68);
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.Size = new System.Drawing.Size(312, 29);
            this.txt_Serial.TabIndex = 5;
            this.txt_Serial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Serial_KeyDown);
            // 
            // CloseReworkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 665);
            this.Controls.Add(this.dgv_UnitsOnBoxes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Serial);
            this.Name = "CloseReworkBox";
            this.Text = "CloseReworkBox";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UnitsOnBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_UnitsOnBoxes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Serial;
    }
}