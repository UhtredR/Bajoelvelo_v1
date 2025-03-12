namespace Bajoelvelo_v1
{
    partial class frmMainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainmenu));
            this.spanelMenu = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sBtnMenu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sbtnSalir = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sbtnAyuda = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sbtnServicios = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sbtnCatalogo = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.spanelTitulo = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.sBtnMinimizar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sBtnMaximizar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sBtnCerrar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.sbtnInicio = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.spanelMenu.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.spanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // spanelMenu
            // 
            this.spanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.spanelMenu.Controls.Add(this.siticonePanel1);
            this.spanelMenu.Controls.Add(this.sbtnSalir);
            this.spanelMenu.Controls.Add(this.sbtnAyuda);
            this.spanelMenu.Controls.Add(this.sbtnServicios);
            this.spanelMenu.Controls.Add(this.sbtnCatalogo);
            this.spanelMenu.Controls.Add(this.sbtnInicio);
            this.spanelMenu.CustomBorderColor = System.Drawing.Color.Transparent;
            this.spanelMenu.Location = new System.Drawing.Point(0, 0);
            this.spanelMenu.Name = "spanelMenu";
            this.spanelMenu.Size = new System.Drawing.Size(196, 508);
            this.spanelMenu.TabIndex = 0;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.pictureBox1);
            this.siticonePanel1.Controls.Add(this.sBtnMenu);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(196, 104);
            this.siticonePanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // sBtnMenu
            // 
            this.sBtnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sBtnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sBtnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sBtnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sBtnMenu.FillColor = System.Drawing.Color.Transparent;
            this.sBtnMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sBtnMenu.ForeColor = System.Drawing.Color.Black;
            this.sBtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("sBtnMenu.Image")));
            this.sBtnMenu.Location = new System.Drawing.Point(147, 3);
            this.sBtnMenu.Name = "sBtnMenu";
            this.sBtnMenu.Size = new System.Drawing.Size(40, 39);
            this.sBtnMenu.TabIndex = 3;
            this.sBtnMenu.Click += new System.EventHandler(this.sBtnMenu_Click);
            // 
            // sbtnSalir
            // 
            this.sbtnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sbtnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sbtnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sbtnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sbtnSalir.FillColor = System.Drawing.Color.Transparent;
            this.sbtnSalir.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnSalir.ForeColor = System.Drawing.Color.Black;
            this.sbtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSalir.Image")));
            this.sbtnSalir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbtnSalir.Location = new System.Drawing.Point(27, 450);
            this.sbtnSalir.Name = "sbtnSalir";
            this.sbtnSalir.Size = new System.Drawing.Size(113, 45);
            this.sbtnSalir.TabIndex = 2;
            this.sbtnSalir.Text = "Salir";
            this.sbtnSalir.Click += new System.EventHandler(this.sbtnSalir_Click);
            // 
            // sbtnAyuda
            // 
            this.sbtnAyuda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sbtnAyuda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sbtnAyuda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sbtnAyuda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sbtnAyuda.FillColor = System.Drawing.Color.Transparent;
            this.sbtnAyuda.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnAyuda.ForeColor = System.Drawing.Color.Black;
            this.sbtnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("sbtnAyuda.Image")));
            this.sbtnAyuda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbtnAyuda.Location = new System.Drawing.Point(27, 225);
            this.sbtnAyuda.Name = "sbtnAyuda";
            this.sbtnAyuda.Size = new System.Drawing.Size(141, 45);
            this.sbtnAyuda.TabIndex = 2;
            this.sbtnAyuda.Text = "Ayuda";
            this.sbtnAyuda.Click += new System.EventHandler(this.sbtnAyuda_Click_1);
            // 
            // sbtnServicios
            // 
            this.sbtnServicios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sbtnServicios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sbtnServicios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sbtnServicios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sbtnServicios.FillColor = System.Drawing.Color.Transparent;
            this.sbtnServicios.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnServicios.ForeColor = System.Drawing.Color.Black;
            this.sbtnServicios.Image = ((System.Drawing.Image)(resources.GetObject("sbtnServicios.Image")));
            this.sbtnServicios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbtnServicios.Location = new System.Drawing.Point(27, 184);
            this.sbtnServicios.Name = "sbtnServicios";
            this.sbtnServicios.Size = new System.Drawing.Size(141, 45);
            this.sbtnServicios.TabIndex = 2;
            this.sbtnServicios.Tag = "Servicios";
            this.sbtnServicios.Text = "Servicios";
            this.sbtnServicios.Click += new System.EventHandler(this.sbtnServicios_Click);
            // 
            // sbtnCatalogo
            // 
            this.sbtnCatalogo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sbtnCatalogo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sbtnCatalogo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sbtnCatalogo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sbtnCatalogo.FillColor = System.Drawing.Color.Transparent;
            this.sbtnCatalogo.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnCatalogo.ForeColor = System.Drawing.Color.Black;
            this.sbtnCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("sbtnCatalogo.Image")));
            this.sbtnCatalogo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbtnCatalogo.Location = new System.Drawing.Point(27, 143);
            this.sbtnCatalogo.Name = "sbtnCatalogo";
            this.sbtnCatalogo.Size = new System.Drawing.Size(141, 45);
            this.sbtnCatalogo.TabIndex = 2;
            this.sbtnCatalogo.Tag = "Catalogo";
            this.sbtnCatalogo.Text = "Catalogo";
            this.sbtnCatalogo.Click += new System.EventHandler(this.sbtnCatalogo_Click);
            // 
            // spanelTitulo
            // 
            this.spanelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spanelTitulo.BackColor = System.Drawing.Color.White;
            this.spanelTitulo.Controls.Add(this.sBtnMinimizar);
            this.spanelTitulo.Controls.Add(this.sBtnMaximizar);
            this.spanelTitulo.Controls.Add(this.sBtnCerrar);
            this.spanelTitulo.Controls.Add(this.Label);
            this.spanelTitulo.Location = new System.Drawing.Point(196, 0);
            this.spanelTitulo.Name = "spanelTitulo";
            this.spanelTitulo.Size = new System.Drawing.Size(640, 42);
            this.spanelTitulo.TabIndex = 1;
            this.spanelTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.spanelTitulo_Paint);
            this.spanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spanelTitulo_MouseDown);
            // 
            // sBtnMinimizar
            // 
            this.sBtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sBtnMinimizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sBtnMinimizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sBtnMinimizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sBtnMinimizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sBtnMinimizar.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.sBtnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sBtnMinimizar.ForeColor = System.Drawing.Color.White;
            this.sBtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("sBtnMinimizar.Image")));
            this.sBtnMinimizar.Location = new System.Drawing.Point(515, 0);
            this.sBtnMinimizar.Name = "sBtnMinimizar";
            this.sBtnMinimizar.Size = new System.Drawing.Size(43, 21);
            this.sBtnMinimizar.TabIndex = 2;
            this.sBtnMinimizar.Click += new System.EventHandler(this.sBtnMinimizar_Click);
            // 
            // sBtnMaximizar
            // 
            this.sBtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sBtnMaximizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sBtnMaximizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sBtnMaximizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sBtnMaximizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sBtnMaximizar.FillColor = System.Drawing.Color.SteelBlue;
            this.sBtnMaximizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sBtnMaximizar.ForeColor = System.Drawing.Color.White;
            this.sBtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("sBtnMaximizar.Image")));
            this.sBtnMaximizar.Location = new System.Drawing.Point(554, 0);
            this.sBtnMaximizar.Name = "sBtnMaximizar";
            this.sBtnMaximizar.Size = new System.Drawing.Size(43, 21);
            this.sBtnMaximizar.TabIndex = 2;
            this.sBtnMaximizar.Click += new System.EventHandler(this.sBtnMaximizar_Click);
            // 
            // sBtnCerrar
            // 
            this.sBtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sBtnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sBtnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sBtnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sBtnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sBtnCerrar.FillColor = System.Drawing.Color.Maroon;
            this.sBtnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sBtnCerrar.ForeColor = System.Drawing.Color.White;
            this.sBtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("sBtnCerrar.Image")));
            this.sBtnCerrar.Location = new System.Drawing.Point(597, 0);
            this.sBtnCerrar.Name = "sBtnCerrar";
            this.sBtnCerrar.Size = new System.Drawing.Size(43, 21);
            this.sBtnCerrar.TabIndex = 2;
            this.sBtnCerrar.Click += new System.EventHandler(this.sBtnCerrar_Click);
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label.Location = new System.Drawing.Point(6, 3);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(105, 29);
            this.Label.TabIndex = 2;
            this.Label.Text = "Dashboard";
            this.Label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // sbtnInicio
            // 
            this.sbtnInicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sbtnInicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sbtnInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sbtnInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sbtnInicio.FillColor = System.Drawing.Color.Transparent;
            this.sbtnInicio.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnInicio.ForeColor = System.Drawing.Color.Black;
            this.sbtnInicio.Image = ((System.Drawing.Image)(resources.GetObject("sbtnInicio.Image")));
            this.sbtnInicio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbtnInicio.Location = new System.Drawing.Point(27, 101);
            this.sbtnInicio.Name = "sbtnInicio";
            this.sbtnInicio.Size = new System.Drawing.Size(141, 45);
            this.sbtnInicio.TabIndex = 2;
            this.sbtnInicio.Tag = "Inicio";
            this.sbtnInicio.Text = "Inicio";
            // 
            // frmMainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(835, 506);
            this.Controls.Add(this.spanelTitulo);
            this.Controls.Add(this.spanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainmenu";
            this.Load += new System.EventHandler(this.frmMainmenu_Load);
            this.Resize += new System.EventHandler(this.frmMainmenu_Resize);
            this.spanelMenu.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.spanelTitulo.ResumeLayout(false);
            this.spanelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel spanelMenu;
        private Siticone.Desktop.UI.WinForms.SiticonePanel spanelTitulo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sBtnMenu;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnCatalogo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnSalir;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnAyuda;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnServicios;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel Label;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sBtnCerrar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sBtnMinimizar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sBtnMaximizar;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnInicio;
    }
}