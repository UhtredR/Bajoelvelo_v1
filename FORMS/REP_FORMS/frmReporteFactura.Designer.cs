namespace Bajoelvelo_v1.FORMS.REP_FORMS
{
    partial class frmReporteFactura
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
            this.sbtnExportarFactura = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // sbtnExportarFactura
            // 
            this.sbtnExportarFactura.BorderRadius = 20;
            this.sbtnExportarFactura.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sbtnExportarFactura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sbtnExportarFactura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sbtnExportarFactura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sbtnExportarFactura.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.sbtnExportarFactura.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnExportarFactura.ForeColor = System.Drawing.Color.Black;
            this.sbtnExportarFactura.Location = new System.Drawing.Point(797, 12);
            this.sbtnExportarFactura.Name = "sbtnExportarFactura";
            this.sbtnExportarFactura.Size = new System.Drawing.Size(157, 42);
            this.sbtnExportarFactura.TabIndex = 13;
            this.sbtnExportarFactura.Text = "Agregar";
            this.sbtnExportarFactura.UseWaitCursor = true;
            this.sbtnExportarFactura.Click += new System.EventHandler(this.sbtnExportarFactura_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 517);
            this.Controls.Add(this.sbtnExportarFactura);
            this.Name = "frmReporteFactura";
            this.Load += new System.EventHandler(this.frmReporteFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnExportarFactura;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}