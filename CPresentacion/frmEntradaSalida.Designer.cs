namespace CPresentacion
{
    partial class frmEntradaSalida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRespaldo = new System.Windows.Forms.Button();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lbFechafin = new System.Windows.Forms.Label();
            this.lbFechaini = new System.Windows.Forms.Label();
            this.dtpFechafin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaini = new System.Windows.Forms.DateTimePicker();
            this.btnResgistros = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbxDeptos = new System.Windows.Forms.ComboBox();
            this.cbxEmpleados = new System.Windows.Forms.ComboBox();
            this.cbxSucursales = new System.Windows.Forms.ComboBox();
            this.lblDepto = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalreg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitemEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemSalida = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mitemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcArticulos = new System.Windows.Forms.TabControl();
            this.tbpListado = new System.Windows.Forms.TabPage();
            this.tbpObservaciones = new System.Windows.Forms.TabPage();
            this.gbxAgregarEditar = new System.Windows.Forms.GroupBox();
            this.lblTObservacion = new System.Windows.Forms.Label();
            this.rbnDescanso = new System.Windows.Forms.RadioButton();
            this.rbnObservacion = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvObservaciones = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idobservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoobs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaobs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.general = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombreobs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalobs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.ckbGeneral = new System.Windows.Forms.CheckBox();
            this.lblEmp = new System.Windows.Forms.Label();
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbxObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.btnObservaciones = new System.Windows.Forms.Button();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.tbcArticulos.SuspendLayout();
            this.tbpListado.SuspendLayout();
            this.tbpObservaciones.SuspendLayout();
            this.gbxAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRespaldo
            // 
            this.btnRespaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespaldo.Location = new System.Drawing.Point(580, 60);
            this.btnRespaldo.Name = "btnRespaldo";
            this.btnRespaldo.Size = new System.Drawing.Size(100, 30);
            this.btnRespaldo.TabIndex = 30;
            this.btnRespaldo.Text = "Respaldo";
            this.btnRespaldo.UseVisualStyleBackColor = true;
            this.btnRespaldo.Click += new System.EventHandler(this.btnRespaldo_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(273, 73);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(74, 16);
            this.lblEmpleado.TabIndex = 29;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(273, 13);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(63, 16);
            this.lblSucursal.TabIndex = 23;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // lbFechafin
            // 
            this.lbFechafin.AutoSize = true;
            this.lbFechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechafin.Location = new System.Drawing.Point(15, 52);
            this.lbFechafin.Name = "lbFechafin";
            this.lbFechafin.Size = new System.Drawing.Size(65, 16);
            this.lbFechafin.TabIndex = 21;
            this.lbFechafin.Text = "Fecha fin:";
            // 
            // lbFechaini
            // 
            this.lbFechaini.AutoSize = true;
            this.lbFechaini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaini.Location = new System.Drawing.Point(15, 17);
            this.lbFechaini.Name = "lbFechaini";
            this.lbFechaini.Size = new System.Drawing.Size(83, 16);
            this.lbFechaini.TabIndex = 20;
            this.lbFechaini.Text = "Fecha inicio:";
            // 
            // dtpFechafin
            // 
            this.dtpFechafin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechafin.Location = new System.Drawing.Point(106, 47);
            this.dtpFechafin.Name = "dtpFechafin";
            this.dtpFechafin.Size = new System.Drawing.Size(119, 22);
            this.dtpFechafin.TabIndex = 19;
            // 
            // dtpFechaini
            // 
            this.dtpFechaini.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaini.Location = new System.Drawing.Point(106, 12);
            this.dtpFechaini.Name = "dtpFechaini";
            this.dtpFechaini.Size = new System.Drawing.Size(119, 22);
            this.dtpFechaini.TabIndex = 18;
            this.dtpFechaini.Value = new System.DateTime(2020, 3, 30, 14, 53, 50, 0);
            // 
            // btnResgistros
            // 
            this.btnResgistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResgistros.Location = new System.Drawing.Point(580, 15);
            this.btnResgistros.Name = "btnResgistros";
            this.btnResgistros.Size = new System.Drawing.Size(100, 30);
            this.btnResgistros.TabIndex = 17;
            this.btnResgistros.Text = "Registros";
            this.btnResgistros.UseVisualStyleBackColor = true;
            this.btnResgistros.Click += new System.EventHandler(this.btnResgistros_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(607, 524);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(115, 16);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total de registros: ";
            // 
            // cbxDeptos
            // 
            this.cbxDeptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDeptos.FormattingEnabled = true;
            this.cbxDeptos.Items.AddRange(new object[] {
            "Todos"});
            this.cbxDeptos.Location = new System.Drawing.Point(388, 40);
            this.cbxDeptos.Name = "cbxDeptos";
            this.cbxDeptos.Size = new System.Drawing.Size(150, 24);
            this.cbxDeptos.TabIndex = 35;
            this.cbxDeptos.SelectedIndexChanged += new System.EventHandler(this.cbxDeptos_SelectedIndexChanged);
            // 
            // cbxEmpleados
            // 
            this.cbxEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmpleados.FormattingEnabled = true;
            this.cbxEmpleados.Location = new System.Drawing.Point(388, 70);
            this.cbxEmpleados.Name = "cbxEmpleados";
            this.cbxEmpleados.Size = new System.Drawing.Size(150, 24);
            this.cbxEmpleados.TabIndex = 36;
            this.cbxEmpleados.SelectedIndexChanged += new System.EventHandler(this.cbxEmpleados_SelectedIndexChanged);
            // 
            // cbxSucursales
            // 
            this.cbxSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSucursales.FormattingEnabled = true;
            this.cbxSucursales.Location = new System.Drawing.Point(388, 10);
            this.cbxSucursales.Name = "cbxSucursales";
            this.cbxSucursales.Size = new System.Drawing.Size(150, 24);
            this.cbxSucursales.TabIndex = 38;
            this.cbxSucursales.SelectedIndexChanged += new System.EventHandler(this.cbxSucursales_SelectedIndexChanged);
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepto.Location = new System.Drawing.Point(273, 43);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(97, 16);
            this.lblDepto.TabIndex = 37;
            this.lblDepto.Text = "Departamento:";
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(700, 60);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(100, 30);
            this.btnExportar.TabIndex = 39;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.AllowUserToResizeColumns = false;
            this.dgvRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecords.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecords.ColumnHeadersHeight = 35;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.codigo,
            this.nombre,
            this.fecha,
            this.hora,
            this.estado,
            this.sucursalreg});
            this.dgvRecords.EnableHeadersVisualStyles = false;
            this.dgvRecords.Location = new System.Drawing.Point(2, 19);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecords.RowHeadersVisible = false;
            this.dgvRecords.RowHeadersWidth = 35;
            this.dgvRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecords.RowTemplate.Height = 30;
            this.dgvRecords.RowTemplate.ReadOnly = true;
            this.dgvRecords.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(784, 361);
            this.dgvRecords.TabIndex = 0;
            this.dgvRecords.VirtualMode = true;
            this.dgvRecords.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecords_CellMouseClick);
            this.dgvRecords.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvRecords_CellValueNeeded);
            this.dgvRecords.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRecords_DataBindingComplete);
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombrecompleto";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 250;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "HORA";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // sucursalreg
            // 
            this.sucursalreg.DataPropertyName = "sucursal";
            this.sucursalreg.HeaderText = "SUCURSAL REG.";
            this.sucursalreg.Name = "sucursalreg";
            this.sucursalreg.ReadOnly = true;
            this.sucursalreg.Width = 150;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemEntrada,
            this.mitemSalida,
            this.toolStripSeparator1,
            this.mitemEliminar});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(181, 98);
            // 
            // mitemEntrada
            // 
            this.mitemEntrada.Name = "mitemEntrada";
            this.mitemEntrada.Size = new System.Drawing.Size(180, 22);
            this.mitemEntrada.Text = "ENTRADA";
            this.mitemEntrada.Click += new System.EventHandler(this.mitemEntrada_Click);
            // 
            // mitemSalida
            // 
            this.mitemSalida.Name = "mitemSalida";
            this.mitemSalida.Size = new System.Drawing.Size(180, 22);
            this.mitemSalida.Text = "SALIDA";
            this.mitemSalida.Click += new System.EventHandler(this.mitemSalida_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mitemEliminar
            // 
            this.mitemEliminar.Name = "mitemEliminar";
            this.mitemEliminar.Size = new System.Drawing.Size(180, 22);
            this.mitemEliminar.Text = "ELIMINAR";
            this.mitemEliminar.Click += new System.EventHandler(this.mitemEliminar_Click);
            // 
            // tbcArticulos
            // 
            this.tbcArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcArticulos.Controls.Add(this.tbpListado);
            this.tbcArticulos.Controls.Add(this.tbpObservaciones);
            this.tbcArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcArticulos.ItemSize = new System.Drawing.Size(58, 18);
            this.tbcArticulos.Location = new System.Drawing.Point(12, 100);
            this.tbcArticulos.Name = "tbcArticulos";
            this.tbcArticulos.SelectedIndex = 0;
            this.tbcArticulos.Size = new System.Drawing.Size(793, 421);
            this.tbcArticulos.TabIndex = 40;
            this.tbcArticulos.SelectedIndexChanged += new System.EventHandler(this.tbcArticulos_SelectedIndexChanged);
            // 
            // tbpListado
            // 
            this.tbpListado.Controls.Add(this.dgvRecords);
            this.tbpListado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpListado.Location = new System.Drawing.Point(4, 22);
            this.tbpListado.Name = "tbpListado";
            this.tbpListado.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListado.Size = new System.Drawing.Size(785, 395);
            this.tbpListado.TabIndex = 0;
            this.tbpListado.Text = "Registros";
            this.tbpListado.UseVisualStyleBackColor = true;
            // 
            // tbpObservaciones
            // 
            this.tbpObservaciones.Controls.Add(this.gbxAgregarEditar);
            this.tbpObservaciones.Location = new System.Drawing.Point(4, 22);
            this.tbpObservaciones.Name = "tbpObservaciones";
            this.tbpObservaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tbpObservaciones.Size = new System.Drawing.Size(785, 395);
            this.tbpObservaciones.TabIndex = 1;
            this.tbpObservaciones.Text = "Observaciones";
            this.tbpObservaciones.UseVisualStyleBackColor = true;
            // 
            // gbxAgregarEditar
            // 
            this.gbxAgregarEditar.Controls.Add(this.lblTObservacion);
            this.gbxAgregarEditar.Controls.Add(this.rbnDescanso);
            this.gbxAgregarEditar.Controls.Add(this.rbnObservacion);
            this.gbxAgregarEditar.Controls.Add(this.btnBuscar);
            this.gbxAgregarEditar.Controls.Add(this.dgvObservaciones);
            this.gbxAgregarEditar.Controls.Add(this.lblFecha);
            this.gbxAgregarEditar.Controls.Add(this.dtpFecha);
            this.gbxAgregarEditar.Controls.Add(this.ckbGeneral);
            this.gbxAgregarEditar.Controls.Add(this.lblEmp);
            this.gbxAgregarEditar.Controls.Add(this.cbxEmp);
            this.gbxAgregarEditar.Controls.Add(this.btnCancelar);
            this.gbxAgregarEditar.Controls.Add(this.btnGuardar);
            this.gbxAgregarEditar.Controls.Add(this.tbxObservacion);
            this.gbxAgregarEditar.Controls.Add(this.lblObservacion);
            this.gbxAgregarEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbxAgregarEditar.Location = new System.Drawing.Point(15, 6);
            this.gbxAgregarEditar.Name = "gbxAgregarEditar";
            this.gbxAgregarEditar.Size = new System.Drawing.Size(751, 403);
            this.gbxAgregarEditar.TabIndex = 23;
            this.gbxAgregarEditar.TabStop = false;
            this.gbxAgregarEditar.Text = "Observaciones";
            // 
            // lblTObservacion
            // 
            this.lblTObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTObservacion.AutoSize = true;
            this.lblTObservacion.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTObservacion.Location = new System.Drawing.Point(529, 357);
            this.lblTObservacion.Name = "lblTObservacion";
            this.lblTObservacion.Size = new System.Drawing.Size(97, 16);
            this.lblTObservacion.TabIndex = 42;
            this.lblTObservacion.Text = "T. Observacion: ";
            // 
            // rbnDescanso
            // 
            this.rbnDescanso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnDescanso.AutoSize = true;
            this.rbnDescanso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnDescanso.Location = new System.Drawing.Point(211, 25);
            this.rbnDescanso.Name = "rbnDescanso";
            this.rbnDescanso.Size = new System.Drawing.Size(88, 20);
            this.rbnDescanso.TabIndex = 35;
            this.rbnDescanso.Text = "Descanso";
            this.rbnDescanso.UseVisualStyleBackColor = true;
            this.rbnDescanso.CheckedChanged += new System.EventHandler(this.rbnDescanso_CheckedChanged);
            // 
            // rbnObservacion
            // 
            this.rbnObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnObservacion.AutoSize = true;
            this.rbnObservacion.Checked = true;
            this.rbnObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnObservacion.Location = new System.Drawing.Point(100, 25);
            this.rbnObservacion.Name = "rbnObservacion";
            this.rbnObservacion.Size = new System.Drawing.Size(103, 20);
            this.rbnObservacion.TabIndex = 34;
            this.rbnObservacion.TabStop = true;
            this.rbnObservacion.Text = "Observación";
            this.rbnObservacion.UseVisualStyleBackColor = true;
            this.rbnObservacion.CheckedChanged += new System.EventHandler(this.rbnObservacion_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBuscar.Location = new System.Drawing.Point(666, 350);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 30);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvObservaciones
            // 
            this.dgvObservaciones.AllowUserToAddRows = false;
            this.dgvObservaciones.AllowUserToDeleteRows = false;
            this.dgvObservaciones.AllowUserToResizeColumns = false;
            this.dgvObservaciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvObservaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvObservaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObservaciones.ColumnHeadersHeight = 35;
            this.dgvObservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvObservaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.idobservacion,
            this.codigoobs,
            this.fechaobs,
            this.general,
            this.nombreobs,
            this.observacion,
            this.sucursalobs});
            this.dgvObservaciones.EnableHeadersVisualStyles = false;
            this.dgvObservaciones.Location = new System.Drawing.Point(364, 21);
            this.dgvObservaciones.MultiSelect = false;
            this.dgvObservaciones.Name = "dgvObservaciones";
            this.dgvObservaciones.ReadOnly = true;
            this.dgvObservaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvObservaciones.RowHeadersVisible = false;
            this.dgvObservaciones.RowHeadersWidth = 35;
            this.dgvObservaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvObservaciones.RowTemplate.Height = 30;
            this.dgvObservaciones.RowTemplate.ReadOnly = true;
            this.dgvObservaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObservaciones.Size = new System.Drawing.Size(387, 323);
            this.dgvObservaciones.TabIndex = 32;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // idobservacion
            // 
            this.idobservacion.DataPropertyName = "idobservacion";
            this.idobservacion.HeaderText = "ID OBSERVACION";
            this.idobservacion.Name = "idobservacion";
            this.idobservacion.ReadOnly = true;
            // 
            // codigoobs
            // 
            this.codigoobs.DataPropertyName = "codigoobs";
            this.codigoobs.HeaderText = "CODIGO";
            this.codigoobs.Name = "codigoobs";
            this.codigoobs.ReadOnly = true;
            this.codigoobs.Width = 80;
            // 
            // fechaobs
            // 
            this.fechaobs.DataPropertyName = "fecha";
            this.fechaobs.HeaderText = "FECHA";
            this.fechaobs.Name = "fechaobs";
            this.fechaobs.ReadOnly = true;
            this.fechaobs.Width = 80;
            // 
            // general
            // 
            this.general.DataPropertyName = "general";
            this.general.HeaderText = "GENERAL";
            this.general.Name = "general";
            this.general.ReadOnly = true;
            this.general.TrueValue = "1";
            this.general.Width = 80;
            // 
            // nombreobs
            // 
            this.nombreobs.DataPropertyName = "nombre";
            this.nombreobs.HeaderText = "NOMBRE";
            this.nombreobs.Name = "nombreobs";
            this.nombreobs.ReadOnly = true;
            this.nombreobs.Width = 200;
            // 
            // observacion
            // 
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "OBSERVACION";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Width = 250;
            // 
            // sucursalobs
            // 
            this.sucursalobs.DataPropertyName = "sucursal";
            this.sucursalobs.HeaderText = "SUCURSAL";
            this.sucursalobs.Name = "sucursalobs";
            this.sucursalobs.ReadOnly = true;
            this.sucursalobs.Width = 150;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(20, 140);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 16);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(105, 130);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(119, 22);
            this.dtpFecha.TabIndex = 30;
            this.dtpFecha.Value = new System.DateTime(2021, 2, 20, 0, 0, 0, 0);
            // 
            // ckbGeneral
            // 
            this.ckbGeneral.AutoSize = true;
            this.ckbGeneral.Enabled = false;
            this.ckbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbGeneral.Location = new System.Drawing.Point(20, 55);
            this.ckbGeneral.Name = "ckbGeneral";
            this.ckbGeneral.Size = new System.Drawing.Size(75, 20);
            this.ckbGeneral.TabIndex = 29;
            this.ckbGeneral.Text = "General";
            this.ckbGeneral.UseVisualStyleBackColor = true;
            this.ckbGeneral.CheckedChanged += new System.EventHandler(this.ckbGeneral_CheckedChanged);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmp.Location = new System.Drawing.Point(20, 95);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(74, 16);
            this.lblEmp.TabIndex = 28;
            this.lblEmp.Text = "Empleado:";
            // 
            // cbxEmp
            // 
            this.cbxEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(105, 90);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(234, 24);
            this.cbxEmp.TabIndex = 3;
            this.cbxEmp.SelectedIndexChanged += new System.EventHandler(this.cbxEmp_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(197, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(84, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbxObservacion
            // 
            this.tbxObservacion.BackColor = System.Drawing.Color.White;
            this.tbxObservacion.Enabled = false;
            this.tbxObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxObservacion.Location = new System.Drawing.Point(105, 165);
            this.tbxObservacion.Multiline = true;
            this.tbxObservacion.Name = "tbxObservacion";
            this.tbxObservacion.Size = new System.Drawing.Size(250, 161);
            this.tbxObservacion.TabIndex = 1;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblObservacion.Location = new System.Drawing.Point(20, 168);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(88, 16);
            this.lblObservacion.TabIndex = 8;
            this.lblObservacion.Text = "Observación:";
            // 
            // btnObservaciones
            // 
            this.btnObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObservaciones.Location = new System.Drawing.Point(700, 15);
            this.btnObservaciones.Name = "btnObservaciones";
            this.btnObservaciones.Size = new System.Drawing.Size(100, 30);
            this.btnObservaciones.TabIndex = 41;
            this.btnObservaciones.Text = "Observación";
            this.btnObservaciones.UseVisualStyleBackColor = true;
            this.btnObservaciones.Click += new System.EventHandler(this.btnObservaciones_Click);
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // frmEntradaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(820, 550);
            this.Controls.Add(this.btnObservaciones);
            this.Controls.Add(this.tbcArticulos);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.cbxSucursales);
            this.Controls.Add(this.lblDepto);
            this.Controls.Add(this.cbxEmpleados);
            this.Controls.Add(this.cbxDeptos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRespaldo);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lbFechafin);
            this.Controls.Add(this.lbFechaini);
            this.Controls.Add(this.dtpFechafin);
            this.Controls.Add(this.dtpFechaini);
            this.Controls.Add(this.btnResgistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntradaSalida";
            this.Text = "frmRegistros";
            this.Load += new System.EventHandler(this.frmRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.tbcArticulos.ResumeLayout(false);
            this.tbpListado.ResumeLayout(false);
            this.tbpObservaciones.ResumeLayout(false);
            this.gbxAgregarEditar.ResumeLayout(false);
            this.gbxAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRespaldo;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lbFechafin;
        private System.Windows.Forms.Label lbFechaini;
        private System.Windows.Forms.DateTimePicker dtpFechafin;
        private System.Windows.Forms.DateTimePicker dtpFechaini;
        private System.Windows.Forms.Button btnResgistros;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cbxDeptos;
        private System.Windows.Forms.ComboBox cbxEmpleados;
        private System.Windows.Forms.ComboBox cbxSucursales;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem mitemEntrada;
        private System.Windows.Forms.ToolStripMenuItem mitemSalida;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mitemEliminar;
        private System.Windows.Forms.TabControl tbcArticulos;
        private System.Windows.Forms.TabPage tbpListado;
        private System.Windows.Forms.TabPage tbpObservaciones;
        private System.Windows.Forms.GroupBox gbxAgregarEditar;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.ComboBox cbxEmp;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbxObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Button btnObservaciones;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox ckbGeneral;
        private System.Windows.Forms.DataGridView dgvObservaciones;
        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idobservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaobs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn general;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalobs;
        private System.Windows.Forms.RadioButton rbnDescanso;
        private System.Windows.Forms.RadioButton rbnObservacion;
        private System.Windows.Forms.Label lblTObservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalreg;
    }
}