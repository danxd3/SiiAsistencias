using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using CNegocio;
using System.Reflection;

namespace CPresentacion
{
    public partial class frmPrincipal : Form
    {
        // Variable y elementos publicos
        public DataTable dtUserLogeado = new DataTable();
        public string sucursalactual;
        public int idsucursalactual;

        // Variables para el formulario
        private int ConexionLoc = 1;
        private int ConexionExt = 2;
        private int OpcionSql = 0;

        
        // Para manipular el diseño del formulario
        private IconButton currentbtn;
        private Panel leftborderbtn;
        private Form currentForm;

        // Librerias para poder mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmPrincipal()
        {
            InitializeComponent();
            leftborderbtn = new Panel();
            leftborderbtn.Size = new Size(7, 50);
            pnlVertical.Controls.Add(leftborderbtn);
            CustomizeDesing();

            // Llenamos el dt que permitirá saber en sucursal estamos.
            OpcionSql = 4;
            DataTable dt = NSucursales.NMostrarSucursales(OpcionSql, 1, ConexionLoc);

            if(dt.Rows.Count != 0)
            {
                sucursalactual = dt.Rows[0]["sucursal"].ToString();
                lbFormActual.Text = sucursalactual + " - INICIO";
                idsucursalactual = Convert.ToInt32(dt.Rows[0]["idsucursal"]);
            }

            //Formulario bordes
            this.Text = null;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tbxUser.Text  = dtUserLogeado.Rows[0]["nombre"].ToString();
            if(dtUserLogeado.Rows[0]["tipo"].ToString() == "CHECADOR") { btnChecador.PerformClick(); }
            if (dtUserLogeado.Rows[0]["tipo"].ToString() == "ADMINISTRADOR" || dtUserLogeado.Rows[0]["tipo"].ToString() == "SUPERVISOR")
            {
                //pbxIconUser_Click(null, null);
            }
        }

        /* ---------- Evento de los botones ---------- */
        
