using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;

namespace CPresentacion
{
    public partial class frmSucursales : Form
    {
        private bool EsNuevo = false;                           // si es nuevo el registro
        private bool EsEditar = false;                          // si se editará el registro
        private int varvalidacampos = 0;                        // variable para validar los campos obligatorios
        private string passactual = string.Empty;               // contraseña actual
        private int ConexionLoc = 1;                            // conexion servidor local
        private int ConexionExt = 2;                            // conexion servidor externo
        private string resultadoSQL = "";                       // resultado de las consultas sql
        
        public frmSucursales()
        {
            InitializeComponent();
            this.ttpMensaje.SetToolTip(this.tbxBuscar, "Ingrese la sucursal a buscar");
            this.ttpMensaje.SetToolTip(this.tbxSucursal, "Nombre de la sucursal");
            this.ttpMensaje.SetToolTip(this.tbxHost, "Dirección del host");
            this.ttpMensaje.SetToolTip(this.tbxDatabase, "Nombre de la Base de Datos");
            this.ttpMensaje.SetToolTip(this.tbxUser, "Usuario mysql");
            this.ttpMensaje.SetToolTip(this.tbxPass, "Contraseña del usuario");
            this.ttpMensaje.SetToolTip(this.tbxPort, "Puerto de conexión");
            this.ttpMensaje.SetToolTip(this.ckbActual, "Marque si esta es la sucursal principal");
            this.ttpMensaje.SetToolTip(this.ckbActivo, "Marque si la sucursal esta activa");
            this.ttpMensaje.SetToolTip(this.ckbNube, "Marque si esta sucursal es la nube");
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            MostrarSucursales();
            HabilitarTbx(false);
            HabilitarBtn();
        }

        /* ---------- EVENTOS DE LOS BOTONES ---------- */

        // Nueva sucursal
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EsNuevo = true;
            EsEditar = false;
            HabilitarBtn();
            LimpiarTbx();
            HabilitarTbx(true);
            tbxSucursal.Focus();            
            this.tbcArticulos.SelectedIndex = 1;
        }

