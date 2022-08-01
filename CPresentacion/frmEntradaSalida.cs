using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;
using ClosedXML.Excel;
using System.IO;

namespace CPresentacion
{
    public partial class frmEntradaSalida : Form
    {
        // Instancia y elementos del formulario principal
        frmPrincipal principal = new frmPrincipal();        // formulario principal
        private string sucursalactual = string.Empty;       // sucursal actual
        private int idsucursalactual = 0;                   // id sucursal actual
        public DataTable dtUserLogeado = new DataTable();   // permisos del usuario lo

        private int idsociedad = 1;
        private int ConexionLoc = 1;
        private int ConexionExt = 2;

        private int variddepto;
        private int varidsucursal;
        private string varcodigo;
        private bool EsNuevo = false;
        private bool EsEditar = false;
        DateTime fechaini;
        DateTime fechafin;

        public frmEntradaSalida(DataTable pdtuser)
        {
            InitializeComponent();
            dtpFechaini.Value = DateTime.Today;
            dtpFechafin.Value = DateTime.Today;
            dtpFecha.Value = DateTime.Today;
            sucursalactual = principal.sucursalactual;
            idsucursalactual = principal.idsucursalactual;
            dtUserLogeado = pdtuser;
        }
        
        private void frmRegistros_Load(object sender, EventArgs e)
        {   
            ListarSucursales();
            ListarDeptos();
            MensajeOK("No se olvide de generar los respaldos");
        }

        /* ------------------------ EVENTO DE LOS BOTONES -----------------------------------*/
        
        // Obtener los registros
        private void btnResgistros_Click(object sender, EventArgs e)
        {
            fechaini = dtpFechaini.Value;
            fechafin = dtpFechafin.Value;

            if (dtpFechaini.Value.Date > dtpFechafin.Value.Date)
            {
                this.MensajeError("Fecha de inicio debe ser menor o igual a la fecha final");
                dtpFechaini.Value = DateTime.Today;
                dtpFechafin.Value = DateTime.Today;
            }
            else
            {
                // Registros por sucursal
                if (varidsucursal >= 1 && variddepto <= 0 && Convert.ToInt32(varcodigo) <= 0)
                {
                    MostrarRegistros(4, varidsucursal, variddepto, varcodigo);
                }
                // Registros por depto
                else if (varidsucursal <= 0 && variddepto >= 1 && Convert.ToInt32(varcodigo) <= 0)
                {
                    MostrarRegistros(7, varidsucursal, variddepto, varcodigo);
                }
                // Registros por sucursal y depto
                else if (varidsucursal >= 1 && variddepto >= 1 && Convert.ToInt32(varcodigo) <= 0)
                {
                    MostrarRegistros(8, varidsucursal, variddepto, varcodigo);
                }
                // Registros por sucursal y empleado
                else if (varidsucursal >= 1 && Convert.ToInt32(varcodigo) >= 1)
                {
                    MostrarRegistros(5, varidsucursal, variddepto, varcodigo);
                }
                // Todos 
                else
                {
                    MostrarRegistros(1, varidsucursal, variddepto, varcodigo);
                }

            }
        }

        // Observaciones y descansos manuales
        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            lblTotal.Visible = false;
            ValidaDesansoObserva();
            idsucursalactual = principal.idsucursalactual;

            this.btnResgistros.Enabled = false;
            this.btnRespaldo.Enabled = false;
            this.btnExportar.Enabled = false;
            this.btnGuardar.Enabled = true;
            this.btnCancelar.Enabled = true;
            EsNuevo = true;
            EsEditar = false;

            ListarEmpleados(idsucursalactual, cbxEmp);
            colorcombobox(cbxEmp);

            // las observaciones de la sucursal actual
            if (dtUserLogeado.Rows[0]["tipo"].ToString() == "GERENTE") MostrarObservaciones(4, idsucursalactual);
            // las observaciones de todas las sucursales
            else MostrarObservaciones(1, idsucursalactual);

            this.tbcArticulos.SelectedIndex = 1;
        }

        // Generar respaldos
        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            string ruta = CurrentDirectory + @"\Backup\";
            string resultado = "";
            string fnombresql = ruta + sucursalactual + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".sql";

