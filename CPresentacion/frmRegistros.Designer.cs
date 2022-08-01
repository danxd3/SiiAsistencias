namespace CPresentacion
{
    partial class frmRegistros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImprimir = new System.Windows.Forms.Button();
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
            this.tbcArticulos = new System.Windows.Forms.TabControl();
            this.tbpListado = new System.Windows.Forms.TabPage();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaentrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BonoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BonoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsucursale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsucursals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpSincronizar = new System.Windows.Forms.TabPage();
            this.ckbObservaciones = new System.Windows.Forms.CheckBox();
            this.ckbAsistencias = new System.Windows.Forms.CheckBox();
            this.ckbHorarios = new System.Windows.Forms.CheckBox();
            this.ckbDeptos = new System.Windows.Forms.CheckBox();
            this.ckbEmpleados = new System.Windows.Forms.CheckBox();
            this.lblServerGral = new System.Windows.Forms.Label();
            this.gbxImportar = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbxExportar = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ckbDetallado = new System.Windows.Forms.CheckBox();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitemDescanso = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDescargar = new FontAwesome.Sharp.IconButton();
            this.btnSubir = new FontAwesome.Sharp.IconButton();
            this.tbcArticulos.SuspendLayout();
            this.tbpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.tbpSincronizar.SuspendLayout();
            this.gbxImportar.SuspendLayout();
            this.gbxExportar.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(630, 45);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 30);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(567, 17);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(74, 16);
            this.lblEmpleado.TabIndex = 29;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(253, 17);
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
            this.btnResgistros.Location = new System.Drawing.Point(540, 45);
            this.btnResgistros.Name = "btnResgistros";
            this.btnResgistros.Size = new System.Drawing.Size(80, 30);
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
            this.lblTotal.Location = new System.Drawing.Point(611, 515);
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
            this.cbxDeptos.Location = new System.Drawing.Point(368, 45);
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
            this.cbxEmpleados.Location = new System.Drawing.Point(652, 14);
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
            this.cbxSucursales.Location = new System.Drawing.Point(368, 14);
            this.cbxSucursales.Name = "cbxSucursales";
            this.cbxSucursales.Size = new System.Drawing.Size(150, 24);
            this.cbxSucursales.TabIndex = 38;
            this.cbxSucursales.SelectedIndexChanged += new System.EventHandler(this.cbxSucursales_SelectedIndexChanged);
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepto.Location = new System.Drawing.Point(253, 48);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(97, 16);
            this.lblDepto.TabIndex = 37;
            this.lblDepto.Text = "Departamento:";
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(720, 45);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(80, 30);
            this.btnExportar.TabIndex = 39;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // tbcArticulos
            // 
            this.tbcArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcArticulos.Controls.Add(this.tbpListado);
            this.tbcArticulos.Controls.Add(this.tbpSincronizar);
            this.tbcArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcArticulos.ItemSize = new System.Drawing.Size(58, 18);
            this.tbcArticulos.Location = new System.Drawing.Point(15, 81);
            this.tbcArticulos.Name = "tbcArticulos";
            this.tbcArticulos.SelectedIndex = 0;
            this.tbcArticulos.Size = new System.Drawing.Size(797, 431);
            this.tbcArticulos.TabIndex = 41;
            this.tbcArticulos.SelectedIndexChanged += new System.EventHandler(this.tbcArticulos_SelectedIndexChanged);
            // 
            // tbpListado
            // 
            this.tbpListado.Controls.Add(this.dgvRecords);
            this.tbpListado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpListado.Location = new System.Drawing.Point(4, 22);
            this.tbpListado.Name = "tbpListado";
            this.tbpListado.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListado.Size = new System.Drawing.Size(789, 405);
            this.tbpListado.TabIndex = 0;
            this.tbpListado.Text = "Registros";
            this.tbpListado.UseVisualStyleBackColor = true;
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
            this.codigo,
            this.nombre,
            this.fecha,
            this.horaentrada,
            this.sucursale,
            this.horasalida,
            this.sucursals,
            this.BonoA,
            this.BonoP,
            this.puntual,
            this.HrExtras,
            this.observaciones,
            this.idsucursale,
            this.idsucursals});
            this.dgvRecords.EnableHeadersVisualStyles = false;
            this.dgvRecords.Location = new System.Drawing.Point(6, 6);
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
            this.dgvRecords.Size = new System.Drawing.Size(777, 393);
            this.dgvRecords.TabIndex = 1;
            this.dgvRecords.VirtualMode = true;
            this.dgvRecords.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecords_CellMouseClick);
            this.dgvRecords.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRecords_DataBindingComplete_1);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 250;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // horaentrada
            // 
            this.horaentrada.DataPropertyName = "horaentrada";
            this.horaentrada.HeaderText = "ENTRADA";
            this.horaentrada.Name = "horaentrada";
            this.horaentrada.ReadOnly = true;
            // 
            // sucursale
            // 
            this.sucursale.DataPropertyName = "sucursale";
            this.sucursale.HeaderText = "SUCURSAL E.";
            this.sucursale.Name = "sucursale";
            this.sucursale.ReadOnly = true;
            this.sucursale.Width = 130;
            // 
            // horasalida
            // 
            this.horasalida.DataPropertyName = "horasalida";
            this.horasalida.HeaderText = "SALIDA";
            this.horasalida.Name = "horasalida";
            this.horasalida.ReadOnly = true;
            // 
            // sucursals
            // 
            this.sucursals.DataPropertyName = "sucursals";
            this.sucursals.HeaderText = "SUCURSAL S.";
            this.sucursals.Name = "sucursals";
            this.sucursals.ReadOnly = true;
            this.sucursals.Width = 130;
            // 
            // BonoA
            // 
            this.BonoA.DataPropertyName = "Bono A.";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BonoA.DefaultCellStyle = dataGridViewCellStyle4;
            this.BonoA.HeaderText = "BONO A.";
            this.BonoA.Name = "BonoA";
            this.BonoA.ReadOnly = true;
            this.BonoA.Width = 84;
            // 
            // BonoP
            // 
            this.BonoP.DataPropertyName = "Bono P.";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BonoP.DefaultCellStyle = dataGridViewCellStyle5;
            this.BonoP.HeaderText = "BONO P.";
            this.BonoP.Name = "BonoP";
            this.BonoP.ReadOnly = true;
            this.BonoP.Width = 84;
            // 
            // puntual
            // 
            this.puntual.DataPropertyName = "puntual";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.puntual.DefaultCellStyle = dataGridViewCellStyle6;
            this.puntual.HeaderText = "PUNTUAL";
            this.puntual.Name = "puntual";
            this.puntual.ReadOnly = true;
            this.puntual.Width = 87;
            // 
            // HrExtras
            // 
            this.HrExtras.DataPropertyName = "HR EXTRAS";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HrExtras.DefaultCellStyle = dataGridViewCellStyle7;
            this.HrExtras.HeaderText = "HR. EXT";
            this.HrExtras.Name = "HrExtras";
            this.HrExtras.ReadOnly = true;
            this.HrExtras.Width = 84;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "Observaciones";
            this.observaciones.HeaderText = "OBSERVACIONES";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Width = 250;
            // 
            // idsucursale
            // 
            this.idsucursale.DataPropertyName = "idsucursale";
            this.idsucursale.HeaderText = "ID SUC. E.";
            this.idsucursale.Name = "idsucursale";
            this.idsucursale.ReadOnly = true;
            // 
            // idsucursals
            // 
            this.idsucursals.DataPropertyName = "idsucursals";
            this.idsucursals.HeaderText = "ID SUC. S";
            this.idsucursals.Name = "idsucursals";
            this.idsucursals.ReadOnly = true;
            // 
            // tbpSincronizar
            // 
            this.tbpSincronizar.Controls.Add(this.ckbObservaciones);
            this.tbpSincronizar.Controls.Add(this.ckbAsistencias);
            this.tbpSincronizar.Controls.Add(this.ckbHorarios);
            this.tbpSincronizar.Controls.Add(this.ckbDeptos);
            this.tbpSincronizar.Controls.Add(this.ckbEmpleados);
            this.tbpSincronizar.Controls.Add(this.lblServerGral);
            this.tbpSincronizar.Controls.Add(this.gbxImportar);
            this.tbpSincronizar.Controls.Add(this.gbxExportar);
            this.tbpSincronizar.Location = new System.Drawing.Point(4, 22);
            this.tbpSincronizar.Name = "tbpSincronizar";
            this.tbpSincronizar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSincronizar.Size = new System.Drawing.Size(789, 405);
            this.tbpSincronizar.TabIndex = 1;
            this.tbpSincronizar.Text = "Sincronizar";
            this.tbpSincronizar.UseVisualStyleBackColor = true;
            // 
            // ckbObservaciones
            // 
            this.ckbObservaciones.AutoSize = true;
            this.ckbObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbObservaciones.Location = new System.Drawing.Point(578, 58);
            this.ckbObservaciones.Name = "ckbObservaciones";
            this.ckbObservaciones.Size = new System.Drawing.Size(119, 20);
            this.ckbObservaciones.TabIndex = 48;
            this.ckbObservaciones.Text = "Observaciones";
            this.ckbObservaciones.UseVisualStyleBackColor = true;
            // 
            // ckbAsistencias
            // 
            this.ckbAsistencias.AutoSize = true;
            this.ckbAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbAsistencias.Location = new System.Drawing.Point(469, 58);
            this.ckbAsistencias.Name = "ckbAsistencias";
            this.ckbAsistencias.Size = new System.Drawing.Size(96, 20);
            this.ckbAsistencias.TabIndex = 47;
            this.ckbAsistencias.Text = "Asistencias";
            this.ckbAsistencias.UseVisualStyleBackColor = true;
            // 
            // ckbHorarios
            // 
            this.ckbHorarios.AutoSize = true;
            this.ckbHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbHorarios.Location = new System.Drawing.Point(353, 58);
            this.ckbHorarios.Name = "ckbHorarios";
            this.ckbHorarios.Size = new System.Drawing.Size(79, 20);
            this.ckbHorarios.TabIndex = 46;
            this.ckbHorarios.Text = "Horarios";
            this.ckbHorarios.UseVisualStyleBackColor = true;
            // 
            // ckbDeptos
            // 
            this.ckbDeptos.AutoSize = true;
            this.ckbDeptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbDeptos.Location = new System.Drawing.Point(215, 58);
            this.ckbDeptos.Name = "ckbDeptos";
            this.ckbDeptos.Size = new System.Drawing.Size(120, 20);
            this.ckbDeptos.TabIndex = 45;
            this.ckbDeptos.Text = "Departamentos";
            this.ckbDeptos.UseVisualStyleBackColor = true;
            // 
            // ckbEmpleados
            // 
            this.ckbEmpleados.AutoSize = true;
            this.ckbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbEmpleados.Location = new System.Drawing.Point(86, 58);
            this.ckbEmpleados.Name = "ckbEmpleados";
            this.ckbEmpleados.Size = new System.Drawing.Size(97, 20);
            this.ckbEmpleados.TabIndex = 44;
            this.ckbEmpleados.Text = "Empleados";
            this.ckbEmpleados.UseVisualStyleBackColor = true;
            // 
            // lblServerGral
            // 
            this.lblServerGral.AutoSize = true;
            this.lblServerGral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerGral.ForeColor = System.Drawing.Color.Red;
            this.lblServerGral.Location = new System.Drawing.Point(257, 16);
            this.lblServerGral.Name = "lblServerGral";
            this.lblServerGral.Size = new System.Drawing.Size(173, 16);
            this.lblServerGral.TabIndex = 42;
            this.lblServerGral.Text = "SERVIDOR GENERAL : ";
            // 
            // gbxImportar
            // 
            this.gbxImportar.Controls.Add(this.btnDescargar);
            this.gbxImportar.Controls.Add(this.textBox2);
            this.gbxImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbxImportar.Location = new System.Drawing.Point(406, 115);
            this.gbxImportar.Name = "gbxImportar";
            this.gbxImportar.Size = new System.Drawing.Size(366, 284);
            this.gbxImportar.TabIndex = 25;
            this.gbxImportar.TabStop = false;
            this.gbxImportar.Text = "Importar";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Blue;
            this.textBox2.Location = new System.Drawing.Point(27, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 55);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "ESTA OPCION ES PARA IMPORTAR LOS DATOS DEL SERVIDOR GENERAL A NUESTRO SISTEMA LOC" +
    "AL";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxExportar
            // 
            this.gbxExportar.Controls.Add(this.btnSubir);
            this.gbxExportar.Controls.Add(this.textBox1);
            this.gbxExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbxExportar.Location = new System.Drawing.Point(15, 115);
            this.gbxExportar.Name = "gbxExportar";
            this.gbxExportar.Size = new System.Drawing.Size(366, 284);
            this.gbxExportar.TabIndex = 24;
            this.gbxExportar.TabStop = false;
            this.gbxExportar.Text = "Exportar";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(16, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 55);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ESTA OPCION ES PARA EXPORTAR LOS DATOS DE NUESTRO SISTEMA LOCAL AL SERVIDOR GENER" +
    "AL";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbDetallado
            // 
            this.ckbDetallado.AutoSize = true;
            this.ckbDetallado.Enabled = false;
            this.ckbDetallado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbDetallado.Location = new System.Drawing.Point(729, 80);
            this.ckbDetallado.Name = "ckbDetallado";
            this.ckbDetallado.Size = new System.Drawing.Size(86, 20);
            this.ckbDetallado.TabIndex = 42;
            this.ckbDetallado.Text = "Detallado";
            this.ckbDetallado.UseVisualStyleBackColor = true;
            this.ckbDetallado.CheckedChanged += new System.EventHandler(this.ckbDetallado_CheckedChanged);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemDescanso});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(135, 26);
            // 
            // mitemDescanso
            // 
            this.mitemDescanso.Name = "mitemDescanso";
            this.mitemDescanso.Size = new System.Drawing.Size(134, 22);
            this.mitemDescanso.Text = "DESCANSO";
            this.mitemDescanso.Click += new System.EventHandler(this.mitemDescanso_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(231)))), ((int)(((byte)(161)))));
            this.btnDescargar.FlatAppearance.BorderSize = 0;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.Black;
            this.btnDescargar.IconChar = FontAwesome.Sharp.IconChar.CloudDownloadAlt;
            this.btnDescargar.IconColor = System.Drawing.Color.DarkOrange;
            this.btnDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargar.IconSize = 35;
            this.btnDescargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDescargar.Location = new System.Drawing.Point(116, 138);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.btnDescargar.Size = new System.Drawing.Size(150, 110);
            this.btnDescargar.TabIndex = 5;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(231)))), ((int)(((byte)(161)))));
            this.btnSubir.FlatAppearance.BorderSize = 0;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.Color.Black;
            this.btnSubir.IconChar = FontAwesome.Sharp.IconChar.CloudUploadAlt;
            this.btnSubir.IconColor = System.Drawing.Color.DarkOrange;
            this.btnSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubir.IconSize = 35;
            this.btnSubir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubir.Location = new System.Drawing.Point(101, 138);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.btnSubir.Size = new System.Drawing.Size(150, 110);
            this.btnSubir.TabIndex = 4;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // frmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(824, 541);
            this.Controls.Add(this.ckbDetallado);
            this.Controls.Add(this.tbcArticulos);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.cbxSucursales);
            this.Controls.Add(this.lblDepto);
            this.Controls.Add(this.cbxEmpleados);
            this.Controls.Add(this.cbxDeptos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lbFechafin);
            this.Controls.Add(this.lbFechaini);
            this.Controls.Add(this.dtpFechafin);
            this.Controls.Add(this.dtpFechaini);
            this.Controls.Add(this.btnResgistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistros";
            this.Text = "frmRegistros";
            this.Load += new System.EventHandler(this.frmRegistros_Load);
            this.tbcArticulos.ResumeLayout(false);
            this.tbpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.tbpSincronizar.ResumeLayout(false);
            this.tbpSincronizar.PerformLayout();
            this.gbxImportar.ResumeLayout(false);
            this.gbxImportar.PerformLayout();
            this.gbxExportar.ResumeLayout(false);
            this.gbxExportar.PerformLayout();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnImprimir;
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
        private System.Windows.Forms.TabControl tbcArticulos;
        private System.Windows.Forms.TabPage tbpListado;
        private System.Windows.Forms.TabPage tbpSincronizar;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.GroupBox gbxImportar;
        private System.Windows.Forms.GroupBox gbxExportar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton btnSubir;
        private System.Windows.Forms.Label lblServerGral;
        private FontAwesome.Sharp.IconButton btnDescargar;
        private System.Windows.Forms.CheckBox ckbObservaciones;
        private System.Windows.Forms.CheckBox ckbAsistencias;
        private System.Windows.Forms.CheckBox ckbHorarios;
        private System.Windows.Forms.CheckBox ckbDeptos;
        private System.Windows.Forms.CheckBox ckbEmpleados;
        private System.Windows.Forms.CheckBox ckbDetallado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaentrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursale;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursals;
        private System.Windows.Forms.DataGridViewTextBoxColumn BonoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BonoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntual;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsucursale;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsucursals;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem mitemDescanso;
    }
}