        // Cerrar la aplicacion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult validasalida = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo);
            if (validasalida == DialogResult.Yes)
            {
                string resultado;
                resultado = NConexion.NConexionExt(string.Empty,
                                                   string.Empty,
                                                   string.Empty,
                                                   string.Empty,
                                                   string.Empty);
                this.Controls.Clear();
                Application.Exit();
            }
                
        }
        // Maximizar la aplicacion
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }
        // Restaurar la aplicacion
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        // Minimizar la aplicacion
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /* ---------- Menú vertical ---------- */

        // Inicio pantalla principal
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            DesactivarBoton();
            leftborderbtn.Visible = false;
            pbxFormActual.IconChar = IconChar.Home;
            pbxFormActual.IconColor = Color.Fuchsia;
            lbFormActual.Text = "Inicio";
        }
        // Checador, registro de asistencias
        private void btnRegistros_Click(object sender, EventArgs e)
        {
            if(dtUserLogeado.Rows[0]["tipo"].ToString() == "CHECADOR" || dtUserLogeado.Rows[0]["tipo"].ToString() == "ADMINISTRADOR")
            {
                ActivarBoton(1, sender, Color.FromArgb(202, 81, 0));
                AbrirFormulario(new frmAsistencias());
                HideSubmenu();
            }
            else { MensajeError("No tienes permiso para esta opcion"); }            
        }
        // Empleados
        private void btnempleados_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() != "CHECADOR")
            {
                ActivarBoton(1, sender, Color.FromArgb(202, 81, 0));
                AbrirFormulario(new frmEmpleados(dtUserLogeado));                
                HideSubmenu();
            }
            else { MensajeError("No tienes permiso para esta opcion"); }

        }
        // Departamentos
        private void btndepto_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() != "CHECADOR")
            {
                ActivarBoton(1, sender, Color.FromArgb(202, 81, 0));
                AbrirFormulario(new frmDeptos());
                HideSubmenu();
            }
            else { MensajeError("No tienes permiso para esta opcion"); }

        }
        // Horarios
        private void btnhorarios_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() != "CHECADOR")
            {
                ActivarBoton(1, sender, Color.FromArgb(202, 81, 0));
                AbrirFormulario(new frmHorarios());
                HideSubmenu();
            }                
            else { MensajeError("No tienes permiso para esta opcion"); }
        }
        // Registros, reportes
        private void btnregistros_Click_1(object sender, EventArgs e)
        {
            ActivarBoton(1, sender, Color.FromArgb(202, 81, 0));
            ShowSubmenu(pnlSubmenuRegistros);
        }
        private void btnEntradaSalida_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() != "CHECADOR")
            {
                ActivarBoton(0, sender, Color.FromArgb(202, 81, 0));
                AbrirFormulario(new frmEntradaSalida(dtUserLogeado));
                HideSubmenu();                
            }
            else { MensajeError("No tienes permiso para esta opcion"); }            
        }

        private void btnVisitas_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() != "CHECADOR")
            {
                ActivarBoton(0, sender, Color.FromArgb(202, 81, 0));
                //AbrirFormulario(new frmRegistros());
                HideSubmenu();
            }
            else { MensajeError("No tienes permiso para esta opcion"); }            
        }

        private void btnCalculoAsistencias_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() != "CHECADOR")
            {
                ActivarBoton(0, sender, Color.FromArgb(202, 81, 0));
                AbrirFormulario(new frmRegistros(dtUserLogeado));
                HideSubmenu();
            }
            else { MensajeError("No tienes permiso para esta opcion"); }            
        }

        // Configuración
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            ActivarBoton(1, sender, Color.FromArgb(202, 81, 0));
            ShowSubmenu(pnlSubmenuConfig);
        }
        // Sucursales
        private void btnSucursales_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() == "ADMINISTRADOR")
            {
                ActivarBoton(0, sender, Color.FromArgb(202, 81, 0));
                AbrirFormulario(new frmSucursales());
                HideSubmenu();
            }
            else { MensajeError("No tienes permiso para esta opcion"); }

        }
        // Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() == "ADMINISTRADOR")
            {
                ActivarBoton(0, sender, Color.FromArgb(202, 81, 0));
                AbrirFormulario(new frmUsuarios());
                HideSubmenu();
            }
            else { MensajeError("No tienes permiso para esta opcion"); }            
        }

        //Reportes
        private void btReporte_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() != "CHECADOR")
            {
                ActivarBoton(1, sender, Color.FromArgb(202, 81, 0));
                AbrirFormulario(new frmReportes(dtUserLogeado));
                HideSubmenu();
            }
            else { MensajeError("No tienes permiso para esta opcion"); }
        }

        /* ---------- Otros eventos ---------- */

        // Moverventana con la barra de titulo
        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /* ---------- Métodos ---------- */

        // Activar los botones verticales
        private void ActivarBoton(int i, object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                //Boton
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(37, 36, 81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                //icono
                pbxFormActual.IconChar = currentbtn.IconChar;
                pbxFormActual.IconColor = color;
                //Etiqueta titulo
                lbFormActual.Text = sucursalactual + " - "+ currentbtn.Text.ToUpper();
                
                if (i == 1)
                {
                    //Panel
                    leftborderbtn.BackColor = color;
                    leftborderbtn.Location = new Point(0, currentbtn.Location.Y);
                    leftborderbtn.Visible = true;
                    leftborderbtn.BringToFront();                    
                }            
            }
        }

        // Desactivar los botones verticales
        private void DesactivarBoton()
        {
            if (currentbtn != null)
            {
                //Boton
                currentbtn.BackColor = Color.FromArgb(32, 32, 72);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        // Abrir los formularios en el panel
        private void AbrirFormulario(Form FormHijo)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = FormHijo;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(FormHijo);
            pnlContenedor.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        // Definicion inicial del los paneles
        private void CustomizeDesing()
        {
            pnlSubmenuConfig.Visible = false;
            pnlSubmenuRegistros.Visible = false;
        }

        //Ocultar submenu
        private void HideSubmenu()
        {
            if (pnlSubmenuConfig.Visible == true)
                pnlSubmenuConfig.Visible = false;
            if (pnlSubmenuRegistros.Visible == true)
                pnlSubmenuRegistros.Visible = false;
        }

        //Mostrar submenu
        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        

        public string versionactual = "";
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

            //versionactual = "versión: " + fvi.FileVersion;            

            //if (Actualizaciones.check())
            //{
            //    var d = new update();
            //    this.Close();
            //    d.ShowDialog();
            //    d.Dispose();
            //}

            //update actualizador = new update();
            //actualizador.Show();


        }

        public string VersionLabel
        {
            get
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    return string.Format("Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    return string.Format("Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
                }
            }
        }
        // Mostrar mensaje de de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Metodo para mostrar mensaje de confirmacion
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            ActivarBoton(0, sender, Color.FromArgb(202, 81, 0));
            //AbrirFormulario(new frmUsuarios());
            HideSubmenu();
        }

        private void pbxIconUser_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() == "ADMINISTRADOR" || dtUserLogeado.Rows[0]["tipo"].ToString() == "SUPERVISOR")
            {
                DesactivarBoton();
                leftborderbtn.Visible = false;
                //AbrirFormulario(new frmDashboard());
                HideSubmenu();
            }
            else { MensajeError("No tienes permiso para esta opcion"); }
        }

        private void btSubAreas_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() != "CHECADOR")
            {
                ActivarBoton(1, sender, Color.FromArgb(202, 81, 0));
                AbrirFormulario(new frmSubAreas(dtUserLogeado));
                HideSubmenu();
            }
            else { MensajeError("No tienes permiso para esta opcion"); }
        }
    }
}