            // Especifica el directorio a manipular.
            try
            {
                if (Directory.Exists(ruta)) { }                                   // Revisar si existe el directorio
                else { DirectoryInfo di = Directory.CreateDirectory(ruta); }      // crearlo

                resultado = NDataBase.NBackup(fnombresql, ConexionLoc);
                if (resultado.Equals("ok")) this.MensajeOK("Respaldo realizado correctamente en: " + ruta);
                else this.MensajeError(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Exportar a excel
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvRecords.Rows.Count > 0)
            {
                ExportToExcelWithFormatting(dgvRecords);
            }
            else MensajeError("No se encontraron registros");
        }

        // Guardar observaciones o descansos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string auxcodigo = string.Empty;
            string resultado = "";

            if (rbnDescanso.Checked == true)
            {
                // Agregar descansos manuales
                try
                {
                    auxcodigo = cbxEmp.SelectedValue.ToString();
                    resultado = NDescansos.NAgregarDescansos(dtpFecha.Value, auxcodigo, ConexionLoc);
                    if (resultado == "ok") this.MensajeOK("Se ingreso correctamente el descanso");
                    else this.MensajeError(resultado);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                int general = 0;
                try
                {
                    if (this.tbxObservacion.Text == string.Empty)
                    {
                        MensajeError("Faltan ingresar algunos datos, seran remarcados");
                        eprError.SetError(tbxObservacion, "Ingrese la observación");
                    }
                    else
                    {
                        if (ckbGeneral.Checked == true) { general = 1; }
                        else { auxcodigo = cbxEmp.SelectedValue.ToString(); }

                        if (this.EsNuevo == true)
                        {
                            resultado = NObservaciones.NAgregarObservacion(general,
                                                                           auxcodigo,
                                                                           dtpFecha.Value,
                                                                           this.tbxObservacion.Text.ToUpper().Trim(),
                                                                           idsucursalactual,
                                                                           ConexionLoc);
                        }
                        else
                        {

                        }
                        if (resultado.Equals("ok"))
                        {
                            if (this.EsNuevo == true) this.MensajeOK("Se ingreso correctamente el registro");                           
                            else this.MensajeOK("Se modifico correctamente el registro");                            
                        }
                        else
                        {
                            this.MensajeError(resultado);
                        }
                        MostrarObservaciones(1, idsucursalactual);
                        tbxObservacion.Text = string.Empty;
                        cbxEmp.SelectedItem = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        // Cancelamos cualquier operación
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.btnResgistros.Enabled = true;
            this.btnRespaldo.Enabled = true;
            this.btnExportar.Enabled = true;
            EsNuevo = false;
            EsEditar = false;
            this.tbcArticulos.SelectedIndex = 0;
        }

        // Buscar observaciones
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtUserLogeado.Rows[0]["tipo"].ToString() == "GERENTE")
            {
                MostrarObservaciones(5, idsucursalactual);
            }
            else
            {
                if (cbxSucursales.SelectedIndex == 0) MostrarObservaciones(2, idsucursalactual);
                else MostrarObservaciones(5, cbxSucursales.SelectedIndex);                
            }
        }

        /* ------------------------ OTROS EVENTOS -----------------------------------*/

        // Evento el cual obtine el id del departamento para obtener sus empleados
        private void cbxDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        // Obtener el numero de la fila
        private void dgvRecords_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == numero.Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        // Color de las filas del DataGrid por empleado
        private void dgvRecords_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            if (gridView.Rows.Count > 0)
            {
                var codigo = gridView.Rows[0].Cells["codigo"].Value.ToString();
                Color color = Color.FromArgb(245, 220, 111);
                Color colorAux = Color.White;
                Color tmpColor;

                foreach (DataGridViewRow row in gridView.Rows)
                {
                    if (row.Cells["codigo"].Value.ToString() == codigo)
                    {
                        row.DefaultCellStyle.BackColor = color;
                    }
                    else
                    {
                        codigo = row.Cells["codigo"].Value.ToString();
                        tmpColor = color;
                        color = colorAux;
                        colorAux = tmpColor;
                        row.DefaultCellStyle.BackColor = color;
                    }
                }
            }
        }

