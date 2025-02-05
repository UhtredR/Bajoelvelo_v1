namespace Bajoelvelo_v1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.stxtUsuario = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.stxtPass = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.srbtnRecordar = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.Controls.Add(this.siticoneButton1);
            this.siticoneCustomGradientPanel1.Controls.Add(this.srbtnRecordar);
            this.siticoneCustomGradientPanel1.Controls.Add(this.stxtPass);
            this.siticoneCustomGradientPanel1.Controls.Add(this.stxtUsuario);
            this.siticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneCustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.siticoneCustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneCustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneCustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Quality = 50;
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(368, 496);
            this.siticoneCustomGradientPanel1.TabIndex = 0;
            this.siticoneCustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneCustomGradientPanel1_Paint);
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.BorderRadius = 20;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // stxtUsuario
            // 
            this.stxtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.stxtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.stxtUsuario.BorderRadius = 5;
            this.stxtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stxtUsuario.DefaultText = "";
            this.stxtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stxtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stxtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.stxtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stxtUsuario.ForeColor = System.Drawing.Color.Black;
            this.stxtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtUsuario.Location = new System.Drawing.Point(68, 79);
            this.stxtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stxtUsuario.Name = "stxtUsuario";
            this.stxtUsuario.PasswordChar = '\0';
            this.stxtUsuario.PlaceholderForeColor = System.Drawing.Color.Black;
            this.stxtUsuario.PlaceholderText = "Usuario";
            this.stxtUsuario.SelectedText = "";
            this.stxtUsuario.Size = new System.Drawing.Size(235, 53);
            this.stxtUsuario.TabIndex = 0;
            // 
            // stxtPass
            // 
            this.stxtPass.BackColor = System.Drawing.Color.Transparent;
            this.stxtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.stxtPass.BorderRadius = 5;
            this.stxtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stxtPass.DefaultText = "";
            this.stxtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stxtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stxtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.stxtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtPass.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stxtPass.ForeColor = System.Drawing.Color.Black;
            this.stxtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtPass.Location = new System.Drawing.Point(68, 154);
            this.stxtPass.Name = "stxtPass";
            this.stxtPass.PasswordChar = '\0';
            this.stxtPass.PlaceholderForeColor = System.Drawing.Color.Black;
            this.stxtPass.PlaceholderText = "Contrasena";
            this.stxtPass.SelectedText = "";
            this.stxtPass.Size = new System.Drawing.Size(235, 53);
            this.stxtPass.TabIndex = 1;
            // 
            // srbtnRecordar
            // 
            this.srbtnRecordar.AutoSize = true;
            this.srbtnRecordar.BackColor = System.Drawing.Color.Transparent;
            this.srbtnRecordar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.srbtnRecordar.CheckedState.BorderThickness = 0;
            this.srbtnRecordar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.srbtnRecordar.CheckedState.InnerColor = System.Drawing.Color.White;
            this.srbtnRecordar.CheckedState.InnerOffset = -4;
            this.srbtnRecordar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srbtnRecordar.Location = new System.Drawing.Point(68, 213);
            this.srbtnRecordar.Name = "srbtnRecordar";
            this.srbtnRecordar.Size = new System.Drawing.Size(86, 20);
            this.srbtnRecordar.TabIndex = 2;
            this.srbtnRecordar.Text = "Recuerdame";
            this.srbtnRecordar.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.srbtnRecordar.UncheckedState.BorderThickness = 2;
            this.srbtnRecordar.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.srbtnRecordar.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.srbtnRecordar.UseVisualStyleBackColor = false;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderRadius = 30;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.White;
            this.siticoneButton1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton1.Location = new System.Drawing.Point(110, 257);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(148, 55);
            this.siticoneButton1.TabIndex = 3;
            this.siticoneButton1.Text = "Iniciar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 496);
            this.Controls.Add(this.siticoneCustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox stxtUsuario;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox stxtPass;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton srbtnRecordar;
    }
}

