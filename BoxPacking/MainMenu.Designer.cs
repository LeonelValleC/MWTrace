namespace BoxPacking
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_LoadWO = new System.Windows.Forms.ToolStripButton();
            this.btn_SetupWO = new System.Windows.Forms.ToolStripButton();
            this.btn_Packing = new System.Windows.Forms.ToolStripButton();
            this.btn_Reports = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_LoadWO,
            this.btn_SetupWO,
            this.btn_Packing,
            this.btn_Reports});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(151, 485);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_LoadWO
            // 
            this.btn_LoadWO.BackColor = System.Drawing.Color.Transparent;
            this.btn_LoadWO.Image = ((System.Drawing.Image)(resources.GetObject("btn_LoadWO.Image")));
            this.btn_LoadWO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_LoadWO.Name = "btn_LoadWO";
            this.btn_LoadWO.Size = new System.Drawing.Size(150, 25);
            this.btn_LoadWO.Text = "Load Work Order";
            this.btn_LoadWO.Click += new System.EventHandler(this.btn_LoadWO_Click);
            // 
            // btn_SetupWO
            // 
            this.btn_SetupWO.Image = ((System.Drawing.Image)(resources.GetObject("btn_SetupWO.Image")));
            this.btn_SetupWO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SetupWO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SetupWO.Name = "btn_SetupWO";
            this.btn_SetupWO.Size = new System.Drawing.Size(109, 25);
            this.btn_SetupWO.Text = "Set-Up WO";
            this.btn_SetupWO.Click += new System.EventHandler(this.btn_SetupWO_Click);
            // 
            // btn_Packing
            // 
            this.btn_Packing.Image = ((System.Drawing.Image)(resources.GetObject("btn_Packing.Image")));
            this.btn_Packing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Packing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Packing.Name = "btn_Packing";
            this.btn_Packing.Size = new System.Drawing.Size(83, 25);
            this.btn_Packing.Text = "Packing";
            this.btn_Packing.Click += new System.EventHandler(this.btn_Packing_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reports.Image")));
            this.btn_Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(84, 25);
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(736, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 485);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainMenu";
            this.Text = "MainMenu [V 1.1]";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_LoadWO;
        private System.Windows.Forms.ToolStripButton btn_SetupWO;
        private System.Windows.Forms.ToolStripButton btn_Packing;
        private System.Windows.Forms.ToolStripButton btn_Reports;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}