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
    public partial class frmHorarios : Form
    {
        private bool EsNuevo = false;
        private bool EsEditar = false;
        private int ConexionLoc = 1;
        private int ConexionExt = 2;
        private string resultadoSQL = "";

        public frmHorarios()
        {
            InitializeComponent();
            this.ttpMensaje.SetToolTip(this.tbxBuscar, "Ingrese el nombre a buscar");
            this.ttpMensaje.SetToolTip(this.tbxNombre, "Ingrese el nombre del horario");
            this.ttpMensaje.SetToolTip(this.tbxHrentrada, "Ingrese la hora de entrada");
            this.ttpMensaje.SetToolTip(this.tbxNombre, "Ingrese la hora de salida");
            this.ttpMensaje.SetToolTip(this.tbxTolerancia, "Ingrese los minutos de tolerancia");
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            MostrarHorarios();
            HabilitarTbx(false);
            HabilitarBtn();
        }

        /* ---------- EVENTO DE LOS BOTONES ---------- */

        // Nuevo horario
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

        // Modificar horario
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.tbxFolio.Text.Equals(""))
            {
                this.EsEditar = true;
                this.HabilitarBtn();
                this.HabilitarTbx(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar el horario a modificar");
            }
        }

        // Eliminar lod horario marcados
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea eliminar los Horarios marcados?", "SiiAsistencias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    resultadoSQL = "";
                    int idhorario = 0;

                    foreach (DataGridViewRow row in dgwCategorias.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            idhorario = Convert.ToInt32(row.Cells[1].Value);
                            resultadoSQL = NHorarios.NEliminarHorarios(idhorario, ConexionLoc);

                            if (resultadoSQL.Equals("ok")) this.MensajeOK("Se elimino correctamente el Horario");
                            else this.MensajeError(resultadoSQL);
                        }
                    }
                    MostrarHorarios();
                    cbxEliminar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // Imprimir horarios
        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        // Buscar horarios
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscarxnombre();
        }

        // Guardar horarios
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                resultadoSQL = "";
                
                if(this.tbxNombre.Text == string.Empty)
                {
                    MensajeError("Faltan ingresar algunos datos, seran remarcados");
                    eprError.SetError(tbxNombre, "Ingrese el nombre del horario");
                }
                else
                {
                    if (this.EsNuevo == true)
                    {
                        resultadoSQL = NHorarios.NAgregarHorarios(this.tbxNombre.Text.Trim().ToUpper(),
                                                                  this.tbxHrentrada.Text.Trim(),
                                                                  this.tbxHrsalida.Text.Trim(),
                                                                  this.tbxTolerancia.Text.Trim(),
                                                                  DateTime.Now,
                                                                  ConexionLoc);
                    }
                    else
                    {
                        resultadoSQL = NHorarios.NEditarHorarios(Convert.ToInt32(this.tbxFolio.Text),
                                                                 this.tbxNombre.Text.Trim().ToUpper(),
                                                                 this.tbxHrentrada.Text.Trim(),
                                                                 this.tbxHrsalida.Text.Trim(),
                                                                 this.tbxTolerancia.Text.Trim(),
                                                                 DateTime.Now,
                                                                 ConexionLoc);
                    }

                    if(resultadoSQL.Equals("ok"))
                    {
                        if(this.EsNuevo == true) this.MensajeOK("Se agrego correctamente el Horario");
                        else this.MensajeOK("Se modifico correctamente el Horario");
                    }
                    else
                    {
                        this.MensajeError(resultadoSQL);
                    }

                    EsNuevo = false;
                    EsEditar = false;
                    HabilitarBtn();
                    LimpiarTbx();
                    MostrarHorarios();
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
        }


        /* ---------- OTROS EVENTO ---------- */

        // Evento que permite dar doble click sobre un registro y mostrar los datos en los textbox.
        private void dgwCategorias_DoubleClick(object sender, EventArgs e)
        {
            this.tbxFolio.Text = Convert.ToString(this.dgwCategorias.CurrentRow.Cells["idhorario"].Value);
            this.tbxNombre.Text = Convert.ToString(this.dgwCategorias.CurrentRow.Cells["nombre"].Value);
            this.tbxHrentrada.Text = Convert.ToString(this.dgwCategorias.CurrentRow.Cells["hrentrada"].Value);
            this.tbxHrsalida.Text = Convert.ToString(this.dgwCategorias.CurrentRow.Cells["hrsalida"].Value);
            this.tbxTolerancia.Text = Convert.ToString(this.dgwCategorias.CurrentRow.Cells["tolerancia"].Value);

            this.lblFmodifica.Visible = true;
            this.lblFmodifica.Text = "Fecha de modificación: " + (Convert.ToDateTime(this.dgwCategorias.CurrentRow.Cells["fmodifica"].Value)).ToShortDateString();
        }

        // CheckBox que habilita la columna para marcar los registros a eliminar. 
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

        // Evento que permite dar click sobre la columna de eliminar y marcar estos registros.
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


        // Metodo para mostrar mensaje de confirmacion
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Metodo para mostrar mensaje de de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Metodo para limpiar los textbox
        private void LimpiarTbx()
        {
            tbxBuscar.Text = string.Empty;
            tbxFolio.Text = string.Empty;
            tbxNombre.Text = string.Empty;
            tbxHrentrada.Text = string.Empty;
            tbxHrsalida.Text = string.Empty;
            tbxTolerancia.Text = string.Empty;
        }

        // Metodo para habilitar los textbox
        private void HabilitarTbx(bool valor)
        {
            tbxNombre.ReadOnly = !valor;
            tbxHrentrada.ReadOnly = !valor;
            tbxHrsalida.ReadOnly = !valor;
            tbxTolerancia.ReadOnly = !valor;
            this.lblFmodifica.Visible = valor;
        }

        // Metodo para habilitar los botones
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

        // Metodo para ocultar columnas
        private void OcultarColumnas()
        {
            dgwCategorias.Columns["Eliminar"].Visible = false;
            dgwCategorias.Columns["idhorario"].Visible = false;
            dgwCategorias.Columns["idsociedad"].Visible = false;
            dgwCategorias.Columns["fmodifica"].Visible = false;
            dgwCategorias.Columns["detalle"].Visible = false;
        }

        // Metodo para mostrar los registros
        private void MostrarHorarios()
        {
            dgwCategorias.DataSource = NHorarios.NMostrarHorarios(ConexionLoc);
            if (dgwCategorias != null)
            {
                OcultarColumnas();
                lblRegistros.Text = "No. de Horarios: " + dgwCategorias.Rows.Count.ToString();
                ColorFila(dgwCategorias);
                dgwCategorias.ClearSelection();
            }
                
        }

        public void ColorFila(DataGridView pDataGrid)
        {
            pDataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
            pDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        // Metodo para Buscar por nombre
        private void Buscarxnombre()
        {
            //dgwCategorias.DataSource = NCategorias.BuscarNombre(tbxBuscar.Text);
            //OcultarColumnas();
            //lblRegistros.Text = "No. de registros " + Convert.ToString(dgwCategorias.Rows.Count);
        }        
    }
}