        // Modificar sucursales
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.tbxFolio.Text.Equals(""))
            {
                this.EsEditar = true;
                this.HabilitarBtn();
                this.HabilitarTbx(true);
            }
            else { this.MensajeError("Selecciona la sucursal a modificar"); }
        }

        // Eliminar sucursales
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea eliminar las sucursales?", "Sistema de asistencias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgwArticulos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            resultadoSQL = "";
                            resultadoSQL = NSucursales.NEliminarSucursales(Convert.ToInt32(row.Cells["idsucursal"].Value), ConexionLoc);

                            if (resultadoSQL.Equals("ok")) this.MensajeOK("Sucursal eliminado correctamente");
                            else this.MensajeError(resultadoSQL);
                        }
                    }
                    MostrarSucursales();
                    cbxEliminar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // Imprimir sucursales
        private void btnImprimir_Click(object sender, EventArgs e)
        {
        }

        // Buscar sucursales
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscarxnombre();
        }

        // Guardar 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                resultadoSQL = "";
                int actual = 0;                
                int activo = 0;
                int nube = 0;
                int opcionCambiaPass = 0;

                if (ckbActual.Checked == true) actual = 1;      // si es la sucursal actual
                if (ckbNube.Checked == true) nube = 1;          // si la sucursal es la nube
                if (ckbActivo.Checked == true) activo = 1;      // si esta activa la sucursal

                ValidaCamposObligatorios();

                if (varvalidacampos >= 0) MensajeError("Faltan ingresar algunos datos, serán remarcados");
                else
                {
                    if (this.EsNuevo == true)
                    {
                        resultadoSQL = NSucursales.NAgregarSucursales(this.tbxSucursal.Text.Trim().ToUpper(),
                                                                   this.tbxHost.Text.Trim(),
                                                                   this.tbxDatabase.Text.Trim(),
                                                                   this.tbxUser.Text.Trim(),
                                                                   this.tbxPass.Text.Trim(),
                                                                   Convert.ToInt32(this.tbxPort.Text.Trim()),
                                                                   actual,
                                                                   activo,
                                                                   nube,
                                                                   ConexionLoc);
                    }
                    else
                    {
                        if (passactual == tbxPass.Text) opcionCambiaPass = 1;
                        else opcionCambiaPass = 2;

                        resultadoSQL = NSucursales.NEditarSucursales(Convert.ToInt32(this.tbxFolio.Text),
                                                                this.tbxSucursal.Text.Trim().ToUpper(),
                                                                this.tbxHost.Text.Trim(),
                                                                this.tbxDatabase.Text.Trim(),
                                                                this.tbxUser.Text.Trim(),
                                                                this.tbxPass.Text.Trim(),
                                                                Convert.ToInt32(this.tbxPort.Text.Trim()),
                                                                actual,
                                                                activo,
                                                                nube,
                                                                opcionCambiaPass,
                                                                ConexionLoc);
                    }
                    
                    if (resultadoSQL.Equals("ok"))
                    {
                        if (this.EsNuevo == true) this.MensajeOK("Se agrego correctamente la sucursal"); 
                        else this.MensajeOK("Se modifico correctamente la sucursal");
                    }
                    else this.MensajeError(resultadoSQL);

                    EsNuevo = false;
                    EsEditar = false;
                    HabilitarBtn();
                    LimpiarTbx();
                    MostrarSucursales();
                    this.tbcArticulos.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.EsEditar = false;
            this.EsNuevo = false;
            this.HabilitarBtn();
            this.HabilitarTbx(false);
            this.LimpiarTbx();
            this.eprError.Clear();
            this.tbcArticulos.SelectedIndex = 0;
        }
        
        /* ---------- OTROS EVENTOS ---------- */

        // Evento que permite dar doble click sobre un registro y mostrar los datos en los textbox.
        private void dgwArticulos_DoubleClick(object sender, EventArgs e)
        {
            this.tbxFolio.Text = Convert.ToString(this.dgwArticulos.CurrentRow.Cells["idsucursal"].Value);
            this.tbxSucursal.Text = Convert.ToString(this.dgwArticulos.CurrentRow.Cells["sucursal"].Value);
            this.tbxHost.Text = Convert.ToString(this.dgwArticulos.CurrentRow.Cells["dirhost"].Value);
            this.tbxDatabase.Text = Convert.ToString(this.dgwArticulos.CurrentRow.Cells["basedatos"].Value);
            this.tbxUser.Text = Convert.ToString(this.dgwArticulos.CurrentRow.Cells["usuario"].Value);
            this.tbxPass.Text = Convert.ToString(this.dgwArticulos.CurrentRow.Cells["contrasena"].Value);
            this.tbxPort.Text = Convert.ToString(this.dgwArticulos.CurrentRow.Cells["puerto"].Value);
            this.ckbActual.Checked = Convert.ToInt32(this.dgwArticulos.CurrentRow.Cells["actual"].Value) == 1 ? true : false;
            this.ckbNube.Checked = Convert.ToInt32(this.dgwArticulos.CurrentRow.Cells["nube"].Value) == 1 ? true : false;
            this.ckbActivo.Checked = Convert.ToInt32(this.dgwArticulos.CurrentRow.Cells["activo"].Value) == 1 ? true : false;

            passactual = tbxPass.Text;
            this.tbcArticulos.SelectedIndex = 1;
        }

        // CheckBox que habilita la columna para marcar los registros a eliminar. 
        private void cbxEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEliminar.Checked)
            {
                this.dgwArticulos.Columns[0].Visible = true;
                LimpiarTbx();
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnImprimir.Enabled = false;
            }
            else
            {
                this.dgwArticulos.Columns[0].Visible = false;
                HabilitarBtn();
            }
        }

        // Evento que permite dar click sobre la columna de eliminar y marcar estos registros.
        private void dgwArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwArticulos.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgwArticulos.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        // Textbox buscar
        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscarxnombre();
        }

        /* ---------- MÉTODOS Y FUNCIONES ---------- */

        // Mensaje de OK
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SiAsistencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Limpiar los textbox
        private void LimpiarTbx()
        {
            tbxBuscar.Text = string.Empty;
            tbxFolio.Text = string.Empty;
            tbxSucursal.Text = string.Empty;
            tbxHost.Text = string.Empty;
            tbxDatabase.Text = string.Empty;
            tbxUser.Text = string.Empty;
            tbxPass.Text = string.Empty;
            tbxPort.Text = string.Empty;
            ckbActual.Checked = false;
            ckbActivo.Checked = false;
            ckbNube.Checked = false;
        }

        // Habilitar los textbox
        private void HabilitarTbx(bool valor)
        {
            tbxHost.ReadOnly = !valor;
            tbxDatabase.ReadOnly = !valor;
            tbxSucursal.ReadOnly = !valor;
            tbxPass.ReadOnly = !valor;
            tbxPort.ReadOnly = !valor;
            tbxUser.ReadOnly = !valor;
        }

        // Habilitar los botones
        private void HabilitarBtn()
        {
            if (this.EsNuevo || this.EsEditar)
            {
                HabilitarTbx(true);
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                HabilitarTbx(false);
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        // Ocultar columnas
        private void OcultarColumnas()
        {
            dgwArticulos.Columns["idsucursal"].Visible = false;
            dgwArticulos.Columns["idsociedad"].Visible = false;
            dgwArticulos.Columns["Eliminar"].Visible = false;
        }

        // Mostrar las sucursales
        private void MostrarSucursales()
        {
            try
            {
                dgwArticulos.DataSource = NSucursales.NMostrarSucursales(1, 1, ConexionLoc);
                if (dgwArticulos.DataSource != null)
                {
                    OcultarColumnas();
                    lblRegistros.Text = "No. de sucursales: " + Convert.ToString(dgwArticulos.Rows.Count);
                    ColorFila(dgwArticulos);
                    dgwArticulos.ClearSelection();
                }                
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }

        // Metodo para Buscar por nombre
        private void Buscarxnombre()
        {
            //dgwArticulos.DataSource = NArticulos.BuscarNombre(tbxBuscar.Text);
            OcultarColumnas();
            lblRegistros.Text = "No. de registros " + Convert.ToString(dgwArticulos.Rows.Count);
        }

        // Validar campos obligatorios ingresados
        private int ValidaCamposObligatorios()
        {
            eprError.Clear();
            varvalidacampos = 0;

            if (this.tbxSucursal.Text == string.Empty)
            { eprError.SetError(tbxSucursal, "Ingrese el nombre de sucursal"); varvalidacampos++; }

            if (this.tbxHost.Text == string.Empty)
            { eprError.SetError(tbxHost, "Ingrese la dirección del host"); varvalidacampos++; }

            if (this.tbxDatabase.Text == string.Empty)
            { eprError.SetError(tbxDatabase, "Ingrese el nombre de la base de datos"); varvalidacampos++; }

            if (this.tbxUser.Text == string.Empty)
            { eprError.SetError(tbxUser, "Ingrese el nombre de usuario"); varvalidacampos++; }

            if (this.tbxPass.Text == string.Empty)
            { eprError.SetError(tbxPass, "Ingrese la contraseña del usuario"); varvalidacampos++; }

            if (this.tbxPort.Text == string.Empty)
            { eprError.SetError(tbxPort, "Ingrese el puerto de conexión"); varvalidacampos++; }

            else { varvalidacampos--; }

            return varvalidacampos;
        }

        public void ColorFila(DataGridView pDataGrid)
        {
            pDataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
            pDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
    }
}
