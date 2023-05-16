
namespace MWTrace_beta
{
    partial class checkSerialsLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkSerialsLabel));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Serial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SerialBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scan Serial:";
            // 
            // txt_Serial
            // 
            this.txt_Serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Serial.Location = new System.Drawing.Point(177, 431);
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.Size = new System.Drawing.Size(312, 29);
            this.txt_Serial.TabIndex = 7;
            this.txt_Serial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Serial_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(759, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Scan Serial Box:";
            // 
            // txt_SerialBox
            // 
            this.txt_SerialBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SerialBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_SerialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SerialBox.Location = new System.Drawing.Point(929, 431);
            this.txt_SerialBox.Name = "txt_SerialBox";
            this.txt_SerialBox.Size = new System.Drawing.Size(312, 29);
            this.txt_SerialBox.TabIndex = 9;
            this.txt_SerialBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SerialBox_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(396, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Verify Unit To Box Serial";
            // 
            // checkSerialsLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SerialBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Serial);
            this.Name = "checkSerialsLabel";
            this.Text = "checkSerialsLabel";
            this.Load += new System.EventHandler(this.checkSerialsLabel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Serial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SerialBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}