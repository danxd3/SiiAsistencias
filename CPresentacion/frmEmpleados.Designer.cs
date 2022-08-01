namespace CPresentacion
{
    partial class frmEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.desactivar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhrentrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhrsalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diasdescansos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienehuella = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pinactivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fmodifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.ckbbaja = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.ttpMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tbcArticulos = new System.Windows.Forms.TabControl();
            this.tbpListado = new System.Windows.Forms.TabPage();
            this.tbpMantenimiento = new System.Windows.Forms.TabPage();
            this.gbxAgregarEditar = new System.Windows.Forms.GroupBox();
            this.ckbModificaSucursal = new System.Windows.Forms.CheckBox();
            this.lblFModificacion = new System.Windows.Forms.Label();
            this.lblFIngreso = new System.Windows.Forms.Label();
            this.tbxPin = new System.Windows.Forms.TextBox();
            this.ckbPin = new System.Windows.Forms.CheckBox();
            this.gbxSync = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cbxSucursal = new System.Windows.Forms.ComboBox();
            this.gbxDescansos = new System.Windows.Forms.GroupBox();
            this.ckbdom = new System.Windows.Forms.CheckBox();
            this.ckbsab = new System.Windows.Forms.CheckBox();
            this.ckbvie = new System.Windows.Forms.CheckBox();
            this.ckbjue = new System.Windows.Forms.CheckBox();
            this.ckbmie = new System.Windows.Forms.CheckBox();
            this.ckbmar = new System.Windows.Forms.CheckBox();
            this.ckblun = new System.Windows.Forms.CheckBox();
            this.ckbHuella = new System.Windows.Forms.CheckBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnHuella = new System.Windows.Forms.Button();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.tbxApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.gbxImagen = new System.Windows.Forms.GroupBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnEliminarImg = new System.Windows.Forms.Button();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.cbxHorarios = new System.Windows.Forms.ComboBox();
            this.cbxDeptos = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxFolio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.rbnBaja = new System.Windows.Forms.RadioButton();
            this.rbnActivo = new System.Windows.Forms.RadioButton();
            this.cbxSucursales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tbcArticulos.SuspendLayout();
            this.tbpListado.SuspendLayout();
            this.tbpMantenimiento.SuspendLayout();
            this.gbxAgregarEditar.SuspendLayout();
            this.gbxSync.SuspendLayout();
            this.gbxDescansos.SuspendLayout();
            this.gbxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.ColumnHeadersHeight = 35;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desactivar,
            this.codigo,
            this.nombre,
            this.apellidos,
            this.sucursalcol,
            this.depto,
            this.colhrentrada,
            this.colhrsalida,
            this.Diasdescansos,
            this.tienehuella,
            this.pinactivo,
            this.pin,
            this.fingreso,
            this.fmodifica});
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.Location = new System.Drawing.Point(18, 44);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 35;
            this.dgvEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmpleados.RowTemplate.Height = 30;
            this.dgvEmpleados.RowTemplate.ReadOnly = true;
            this.dgvEmpleados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(757, 356);
            this.dgvEmpleados.TabIndex = 1;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            this.dgvEmpleados.DoubleClick += new System.EventHandler(this.dgvEmpleados_DoubleClick);
            // 
            // desactivar
            // 
            this.desactivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.desactivar.HeaderText = "DES/ACTIVAR";
            this.desactivar.Name = "desactivar";
            this.desactivar.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "COD.";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 75;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE(S)";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // apellidos
            // 
            this.apellidos.DataPropertyName = "apellidos";
            this.apellidos.HeaderText = "APELLIDOS";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Width = 200;
            // 
            // sucursalcol
            // 
            this.sucursalcol.DataPropertyName = "sucursal";
            this.sucursalcol.HeaderText = "SUCURSAL";
            this.sucursalcol.Name = "sucursalcol";
            this.sucursalcol.ReadOnly = true;
            this.sucursalcol.Width = 120;
            // 
            // depto
            // 
            this.depto.DataPropertyName = "depto";
            this.depto.HeaderText = "DEPARTAMENTO";
            this.depto.Name = "depto";
            this.depto.ReadOnly = true;
            this.depto.Width = 120;
            // 
            // colhrentrada
            // 
            this.colhrentrada.DataPropertyName = "hrentrada";
            this.colhrentrada.HeaderText = "ENTRADA";
            this.colhrentrada.Name = "colhrentrada";
            this.colhrentrada.ReadOnly = true;
            // 
            // colhrsalida
            // 
            this.colhrsalida.DataPropertyName = "hrsalida";
            this.colhrsalida.HeaderText = "SALIDA";
            this.colhrsalida.Name = "colhrsalida";
            this.colhrsalida.ReadOnly = true;
            // 
            // Diasdescansos
            // 
            this.Diasdescansos.DataPropertyName = "diasdescansos";
            this.Diasdescansos.HeaderText = "DESCANSOS";
            this.Diasdescansos.Name = "Diasdescansos";
            this.Diasdescansos.ReadOnly = true;
            this.Diasdescansos.Width = 150;
            // 
            // tienehuella
            // 
            this.tienehuella.DataPropertyName = "tienehuella";
            this.tienehuella.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tienehuella.HeaderText = "HUELLA";
            this.tienehuella.Name = "tienehuella";
            this.tienehuella.ReadOnly = true;
            this.tienehuella.TrueValue = "1";
            // 
            // pinactivo
            // 
            this.pinactivo.DataPropertyName = "pinactivo";
            this.pinactivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pinactivo.HeaderText = "PERMITE PIN";
            this.pinactivo.Name = "pinactivo";
            this.pinactivo.ReadOnly = true;
            this.pinactivo.TrueValue = "1";
            // 
            // pin
            // 
            this.pin.DataPropertyName = "pin";
            this.pin.HeaderText = "PIN";
            this.pin.Name = "pin";
            this.pin.ReadOnly = true;
            // 
            // fingreso
            // 
            this.fingreso.DataPropertyName = "fingreso";
            this.fingreso.HeaderText = "F. INGRESO";
            this.fingreso.Name = "fingreso";
            this.fingreso.ReadOnly = true;
            // 
            // fmodifica
            // 
            this.fmodifica.DataPropertyName = "fmodifica";
            this.fmodifica.HeaderText = "F. MODIFICA";
            this.fmodifica.Name = "fmodifica";
            this.fmodifica.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(728, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 30);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBuscar.BackColor = System.Drawing.Color.White;
            this.tbxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscar.Location = new System.Drawing.Point(496, 53);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(225, 22);
            this.tbxBuscar.TabIndex = 5;
            this.tbxBuscar.TextChanged += new System.EventHandler(this.tbxBuscar_TextChanged);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(621, 19);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(120, 16);
            this.lblRegistros.TabIndex = 19;
            this.lblRegistros.Text = "No. de elementos: ";
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(442, 56);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(53, 16);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar:";
            // 
            // ckbbaja
            // 
            this.ckbbaja.AutoSize = true;
            this.ckbbaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbbaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbbaja.Location = new System.Drawing.Point(18, 18);
            this.ckbbaja.Name = "ckbbaja";
            this.ckbbaja.Size = new System.Drawing.Size(53, 20);
            this.ckbbaja.TabIndex = 0;
            this.ckbbaja.Text = "Baja";
            this.ckbbaja.UseVisualStyleBackColor = true;
            this.ckbbaja.CheckedChanged += new System.EventHandler(this.cbxEliminar_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(290, 30);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 30);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.Location = new System.Drawing.Point(200, 30);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(85, 30);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "&Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(110, 30);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 30);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(20, 30);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 30);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tbcArticulos
            // 
            this.tbcArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcArticulos.Controls.Add(this.tbpListado);
            this.tbcArticulos.Controls.Add(this.tbpMantenimiento);
            this.tbcArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcArticulos.ItemSize = new System.Drawing.Size(58, 18);
            this.tbcArticulos.Location = new System.Drawing.Point(15, 88);
            this.tbcArticulos.Name = "tbcArticulos";
            this.tbcArticulos.SelectedIndex = 0;
            this.tbcArticulos.Size = new System.Drawing.Size(793, 450);
            this.tbcArticulos.TabIndex = 7;
            // 
            // tbpListado
            // 
            this.tbpListado.Controls.Add(this.ckbbaja);
            this.tbpListado.Controls.Add(this.dgvEmpleados);
            this.tbpListado.Controls.Add(this.lblRegistros);
            this.tbpListado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpListado.Location = new System.Drawing.Point(4, 22);
            this.tbpListado.Name = "tbpListado";
            this.tbpListado.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListado.Size = new System.Drawing.Size(785, 424);
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
            this.tbpMantenimiento.Size = new System.Drawing.Size(785, 424);
            this.tbpMantenimiento.TabIndex = 1;
            this.tbpMantenimiento.Text = "Mantenimiento";
            this.tbpMantenimiento.UseVisualStyleBackColor = true;
            // 
            // gbxAgregarEditar
            // 
            this.gbxAgregarEditar.Controls.Add(this.ckbModificaSucursal);
            this.gbxAgregarEditar.Controls.Add(this.lblFModificacion);
            this.gbxAgregarEditar.Controls.Add(this.lblFIngreso);
            this.gbxAgregarEditar.Controls.Add(this.tbxPin);
            this.gbxAgregarEditar.Controls.Add(this.ckbPin);
            this.gbxAgregarEditar.Controls.Add(this.gbxSync);
            this.gbxAgregarEditar.Controls.Add(this.gbxDescansos);
            this.gbxAgregarEditar.Controls.Add(this.ckbHuella);
            this.gbxAgregarEditar.Controls.Add(this.tbxCodigo);
            this.gbxAgregarEditar.Controls.Add(this.lblCodigo);
            this.gbxAgregarEditar.Controls.Add(this.btnHuella);
            this.gbxAgregarEditar.Controls.Add(this.ckbActivo);
            this.gbxAgregarEditar.Controls.Add(this.tbxApellidos);
            this.gbxAgregarEditar.Controls.Add(this.lblApellidos);
            this.gbxAgregarEditar.Controls.Add(this.gbxImagen);
            this.gbxAgregarEditar.Controls.Add(this.lblHorario);
            this.gbxAgregarEditar.Controls.Add(this.lblDepto);
            this.gbxAgregarEditar.Controls.Add(this.cbxHorarios);
            this.gbxAgregarEditar.Controls.Add(this.cbxDeptos);
            this.gbxAgregarEditar.Controls.Add(this.btnCancelar);
            this.gbxAgregarEditar.Controls.Add(this.btnGuardar);
            this.gbxAgregarEditar.Controls.Add(this.tbxNombre);
            this.gbxAgregarEditar.Controls.Add(this.tbxFolio);
            this.gbxAgregarEditar.Controls.Add(this.lblNombre);
            this.gbxAgregarEditar.Controls.Add(this.lblFolio);
            this.gbxAgregarEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbxAgregarEditar.Location = new System.Drawing.Point(15, 6);
            this.gbxAgregarEditar.Name = "gbxAgregarEditar";
            this.gbxAgregarEditar.Size = new System.Drawing.Size(751, 403);
            this.gbxAgregarEditar.TabIndex = 23;
            this.gbxAgregarEditar.TabStop = false;
            this.gbxAgregarEditar.Text = "Empleados";
            // 
            // ckbModificaSucursal
            // 
            this.ckbModificaSucursal.AutoSize = true;
            this.ckbModificaSucursal.Enabled = false;
            this.ckbModificaSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbModificaSucursal.Location = new System.Drawing.Point(585, 218);
            this.ckbModificaSucursal.Name = "ckbModificaSucursal";
            this.ckbModificaSucursal.Size = new System.Drawing.Size(137, 20);
            this.ckbModificaSucursal.TabIndex = 37;
            this.ckbModificaSucursal.Text = "Modificar Sucursal";
            this.ckbModificaSucursal.UseVisualStyleBackColor = true;
            this.ckbModificaSucursal.CheckedChanged += new System.EventHandler(this.ckbModificaSucursal_CheckedChanged);
            // 
            // lblFModificacion
            // 
            this.lblFModificacion.AutoSize = true;
            this.lblFModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFModificacion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFModificacion.Location = new System.Drawing.Point(524, 11);
            this.lblFModificacion.Name = "lblFModificacion";
            this.lblFModificacion.Size = new System.Drawing.Size(214, 16);
            this.lblFModificacion.TabIndex = 36;
            this.lblFModificacion.Text = "Fecha de modificación: 01/01/2021";
            this.lblFModificacion.Visible = false;
            // 
            // lblFIngreso
            // 
            this.lblFIngreso.AutoSize = true;
            this.lblFIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFIngreso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFIngreso.Location = new System.Drawing.Point(324, 11);
            this.lblFIngreso.Name = "lblFIngreso";
            this.lblFIngreso.Size = new System.Drawing.Size(186, 16);
            this.lblFIngreso.TabIndex = 35;
            this.lblFIngreso.Text = "Fecha de ingreso: 01/01/2021 ";
            this.lblFIngreso.Visible = false;
            // 
            // tbxPin
            // 
            this.tbxPin.BackColor = System.Drawing.Color.White;
            this.tbxPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxPin.Location = new System.Drawing.Point(313, 280);
            this.tbxPin.MaxLength = 4;
            this.tbxPin.Name = "tbxPin";
            this.tbxPin.Size = new System.Drawing.Size(62, 22);
            this.tbxPin.TabIndex = 34;
            this.tbxPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPin_KeyPress);
            // 
            // ckbPin
            // 
            this.ckbPin.AutoSize = true;
            this.ckbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbPin.Location = new System.Drawing.Point(264, 281);
            this.ckbPin.Name = "ckbPin";
            this.ckbPin.Size = new System.Drawing.Size(49, 20);
            this.ckbPin.TabIndex = 33;
            this.ckbPin.Text = "Pin:";
            this.ckbPin.UseVisualStyleBackColor = true;
            // 
            // gbxSync
            // 
            this.gbxSync.Controls.Add(this.btnAceptar);
            this.gbxSync.Controls.Add(this.btnActivar);
            this.gbxSync.Controls.Add(this.lblSucursal);
            this.gbxSync.Controls.Add(this.cbxSucursal);
            this.gbxSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbxSync.Location = new System.Drawing.Point(450, 239);
            this.gbxSync.Name = "gbxSync";
            this.gbxSync.Size = new System.Drawing.Size(275, 130);
            this.gbxSync.TabIndex = 32;
            this.gbxSync.TabStop = false;
            this.gbxSync.Text = "Sincronizar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAceptar.Location = new System.Drawing.Point(174, 77);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 30);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "&Sincronizar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnActivar.Location = new System.Drawing.Point(69, 77);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(80, 30);
            this.btnActivar.TabIndex = 25;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSucursal.Location = new System.Drawing.Point(5, 37);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(63, 16);
            this.lblSucursal.TabIndex = 24;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // cbxSucursal
            // 
            this.cbxSucursal.Enabled = false;
            this.cbxSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxSucursal.FormattingEnabled = true;
            this.cbxSucursal.Location = new System.Drawing.Point(74, 34);
            this.cbxSucursal.Name = "cbxSucursal";
            this.cbxSucursal.Size = new System.Drawing.Size(183, 24);
            this.cbxSucursal.TabIndex = 23;
            // 
            // gbxDescansos
            // 
            this.gbxDescansos.Controls.Add(this.ckbdom);
            this.gbxDescansos.Controls.Add(this.ckbsab);
            this.gbxDescansos.Controls.Add(this.ckbvie);
            this.gbxDescansos.Controls.Add(this.ckbjue);
            this.gbxDescansos.Controls.Add(this.ckbmie);
            this.gbxDescansos.Controls.Add(this.ckbmar);
            this.gbxDescansos.Controls.Add(this.ckblun);
            this.gbxDescansos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbxDescansos.Location = new System.Drawing.Point(18, 267);
            this.gbxDescansos.Name = "gbxDescansos";
            this.gbxDescansos.Size = new System.Drawing.Size(207, 112);
            this.gbxDescansos.TabIndex = 31;
            this.gbxDescansos.TabStop = false;
            this.gbxDescansos.Text = "Descansos";
            // 
            // ckbdom
            // 
            this.ckbdom.AutoSize = true;
            this.ckbdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbdom.Location = new System.Drawing.Point(145, 25);
            this.ckbdom.Name = "ckbdom";
            this.ckbdom.Size = new System.Drawing.Size(56, 20);
            this.ckbdom.TabIndex = 6;
            this.ckbdom.Text = "Dom";
            this.ckbdom.UseVisualStyleBackColor = true;
            // 
            // ckbsab
            // 
            this.ckbsab.AutoSize = true;
            this.ckbsab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbsab.Location = new System.Drawing.Point(80, 75);
            this.ckbsab.Name = "ckbsab";
            this.ckbsab.Size = new System.Drawing.Size(52, 20);
            this.ckbsab.TabIndex = 5;
            this.ckbsab.Text = "Sab";
            this.ckbsab.UseVisualStyleBackColor = true;
            // 
            // ckbvie
            // 
            this.ckbvie.AutoSize = true;
            this.ckbvie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbvie.Location = new System.Drawing.Point(80, 50);
            this.ckbvie.Name = "ckbvie";
            this.ckbvie.Size = new System.Drawing.Size(47, 20);
            this.ckbvie.TabIndex = 4;
            this.ckbvie.Text = "Vie";
            this.ckbvie.UseVisualStyleBackColor = true;
            // 
            // ckbjue
            // 
            this.ckbjue.AutoSize = true;
            this.ckbjue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbjue.Location = new System.Drawing.Point(80, 25);
            this.ckbjue.Name = "ckbjue";
            this.ckbjue.Size = new System.Drawing.Size(49, 20);
            this.ckbjue.TabIndex = 3;
            this.ckbjue.Text = "Jue";
            this.ckbjue.UseVisualStyleBackColor = true;
            // 
            // ckbmie
            // 
            this.ckbmie.AutoSize = true;
            this.ckbmie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbmie.Location = new System.Drawing.Point(15, 75);
            this.ckbmie.Name = "ckbmie";
            this.ckbmie.Size = new System.Drawing.Size(49, 20);
            this.ckbmie.TabIndex = 2;
            this.ckbmie.Text = "Mie";
            this.ckbmie.UseVisualStyleBackColor = true;
            // 
            // ckbmar
            // 
            this.ckbmar.AutoSize = true;
            this.ckbmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbmar.Location = new System.Drawing.Point(15, 50);
            this.ckbmar.Name = "ckbmar";
            this.ckbmar.Size = new System.Drawing.Size(50, 20);
            this.ckbmar.TabIndex = 1;
            this.ckbmar.Text = "Mar";
            this.ckbmar.UseVisualStyleBackColor = true;
            // 
            // ckblun
            // 
            this.ckblun.AutoSize = true;
            this.ckblun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckblun.Location = new System.Drawing.Point(15, 25);
            this.ckblun.Name = "ckblun";
            this.ckblun.Size = new System.Drawing.Size(48, 20);
            this.ckblun.TabIndex = 0;
            this.ckblun.Text = "Lun";
            this.ckblun.UseVisualStyleBackColor = true;
            // 
            // ckbHuella
            // 
            this.ckbHuella.AutoSize = true;
            this.ckbHuella.Enabled = false;
            this.ckbHuella.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbHuella.Location = new System.Drawing.Point(624, 53);
            this.ckbHuella.Name = "ckbHuella";
            this.ckbHuella.Size = new System.Drawing.Size(15, 14);
            this.ckbHuella.TabIndex = 5;
            this.ckbHuella.UseVisualStyleBackColor = true;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.BackColor = System.Drawing.Color.White;
            this.tbxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxCodigo.Location = new System.Drawing.Point(125, 30);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(100, 22);
            this.tbxCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCodigo.Location = new System.Drawing.Point(15, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 16);
            this.lblCodigo.TabIndex = 28;
            this.lblCodigo.Text = "Codigo:";
            // 
            // btnHuella
            // 
            this.btnHuella.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnHuella.Location = new System.Drawing.Point(645, 44);
            this.btnHuella.Name = "btnHuella";
            this.btnHuella.Size = new System.Drawing.Size(80, 30);
            this.btnHuella.TabIndex = 27;
            this.btnHuella.Text = "Huella";
            this.btnHuella.UseVisualStyleBackColor = true;
            this.btnHuella.Click += new System.EventHandler(this.btnHuella_Click);
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Checked = true;
            this.ckbActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbActivo.Location = new System.Drawing.Point(450, 50);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(64, 20);
            this.ckbActivo.TabIndex = 26;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // tbxApellidos
            // 
            this.tbxApellidos.BackColor = System.Drawing.Color.White;
            this.tbxApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxApellidos.Location = new System.Drawing.Point(125, 130);
            this.tbxApellidos.Name = "tbxApellidos";
            this.tbxApellidos.Size = new System.Drawing.Size(250, 22);
            this.tbxApellidos.TabIndex = 2;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblApellidos.Location = new System.Drawing.Point(15, 133);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(68, 16);
            this.lblApellidos.TabIndex = 24;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // gbxImagen
            // 
            this.gbxImagen.Controls.Add(this.pbxImagen);
            this.gbxImagen.Controls.Add(this.btnEliminarImg);
            this.gbxImagen.Controls.Add(this.btnAgregarImg);
            this.gbxImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbxImagen.Location = new System.Drawing.Point(450, 80);
            this.gbxImagen.Name = "gbxImagen";
            this.gbxImagen.Size = new System.Drawing.Size(275, 120);
            this.gbxImagen.TabIndex = 23;
            this.gbxImagen.TabStop = false;
            this.gbxImagen.Text = "Imagen";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Image = global::CPresentacion.Properties.Resources.sin_imagen;
            this.pbxImagen.Location = new System.Drawing.Point(6, 23);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(148, 91);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 26;
            this.pbxImagen.TabStop = false;
            // 
            // btnEliminarImg
            // 
            this.btnEliminarImg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarImg.Location = new System.Drawing.Point(177, 72);
            this.btnEliminarImg.Name = "btnEliminarImg";
            this.btnEliminarImg.Size = new System.Drawing.Size(80, 30);
            this.btnEliminarImg.TabIndex = 1;
            this.btnEliminarImg.Text = "Eliminar";
            this.btnEliminarImg.UseVisualStyleBackColor = true;
            this.btnEliminarImg.Click += new System.EventHandler(this.btnEliminarImg_Click);
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImg.Location = new System.Drawing.Point(177, 33);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(80, 30);
            this.btnAgregarImg.TabIndex = 0;
            this.btnAgregarImg.Text = "Agregar";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblHorario.Location = new System.Drawing.Point(15, 233);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(56, 16);
            this.lblHorario.TabIndex = 22;
            this.lblHorario.Text = "Horario:";
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDepto.Location = new System.Drawing.Point(15, 183);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(97, 16);
            this.lblDepto.TabIndex = 21;
            this.lblDepto.Text = "Departamento:";
            // 
            // cbxHorarios
            // 
            this.cbxHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxHorarios.FormattingEnabled = true;
            this.cbxHorarios.Location = new System.Drawing.Point(125, 230);
            this.cbxHorarios.Name = "cbxHorarios";
            this.cbxHorarios.Size = new System.Drawing.Size(250, 24);
            this.cbxHorarios.TabIndex = 4;
            // 
            // cbxDeptos
            // 
            this.cbxDeptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxDeptos.FormattingEnabled = true;
            this.cbxDeptos.Location = new System.Drawing.Point(125, 180);
            this.cbxDeptos.Name = "cbxDeptos";
            this.cbxDeptos.Size = new System.Drawing.Size(250, 24);
            this.cbxDeptos.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(354, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(249, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.White;
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(125, 80);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(250, 22);
            this.tbxNombre.TabIndex = 1;
            // 
            // tbxFolio
            // 
            this.tbxFolio.BackColor = System.Drawing.Color.White;
            this.tbxFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxFolio.Location = new System.Drawing.Point(125, 6);
            this.tbxFolio.Name = "tbxFolio";
            this.tbxFolio.ReadOnly = true;
            this.tbxFolio.Size = new System.Drawing.Size(100, 22);
            this.tbxFolio.TabIndex = 12;
            this.tbxFolio.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNombre.Location = new System.Drawing.Point(15, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFolio.Location = new System.Drawing.Point(79, 9);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(41, 16);
            this.lblFolio.TabIndex = 7;
            this.lblFolio.Text = "Folio:";
            this.lblFolio.Visible = false;
            // 
            // rbnBaja
            // 
            this.rbnBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnBaja.AutoSize = true;
            this.rbnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnBaja.Location = new System.Drawing.Point(566, 88);
            this.rbnBaja.Name = "rbnBaja";
            this.rbnBaja.Size = new System.Drawing.Size(54, 20);
            this.rbnBaja.TabIndex = 8;
            this.rbnBaja.Text = "Baja";
            this.rbnBaja.UseVisualStyleBackColor = true;
            this.rbnBaja.CheckedChanged += new System.EventHandler(this.rbnBaja_CheckedChanged);
            // 
            // rbnActivo
            // 
            this.rbnActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnActivo.AutoSize = true;
            this.rbnActivo.Checked = true;
            this.rbnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnActivo.Location = new System.Drawing.Point(496, 88);
            this.rbnActivo.Name = "rbnActivo";
            this.rbnActivo.Size = new System.Drawing.Size(70, 20);
            this.rbnActivo.TabIndex = 9;
            this.rbnActivo.TabStop = true;
            this.rbnActivo.Text = "Activos";
            this.rbnActivo.UseVisualStyleBackColor = true;
            this.rbnActivo.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            // 
            // cbxSucursales
            // 
            this.cbxSucursales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSucursales.FormattingEnabled = true;
            this.cbxSucursales.Location = new System.Drawing.Point(496, 12);
            this.cbxSucursales.Name = "cbxSucursales";
            this.cbxSucursales.Size = new System.Drawing.Size(150, 24);
            this.cbxSucursales.TabIndex = 40;
            this.cbxSucursales.SelectedIndexChanged += new System.EventHandler(this.cbxSucursales_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sucursal:";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 550);
            this.Controls.Add(this.cbxSucursales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbnActivo);
            this.Controls.Add(this.rbnBaja);
            this.Controls.Add(this.tbcArticulos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticulos";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tbcArticulos.ResumeLayout(false);
            this.tbpListado.ResumeLayout(false);
            this.tbpListado.PerformLayout();
            this.tbpMantenimiento.ResumeLayout(false);
            this.gbxAgregarEditar.ResumeLayout(false);
            this.gbxAgregarEditar.PerformLayout();
            this.gbxSync.ResumeLayout(false);
            this.gbxSync.PerformLayout();
            this.gbxDescansos.ResumeLayout(false);
            this.gbxDescansos.PerformLayout();
            this.gbxImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.CheckBox ckbbaja;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ToolTip ttpMensaje;
        private System.Windows.Forms.TabControl tbcArticulos;
        private System.Windows.Forms.TabPage tbpListado;
        private System.Windows.Forms.TabPage tbpMantenimiento;
        private System.Windows.Forms.GroupBox gbxAgregarEditar;
        private System.Windows.Forms.GroupBox gbxImagen;
        private System.Windows.Forms.Button btnEliminarImg;
        private System.Windows.Forms.Button btnAgregarImg;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.ComboBox cbxHorarios;
        private System.Windows.Forms.ComboBox cbxDeptos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxFolio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.TextBox tbxApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnHuella;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.CheckBox ckbHuella;
        private System.Windows.Forms.GroupBox gbxDescansos;
        private System.Windows.Forms.CheckBox ckbdom;
        private System.Windows.Forms.CheckBox ckbsab;
        private System.Windows.Forms.CheckBox ckbvie;
        private System.Windows.Forms.CheckBox ckbjue;
        private System.Windows.Forms.CheckBox ckbmie;
        private System.Windows.Forms.CheckBox ckbmar;
        private System.Windows.Forms.CheckBox ckblun;
        private System.Windows.Forms.GroupBox gbxSync;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox cbxSucursal;
        private System.Windows.Forms.TextBox tbxPin;
        private System.Windows.Forms.CheckBox ckbPin;
        private System.Windows.Forms.RadioButton rbnActivo;
        private System.Windows.Forms.RadioButton rbnBaja;
        private System.Windows.Forms.ComboBox cbxSucursales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFModificacion;
        private System.Windows.Forms.Label lblFIngreso;
        private System.Windows.Forms.CheckBox ckbModificaSucursal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn desactivar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn depto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhrentrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhrsalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diasdescansos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tienehuella;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pinactivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fmodifica;
    }
}