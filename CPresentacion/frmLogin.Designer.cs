namespace CPresentacion
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.tbxcontrasena = new System.Windows.Forms.TextBox();
            this.cbxusuario = new System.Windows.Forms.ComboBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcomp = new System.Windows.Forms.Label();
            this.pbxFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.tbxSucursal = new System.Windows.Forms.TextBox();
            this.pnltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormActual)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltitulo
            // 
            this.pnltitulo.BackColor = System.Drawing.Color.DarkOrange;
            this.pnltitulo.Controls.Add(this.lbltitulo);
            this.pnltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnltitulo.Location = new System.Drawing.Point(0, 0);
            this.pnltitulo.Name = "pnltitulo";
            this.pnltitulo.Size = new System.Drawing.Size(250, 30);
            this.pnltitulo.TabIndex = 16;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(62, 4);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(128, 23);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Iniciar sesión";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(25, 285);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(90, 35);
            this.btnaceptar.TabIndex = 13;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(130, 285);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(90, 35);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // tbxcontrasena
            // 
            this.tbxcontrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxcontrasena.Location = new System.Drawing.Point(110, 245);
            this.tbxcontrasena.Name = "tbxcontrasena";
            this.tbxcontrasena.PasswordChar = '*';
            this.tbxcontrasena.Size = new System.Drawing.Size(120, 27);
            this.tbxcontrasena.TabIndex = 12;
            this.tbxcontrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxcontrasena_KeyPress);
            // 
            // cbxusuario
            // 
            this.cbxusuario.BackColor = System.Drawing.SystemColors.Window;
            this.cbxusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxusuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxusuario.FormattingEnabled = true;
            this.cbxusuario.Location = new System.Drawing.Point(110, 200);
            this.cbxusuario.Name = "cbxusuario";
            this.cbxusuario.Size = new System.Drawing.Size(120, 28);
            this.cbxusuario.TabIndex = 11;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontrasena.Location = new System.Drawing.Point(7, 250);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(97, 18);
            this.lblcontrasena.TabIndex = 10;
            this.lblcontrasena.Text = "Contraseña:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(12, 204);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(66, 18);
            this.lblusuario.TabIndex = 9;
            this.lblusuario.Text = "Usuario:";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomp.Location = new System.Drawing.Point(46, 334);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(202, 15);
            this.lblcomp.TabIndex = 17;
            this.lblcomp.Text = "Comacc - Tu impulso en tecnológia";
            // 
            // pbxFormActual
            // 
            this.pbxFormActual.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbxFormActual.ForeColor = System.Drawing.Color.Orange;
            this.pbxFormActual.IconChar = FontAwesome.Sharp.IconChar.User;
            this.pbxFormActual.IconColor = System.Drawing.Color.Orange;
            this.pbxFormActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxFormActual.IconSize = 93;
            this.pbxFormActual.Location = new System.Drawing.Point(72, 47);
            this.pbxFormActual.Name = "pbxFormActual";
            this.pbxFormActual.Size = new System.Drawing.Size(94, 93);
            this.pbxFormActual.TabIndex = 18;
            this.pbxFormActual.TabStop = false;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(12, 160);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(73, 18);
            this.lblSucursal.TabIndex = 19;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // tbxSucursal
            // 
            this.tbxSucursal.Enabled = false;
            this.tbxSucursal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSucursal.Location = new System.Drawing.Point(110, 155);
            this.tbxSucursal.Name = "tbxSucursal";
            this.tbxSucursal.ReadOnly = true;
            this.tbxSucursal.Size = new System.Drawing.Size(120, 27);
            this.tbxSucursal.TabIndex = 21;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.ControlBox = false;
            this.Controls.Add(this.tbxSucursal);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.pbxFormActual);
            this.Controls.Add(this.pnltitulo);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.tbxcontrasena);
            this.Controls.Add(this.cbxusuario);
            this.Controls.Add(this.lblcontrasena);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblcomp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnltitulo.ResumeLayout(false);
            this.pnltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormActual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox tbxcontrasena;
        private System.Windows.Forms.ComboBox cbxusuario;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcomp;
        private FontAwesome.Sharp.IconPictureBox pbxFormActual;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox tbxSucursal;
    }
}