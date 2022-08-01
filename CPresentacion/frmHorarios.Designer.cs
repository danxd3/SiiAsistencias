namespace CPresentacion
{
    partial class frmHorarios
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cbxEliminar = new System.Windows.Forms.CheckBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgwCategorias = new System.Windows.Forms.DataGridView();
            this.gbxAgregarEditar = new System.Windows.Forms.GroupBox();
            this.lblFmodifica = new System.Windows.Forms.Label();
            this.tbxTolerancia = new System.Windows.Forms.TextBox();
            this.lblTolerancia = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.tbxHrsalida = new System.Windows.Forms.TextBox();
            this.lblHrsalida = new System.Windows.Forms.Label();
            this.tbxHrentrada = new System.Windows.Forms.TextBox();
            this.lblHrentrada = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxFolio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.ttpMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idhorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrentrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrsalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tolerancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategorias)).BeginInit();
            this.gbxAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(20, 40);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 30);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(110, 40);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 30);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(200, 40);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(290, 40);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 30);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cbxEliminar
            // 
            this.cbxEliminar.AutoSize = true;
            this.cbxEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEliminar.Location = new System.Drawing.Point(25, 100);
            this.cbxEliminar.Name = "cbxEliminar";
            this.cbxEliminar.Size = new System.Drawing.Size(76, 20);
            this.cbxEliminar.TabIndex = 5;
            this.cbxEliminar.Text = "Eliminar";
            this.cbxEliminar.UseVisualStyleBackColor = true;
            this.cbxEliminar.CheckedChanged += new System.EventHandler(this.cbxEliminar_CheckedChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(425, 47);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 16);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(300, 100);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(111, 16);
            this.lblRegistros.TabIndex = 7;
            this.lblRegistros.Text = "No. de Horarios:";
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.BackColor = System.Drawing.Color.White;
            this.tbxBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscar.Location = new System.Drawing.Point(485, 44);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(225, 22);
            this.tbxBuscar.TabIndex = 8;
            this.tbxBuscar.TextChanged += new System.EventHandler(this.tbxBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(720, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 30);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgwCategorias
            // 
            this.dgwCategorias.AllowUserToAddRows = false;
            this.dgwCategorias.AllowUserToDeleteRows = false;
            this.dgwCategorias.AllowUserToResizeColumns = false;
            this.dgwCategorias.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwCategorias.ColumnHeadersHeight = 35;
            this.dgwCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.idhorario,
            this.nombre,
            this.hrentrada,
            this.hrsalida,
            this.tolerancia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwCategorias.EnableHeadersVisualStyles = false;
            this.dgwCategorias.Location = new System.Drawing.Point(20, 130);
            this.dgwCategorias.MultiSelect = false;
            this.dgwCategorias.Name = "dgwCategorias";
            this.dgwCategorias.ReadOnly = true;
            this.dgwCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwCategorias.RowHeadersVisible = false;
            this.dgwCategorias.RowHeadersWidth = 35;
            this.dgwCategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwCategorias.RowTemplate.Height = 30;
            this.dgwCategorias.RowTemplate.ReadOnly = true;
            this.dgwCategorias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCategorias.Size = new System.Drawing.Size(430, 400);
            this.dgwCategorias.TabIndex = 10;
            this.dgwCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCategorias_CellContentClick);
            this.dgwCategorias.DoubleClick += new System.EventHandler(this.dgwCategorias_DoubleClick);
            // 
            // gbxAgregarEditar
            // 
            this.gbxAgregarEditar.Controls.Add(this.lblFmodifica);
            this.gbxAgregarEditar.Controls.Add(this.tbxTolerancia);
            this.gbxAgregarEditar.Controls.Add(this.lblTolerancia);
            this.gbxAgregarEditar.Controls.Add(this.lblNotas);
            this.gbxAgregarEditar.Controls.Add(this.tbxHrsalida);
            this.gbxAgregarEditar.Controls.Add(this.lblHrsalida);
            this.gbxAgregarEditar.Controls.Add(this.tbxHrentrada);
            this.gbxAgregarEditar.Controls.Add(this.lblHrentrada);
            this.gbxAgregarEditar.Controls.Add(this.btnCancelar);
            this.gbxAgregarEditar.Controls.Add(this.btnGuardar);
            this.gbxAgregarEditar.Controls.Add(this.tbxNombre);
            this.gbxAgregarEditar.Controls.Add(this.tbxFolio);
            this.gbxAgregarEditar.Controls.Add(this.lblNombre);
            this.gbxAgregarEditar.Controls.Add(this.lblFolio);
            this.gbxAgregarEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAgregarEditar.Location = new System.Drawing.Point(475, 130);
            this.gbxAgregarEditar.Name = "gbxAgregarEditar";
            this.gbxAgregarEditar.Size = new System.Drawing.Size(330, 325);
            this.gbxAgregarEditar.TabIndex = 11;
            this.gbxAgregarEditar.TabStop = false;
            this.gbxAgregarEditar.Text = "Agregar / Editar";
            // 
            // lblFmodifica
            // 
            this.lblFmodifica.AutoSize = true;
            this.lblFmodifica.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFmodifica.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFmodifica.Location = new System.Drawing.Point(15, 216);
            this.lblFmodifica.Name = "lblFmodifica";
            this.lblFmodifica.Size = new System.Drawing.Size(242, 16);
            this.lblFmodifica.TabIndex = 23;
            this.lblFmodifica.Text = "Fecha de modificacion: 01/01/2021";
            // 
            // tbxTolerancia
            // 
            this.tbxTolerancia.BackColor = System.Drawing.Color.White;
            this.tbxTolerancia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTolerancia.Location = new System.Drawing.Point(134, 160);
            this.tbxTolerancia.Name = "tbxTolerancia";
            this.tbxTolerancia.Size = new System.Drawing.Size(166, 22);
            this.tbxTolerancia.TabIndex = 4;
            // 
            // lblTolerancia
            // 
            this.lblTolerancia.AutoSize = true;
            this.lblTolerancia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTolerancia.Location = new System.Drawing.Point(15, 163);
            this.lblTolerancia.Name = "lblTolerancia";
            this.lblTolerancia.Size = new System.Drawing.Size(113, 16);
            this.lblTolerancia.TabIndex = 22;
            this.lblTolerancia.Text = "Tolerancia (min):";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(123, 187);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(174, 12);
            this.lblNotas.TabIndex = 21;
            this.lblNotas.Text = "*Considerar formato de 24 horas.";
            // 
            // tbxHrsalida
            // 
            this.tbxHrsalida.BackColor = System.Drawing.Color.White;
            this.tbxHrsalida.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHrsalida.Location = new System.Drawing.Point(100, 120);
            this.tbxHrsalida.Name = "tbxHrsalida";
            this.tbxHrsalida.Size = new System.Drawing.Size(200, 22);
            this.tbxHrsalida.TabIndex = 3;
            // 
            // lblHrsalida
            // 
            this.lblHrsalida.AutoSize = true;
            this.lblHrsalida.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrsalida.Location = new System.Drawing.Point(15, 123);
            this.lblHrsalida.Name = "lblHrsalida";
            this.lblHrsalida.Size = new System.Drawing.Size(72, 16);
            this.lblHrsalida.TabIndex = 19;
            this.lblHrsalida.Text = "Hr. salida:";
            // 
            // tbxHrentrada
            // 
            this.tbxHrentrada.BackColor = System.Drawing.Color.White;
            this.tbxHrentrada.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHrentrada.Location = new System.Drawing.Point(100, 80);
            this.tbxHrentrada.Name = "tbxHrentrada";
            this.tbxHrentrada.Size = new System.Drawing.Size(200, 22);
            this.tbxHrentrada.TabIndex = 2;
            // 
            // lblHrentrada
            // 
            this.lblHrentrada.AutoSize = true;
            this.lblHrentrada.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrentrada.Location = new System.Drawing.Point(15, 83);
            this.lblHrentrada.Name = "lblHrentrada";
            this.lblHrentrada.Size = new System.Drawing.Size(85, 16);
            this.lblHrentrada.TabIndex = 17;
            this.lblHrentrada.Text = "Hr. entrada:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(170, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 25);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(68, 282);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 25);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.White;
            this.tbxNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(100, 40);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(200, 22);
            this.tbxNombre.TabIndex = 1;
            // 
            // tbxFolio
            // 
            this.tbxFolio.BackColor = System.Drawing.Color.White;
            this.tbxFolio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFolio.Location = new System.Drawing.Point(212, 7);
            this.tbxFolio.Name = "tbxFolio";
            this.tbxFolio.ReadOnly = true;
            this.tbxFolio.Size = new System.Drawing.Size(100, 22);
            this.tbxFolio.TabIndex = 12;
            this.tbxFolio.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(167, 10);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(42, 16);
            this.lblFolio.TabIndex = 7;
            this.lblFolio.Text = "Folio:";
            this.lblFolio.Visible = false;
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // idhorario
            // 
            this.idhorario.DataPropertyName = "idhorario";
            this.idhorario.HeaderText = "ID HORARIO";
            this.idhorario.Name = "idhorario";
            this.idhorario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // hrentrada
            // 
            this.hrentrada.DataPropertyName = "hrentrada";
            this.hrentrada.HeaderText = "ENTRADA";
            this.hrentrada.Name = "hrentrada";
            this.hrentrada.ReadOnly = true;
            // 
            // hrsalida
            // 
            this.hrsalida.DataPropertyName = "hrsalida";
            this.hrsalida.HeaderText = "SALIDA";
            this.hrsalida.Name = "hrsalida";
            this.hrsalida.ReadOnly = true;
            // 
            // tolerancia
            // 
            this.tolerancia.DataPropertyName = "tolerancia";
            this.tolerancia.HeaderText = "TOLERANCIA";
            this.tolerancia.Name = "tolerancia";
            this.tolerancia.ReadOnly = true;
            // 
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 541);
            this.Controls.Add(this.gbxAgregarEditar);
            this.Controls.Add(this.dgwCategorias);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbxBuscar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.cbxEliminar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategorias)).EndInit();
            this.gbxAgregarEditar.ResumeLayout(false);
            this.gbxAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.CheckBox cbxEliminar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgwCategorias;
        private System.Windows.Forms.GroupBox gbxAgregarEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxFolio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.ToolTip ttpMensaje;
        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.TextBox tbxHrsalida;
        private System.Windows.Forms.Label lblHrsalida;
        private System.Windows.Forms.TextBox tbxHrentrada;
        private System.Windows.Forms.Label lblHrentrada;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.TextBox tbxTolerancia;
        private System.Windows.Forms.Label lblTolerancia;
        private System.Windows.Forms.Label lblFmodifica;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrentrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrsalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn tolerancia;
    }
}