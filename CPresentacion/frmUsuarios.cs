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
    public partial class frmUsuarios : Form
    {
        private bool EsNuevo = false;               // validará si el usuario es nuevo
        private bool EsEditar = false;              // validará si el usuario se editará
        private string resultadoSQL = "";                   // mostrará los resultados de los CRUD
        private int validatbxvacios;                        // validará si hay campos vacios
        private string contrasenaactual = "";               // servirá para validar si se actualizará la contraseña

        private int ConexionLoc = 1;
        private int ConexionExt = 2;

        public frmUsuarios()
        {
            InitializeComponent();

            this.ttpMensaje.SetToolTip(this.tbxBuscar, "Ingrese el nombre a buscar");
            this.ttpMensaje.SetToolTip(this.tbxNombre, "Ingrese el nombre del usuario");
            this.ttpMensaje.SetToolTip(this.tbxUsuario, "Ingrese el usuario");
            this.ttpMensaje.SetToolTip(this.tbxContrasena, "Ingrese la contraseña");
            this.ttpMensaje.SetToolTip(this.cbxTipo, "Seleccione el tipo de usuario");
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            HabilitarTbx(false);
            HabilitarBtn();
            cbxTipo.SelectedIndex = 0;
        }

        /* ---------- Evento de los botones ---------- */

        // Nuevo usuario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EsNuevo = true;
            EsEditar = false;
            HabilitarBtn();
            LimpiarTbx();
            HabilitarTbx(true);
            tbxNombre.Focus();
        }

        // Modificar usuario
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.tbxFolio.Text.Equals(""))
            {
                this.EsEditar = true;
                this.HabilitarBtn();
                this.HabilitarTbx(true);
            }
            else { this.MensajeError("Debe seleccionar el usuario a modificar"); }
        }

        // Eliminar los usuarios marcados
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea eliminar los usuarios marcados?", "SiiAsistencias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {                        
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            resultadoSQL = "";
                            resultadoSQL = NUsuarios.NEliminarUsuarios(Convert.ToInt32(row.Cells["idusuario"]), ConexionLoc);

                            if (resultadoSQL.Equals("ok")) this.MensajeOK("Usuario eliminado correctamente");
                            else this.MensajeError(resultadoSQL);
                        }
                    }
                    MostrarUsuarios();
                    ckbEliminar.Checked = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }

        // Imprimir los usuarios
        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        // Guardar usuario nuevo o usuario modificado
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaCamposVacios();
                if (validatbxvacios >= 0) MensajeError("Faltan ingresar algunos datos, serán remarcados");
                else
                {
                    if(cbxTipo.SelectedIndex == 0)
                    { MensajeError("Seleccione un tipo de usuario correcto"); eprError.SetError(cbxTipo, "Seleccione otro tipo"); }
                    else
                    {
                        resultadoSQL = "";

                        if (this.EsNuevo == true)
                        {                            
                            resultadoSQL = NUsuarios.NAgregarUsuarios(this.tbxNombre.Text.Trim().ToUpper(),
                                                                      this.tbxUsuario.Text.Trim().ToUpper(),
                                                                      this.tbxContrasena.Text.Trim(),
                                                                      this.cbxTipo.Text.Trim().ToUpper(),
                                                                      ConexionLoc);
                        }
                        else
                        {
                            bool opcioncambiaclave = false;
                            if (contrasenaactual != tbxContrasena.Text) opcioncambiaclave = true;

                            resultadoSQL = NUsuarios.NEditarUsuarios(Convert.ToInt32(tbxFolio.Text),
                                                                  this.tbxNombre.Text.Trim().ToUpper(),
                                                                  this.tbxUsuario.Text.Trim().ToUpper(),
                                                                  this.tbxContrasena.Text.Trim(),
                                                                  this.cbxTipo.Text.Trim().ToUpper(),
                                                                  opcioncambiaclave,
                                                                  ConexionLoc);
                        }

                        if (resultadoSQL.Equals("ok"))
                        {
                            if (this.EsNuevo == true) this.MensajeOK("Se ingreso correctamente el registro");
                            else this.MensajeOK("Se modifico correctamente el registro");
                        }
                        else this.MensajeError(resultadoSQL);

                        EsNuevo = false;
                        EsEditar = false;
                        HabilitarBtn();
                        LimpiarTbx();
                        MostrarUsuarios();
                    }                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
            cbxTipo.SelectedIndex = 0;
            this.dgvUsuarios.Focus();
        }

        // Cancelar el proceso de guardado
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.EsEditar = false;
            this.EsNuevo = false;
            this.HabilitarBtn();
            this.HabilitarTbx(false);
            this.LimpiarTbx();
            this.cbxTipo.SelectedIndex = 0;
            this.dgvUsuarios.Focus();
        }


        /* ---------- Otros eventos ---------- */

        // Doble click sobre el datagrid
        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios != null)
            {
                btnCancelar.PerformClick();     // llamamos el evento cancelar                

                this.tbxFolio.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["idusuario"].Value);
                this.tbxNombre.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["nombre"].Value);
                this.tbxUsuario.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["usuario"].Value);
                this.tbxContrasena.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["clave"].Value);
                this.cbxTipo.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["tipo"].Value);

                contrasenaactual = tbxContrasena.Text; // asigamos la contraseña a la variable
            }
        }

        // CheckBox que habilita la columna para marcar los registros a eliminar. 
        private void ckbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEliminar.Checked)
            {
                this.dgvUsuarios.Columns[0].Visible = true;
                LimpiarTbx();
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnImprimir.Enabled = false;
            }
            else
            {
                this.dgvUsuarios.Columns[0].Visible = false;
                HabilitarBtn();
            }
        }

        // Evento que permite dar click sobre la columna de eliminar y marcar estos registros.
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsuarios.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvUsuarios.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        // Buscar el el datagrid
        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            if(tbxBuscar.Text.Length >= 4)
            {
                FiltrarDatosDatagridview(dgvUsuarios, "usuario", tbxBuscar);
            }

        }

        private void FiltrarDatosDatagridview(DataGridView datagrid, string nombre_columna, TextBox txt_buscar)
        {
            string cadena = txt_buscar.Text.Trim().Replace("*", "");
            string filtro = string.Format("convert([{0}], System.String) LIKE '{1}%'", nombre_columna, cadena);
            (datagrid.DataSource as DataTable).DefaultView.RowFilter = filtro;
        }


        /* ---------- Métodos y funciones ---------- */

        // Mostrar usuarios
        private void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = NUsuarios.NMostrarUsuarios(1, "", ConexionLoc);
            if (dgvUsuarios != null)
            {
                OcultarColumnas();
                lblRegistros.Text = "No. de registros " + Convert.ToString(dgvUsuarios.Rows.Count);
            }
            
        }
        // Metodo para ocultar columnas
        private void OcultarColumnas()
        {
            dgvUsuarios.Columns["Eliminar"].Visible = false;
            dgvUsuarios.Columns["idsociedad"].Visible = false;
            dgvUsuarios.Columns["idusuario"].Visible = false;
            dgvUsuarios.Columns["nombre"].Visible = false;
            dgvUsuarios.Columns["clave"].Visible = false;
        }

        // Habilitar los textbox
        private void HabilitarTbx(bool valor)
        {
            tbxNombre.ReadOnly = !valor;
            tbxUsuario.ReadOnly = !valor;
            tbxContrasena.ReadOnly = !valor;
            cbxTipo.Enabled = valor;
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

        // Limpiar los textbox
        private void LimpiarTbx()
        {
            tbxBuscar.Text = string.Empty;
            tbxFolio.Text = string.Empty;
            tbxNombre.Text = string.Empty;
            tbxUsuario.Text = string.Empty;
            tbxContrasena.Text = string.Empty;
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

        // Validará los campos vacios al guardar o editar
        private void ValidaCamposVacios()
        {
            eprError.Clear();
            validatbxvacios = 0;
            if (this.tbxNombre.Text == string.Empty)
            { eprError.SetError(tbxNombre, "Ingrese el nombre de usuario"); validatbxvacios++; }

            if (this.tbxUsuario.Text == string.Empty)
            { eprError.SetError(tbxUsuario, "Ingrese el usuario"); validatbxvacios++; }

            if (this.tbxContrasena.Text == string.Empty)
            { eprError.SetError(tbxContrasena, "ingrese la contraseña"); validatbxvacios++; }

            if (this.cbxTipo.Text == string.Empty)
            { eprError.SetError(cbxTipo, "Seleccione el tipo de usuario"); validatbxvacios++; }

            else { validatbxvacios--; }
        }

        
    }
}
