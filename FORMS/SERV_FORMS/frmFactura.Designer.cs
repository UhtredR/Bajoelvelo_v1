namespace Bajoelvelo_v1.FORMS.SERV_FORMS
{
    partial class frmFactura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sBtnMinimizar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sBtnMaximizar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sBtnCerrar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.dgFacturas = new System.Windows.Forms.DataGridView();
            this.sbtnImprimir = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.stxtBuscar = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.sbtnEliminar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sbtnBuscar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel1.Controls.Add(this.pictureBox1);
            this.siticoneGradientPanel1.Controls.Add(this.sBtnMinimizar);
            this.siticoneGradientPanel1.Controls.Add(this.sBtnMaximizar);
            this.siticoneGradientPanel1.Controls.Add(this.sBtnCerrar);
            this.siticoneGradientPanel1.Controls.Add(this.siticoneHtmlLabel5);
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.White;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(962, 54);
            this.siticoneGradientPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // sBtnMinimizar
            // 
            this.sBtnMinimizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sBtnMinimizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sBtnMinimizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sBtnMinimizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sBtnMinimizar.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.sBtnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sBtnMinimizar.ForeColor = System.Drawing.Color.White;
            this.sBtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("sBtnMinimizar.Image")));
            this.sBtnMinimizar.Location = new System.Drawing.Point(834, 0);
            this.sBtnMinimizar.Name = "sBtnMinimizar";
            this.sBtnMinimizar.Size = new System.Drawing.Size(43, 21);
            this.sBtnMinimizar.TabIndex = 3;
            // 
            // sBtnMaximizar
            // 
            this.sBtnMaximizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sBtnMaximizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sBtnMaximizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sBtnMaximizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sBtnMaximizar.FillColor = System.Drawing.Color.SteelBlue;
            this.sBtnMaximizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sBtnMaximizar.ForeColor = System.Drawing.Color.White;
            this.sBtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("sBtnMaximizar.Image")));
            this.sBtnMaximizar.Location = new System.Drawing.Point(873, 0);
            this.sBtnMaximizar.Name = "sBtnMaximizar";
            this.sBtnMaximizar.Size = new System.Drawing.Size(43, 21);
            this.sBtnMaximizar.TabIndex = 4;
            // 
            // sBtnCerrar
            // 
            this.sBtnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sBtnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sBtnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sBtnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sBtnCerrar.FillColor = System.Drawing.Color.Maroon;
            this.sBtnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sBtnCerrar.ForeColor = System.Drawing.Color.White;
            this.sBtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("sBtnCerrar.Image")));
            this.sBtnCerrar.Location = new System.Drawing.Point(916, 0);
            this.sBtnCerrar.Name = "sBtnCerrar";
            this.sBtnCerrar.Size = new System.Drawing.Size(43, 21);
            this.sBtnCerrar.TabIndex = 5;
            this.sBtnCerrar.Click += new System.EventHandler(this.sBtnCerrar_Click);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(62, 12);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(249, 31);
            this.siticoneHtmlLabel5.TabIndex = 1;
            this.siticoneHtmlLabel5.Text = "Consultor de Facturas";
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.Controls.Add(this.dgFacturas);
            this.siticoneCustomGradientPanel1.Controls.Add(this.sbtnImprimir);
            this.siticoneCustomGradientPanel1.Controls.Add(this.stxtBuscar);
            this.siticoneCustomGradientPanel1.Controls.Add(this.sbtnEliminar);
            this.siticoneCustomGradientPanel1.Controls.Add(this.sbtnBuscar);
            this.siticoneCustomGradientPanel1.Controls.Add(this.siticoneGradientPanel1);
            this.siticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(959, 564);
            this.siticoneCustomGradientPanel1.TabIndex = 3;
            // 
            // dgFacturas
            // 
            this.dgFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturas.Location = new System.Drawing.Point(3, 129);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.Size = new System.Drawing.Size(953, 423);
            this.dgFacturas.TabIndex = 12;
            this.dgFacturas.UseWaitCursor = true;
            // 
            // sbtnImprimir
            // 
            this.sbtnImprimir.BorderRadius = 20;
            this.sbtnImprimir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sbtnImprimir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sbtnImprimir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sbtnImprimir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sbtnImprimir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.sbtnImprimir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnImprimir.ForeColor = System.Drawing.Color.Black;
            this.sbtnImprimir.Location = new System.Drawing.Point(779, 71);
            this.sbtnImprimir.Name = "sbtnImprimir";
            this.sbtnImprimir.Size = new System.Drawing.Size(157, 42);
            this.sbtnImprimir.TabIndex = 9;
            this.sbtnImprimir.Text = "Imprimir";
            this.sbtnImprimir.UseWaitCursor = true;
            this.sbtnImprimir.Click += new System.EventHandler(this.sbtnImprimir_Click_1);
            // 
            // stxtBuscar
            // 
            this.stxtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.stxtBuscar.BorderRadius = 15;
            this.stxtBuscar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.stxtBuscar.DefaultText = "";
            this.stxtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stxtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stxtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtBuscar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stxtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtBuscar.Location = new System.Drawing.Point(18, 71);
            this.stxtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stxtBuscar.Name = "stxtBuscar";
            this.stxtBuscar.PasswordChar = '\0';
            this.stxtBuscar.PlaceholderText = "";
            this.stxtBuscar.SelectedText = "";
            this.stxtBuscar.Size = new System.Drawing.Size(332, 42);
            this.stxtBuscar.TabIndex = 8;
            this.stxtBuscar.UseWaitCursor = true;
            // 
            // sbtnEliminar
            // 
            this.sbtnEliminar.BorderRadius = 20;
            this.sbtnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sbtnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sbtnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sbtnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sbtnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.sbtnEliminar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.sbtnEliminar.Location = new System.Drawing.Point(616, 71);
            this.sbtnEliminar.Name = "sbtnEliminar";
            this.sbtnEliminar.Size = new System.Drawing.Size(157, 42);
            this.sbtnEliminar.TabIndex = 10;
            this.sbtnEliminar.Text = "Eliminar";
            this.sbtnEliminar.UseWaitCursor = true;
            this.sbtnEliminar.Click += new System.EventHandler(this.sbtnEliminar_Click_1);
            // 
            // sbtnBuscar
            // 
            this.sbtnBuscar.BorderRadius = 20;
            this.sbtnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sbtnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sbtnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sbtnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sbtnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.sbtnBuscar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.sbtnBuscar.Location = new System.Drawing.Point(453, 71);
            this.sbtnBuscar.Name = "sbtnBuscar";
            this.sbtnBuscar.Size = new System.Drawing.Size(157, 42);
            this.sbtnBuscar.TabIndex = 11;
            this.sbtnBuscar.Text = "Buscar";
            this.sbtnBuscar.UseWaitCursor = true;
            this.sbtnBuscar.Click += new System.EventHandler(this.sbtnBuscar_Click_1);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 564);
            this.Controls.Add(this.siticoneCustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sBtnMinimizar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sBtnMaximizar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sBtnCerrar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private System.Windows.Forms.DataGridView dgFacturas;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnImprimir;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox stxtBuscar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnEliminar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}