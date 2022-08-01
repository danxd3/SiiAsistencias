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
    public partial class frmDeptos : Form
    {
        private bool EsNuevo = false;       // Registro nuevo
        private bool EsEditar = false;      // Registro modificado
        private int ConexionLoc = 1;        // Conexion local
        private int ConexionExt = 2;        // Conexion externa
        private string resultadoSQL = "";   // Resultado de las consultas

        public frmDeptos()
        {
            InitializeComponent();
            this.ttpMensaje.SetToolTip(this.tbxBuscar, "Ingrese el nombre a buscar");
            this.ttpMensaje.SetToolTip(this.tbxNombre, "Ingrese el nombre del departamento");
            this.ttpMensaje.SetToolTip(this.tbxDescripcion, "Ingrese una descripcion para el departamento");            
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            MostrarDeptos();
            HabilitarTbx(false);
            HabilitarBtn();
            LimpiarTbx();
        }

        /* ---------- EVENTOS ---------- */

        // Nuevo depto
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EsNuevo = true;
            EsEditar = false;
            HabilitarBtn();
            LimpiarTbx();
            HabilitarTbx(true);
            tbxNombre.Focus();

            lblFmodifica.Text = "Fecha de modificación: " + Convert.ToString(DateTime.Now.ToShortDateString());
        }        

        // Modificar depto
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.tbxFolio.Text.Equals(""))
            {
                this.EsEditar = true;
                this.HabilitarBtn();
                this.HabilitarTbx(true);
            }
            else this.MensajeError("Debe seleccionar un registro a modificar");
        }

        // Elimina los deptos marcados
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DialogoOpcion;
                DialogoOpcion = MessageBox.Show("¿Desea eliminar los departamentos marcados?", "SiiAsistencias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(DialogoOpcion == DialogResult.OK)
                {
                    string codigo;
                    resultadoSQL = "";

                    foreach(DataGridViewRow row in dgwCategorias.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            resultadoSQL = NDeptos.NEliminarDeptos(Convert.ToInt32(codigo), ConexionLoc);
                         
                            if (resultadoSQL.Equals("ok")) this.MensajeOK("Departamento eliminado correctamente"); 
                            else this.MensajeError(resultadoSQL); 
                        }
                    }
                    MostrarDeptos();
                    cbxEliminar.Checked = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }

        // Imprime los deptos
        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        // Botón buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscarxnombre();
        }

        // Guardar (guarda un nuevo registro o el registro modificado).        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                resultadoSQL = "";                
                if(this.tbxNombre.Text == string.Empty)
                {
                    MensajeError("Faltan algunos datos por ingresar, serán remarcados");
                    eprError.SetError(tbxNombre, "Ingrese un nombre");
                }
                else
                {
                    if (this.EsNuevo == true)
                    {
                        resultadoSQL = NDeptos.NAgregarDepto(this.tbxNombre.Text.Trim().ToUpper(),
                                                             this.tbxDescripcion.Text.Trim().ToUpper(),
                                                             DateTime.Now,
                                                             ConexionLoc);
                    }
                    else
                    {
                        resultadoSQL = NDeptos.NEditarDeptos(Convert.ToInt32(this.tbxFolio.Text),
                                                             this.tbxNombre.Text.Trim().ToUpper(),
                                                             this.tbxDescripcion.Text.Trim().ToUpper(),
                                                             DateTime.Now,
                                                             ConexionLoc);
                    }

                    if(resultadoSQL.Equals("ok"))
                    {
                        if(this.EsNuevo == true) this.MensajeOK("Departamento agregado correctamente");
                        else this.MensajeOK("Departamento modificado correctamente"); 
                    }
                    else this.MensajeError(resultadoSQL); 

                    EsNuevo = false;
                    EsEditar = false;
                    HabilitarBtn();
                    LimpiarTbx();
                    MostrarDeptos();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }

        // Cancelar (cancela la operacion que se esta realizando).
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.EsEditar = false;
            this.EsNuevo = false;
            this.HabilitarBtn();
            this.HabilitarTbx(false);
            this.LimpiarTbx();
        }

        /* ---------- OTROS EVENTOS ---------- */

        // Doble click sobre el datagrid
        private void dgwCategorias_DoubleClick(object sender, EventArgs e)
        {
            this.tbxFolio.Text = Convert.ToString(this.dgwCategorias.CurrentRow.Cells["iddepto"].Value);
            this.tbxNombre.Text = Convert.ToString(this.dgwCategorias.CurrentRow.Cells["nombre"].Value);
            this.tbxDescripcion.Text = Convert.ToString(this.dgwCategorias.CurrentRow.Cells["descripcion"].Value);

            this.lblFmodifica.Visible = true;
            this.lblFmodifica.Text = "Fecha de modificación: " + (Convert.ToDateTime(this.dgwCategorias.CurrentRow.Cells["fmodifica"].Value)).ToShortDateString();
        }

        // Habilita la columna y poder seleccionar los registros a eliminar
        private void cbxEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEliminar.Checked)
            {
                this.dgwCategorias.Columns[0].Visible = true;
                LimpiarTbx();
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnImprimir.Enabled = false;

            }
            else
            {
                this.dgwCategorias.Columns[0].Visible = false;
                HabilitarBtn();
            }

        }

        // Perimite seleccionar los registros
        private void dgwCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgwCategorias.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgwCategorias.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }

        }

        // Textbox buscar
        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscarxnombre();
        }

        /* ---------- METODOS Y FUNCIONES ---------- */

        // Mensaje de confirmacion
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Limpiar los textbox
        private void LimpiarTbx()
        {
            tbxBuscar.Text = string.Empty;
            tbxDescripcion.Text = string.Empty;
            tbxFolio.Text = string.Empty;
            tbxNombre.Text = string.Empty;
        }

        // Habilitar los textbox
        private void HabilitarTbx(bool valor)
        {
            tbxNombre.ReadOnly = !valor;
            tbxDescripcion.ReadOnly = !valor;
            this.lblFmodifica.Visible = valor;
        }

        // Habilitar los botones
        private void HabilitarBtn()
        {
            if(this.EsNuevo || this.EsEditar)
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
            dgwCategorias.Columns["Eliminar"].Visible = false;
            dgwCategorias.Columns["idsociedad"].Visible = false;
            dgwCategorias.Columns["iddepto"].Visible = false;
            dgwCategorias.Columns["fmodifica"].Visible = false;
        }

        // Mostrar los registros
        private void MostrarDeptos()
        {
            dgwCategorias.DataSource = NDeptos.NMostrarDeptos(ConexionLoc);
            if (dgwCategorias != null)
            {
                OcultarColumnas();
                lblRegistros.Text = "No. de Deptos: " + Convert.ToString(dgwCategorias.Rows.Count);
                ColorFila(dgwCategorias);
                dgwCategorias.ClearSelection();
            }
        }

        public void ColorFila(DataGridView pDataGrid)
        {
            pDataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
            pDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        // Buscar por nombre
        private void Buscarxnombre()
        {
            //dgwCategorias.DataSource = NCategorias.BuscarNombre(tbxBuscar.Text);
            //OcultarColumnas();
            //lblRegistros.Text = "No. de registros " + Convert.ToString(dgwCategorias.Rows.Count);
        }
    }
}