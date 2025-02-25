namespace Bajoelvelo_v1.FORMS.SERV_FORMS
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.sBtnMinimizar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sBtnMaximizar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sBtnCerrar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.stxtBuscar = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.sbtnBuscar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sbtnEliminar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sbtnImprimir = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.stabControlbtn1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tpageConsultas = new System.Windows.Forms.TabPage();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).BeginInit();
            this.stabControlbtn1.SuspendLayout();
            this.tpageConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
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
            this.siticoneGradientPanel1.Controls.Add(this.sBtnMinimizar);
            this.siticoneGradientPanel1.Controls.Add(this.sBtnMaximizar);
            this.siticoneGradientPanel1.Controls.Add(this.sBtnCerrar);
            this.siticoneGradientPanel1.Controls.Add(this.siticoneHtmlLabel5);
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.White;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(1, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(992, 54);
            this.siticoneGradientPanel1.TabIndex = 2;
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
            this.sBtnMinimizar.Location = new System.Drawing.Point(866, 0);
            this.sBtnMinimizar.Name = "sBtnMinimizar";
            this.sBtnMinimizar.Size = new System.Drawing.Size(43, 21);
            this.sBtnMinimizar.TabIndex = 3;
            this.sBtnMinimizar.Click += new System.EventHandler(this.sBtnMinimizar_Click);
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
            this.sBtnMaximizar.Location = new System.Drawing.Point(905, 0);
            this.sBtnMaximizar.Name = "sBtnMaximizar";
            this.sBtnMaximizar.Size = new System.Drawing.Size(43, 21);
            this.sBtnMaximizar.TabIndex = 4;
            this.sBtnMaximizar.Click += new System.EventHandler(this.sBtnMaximizar_Click);
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
            this.sBtnCerrar.Location = new System.Drawing.Point(948, 0);
            this.sBtnCerrar.Name = "sBtnCerrar";
            this.sBtnCerrar.Size = new System.Drawing.Size(43, 21);
            this.sBtnCerrar.TabIndex = 5;
            this.sBtnCerrar.Click += new System.EventHandler(this.sBtnCerrar_Click);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(12, 14);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(244, 31);
            this.siticoneHtmlLabel5.TabIndex = 1;
            this.siticoneHtmlLabel5.Text = "Consultor de Clientes";
            // 
            // siticoneDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.siticoneDataGridView1.ColumnHeadersHeight = 4;
            this.siticoneDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.siticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.Location = new System.Drawing.Point(425, 265);
            this.siticoneDataGridView1.Name = "siticoneDataGridView1";
            this.siticoneDataGridView1.RowHeadersVisible = false;
            this.siticoneDataGridView1.Size = new System.Drawing.Size(240, 150);
            this.siticoneDataGridView1.TabIndex = 3;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.siticoneDataGridView1.ThemeStyle.ReadOnly = false;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.stxtBuscar.Location = new System.Drawing.Point(32, 16);
            this.stxtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stxtBuscar.Name = "stxtBuscar";
            this.stxtBuscar.PasswordChar = '\0';
            this.stxtBuscar.PlaceholderText = "";
            this.stxtBuscar.SelectedText = "";
            this.stxtBuscar.Size = new System.Drawing.Size(332, 42);
            this.stxtBuscar.TabIndex = 5;
            this.stxtBuscar.UseWaitCursor = true;
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
            this.sbtnBuscar.Location = new System.Drawing.Point(467, 16);
            this.sbtnBuscar.Name = "sbtnBuscar";
            this.sbtnBuscar.Size = new System.Drawing.Size(157, 42);
            this.sbtnBuscar.TabIndex = 6;
            this.sbtnBuscar.Text = "Buscar";
            this.sbtnBuscar.UseWaitCursor = true;
            this.sbtnBuscar.Click += new System.EventHandler(this.sbtnBuscar_Click);
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
            this.sbtnEliminar.Location = new System.Drawing.Point(630, 16);
            this.sbtnEliminar.Name = "sbtnEliminar";
            this.sbtnEliminar.Size = new System.Drawing.Size(157, 42);
            this.sbtnEliminar.TabIndex = 6;
            this.sbtnEliminar.Text = "Eliminar";
            this.sbtnEliminar.UseWaitCursor = true;
            this.sbtnEliminar.Click += new System.EventHandler(this.sbtnEliminar_Click);
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
            this.sbtnImprimir.Location = new System.Drawing.Point(793, 16);
            this.sbtnImprimir.Name = "sbtnImprimir";
            this.sbtnImprimir.Size = new System.Drawing.Size(157, 42);
            this.sbtnImprimir.TabIndex = 6;
            this.sbtnImprimir.Text = "Imprimir";
            this.sbtnImprimir.UseWaitCursor = true;
            this.sbtnImprimir.Click += new System.EventHandler(this.sbtnImprimir_Click);
            // 
            // stabControlbtn1
            // 
            this.stabControlbtn1.Controls.Add(this.tpageConsultas);
            this.stabControlbtn1.Controls.Add(this.tabPage2);
            this.stabControlbtn1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stabControlbtn1.ItemSize = new System.Drawing.Size(180, 40);
            this.stabControlbtn1.Location = new System.Drawing.Point(0, 51);
            this.stabControlbtn1.Name = "stabControlbtn1";
            this.stabControlbtn1.SelectedIndex = 0;
            this.stabControlbtn1.Size = new System.Drawing.Size(993, 542);
            this.stabControlbtn1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.stabControlbtn1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.stabControlbtn1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.stabControlbtn1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.stabControlbtn1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.stabControlbtn1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.stabControlbtn1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.stabControlbtn1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.stabControlbtn1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.stabControlbtn1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.stabControlbtn1.TabButtonSelectedState.BorderColor = System.Drawing.Color.White;
            this.stabControlbtn1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.stabControlbtn1.TabButtonSelectedState.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stabControlbtn1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
            this.stabControlbtn1.TabButtonSelectedState.InnerColor = System.Drawing.Color.White;
            this.stabControlbtn1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.stabControlbtn1.TabIndex = 7;
            this.stabControlbtn1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.stabControlbtn1.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            this.stabControlbtn1.UseWaitCursor = true;
            // 
            // tpageConsultas
            // 
            this.tpageConsultas.BackColor = System.Drawing.Color.Transparent;
            this.tpageConsultas.Controls.Add(this.dgClientes);
            this.tpageConsultas.Controls.Add(this.sbtnImprimir);
            this.tpageConsultas.Controls.Add(this.stxtBuscar);
            this.tpageConsultas.Controls.Add(this.sbtnEliminar);
            this.tpageConsultas.Controls.Add(this.sbtnBuscar);
            this.tpageConsultas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpageConsultas.Location = new System.Drawing.Point(4, 44);
            this.tpageConsultas.Name = "tpageConsultas";
            this.tpageConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tpageConsultas.Size = new System.Drawing.Size(985, 494);
            this.tpageConsultas.TabIndex = 0;
            this.tpageConsultas.Text = "Consultas";
            this.tpageConsultas.UseWaitCursor = true;
            // 
            // dgClientes
            // 
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(9, 74);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(969, 414);
            this.dgClientes.TabIndex = 7;
            this.dgClientes.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(985, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.UseWaitCursor = true;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 605);
            this.Controls.Add(this.stabControlbtn1);
            this.Controls.Add(this.siticoneDataGridView1);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).EndInit();
            this.stabControlbtn1.ResumeLayout(false);
            this.tpageConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sBtnMinimizar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sBtnMaximizar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sBtnCerrar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox stxtBuscar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnEliminar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnBuscar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sbtnImprimir;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl stabControlbtn1;
        private System.Windows.Forms.TabPage tpageConsultas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgClientes;
    }
}