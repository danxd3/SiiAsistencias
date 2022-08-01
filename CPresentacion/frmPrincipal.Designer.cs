namespace CPresentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnRestaurar = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.lbFormActual = new System.Windows.Forms.Label();
            this.pbxFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.pnlVertical = new System.Windows.Forms.Panel();
            this.btReporte = new FontAwesome.Sharp.IconButton();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.pnlSubmenuConfig = new System.Windows.Forms.Panel();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnSucursales = new FontAwesome.Sharp.IconButton();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.pnlSubmenuRegistros = new System.Windows.Forms.Panel();
            this.btnCalculoAsistencias = new FontAwesome.Sharp.IconButton();
            this.btnVisitas = new FontAwesome.Sharp.IconButton();
            this.btnEntradaSalida = new FontAwesome.Sharp.IconButton();
            this.btnregistros = new FontAwesome.Sharp.IconButton();
            this.btnhorarios = new FontAwesome.Sharp.IconButton();
            this.btndepto = new FontAwesome.Sharp.IconButton();
            this.btnempleados = new FontAwesome.Sharp.IconButton();
            this.btnChecador = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbxIconUser = new FontAwesome.Sharp.IconPictureBox();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxBienvenido = new System.Windows.Forms.TextBox();
            this.ttpMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btSubAreas = new FontAwesome.Sharp.IconButton();
            this.pnlTotal.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormActual)).BeginInit();
            this.pnlVertical.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlSubmenuConfig.SuspendLayout();
            this.pnlSubmenuRegistros.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(220, 50);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(820, 550);
            this.pnlContenedor.TabIndex = 3;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.pnlContenedor);
            this.pnlTotal.Controls.Add(this.pnlTitulo);
            this.pnlTotal.Controls.Add(this.pnlVertical);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotal.Location = new System.Drawing.Point(0, 0);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(1040, 600);
            this.pnlTotal.TabIndex = 1;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.pnlTitulo.Controls.Add(this.btnMaximizar);
            this.pnlTitulo.Controls.Add(this.btnRestaurar);
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Controls.Add(this.lbFormActual);
            this.pnlTitulo.Controls.Add(this.pbxFormActual);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(220, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(820, 50);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.btnMaximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(220)))), ((int)(((byte)(90)))));
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(220)))), ((int)(((byte)(90)))));
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 25;
            this.btnMaximizar.Location = new System.Drawing.Point(758, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.btnRestaurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(240)))));
            this.btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestaurar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(240)))));
            this.btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestaurar.IconSize = 25;
            this.btnRestaurar.Location = new System.Drawing.Point(758, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.btnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 25;
            this.btnMinimizar.Location = new System.Drawing.Point(727, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(789, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbFormActual
            // 
            this.lbFormActual.AutoSize = true;
            this.lbFormActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormActual.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbFormActual.Location = new System.Drawing.Point(58, 13);
            this.lbFormActual.Name = "lbFormActual";
            this.lbFormActual.Size = new System.Drawing.Size(160, 24);
            this.lbFormActual.TabIndex = 1;
            this.lbFormActual.Text = "Sucursal - Inicio";
            // 
            // pbxFormActual
            // 
            this.pbxFormActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.pbxFormActual.ForeColor = System.Drawing.Color.Fuchsia;
            this.pbxFormActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.pbxFormActual.IconColor = System.Drawing.Color.Fuchsia;
            this.pbxFormActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxFormActual.IconSize = 45;
            this.pbxFormActual.Location = new System.Drawing.Point(7, 3);
            this.pbxFormActual.Name = "pbxFormActual";
            this.pbxFormActual.Size = new System.Drawing.Size(45, 45);
            this.pbxFormActual.TabIndex = 0;
            this.pbxFormActual.TabStop = false;
            // 
            // pnlVertical
            // 
            this.pnlVertical.AutoScroll = true;
            this.pnlVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.pnlVertical.Controls.Add(this.btSubAreas);
            this.pnlVertical.Controls.Add(this.btReporte);
            this.pnlVertical.Controls.Add(this.pnlInfo);
            this.pnlVertical.Controls.Add(this.pnlSubmenuConfig);
            this.pnlVertical.Controls.Add(this.btnConfiguracion);
            this.pnlVertical.Controls.Add(this.pnlSubmenuRegistros);
            this.pnlVertical.Controls.Add(this.btnregistros);
            this.pnlVertical.Controls.Add(this.btnhorarios);
            this.pnlVertical.Controls.Add(this.btndepto);
            this.pnlVertical.Controls.Add(this.btnempleados);
            this.pnlVertical.Controls.Add(this.btnChecador);
            this.pnlVertical.Controls.Add(this.pnlLogo);
            this.pnlVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlVertical.Name = "pnlVertical";
            this.pnlVertical.Size = new System.Drawing.Size(220, 600);
            this.pnlVertical.TabIndex = 0;
            // 
            // btReporte
            // 
            this.btReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btReporte.FlatAppearance.BorderSize = 0;
            this.btReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReporte.ForeColor = System.Drawing.Color.Gainsboro;
            this.btReporte.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.btReporte.IconColor = System.Drawing.Color.Gainsboro;
            this.btReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btReporte.IconSize = 32;
            this.btReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReporte.Location = new System.Drawing.Point(0, 670);
            this.btReporte.Name = "btReporte";
            this.btReporte.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btReporte.Size = new System.Drawing.Size(203, 50);
            this.btReporte.TabIndex = 7;
            this.btReporte.Text = "Reportes";
            this.btReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btReporte.UseVisualStyleBackColor = true;
            this.btReporte.Click += new System.EventHandler(this.btReporte_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnActualizar);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfo.Location = new System.Drawing.Point(0, 770);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(203, 100);
            this.pnlInfo.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnActualizar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 32;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(0, 50);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnActualizar.Size = new System.Drawing.Size(203, 50);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlSubmenuConfig
            // 
            this.pnlSubmenuConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.pnlSubmenuConfig.Controls.Add(this.btnUsuarios);
            this.pnlSubmenuConfig.Controls.Add(this.btnSucursales);
            this.pnlSubmenuConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuConfig.Location = new System.Drawing.Point(0, 570);
            this.pnlSubmenuConfig.Name = "pnlSubmenuConfig";
            this.pnlSubmenuConfig.Size = new System.Drawing.Size(203, 100);
            this.pnlSubmenuConfig.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuarios.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 32;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 50);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(203, 50);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSucursales
            // 
            this.btnSucursales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSucursales.FlatAppearance.BorderSize = 0;
            this.btnSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucursales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSucursales.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnSucursales.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSucursales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSucursales.IconSize = 32;
            this.btnSucursales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSucursales.Location = new System.Drawing.Point(0, 0);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSucursales.Size = new System.Drawing.Size(203, 50);
            this.btnSucursales.TabIndex = 0;
            this.btnSucursales.Text = "Sucursales";
            this.btnSucursales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSucursales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSucursales.UseVisualStyleBackColor = true;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnConfiguracion.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracion.IconSize = 32;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 520);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConfiguracion.Size = new System.Drawing.Size(203, 50);
            this.btnConfiguracion.TabIndex = 6;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // pnlSubmenuRegistros
            // 
            this.pnlSubmenuRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.pnlSubmenuRegistros.Controls.Add(this.btnCalculoAsistencias);
            this.pnlSubmenuRegistros.Controls.Add(this.btnVisitas);
            this.pnlSubmenuRegistros.Controls.Add(this.btnEntradaSalida);
            this.pnlSubmenuRegistros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuRegistros.Location = new System.Drawing.Point(0, 370);
            this.pnlSubmenuRegistros.Name = "pnlSubmenuRegistros";
            this.pnlSubmenuRegistros.Size = new System.Drawing.Size(203, 150);
            this.pnlSubmenuRegistros.TabIndex = 2;
            // 
            // btnCalculoAsistencias
            // 
            this.btnCalculoAsistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalculoAsistencias.FlatAppearance.BorderSize = 0;
            this.btnCalculoAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculoAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculoAsistencias.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalculoAsistencias.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnCalculoAsistencias.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCalculoAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalculoAsistencias.IconSize = 32;
            this.btnCalculoAsistencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculoAsistencias.Location = new System.Drawing.Point(0, 100);
            this.btnCalculoAsistencias.Name = "btnCalculoAsistencias";
            this.btnCalculoAsistencias.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnCalculoAsistencias.Size = new System.Drawing.Size(203, 50);
            this.btnCalculoAsistencias.TabIndex = 3;
            this.btnCalculoAsistencias.Text = "Asistencias";
            this.btnCalculoAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculoAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculoAsistencias.UseVisualStyleBackColor = true;
            this.btnCalculoAsistencias.Click += new System.EventHandler(this.btnCalculoAsistencias_Click);
            // 
            // btnVisitas
            // 
            this.btnVisitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisitas.FlatAppearance.BorderSize = 0;
            this.btnVisitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVisitas.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.btnVisitas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVisitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVisitas.IconSize = 32;
            this.btnVisitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitas.Location = new System.Drawing.Point(0, 50);
            this.btnVisitas.Name = "btnVisitas";
            this.btnVisitas.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnVisitas.Size = new System.Drawing.Size(203, 50);
            this.btnVisitas.TabIndex = 2;
            this.btnVisitas.Text = "Visitas";
            this.btnVisitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisitas.UseVisualStyleBackColor = true;
            this.btnVisitas.Click += new System.EventHandler(this.btnVisitas_Click);
            // 
            // btnEntradaSalida
            // 
            this.btnEntradaSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntradaSalida.FlatAppearance.BorderSize = 0;
            this.btnEntradaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaSalida.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntradaSalida.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnEntradaSalida.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEntradaSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntradaSalida.IconSize = 32;
            this.btnEntradaSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradaSalida.Location = new System.Drawing.Point(0, 0);
            this.btnEntradaSalida.Name = "btnEntradaSalida";
            this.btnEntradaSalida.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEntradaSalida.Size = new System.Drawing.Size(203, 50);
            this.btnEntradaSalida.TabIndex = 1;
            this.btnEntradaSalida.Text = "Entrada/Salida";
            this.btnEntradaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradaSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntradaSalida.UseVisualStyleBackColor = true;
            this.btnEntradaSalida.Click += new System.EventHandler(this.btnEntradaSalida_Click);
            // 
            // btnregistros
            // 
            this.btnregistros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnregistros.FlatAppearance.BorderSize = 0;
            this.btnregistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnregistros.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnregistros.IconColor = System.Drawing.Color.Gainsboro;
            this.btnregistros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregistros.IconSize = 32;
            this.btnregistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistros.Location = new System.Drawing.Point(0, 320);
            this.btnregistros.Name = "btnregistros";
            this.btnregistros.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnregistros.Size = new System.Drawing.Size(203, 50);
            this.btnregistros.TabIndex = 5;
            this.btnregistros.Text = "Registros";
            this.btnregistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregistros.UseVisualStyleBackColor = true;
            this.btnregistros.Click += new System.EventHandler(this.btnregistros_Click_1);
            // 
            // btnhorarios
            // 
            this.btnhorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhorarios.FlatAppearance.BorderSize = 0;
            this.btnhorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhorarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnhorarios.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.btnhorarios.IconColor = System.Drawing.Color.Gainsboro;
            this.btnhorarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhorarios.IconSize = 32;
            this.btnhorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhorarios.Location = new System.Drawing.Point(0, 270);
            this.btnhorarios.Name = "btnhorarios";
            this.btnhorarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnhorarios.Size = new System.Drawing.Size(203, 50);
            this.btnhorarios.TabIndex = 4;
            this.btnhorarios.Text = "Horarios";
            this.btnhorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhorarios.UseVisualStyleBackColor = true;
            this.btnhorarios.Click += new System.EventHandler(this.btnhorarios_Click);
            // 
            // btndepto
            // 
            this.btndepto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndepto.FlatAppearance.BorderSize = 0;
            this.btndepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndepto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btndepto.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btndepto.IconColor = System.Drawing.Color.Gainsboro;
            this.btndepto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndepto.IconSize = 32;
            this.btndepto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndepto.Location = new System.Drawing.Point(0, 220);
            this.btndepto.Name = "btndepto";
            this.btndepto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btndepto.Size = new System.Drawing.Size(203, 50);
            this.btndepto.TabIndex = 3;
            this.btndepto.Text = "Departamentos";
            this.btndepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndepto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndepto.UseVisualStyleBackColor = true;
            this.btndepto.Click += new System.EventHandler(this.btndepto_Click);
            // 
            // btnempleados
            // 
            this.btnempleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnempleados.FlatAppearance.BorderSize = 0;
            this.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnempleados.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnempleados.IconColor = System.Drawing.Color.Gainsboro;
            this.btnempleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnempleados.IconSize = 32;
            this.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleados.Location = new System.Drawing.Point(0, 170);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnempleados.Size = new System.Drawing.Size(203, 50);
            this.btnempleados.TabIndex = 2;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnempleados.UseVisualStyleBackColor = true;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // btnChecador
            // 
            this.btnChecador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChecador.FlatAppearance.BorderSize = 0;
            this.btnChecador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChecador.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChecador.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            this.btnChecador.IconColor = System.Drawing.Color.Gainsboro;
            this.btnChecador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChecador.IconSize = 32;
            this.btnChecador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChecador.Location = new System.Drawing.Point(0, 120);
            this.btnChecador.Name = "btnChecador";
            this.btnChecador.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChecador.Size = new System.Drawing.Size(203, 50);
            this.btnChecador.TabIndex = 1;
            this.btnChecador.Text = "Checador";
            this.btnChecador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChecador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChecador.UseVisualStyleBackColor = true;
            this.btnChecador.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbxIconUser);
            this.pnlLogo.Controls.Add(this.tbxUser);
            this.pnlLogo.Controls.Add(this.tbxBienvenido);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(203, 120);
            this.pnlLogo.TabIndex = 1;
            // 
            // pbxIconUser
            // 
            this.pbxIconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.pbxIconUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.pbxIconUser.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.pbxIconUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.pbxIconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxIconUser.IconSize = 65;
            this.pbxIconUser.Location = new System.Drawing.Point(69, 8);
            this.pbxIconUser.Name = "pbxIconUser";
            this.pbxIconUser.Size = new System.Drawing.Size(65, 65);
            this.pbxIconUser.TabIndex = 0;
            this.pbxIconUser.TabStop = false;
            this.pbxIconUser.Click += new System.EventHandler(this.pbxIconUser_Click);
            // 
            // tbxUser
            // 
            this.tbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.tbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUser.Enabled = false;
            this.tbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbxUser.Location = new System.Drawing.Point(17, 97);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.ReadOnly = true;
            this.tbxUser.Size = new System.Drawing.Size(163, 17);
            this.tbxUser.TabIndex = 1;
            this.tbxUser.Text = "USER";
            this.tbxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxBienvenido
            // 
            this.tbxBienvenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.tbxBienvenido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBienvenido.Enabled = false;
            this.tbxBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBienvenido.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbxBienvenido.Location = new System.Drawing.Point(17, 74);
            this.tbxBienvenido.Name = "tbxBienvenido";
            this.tbxBienvenido.ReadOnly = true;
            this.tbxBienvenido.Size = new System.Drawing.Size(163, 17);
            this.tbxBienvenido.TabIndex = 0;
            this.tbxBienvenido.Text = "BIENVENIDO/A";
            this.tbxBienvenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // btSubAreas
            // 
            this.btSubAreas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSubAreas.FlatAppearance.BorderSize = 0;
            this.btSubAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubAreas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btSubAreas.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btSubAreas.IconColor = System.Drawing.Color.Gainsboro;
            this.btSubAreas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSubAreas.IconSize = 32;
            this.btSubAreas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSubAreas.Location = new System.Drawing.Point(0, 720);
            this.btSubAreas.Name = "btSubAreas";
            this.btSubAreas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btSubAreas.Size = new System.Drawing.Size(203, 50);
            this.btSubAreas.TabIndex = 8;
            this.btSubAreas.Text = "SubAreas";
            this.btSubAreas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSubAreas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSubAreas.UseVisualStyleBackColor = true;
            this.btSubAreas.Click += new System.EventHandler(this.btSubAreas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.pnlTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1040, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlTotal.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormActual)).EndInit();
            this.pnlVertical.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlSubmenuConfig.ResumeLayout(false);
            this.pnlSubmenuRegistros.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlTitulo;
        private FontAwesome.Sharp.IconPictureBox btnMaximizar;
        private FontAwesome.Sharp.IconPictureBox btnRestaurar;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private System.Windows.Forms.Label lbFormActual;
        private FontAwesome.Sharp.IconPictureBox pbxFormActual;
        private System.Windows.Forms.Panel pnlVertical;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnChecador;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlContenedor;
        private FontAwesome.Sharp.IconButton btndepto;
        private FontAwesome.Sharp.IconButton btnhorarios;
        private FontAwesome.Sharp.IconButton btnregistros;
        private FontAwesome.Sharp.IconButton btnempleados;
        private System.Windows.Forms.Panel pnlSubmenuConfig;
        private FontAwesome.Sharp.IconButton btnSucursales;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel pnlSubmenuRegistros;
        private FontAwesome.Sharp.IconButton btnVisitas;
        private FontAwesome.Sharp.IconButton btnEntradaSalida;
        private FontAwesome.Sharp.IconButton btnCalculoAsistencias;
        private System.Windows.Forms.Panel pnlInfo;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconPictureBox pbxIconUser;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxBienvenido;
        private System.Windows.Forms.ToolTip ttpMensaje;
        private System.Windows.Forms.ErrorProvider eprError;
        private FontAwesome.Sharp.IconButton btReporte;
        private FontAwesome.Sharp.IconButton btSubAreas;
    }
}