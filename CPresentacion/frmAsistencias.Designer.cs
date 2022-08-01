namespace CPresentacion
{
    partial class frmAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistencias));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxES = new System.Windows.Forms.GroupBox();
            this.rbnSalidaVisita = new System.Windows.Forms.RadioButton();
            this.rbnEntradaVisita = new System.Windows.Forms.RadioButton();
            this.btnES = new FontAwesome.Sharp.IconButton();
            this.rbnSalida = new System.Windows.Forms.RadioButton();
            this.rbnEntrada = new System.Windows.Forms.RadioButton();
            this.ttpMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMensaje = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxES.SuspendLayout();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Visible = false;
            // 
            // Prompt
            // 
            this.Prompt.Text = "Escanea tu misma huella otra vez";
            this.Prompt.Visible = false;
            // 
            // StatusText
            // 
            this.StatusText.Text = resources.GetString("StatusText.Text");
            this.StatusText.Visible = false;
            // 
            // StatusLine
            // 
            this.StatusLine.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(737, 506);
            this.CloseButton.Visible = false;
            // 
            // PromptLabel
            // 
            this.PromptLabel.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CPresentacion.Properties.Resources.colocahuella;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbxES
            // 
            this.gbxES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxES.Controls.Add(this.rbnSalidaVisita);
            this.gbxES.Controls.Add(this.rbnEntradaVisita);
            this.gbxES.Controls.Add(this.btnES);
            this.gbxES.Controls.Add(this.rbnSalida);
            this.gbxES.Controls.Add(this.rbnEntrada);
            this.gbxES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxES.Location = new System.Drawing.Point(682, 414);
            this.gbxES.Name = "gbxES";
            this.gbxES.Size = new System.Drawing.Size(130, 115);
            this.gbxES.TabIndex = 8;
            this.gbxES.TabStop = false;
            this.gbxES.Text = "Tipo de registros";
            // 
            // rbnSalidaVisita
            // 
            this.rbnSalidaVisita.AutoSize = true;
            this.rbnSalidaVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSalidaVisita.Location = new System.Drawing.Point(5, 80);
            this.rbnSalidaVisita.Name = "rbnSalidaVisita";
            this.rbnSalidaVisita.Size = new System.Drawing.Size(98, 20);
            this.rbnSalidaVisita.TabIndex = 6;
            this.rbnSalidaVisita.TabStop = true;
            this.rbnSalidaVisita.Text = "Salida visita";
            this.rbnSalidaVisita.UseVisualStyleBackColor = true;
            // 
            // rbnEntradaVisita
            // 
            this.rbnEntradaVisita.AutoSize = true;
            this.rbnEntradaVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEntradaVisita.Location = new System.Drawing.Point(5, 60);
            this.rbnEntradaVisita.Name = "rbnEntradaVisita";
            this.rbnEntradaVisita.Size = new System.Drawing.Size(106, 20);
            this.rbnEntradaVisita.TabIndex = 5;
            this.rbnEntradaVisita.TabStop = true;
            this.rbnEntradaVisita.Text = "Entrada visita";
            this.rbnEntradaVisita.UseVisualStyleBackColor = true;
            // 
            // btnES
            // 
            this.btnES.FlatAppearance.BorderSize = 0;
            this.btnES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnES.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnES.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnES.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(129)))), ((int)(((byte)(33)))));
            this.btnES.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnES.IconSize = 20;
            this.btnES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnES.Location = new System.Drawing.Point(83, 21);
            this.btnES.Name = "btnES";
            this.btnES.Size = new System.Drawing.Size(25, 25);
            this.btnES.TabIndex = 4;
            this.btnES.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnES.UseVisualStyleBackColor = true;
            this.btnES.Click += new System.EventHandler(this.btnES_Click);
            // 
            // rbnSalida
            // 
            this.rbnSalida.AutoSize = true;
            this.rbnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSalida.Location = new System.Drawing.Point(5, 40);
            this.rbnSalida.Name = "rbnSalida";
            this.rbnSalida.Size = new System.Drawing.Size(64, 20);
            this.rbnSalida.TabIndex = 1;
            this.rbnSalida.TabStop = true;
            this.rbnSalida.Text = "Salida";
            this.rbnSalida.UseVisualStyleBackColor = true;
            // 
            // rbnEntrada
            // 
            this.rbnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnEntrada.AutoSize = true;
            this.rbnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEntrada.Location = new System.Drawing.Point(5, 21);
            this.rbnEntrada.Name = "rbnEntrada";
            this.rbnEntrada.Size = new System.Drawing.Size(72, 20);
            this.rbnEntrada.TabIndex = 0;
            this.rbnEntrada.TabStop = true;
            this.rbnEntrada.Text = "Entrada";
            this.rbnEntrada.UseVisualStyleBackColor = true;
            // 
            // pnlMensaje
            // 
            this.pnlMensaje.Location = new System.Drawing.Point(0, 0);
            this.pnlMensaje.Name = "pnlMensaje";
            this.pnlMensaje.Size = new System.Drawing.Size(800, 400);
            this.pnlMensaje.TabIndex = 9;
            this.pnlMensaje.Visible = false;
            // 
            // frmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 541);
            this.Controls.Add(this.pnlMensaje);
            this.Controls.Add(this.gbxES);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsistencias";
            this.Text = "frmChecador";
            this.Load += new System.EventHandler(this.frmAsistencias_Load);
            this.Controls.SetChildIndex(this.CloseButton, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.gbxES, 0);
            this.Controls.SetChildIndex(this.PromptLabel, 0);
            this.Controls.SetChildIndex(this.StatusLine, 0);
            this.Controls.SetChildIndex(this.StatusLabel, 0);
            this.Controls.SetChildIndex(this.Prompt, 0);
            this.Controls.SetChildIndex(this.StatusText, 0);
            this.Controls.SetChildIndex(this.Picture, 0);
            this.Controls.SetChildIndex(this.pnlMensaje, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxES.ResumeLayout(false);
            this.gbxES.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxES;
        private System.Windows.Forms.RadioButton rbnSalida;
        private System.Windows.Forms.RadioButton rbnEntrada;
        private System.Windows.Forms.ToolTip ttpMensaje;
        private FontAwesome.Sharp.IconButton btnES;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbnSalidaVisita;
        private System.Windows.Forms.RadioButton rbnEntradaVisita;
        private System.Windows.Forms.Panel pnlMensaje;
    }
}