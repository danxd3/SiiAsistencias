namespace CPresentacion
{
    partial class frmSubAreas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbxAgregarEditar = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbxFolio = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblFmodifica = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cbxEliminar = new System.Windows.Forms.CheckBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.dgwCategorias = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrearea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSucursales = new System.Windows.Forms.ComboBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.lbFechaini = new System.Windows.Forms.Label();
            this.dtpFechaini = new System.Windows.Forms.DateTimePicker();
            this.dgvPrueba = new System.Windows.Forms.DataGridView();
            this.depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subareax = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nombrex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardarEmpAreas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbInacistencias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEmpleados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btInsertarExcepcion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.gbxAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategorias)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBuscar);
            this.tabPage3.Controls.Add(this.tbxBuscar);
            this.tabPage3.Controls.Add(this.dgwCategorias);
            this.tabPage3.Controls.Add(this.lblBuscar);
            this.tabPage3.Controls.Add(this.lblRegistros);
            this.tabPage3.Controls.Add(this.cbxEliminar);
            this.tabPage3.Controls.Add(this.btnImprimir);
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.btnModificar);
            this.tabPage3.Controls.Add(this.btnNuevo);
            this.tabPage3.Controls.Add(this.gbxAgregarEditar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(799, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbxAgregarEditar
            // 
            this.gbxAgregarEditar.Controls.Add(this.lblFmodifica);
            this.gbxAgregarEditar.Controls.Add(this.lblFolio);
            this.gbxAgregarEditar.Controls.Add(this.btnCancelar);
            this.gbxAgregarEditar.Controls.Add(this.btnGuardar);
            this.gbxAgregarEditar.Controls.Add(this.tbxDescripcion);
            this.gbxAgregarEditar.Controls.Add(this.tbxNombre);
            this.gbxAgregarEditar.Controls.Add(this.tbxFolio);
            this.gbxAgregarEditar.Controls.Add(this.lblDescripcion);
            this.gbxAgregarEditar.Controls.Add(this.lblNombre);
            this.gbxAgregarEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAgregarEditar.Location = new System.Drawing.Point(460, 99);
            this.gbxAgregarEditar.Name = "gbxAgregarEditar";
            this.gbxAgregarEditar.Size = new System.Drawing.Size(330, 315);
            this.gbxAgregarEditar.TabIndex = 24;
            this.gbxAgregarEditar.TabStop = false;
            this.gbxAgregarEditar.Text = "Agregar / Editar";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(15, 88);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 16);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descrpcion:";
            // 
            // tbxFolio
            // 
            this.tbxFolio.BackColor = System.Drawing.Color.White;
            this.tbxFolio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFolio.Location = new System.Drawing.Point(228, 9);
            this.tbxFolio.Name = "tbxFolio";
            this.tbxFolio.ReadOnly = true;
            this.tbxFolio.Size = new System.Drawing.Size(100, 23);
            this.tbxFolio.TabIndex = 12;
            this.tbxFolio.Visible = false;
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.White;
            this.tbxNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(100, 40);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(200, 23);
            this.tbxNombre.TabIndex = 13;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.BackColor = System.Drawing.Color.White;
            this.tbxDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescripcion.Location = new System.Drawing.Point(100, 85);
            this.tbxDescripcion.MaxLength = 256;
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescripcion.Size = new System.Drawing.Size(200, 91);
            this.tbxDescripcion.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(86, 244);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(188, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(180, 12);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(42, 16);
            this.lblFolio.TabIndex = 17;
            this.lblFolio.Text = "Folio:";
            this.lblFolio.Visible = false;
            // 
            // lblFmodifica
            // 
            this.lblFmodifica.AutoSize = true;
            this.lblFmodifica.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFmodifica.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFmodifica.Location = new System.Drawing.Point(15, 190);
            this.lblFmodifica.Name = "lblFmodifica";
            this.lblFmodifica.Size = new System.Drawing.Size(242, 16);
            this.lblFmodifica.TabIndex = 18;
            this.lblFmodifica.Text = "Fecha de modificación: 01/01/2000";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(8, 14);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 30);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(98, 14);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 30);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(188, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 30);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(278, 14);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 30);
            this.btnImprimir.TabIndex = 28;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // cbxEliminar
            // 
            this.cbxEliminar.AutoSize = true;
            this.cbxEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEliminar.Location = new System.Drawing.Point(5, 63);
            this.cbxEliminar.Name = "cbxEliminar";
            this.cbxEliminar.Size = new System.Drawing.Size(76, 20);
            this.cbxEliminar.TabIndex = 29;
            this.cbxEliminar.Text = "Eliminar";
            this.cbxEliminar.UseVisualStyleBackColor = true;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(275, 63);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(129, 16);
            this.lblRegistros.TabIndex = 30;
            this.lblRegistros.Text = "No. de SubAreas: ";
            // 
            // dgwCategorias
            // 
            this.dgwCategorias.AllowUserToAddRows = false;
            this.dgwCategorias.AllowUserToDeleteRows = false;
            this.dgwCategorias.AllowUserToResizeColumns = false;
            this.dgwCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgwCategorias.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwCategorias.ColumnHeadersHeight = 35;
            this.dgwCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.nombrearea,
            this.descripcion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCategorias.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwCategorias.EnableHeadersVisualStyles = false;
            this.dgwCategorias.Location = new System.Drawing.Point(13, 99);
            this.dgwCategorias.MultiSelect = false;
            this.dgwCategorias.Name = "dgwCategorias";
            this.dgwCategorias.ReadOnly = true;
            this.dgwCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwCategorias.RowHeadersVisible = false;
            this.dgwCategorias.RowHeadersWidth = 35;
            this.dgwCategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwCategorias.RowTemplate.Height = 30;
            this.dgwCategorias.RowTemplate.ReadOnly = true;
            this.dgwCategorias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCategorias.Size = new System.Drawing.Size(430, 373);
            this.dgwCategorias.TabIndex = 31;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 250;
            // 
            // nombrearea
            // 
            this.nombrearea.DataPropertyName = "nombrearea";
            this.nombrearea.HeaderText = "DEPARTAMENTO";
            this.nombrearea.Name = "nombrearea";
            this.nombrearea.ReadOnly = true;
            this.nombrearea.Width = 200;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "ELIMINAR";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(413, 24);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(58, 16);
            this.lblBuscar.TabIndex = 32;
            this.lblBuscar.Text = "Buscar:";
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.BackColor = System.Drawing.Color.White;
            this.tbxBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscar.Location = new System.Drawing.Point(478, 21);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(225, 23);
            this.tbxBuscar.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(713, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 30);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.GuardarEmpAreas);
            this.tabPage2.Controls.Add(this.dgvPrueba);
            this.tabPage2.Controls.Add(this.dtpFechaini);
            this.tabPage2.Controls.Add(this.lbFechaini);
            this.tabPage2.Controls.Add(this.btConsultar);
            this.tabPage2.Controls.Add(this.cbxSucursales);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asignar Sub Areas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Sucursal:";
            // 
            // cbxSucursales
            // 
            this.cbxSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSucursales.FormattingEnabled = true;
            this.cbxSucursales.Location = new System.Drawing.Point(95, 37);
            this.cbxSucursales.Name = "cbxSucursales";
            this.cbxSucursales.Size = new System.Drawing.Size(150, 24);
            this.cbxSucursales.TabIndex = 42;
            this.cbxSucursales.SelectedIndexChanged += new System.EventHandler(this.cbxSucursales_SelectedIndexChanged);
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(277, 24);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(105, 43);
            this.btConsultar.TabIndex = 46;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbFechaini
            // 
            this.lbFechaini.AutoSize = true;
            this.lbFechaini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaini.Location = new System.Drawing.Point(30, 6);
            this.lbFechaini.Name = "lbFechaini";
            this.lbFechaini.Size = new System.Drawing.Size(83, 16);
            this.lbFechaini.TabIndex = 48;
            this.lbFechaini.Text = "Fecha inicio:";
            // 
            // dtpFechaini
            // 
            this.dtpFechaini.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaini.Location = new System.Drawing.Point(119, 4);
            this.dtpFechaini.Name = "dtpFechaini";
            this.dtpFechaini.Size = new System.Drawing.Size(119, 22);
            this.dtpFechaini.TabIndex = 47;
            this.dtpFechaini.Value = new System.DateTime(2020, 3, 30, 14, 53, 50, 0);
            // 
            // dgvPrueba
            // 
            this.dgvPrueba.AllowUserToAddRows = false;
            this.dgvPrueba.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrueba.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrueba.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigox,
            this.nombrex,
            this.Subareax,
            this.depto});
            this.dgvPrueba.EnableHeadersVisualStyles = false;
            this.dgvPrueba.Location = new System.Drawing.Point(29, 81);
            this.dgvPrueba.Name = "dgvPrueba";
            this.dgvPrueba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrueba.Size = new System.Drawing.Size(748, 255);
            this.dgvPrueba.TabIndex = 50;
            this.dgvPrueba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrueba_CellContentClick);
            // 
            // depto
            // 
            this.depto.DataPropertyName = "depto";
            this.depto.HeaderText = "Depto";
            this.depto.Name = "depto";
            // 
            // Subareax
            // 
            this.Subareax.DataPropertyName = "idsubarea";
            this.Subareax.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Subareax.HeaderText = "Subareax";
            this.Subareax.Name = "Subareax";
            this.Subareax.Width = 250;
            // 
            // nombrex
            // 
            this.nombrex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrex.DataPropertyName = "nombrecompleto";
            this.nombrex.HeaderText = "Nombrex";
            this.nombrex.Name = "nombrex";
            // 
            // codigox
            // 
            this.codigox.DataPropertyName = "codigo";
            this.codigox.HeaderText = "codigox";
            this.codigox.Name = "codigox";
            // 
            // GuardarEmpAreas
            // 
            this.GuardarEmpAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardarEmpAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarEmpAreas.Location = new System.Drawing.Point(672, 427);
            this.GuardarEmpAreas.Name = "GuardarEmpAreas";
            this.GuardarEmpAreas.Size = new System.Drawing.Size(105, 43);
            this.GuardarEmpAreas.TabIndex = 51;
            this.GuardarEmpAreas.Text = "Guardar";
            this.GuardarEmpAreas.UseVisualStyleBackColor = true;
            this.GuardarEmpAreas.Click += new System.EventHandler(this.GuardarEmpAreas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btInsertarExcepcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxEmpleados);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbInacistencias);
            this.groupBox1.Location = new System.Drawing.Point(29, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 145);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Inasistencia";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbInacistencias
            // 
            this.cbInacistencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInacistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInacistencias.FormattingEnabled = true;
            this.cbInacistencias.Location = new System.Drawing.Point(104, 61);
            this.cbInacistencias.Name = "cbInacistencias";
            this.cbInacistencias.Size = new System.Drawing.Size(150, 24);
            this.cbInacistencias.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Excepcion";
            // 
            // cbxEmpleados
            // 
            this.cbxEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmpleados.FormattingEnabled = true;
            this.cbxEmpleados.Location = new System.Drawing.Point(102, 27);
            this.cbxEmpleados.Name = "cbxEmpleados";
            this.cbxEmpleados.Size = new System.Drawing.Size(259, 24);
            this.cbxEmpleados.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Empleado";
            // 
            // btInsertarExcepcion
            // 
            this.btInsertarExcepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertarExcepcion.Location = new System.Drawing.Point(104, 96);
            this.btInsertarExcepcion.Name = "btInsertarExcepcion";
            this.btInsertarExcepcion.Size = new System.Drawing.Size(105, 43);
            this.btInsertarExcepcion.TabIndex = 58;
            this.btInsertarExcepcion.Text = "Insertar";
            this.btInsertarExcepcion.UseVisualStyleBackColor = true;
            this.btInsertarExcepcion.Click += new System.EventHandler(this.btInsertarExcepcion_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(539, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 58;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // frmSubAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 541);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubAreas";
            this.Text = "frmSubAreas";
            this.Load += new System.EventHandler(this.frmSubAreas_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.gbxAgregarEditar.ResumeLayout(false);
            this.gbxAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategorias)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.DataGridView dgwCategorias;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrearea;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.CheckBox cbxEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxAgregarEditar;
        private System.Windows.Forms.Label lblFmodifica;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxFolio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btInsertarExcepcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEmpleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbInacistencias;
        private System.Windows.Forms.Button GuardarEmpAreas;
        private System.Windows.Forms.DataGridView dgvPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrex;
        private System.Windows.Forms.DataGridViewComboBoxColumn Subareax;
        private System.Windows.Forms.DataGridViewTextBoxColumn depto;
        private System.Windows.Forms.DateTimePicker dtpFechaini;
        private System.Windows.Forms.Label lbFechaini;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.ComboBox cbxSucursales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}