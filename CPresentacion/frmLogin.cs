using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;

namespace CPresentacion
{
    public partial class frmLogin : Form
    {
        // Variables que se usarán en el fromulario
        private int ConexionLoc = 1;
        private int ConexionExt = 2;

        // Elementos publicos
        public DataTable dtUser = new DataTable();
        public DataTable dtUserLogeado = new DataTable();
        public DataTable dtSucursalActual = new DataTable();

        private int IdsucursalAct;

        public frmLogin()
        {
            InitializeComponent();
            MostrarSucursal();
            MostrarUsuarios();
        }

        // Botón cancelar (salir de la aplicación).
        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult validasalida = MessageBox.Show("Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (validasalida == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        // Botón para iniciar sesion
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string user = cbxusuario.Text;
            string pass = tbxcontrasena.Text;

            if (user.Trim() == string.Empty || pass.Trim() == string.Empty)
            {
                MessageBox.Show("Favor de ingresar la contraseña", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dtUserLogeado.Clear();
                dtUserLogeado = NUsuarios.Login(user, pass, ConexionLoc);

                if (dtUserLogeado != null)
                {
                    if (dtUserLogeado.Rows.Count >= 1)
                    {
                        // Valida el inicio del sistema
                        Iniciasys();

                        frmPrincipal principal = new frmPrincipal();
                        principal.dtUserLogeado = dtUserLogeado;
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxcontrasena.Clear();
                        tbxcontrasena.Focus();
                    }
                }
                else { MessageBox.Show("No se pudo conectar a la base de datos", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        // Registrar inicio de systema
        private void Iniciasys()
        {
            try
            {
                // obtenemos los registros de inicio del sistema de la fecha actual
                DataTable dtIniciasys = NIniciasys.NMostrarIniciasys(ConexionLoc, 3, IdsucursalAct, DateTime.Today, DateTime.Today.AddDays(+1));

                if (dtIniciasys != null && dtIniciasys.Rows.Count == 0)
                {
                    string resultadosql = NIniciasys.NAgregarIniciasys(ConexionLoc, DateTime.Now, IdsucursalAct);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }

        // Mostrar los usuarios en el combobox
        private void MostrarUsuarios()
        {
            dtUser = NUsuarios.NMostrarUsuarios(1, "", ConexionLoc);
            if(dtUser != null)
            {
                cbxusuario.DataSource = dtUser;
                cbxusuario.ValueMember = "idusuario";
                cbxusuario.DisplayMember = "usuario";
            }
            else
            {
                DialogResult validacon = MessageBox.Show("No se pudo conectar a la base de datos" +
                                "\n\n¿Desea revisar los parametros de conexión?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (validacon == DialogResult.Yes)
                {
                    MessageBox.Show("Abre ventana de configuración");
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        // Mostrar sucursales
        private void MostrarSucursal()
        {            
            dtSucursalActual = NSucursales.NMostrarSucursales(4, 1, ConexionLoc);
            // 4 - Sucursal actual
            // 1 - Sucursal activo

            if (dtSucursalActual != null)
            {
                tbxSucursal.Text = dtSucursalActual.Rows[0]["sucursal"].ToString();
                IdsucursalAct = Convert.ToInt32(dtSucursalActual.Rows[0]["idsucursal"]);
            }
        }

        private void tbxcontrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                btnaceptar_Click(sender, e);//llama al evento click del boton
            }            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (dtSucursalActual == null)
            {
                Application.Exit();
            }

            tbxcontrasena.Focus();
        }
    }
}
