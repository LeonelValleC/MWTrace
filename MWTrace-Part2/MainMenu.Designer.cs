namespace MWTrace_Part2
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_Order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Status = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.Location = new System.Drawing.Point(86, 116);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(191, 181);
            this.btn_Order.TabIndex = 0;
            this.btn_Order.Text = "New Order";
            this.btn_Order.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(371, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 181);
            this.button1.TabIndex = 1;
            this.button1.Text = "Packaging";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1014, 401);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 401);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Status
            // 
            this.btn_Status.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Status.Location = new System.Drawing.Point(954, 116);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(191, 181);
            this.btn_Status.TabIndex = 7;
            this.btn_Status.Text = "Status";
            this.btn_Status.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Status.UseVisualStyleBackColor = false;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reportes.Location = new System.Drawing.Point(663, 116);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(191, 181);
            this.btn_Reportes.TabIndex = 8;
            this.btn_Reportes.Text = "Reports";
            this.btn_Reportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Reportes.UseVisualStyleBackColor = false;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 649);
            this.Controls.Add(this.btn_Reportes);
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.Text = "MainMenu V1.3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.Button btn_Reportes;
    }
}

