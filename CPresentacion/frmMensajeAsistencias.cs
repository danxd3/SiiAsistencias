using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class frmMensajeAsistencias : Form
    {
        public int entrasale;   // entrada / salida
        public string nombre;   // nombre empleado
        string fechahora;       // fecha hora registro

        public Point puntoinicio;
        frmAsistencias asistencias = new frmAsistencias();

        public frmMensajeAsistencias(int pentrasale, string pnombre, string pfechahora)
        {
            InitializeComponent();
            entrasale = pentrasale;
            nombre = pnombre;
            fechahora = pfechahora;
            timer1.Stop();
        }

        private void frmMensajeAsistencias_Load(object sender, EventArgs e)
        {
            MostrarMensaje();

        }
        public void MostrarMensaje()
        {
            if (entrasale == 1)
            {
                lblEstatus.Text = "ENTRADA";
                lblNombre.Text = nombre;
                lblHorareg.Text = fechahora;
                lblMensaje.Text = "¡EXCELENTE DIA!";
                pbxSun.Visible = true;
            }
            else if (entrasale == 2)
            {
                lblEstatus.Text = "ENTRADA";
                lblNombre.Text = nombre;
                lblHorareg.Text = fechahora;
                lblMensaje.Text = "Entrada en tiempo de tolerancia \n ¡EXCELENTE DIA!";
                pbxSun.Visible = true;
            }
            else if (entrasale == 3)
            {
                lblEstatus.Text = "ENTRADA";
                lblNombre.Text = nombre;
                lblHorareg.Text = fechahora;
                lblMensaje.Text = "TRATA DE LLEGAR MAS TEMPRANO, RETARDO \n ¡EXCELENTE DIA!";
                pbxSun.Visible = true;
            }
            else if (entrasale == 4)
            {
                lblEstatus.Text = "SALIDA";
                lblNombre.Text = nombre;
                lblHorareg.Text = fechahora;
                lblMensaje.Text = "SALIDA ANTICIPADA \n ¡DESCANSA NOS VEMOS MAÑANA!";
                pbxMoon.Visible = true;
            }
            else if (entrasale == 5)
            {
                lblEstatus.Text = "SALIDA";
                lblNombre.Text = nombre;
                lblHorareg.Text = fechahora;
                lblMensaje.Text = "¡DESCANSA NOS VEMOS MAÑANA!";
                pbxMoon.Visible = true;
            }
            else if (entrasale == 6)
            {
                frmPrincipal principal = new frmPrincipal();

                lblEstatus.Text = nombre;
                lblNoencontrado.Text = "BIENVENIDO A LA SUCURSAL: \n" + principal.sucursalactual + "\nENTRADA VISITA";
                lblNoencontrado.Visible = true;
                lblNombre.Visible = false;
                lblHorareg.Visible = false;
                lblMensaje.Visible = false;
                pnlInfo.BackColor = Color.FromArgb(190, 220, 255);
                lblNoencontrado.BackColor = Color.FromArgb(190, 220, 255);
                lblEstatus.BackColor = Color.FromArgb(190, 220, 255);
            }
            else if (entrasale == 7)
            {
                frmPrincipal principal = new frmPrincipal();

                lblEstatus.Text = nombre;
                lblNoencontrado.Text = "SALIDA DE LA SUCURSAL: \n" + principal.sucursalactual + "\nSALIDA VISITA";
                lblNoencontrado.Visible = true;
                lblNombre.Visible = false;
                lblHorareg.Visible = false;
                lblMensaje.Visible = false;
                pnlInfo.BackColor = Color.FromArgb(190, 220, 255);
                lblNoencontrado.BackColor = Color.FromArgb(190, 220, 255);
                lblEstatus.BackColor = Color.FromArgb(190, 220, 255);
            }
            else
            {
                lblNoencontrado.Visible = true;
                lblEstatus.Visible = false;
                lblNombre.Visible = false;
                lblHorareg.Visible = false;
                lblMensaje.Visible = false;
                pnlInfo.BackColor = Color.Red;
                lblNoencontrado.BackColor = Color.Red;

            }
            timer1.Interval = 5000;
            timer1.Start();
            timer1.Tick += (psender, pe) =>
            {
                timer1.Stop();
                this.Close();
            };

        }
    }
}
