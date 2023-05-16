namespace BoxPacking
{
    partial class Reports
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
            this.dg_Reports = new System.Windows.Forms.DataGridView();
            this.btn_Report = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Reports)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Reports
            // 
            this.dg_Reports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Reports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_Reports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dg_Reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Reports.Location = new System.Drawing.Point(12, 181);
            this.dg_Reports.Name = "dg_Reports";
            this.dg_Reports.Size = new System.Drawing.Size(1088, 358);
            this.dg_Reports.TabIndex = 0;
            // 
            // btn_Report
            // 
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Location = new System.Drawing.Point(1025, 152);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(75, 23);
            this.btn_Report.TabIndex = 1;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter:";
            // 
            // cb_Filter
            // 
            this.cb_Filter.FormattingEnabled = true;
            this.cb_Filter.Items.AddRange(new object[] {
            "Orden",
            "Fecha Registro",
            "Serial Number",
            "Scan Modem",
            "Scan Sim",
            "Modelo"});
            this.cb_Filter.Location = new System.Drawing.Point(12, 50);
            this.cb_Filter.Name = "cb_Filter";
            this.cb_Filter.Size = new System.Drawing.Size(351, 21);
            this.cb_Filter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(12, 123);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(348, 20);
            this.txt_Search.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(393, 120);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Submit";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 551);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.dg_Reports);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Reports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Reports;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
    }
}