        // Muestra el menu al presionar boton derecho sobre el datagrid
        private void dgvRecords_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex == -1)
                {
                }
                else
                {
                    dgvRecords.CurrentCell = dgvRecords.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cmsMenu.Show(Cursor.Position.X, Cursor.Position.Y);
                }
            }
        }

        // Coloca el estado como entrada
        private void mitemEntrada_Click(object sender, EventArgs e)
        {
            int registro;
            int regactual;
            if (dgvRecords.SelectedRows.Count == 1)
            {
                registro = Convert.ToInt32(dgvRecords.CurrentRow.Cells["idregistro"].Value);
                regactual = Convert.ToInt32(dgvRecords.CurrentRow.Cells["numero"].Value);
                CambiarEstado(registro, 1, regactual);
            }
        }

        // Coloca el estado como salida
        private void mitemSalida_Click(object sender, EventArgs e)
        {
            int registro;
            int regactual;
            if (dgvRecords.SelectedRows.Count == 1)
            {
                registro = Convert.ToInt32(dgvRecords.CurrentRow.Cells["idregistro"].Value);
                regactual = Convert.ToInt32(dgvRecords.CurrentRow.Cells["numero"].Value);
                CambiarEstado(registro, 2, regactual);
            }
        }

        // Elimina el registro
        private void mitemEliminar_Click(object sender, EventArgs e)
        {
            int registro;
            int regactual;
            if (dgvRecords.SelectedRows.Count == 1)
            {
                registro = Convert.ToInt32(dgvRecords.CurrentRow.Cells["idregistro"].Value);
                regactual = Convert.ToInt32(dgvRecords.CurrentRow.Cells["numero"].Value);
                string resultado = "";

                try
                {
                    resultado = NRegistros.NModificarRegistrosActivos(registro, ConexionLoc);
                    if (resultado.Equals("ok")) this.MensajeOK("Se elimino correctamente el estado");
                    else this.MensajeError(resultado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                btnResgistros.PerformClick();
                dgvRecords.Rows[regactual - 1].Selected = true;
                dgvRecords.FirstDisplayedScrollingRowIndex = regactual - 1;
            }
        }

        private void cbxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbxEmp.SelectedValue != null)
            //{
            //    string auxidsucursal = cbxEmp.SelectedValue.ToString();
            //}
        }

        // Sabemos si será observación general o por empleado
        private void ckbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGeneral.Checked == true) cbxEmp.Enabled = false;
            else cbxEmp.Enabled = true;
        }

        // Si seleccionamos una sucursal mostrara los empleados de esa sucursal
        private void cbxSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSucursales.SelectedValue != null)
            {
                varidsucursal = Convert.ToInt32(cbxSucursales.SelectedValue);
                if (varidsucursal >= 0) { ListarEmpleados(varidsucursal, cbxEmpleados); }
            }
        }

        // Si seleccionamos un depto lo asignamos a la variable
        private void cbxDeptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDeptos.SelectedValue != null)
            { variddepto = Convert.ToInt32(cbxDeptos.SelectedValue); }
        }

        // Si seleccionamos un empleado lo asignamos a la variable
        private void cbxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEmpleados.SelectedValue != null)
            { varcodigo = cbxEmpleados.SelectedValue.ToString(); }
        }

        // Si cambiamos de pestañas en el tabcontrol
        private void tbcArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tbcArticulos.SelectedIndex == 1)
            {
                btnObservaciones.PerformClick();
            }
            else
            {
                this.lblTotal.Visible = true;
                this.btnResgistros.Enabled = true;
                this.btnRespaldo.Enabled = true;
                this.btnExportar.Enabled = true;

                this.ckbGeneral.Enabled = false;
                this.cbxEmp.Enabled = false;
                this.dtpFecha.Enabled = false;
                this.tbxObservacion.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.tbcArticulos.SelectedIndex = 0;
            }
        }

        // Será onservación
        private void rbnObservacion_CheckedChanged(object sender, EventArgs e)
        {
            ValidaDesansoObserva();
        }

        // Será descanso
        private void rbnDescanso_CheckedChanged(object sender, EventArgs e)
        {
            ValidaDesansoObserva();
        }
        

        /* ------------------------ METODOS PARA DISEÑO -----------------------------------*/

        // Asigna color a las filas
        public void ColorFila(DataGridView pDataGrid)
        {
            pDataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
            pDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }        
        // Obtener la posicion de un control en cordenadas x,y
        private Point locacion(Control c)
        {
            Point p;
            for (p = c.Location; c.Parent != null; c = c.Parent)
            {
                p.Offset(c.Parent.Location);
            }
            MessageBox.Show(p.ToString());
            return p;
        }
        // Mostrar mensaje de OK
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Metodo para ocultar columnas del datagrid
        private void OcultarColumnas()
        {
            dgvRecords.Columns["idregistro"].Visible = false;
            dgvRecords.Columns["numero"].Visible = false;
            dgvRecords.Columns["fechahorareg"].Visible = false;
            dgvRecords.Columns["idestado"].Visible = false;
            dgvRecords.Columns["idsucursal"].Visible = false;
        }

        // Validamos si se agregará descansos u observaciones
        public void ValidaDesansoObserva()
        {
            if (rbnObservacion.Checked == true)
            {
                ckbGeneral.Enabled = true;
                cbxEmp.Enabled = true;
                dtpFecha.Enabled = true;
                tbxObservacion.Enabled = true;
            }
            else
            {
                ckbGeneral.Enabled = false;
                cbxEmp.Enabled = true;
                dtpFecha.Enabled = true;
                tbxObservacion.Enabled = false;
                ckbGeneral.Checked = false;
            }
        }

        // Intercalar colores del combobox
        private void colorcombobox(ComboBox pcombo)
        {
            //int contador = pcombo.Items.Count;
            //for (int i = 1; i <= contador; i++)
            //{
            //    if (i % 2 == 0) { pcombo.BackColor = Color.FromArgb(255, 130, 4); }
            //    else { pcombo.BackColor = Color.White; }
            //}
        }

        // Exportar a excel
        public void ExportToExcelWithFormatting(DataGridView dataGridView1)
        {
            string fileName;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.Title = "To Excel";
            saveFileDialog1.FileName = "Registros - " + DateTime.Now.ToString("dd-MM-yyyy");

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add(this.Text);
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (!dataGridView1.Columns[i].Visible) continue;
                    worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].Name;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (!dataGridView1.Columns[j].Visible) continue;
                        worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value.ToString();

                        if (worksheet.Cell(i + 2, j + 1).Value.ToString().Length > 0)
                        {
                            XLAlignmentHorizontalValues align;

                            switch (dataGridView1.Rows[i].Cells[j].Style.Alignment)
                            {
                                case DataGridViewContentAlignment.BottomRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.MiddleRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.TopRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.BottomCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                case DataGridViewContentAlignment.MiddleCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                case DataGridViewContentAlignment.TopCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                default:
                                    align = XLAlignmentHorizontalValues.Left;
                                    break;
                            }

                            worksheet.Cell(i + 2, j + 1).Style.Alignment.Horizontal = align;

                            XLColor xlColor = XLColor.FromColor(dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor);
                            worksheet.Cell(i + 2, j + 1).AddConditionalFormat().WhenLessThan(1).Fill.SetBackgroundColor(xlColor);

                            worksheet.Cell(i + 2, j + 1).Style.Font.FontName = dataGridView1.Font.Name;
                            worksheet.Cell(i + 2, j + 1).Style.Font.FontSize = dataGridView1.Font.Size;
                        }
                    }
                }
                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(fileName);
            }
        }

        /* ------------------------ METODOS PARA CONSULTAS SQL -----------------------------------*/

        // Obtener las sucursales
        public void ListarSucursales()
        {
            idsucursalactual = principal.idsucursalactual;

            DataTable dtlistarsuc = new DataTable();
            dtlistarsuc.Columns.Add("idsucursal", typeof(int));
            dtlistarsuc.Columns.Add("sucursal", typeof(string));
            dtlistarsuc.Rows.Add(0, "SELECCIONE:");

            DataTable dt = NSucursales.NMostrarSucursales(1, idsucursalactual, ConexionLoc);
            dtlistarsuc.Merge(dt);
            cbxSucursales.ValueMember = "idsucursal";
            cbxSucursales.DisplayMember = "sucursal";
            cbxSucursales.DataSource = dtlistarsuc;

            // si es gerente no podra cambiar de sucursal para obtener los registros
            if (dtUserLogeado.Rows[0]["tipo"].ToString() == "GERENTE")
            {
                cbxSucursales.SelectedIndex = idsucursalactual;
                cbxSucursales.Enabled = false;
            }
            else  cbxSucursales.SelectedIndex = 0;
        }

        // Obtener los departamentos
        public void ListarDeptos()
        {
            DataTable dtlistardepto = new DataTable();
            dtlistardepto.Columns.Add("iddepto", typeof(int));
            dtlistardepto.Columns.Add("nombre", typeof(string));
            dtlistardepto.Rows.Add(0, "SELECCIONE:");

            DataTable dt = NDeptos.NMostrarDeptos(ConexionLoc);
            dtlistardepto.Merge(dt);
            cbxDeptos.ValueMember = "iddepto";
            cbxDeptos.DisplayMember = "nombre";
            cbxDeptos.DataSource = dtlistardepto;

            cbxDeptos.SelectedIndex = 0; // seleccionamos el primer departamento (SELECCIONE:)
        }

        // Obtener los empleados
        public void ListarEmpleados(int pidsucursal, ComboBox pcombo)
        {
            DataTable dtlistaremp = new DataTable();
            dtlistaremp.Columns.Add("codigo", typeof(string));
            dtlistaremp.Columns.Add("nombrecompleto", typeof(string));
            dtlistaremp.Rows.Add("0", "SELECCIONE:");

            
            DataTable dt = NEmpleados.NMostrarEmpleadosDetalles(3, 1, 1, pidsucursal, "", "", 1, 1, ConexionLoc);
            dtlistaremp.Merge(dt);
            pcombo.ValueMember = "codigo";
            pcombo.DisplayMember = "nombrecompleto";
            pcombo.DataSource = dtlistaremp;

            pcombo.SelectedIndex = 0; // seleccionamos el primer empleado (SELECCIONE:)
        }

        // Cambia el estado del registro (entrada o salida)
        private void CambiarEstado(int pidregistro, int pestado, int pregactual)
        {
            int registro = pidregistro;
            int estado = pestado;
            string resultado = "";

            try
            {
                resultado = NRegistros.NModificarRegistrosEstados(registro, estado, ConexionLoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            btnResgistros.PerformClick();
            dgvRecords.Rows[pregactual - 1].Selected = true;
            dgvRecords.FirstDisplayedScrollingRowIndex = pregactual - 1;
        }

        // Mostrar los registros
        private void MostrarRegistros(int popcion, int pidsucursal, int piddepto, string pcodigo)
        {
            dgvRecords.DataSource = NRegistros.NMostrarRegistros(popcion,
                                                                 1,
                                                                 fechaini,
                                                                 fechafin,
                                                                 pidsucursal,
                                                                 pcodigo,
                                                                 variddepto,
                                                                 ConexionLoc);
            if (dgvRecords != null) OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvRecords.Rows.Count);
            dgvRecords.ClearSelection();
        }

        // Mostrar observaciones
        private void MostrarObservaciones(int popcion, int pidsucursal)
        {
            dgvObservaciones.DataSource = NObservaciones.NMostrarObservaciones(popcion,
                                                                               dtpFechaini.Value,
                                                                               dtpFechafin.Value,
                                                                               pidsucursal,
                                                                               ConexionLoc);
            if (dgvObservaciones != null)
            {
                dgvObservaciones.Columns["idobservacion"].Visible = false;
                dgvObservaciones.Columns["Eliminar"].Visible = false;
                dgvObservaciones.Columns["codigoobs"].Visible = false;
                dgvObservaciones.Columns["idsucursal"].Visible = false;
                dgvObservaciones.Columns["sync"].Visible = false;
                dgvObservaciones.Columns["general"].Visible = false;

                ColorFila(dgvObservaciones);
                lblTObservacion.Text = "T. Observaciones: " + Convert.ToString(dgvObservaciones.Rows.Count);
                dgvObservaciones.ClearSelection();

            }
        }




        



























    }
}
