namespace CPresentacion
{
    partial class frmSucursales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgwArticulos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirhost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basedatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actual = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nube = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cbxEliminar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ttpMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.tbcArticulos = new System.Windows.Forms.TabControl();
            this.tbpListado = new System.Windows.Forms.TabPage();
            this.tbpMantenimiento = new System.Windows.Forms.TabPage();
            this.gbxAgregarEditar = new System.Windows.Forms.GroupBox();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.ckbNube = new System.Windows.Forms.CheckBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxSucursal = new System.Windows.Forms.TextBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.ckbActual = new System.Windows.Forms.CheckBox();
            this.tbxDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.tbxFolio = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArticulos)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.tbcArticulos.SuspendLayout();
            this.tbpListado.SuspendLayout();
            this.tbpMantenimiento.SuspendLayout();
            this.gbxAgregarEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // dgwArticulos
            // 
            this.dgwArticulos.AllowUserToAddRows = false;
            this.dgwArticulos.AllowUserToDeleteRows = false;
            this.dgwArticulos.AllowUserToResizeColumns = false;
            this.dgwArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(129)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwArticulos.ColumnHeadersHeight = 35;
            this.dgwArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.sucursal,
            this.dirhost,
            this.basedatos,
            this.usuario,
            this.contrasena,
            this.puerto,
            this.actual,
            this.activo,
            this.nube});
            this.dgwArticulos.EnableHeadersVisualStyles = false;
            this.dgwArticulos.Location = new System.Drawing.Point(18, 44);
            this.dgwArticulos.MultiSelect = false;
            this.dgwArticulos.Name = "dgwArticulos";
            this.dgwArticulos.ReadOnly = true;
            this.dgwArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwArticulos.RowHeadersVisible = false;
            this.dgwArticulos.RowHeadersWidth = 35;
            this.dgwArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwArticulos.RowTemplate.Height = 30;
            this.dgwArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwArticulos.Size = new System.Drawing.Size(761, 320);
            this.dgwArticulos.TabIndex = 22;
            this.dgwArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwArticulos_CellContentClick);
            this.dgwArticulos.DoubleClick += new System.EventHandler(this.dgwArticulos_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // sucursal
            // 
            this.sucursal.DataPropertyName = "sucursal";
            this.sucursal.HeaderText = "SUCURSAL";
            this.sucursal.Name = "sucursal";
            this.sucursal.ReadOnly = true;
            this.sucursal.Width = 120;
            // 
            // dirhost
            // 
            this.dirhost.DataPropertyName = "dirhost";
            this.dirhost.HeaderText = "HOST";
            this.dirhost.Name = "dirhost";
            this.dirhost.ReadOnly = true;
            this.dirhost.Width = 120;
            // 
            // basedatos
            // 
            this.basedatos.DataPropertyName = "basedatos";
            this.basedatos.HeaderText = "BD";
            this.basedatos.Name = "basedatos";
            this.basedatos.ReadOnly = true;
            this.basedatos.Width = 120;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 120;
            // 
            // contrasena
            // 
            this.contrasena.DataPropertyName = "contrasena";
            this.contrasena.HeaderText = "CONTRASEÑA";
            this.contrasena.Name = "contrasena";
            this.contrasena.ReadOnly = true;
            this.contrasena.Width = 200;
            // 
            // puerto
            // 
            this.puerto.DataPropertyName = "puerto";
            this.puerto.HeaderText = "PUERTO";
            this.puerto.Name = "puerto";
            this.puerto.ReadOnly = true;
            this.puerto.Width = 70;
            // 
            // actual
            // 
            this.actual.DataPropertyName = "actual";
            this.actual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.actual.HeaderText = "ACTUAL";
            this.actual.Name = "actual";
            this.actual.ReadOnly = true;
            this.actual.TrueValue = "1";
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.activo.HeaderText = "ACTIVO";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.TrueValue = "1";
            // 
            // nube
            // 
            this.nube.DataPropertyName = "nube";
            this.nube.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nube.HeaderText = "NUBE";
            this.nube.Name = "nube";
            this.nube.ReadOnly = true;
            this.nube.TrueValue = "1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(732, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 25);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.BackColor = System.Drawing.Color.White;
            this.tbxBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscar.Location = new System.Drawing.Point(497, 71);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(225, 22);
            this.tbxBuscar.TabIndex = 20;
            this.tbxBuscar.TextChanged += new System.EventHandler(this.tbxBuscar_TextChanged);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(599, 20);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(129, 16);
            this.lblRegistros.TabIndex = 19;
            this.lblRegistros.Text = "No. de sucursales: ";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(442, 74);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 16);
            this.lblBuscar.TabIndex = 18;
            this.lblBuscar.Text = "Buscar:";
            // 
            // cbxEliminar
            // 
            this.cbxEliminar.AutoSize = true;
            this.cbxEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEliminar.Location = new System.Drawing.Point(18, 18);
            this.cbxEliminar.Name = "cbxEliminar";
            this.cbxEliminar.Size = new System.Drawing.Size(74, 20);
            this.cbxEliminar.TabIndex = 17;
            this.cbxEliminar.Text = "Eliminar";
            this.cbxEliminar.UseVisualStyleBackColor = true;
            this.cbxEliminar.CheckedChanged += new System.EventHandler(this.cbxEliminar_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(290, 70);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 25);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(200, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 25);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(110, 70);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 25);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(20, 70);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 25);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(333, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 24);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "SUCURSALES";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(900, 50);
            this.pnlTitulo.TabIndex = 12;
            // 
            // tbcArticulos
            // 
            this.tbcArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcArticulos.Controls.Add(this.tbpListado);
            this.tbcArticulos.Controls.Add(this.tbpMantenimiento);
            this.tbcArticulos.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcArticulos.ItemSize = new System.Drawing.Size(58, 18);
            this.tbcArticulos.Location = new System.Drawing.Point(15, 115);
            this.tbcArticulos.Name = "tbcArticulos";
            this.tbcArticulos.SelectedIndex = 0;
            this.tbcArticulos.Size = new System.Drawing.Size(797, 414);
            this.tbcArticulos.TabIndex = 24;
            // 
            // tbpListado
            // 
            this.tbpListado.Controls.Add(this.cbxEliminar);
            this.tbpListado.Controls.Add(this.dgwArticulos);
            this.tbpListado.Controls.Add(this.lblRegistros);
            this.tbpListado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpListado.Location = new System.Drawing.Point(4, 22);
            this.tbpListado.Name = "tbpListado";
            this.tbpListado.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListado.Size = new System.Drawing.Size(789, 388);
            this.tbpListado.TabIndex = 0;
            this.tbpListado.Text = "Listado";
            this.tbpListado.UseVisualStyleBackColor = true;
            // 
            // tbpMantenimiento
            // 
            this.tbpMantenimiento.Controls.Add(this.gbxAgregarEditar);
            this.tbpMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tbpMantenimiento.Name = "tbpMantenimiento";
            this.tbpMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMantenimiento.Size = new System.Drawing.Size(789, 388);
            this.tbpMantenimiento.TabIndex = 1;
            this.tbpMantenimiento.Text = "Mantenimiento";
            this.tbpMantenimiento.UseVisualStyleBackColor = true;
            // 
            // gbxAgregarEditar
            // 
            this.gbxAgregarEditar.Controls.Add(this.ckbActivo);
            this.gbxAgregarEditar.Controls.Add(this.ckbNube);
            this.gbxAgregarEditar.Controls.Add(this.tbxPort);
            this.gbxAgregarEditar.Controls.Add(this.lblPort);
            this.gbxAgregarEditar.Controls.Add(this.tbxPass);
            this.gbxAgregarEditar.Controls.Add(this.tbxUser);
            this.gbxAgregarEditar.Controls.Add(this.tbxSucursal);
            this.gbxAgregarEditar.Controls.Add(this.lblSucursal);
            this.gbxAgregarEditar.Controls.Add(this.ckbActual);
            this.gbxAgregarEditar.Controls.Add(this.tbxDatabase);
            this.gbxAgregarEditar.Controls.Add(this.lblDatabase);
            this.gbxAgregarEditar.Controls.Add(this.lblPass);
            this.gbxAgregarEditar.Controls.Add(this.lblUser);
            this.gbxAgregarEditar.Controls.Add(this.btnCancelar);
            this.gbxAgregarEditar.Controls.Add(this.btnGuardar);
            this.gbxAgregarEditar.Controls.Add(this.tbxHost);
            this.gbxAgregarEditar.Controls.Add(this.tbxFolio);
            this.gbxAgregarEditar.Controls.Add(this.lblHost);
            this.gbxAgregarEditar.Controls.Add(this.lblFolio);
            this.gbxAgregarEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAgregarEditar.Location = new System.Drawing.Point(15, 6);
            this.gbxAgregarEditar.Name = "gbxAgregarEditar";
            this.gbxAgregarEditar.Size = new System.Drawing.Size(751, 366);
            this.gbxAgregarEditar.TabIndex = 23;
            this.gbxAgregarEditar.TabStop = false;
            this.gbxAgregarEditar.Text = "Sucursales";
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Location = new System.Drawing.Point(642, 42);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(64, 20);
            this.ckbActivo.TabIndex = 36;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // ckbNube
            // 
            this.ckbNube.AutoSize = true;
            this.ckbNube.Location = new System.Drawing.Point(555, 42);
            this.ckbNube.Name = "ckbNube";
            this.ckbNube.Size = new System.Drawing.Size(60, 20);
            this.ckbNube.TabIndex = 35;
            this.ckbNube.Text = "Nube";
            this.ckbNube.UseVisualStyleBackColor = true;
            // 
            // tbxPort
            // 
            this.tbxPort.BackColor = System.Drawing.Color.White;
            this.tbxPort.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPort.Location = new System.Drawing.Point(548, 90);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 22);
            this.tbxPort.TabIndex = 34;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(461, 93);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(55, 16);
            this.lblPort.TabIndex = 33;
            this.lblPort.Text = "Puerto:";
            // 
            // tbxPass
            // 
            this.tbxPass.BackColor = System.Drawing.Color.White;
            this.tbxPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass.Location = new System.Drawing.Point(125, 240);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(250, 22);
            this.tbxPass.TabIndex = 32;
            // 
            // tbxUser
            // 
            this.tbxUser.BackColor = System.Drawing.Color.White;
            this.tbxUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(125, 190);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(250, 22);
            this.tbxUser.TabIndex = 31;
            // 
            // tbxSucursal
            // 
            this.tbxSucursal.BackColor = System.Drawing.Color.White;
            this.tbxSucursal.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSucursal.Location = new System.Drawing.Point(125, 40);
            this.tbxSucursal.Name = "tbxSucursal";
            this.tbxSucursal.ReadOnly = true;
            this.tbxSucursal.Size = new System.Drawing.Size(250, 22);
            this.tbxSucursal.TabIndex = 29;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(15, 43);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(66, 16);
            this.lblSucursal.TabIndex = 28;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // ckbActual
            // 
            this.ckbActual.AutoSize = true;
            this.ckbActual.Location = new System.Drawing.Point(464, 42);
            this.ckbActual.Name = "ckbActual";
            this.ckbActual.Size = new System.Drawing.Size(65, 20);
            this.ckbActual.TabIndex = 26;
            this.ckbActual.Text = "Actual";
            this.ckbActual.UseVisualStyleBackColor = true;
            // 
            // tbxDatabase
            // 
            this.tbxDatabase.BackColor = System.Drawing.Color.White;
            this.tbxDatabase.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDatabase.Location = new System.Drawing.Point(125, 140);
            this.tbxDatabase.Name = "tbxDatabase";
            this.tbxDatabase.Size = new System.Drawing.Size(250, 22);
            this.tbxDatabase.TabIndex = 25;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.Location = new System.Drawing.Point(15, 143);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(104, 16);
            this.lblDatabase.TabIndex = 24;
            this.lblDatabase.Text = "Base de datos:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(15, 243);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(87, 16);
            this.lblPass.TabIndex = 22;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(15, 193);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 16);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "Usuario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(588, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 25);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(484, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 25);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbxHost
            // 
            this.tbxHost.BackColor = System.Drawing.Color.White;
            this.tbxHost.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHost.Location = new System.Drawing.Point(125, 90);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(250, 22);
            this.tbxHost.TabIndex = 13;
            // 
            // tbxFolio
            // 
            this.tbxFolio.BackColor = System.Drawing.Color.White;
            this.tbxFolio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFolio.Location = new System.Drawing.Point(236, 7);
            this.tbxFolio.Name = "tbxFolio";
            this.tbxFolio.ReadOnly = true;
            this.tbxFolio.Size = new System.Drawing.Size(100, 22);
            this.tbxFolio.TabIndex = 12;
            this.tbxFolio.Visible = false;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.Location = new System.Drawing.Point(15, 93);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(42, 16);
            this.lblHost.TabIndex = 8;
            this.lblHost.Text = "Host:";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(129, 10);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(42, 16);
            this.lblFolio.TabIndex = 7;
            this.lblFolio.Text = "Folio:";
            this.lblFolio.Visible = false;
            // 
            // frmSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 541);
            this.Controls.Add(this.tbcArticulos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArticulos)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.tbcArticulos.ResumeLayout(false);
            this.tbpListado.ResumeLayout(false);
            this.tbpListado.PerformLayout();
            this.tbpMantenimiento.ResumeLayout(false);
            this.gbxAgregarEditar.ResumeLayout(false);
            this.gbxAgregarEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.DataGridView dgwArticulos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.CheckBox cbxEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolTip ttpMensaje;
        private System.Windows.Forms.TabControl tbcArticulos;
        private System.Windows.Forms.TabPage tbpListado;
        private System.Windows.Forms.TabPage tbpMantenimiento;
        private System.Windows.Forms.GroupBox gbxAgregarEditar;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.TextBox tbxFolio;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.TextBox tbxDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.CheckBox ckbActual;
        private System.Windows.Forms.TextBox tbxSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.CheckBox ckbNube;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirhost;
        private System.Windows.Forms.DataGridViewTextBoxColumn basedatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn puerto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actual;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nube;
        private System.Windows.Forms.CheckBox ckbActivo;
    }
}