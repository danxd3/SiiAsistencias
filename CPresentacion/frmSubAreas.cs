using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using CNegocio;

namespace CPresentacion
{
    public partial class frmSubAreas : Form
    {
        private bool EsNuevo = false;       // Registro nuevo
        private bool EsEditar = false;      // Registro modificado
        private int ConexionLoc = 1;        // Conexion local
        private int ConexionExt = 2;        // Conexion externa
        private string resultadoSQL = "";   // Resultado de las consultas

        frmPrincipal principal = new frmPrincipal();
        private string sucursalactual = string.Empty;
        private int idsucursalactual = 0;
        public DataTable dtUserLogeado = new DataTable();
        private DataTable dtAuxEmpleadosGral = new DataTable();
        private DataTable dtEmpleadosCInasistencias = new DataTable();

        //private int ConexionLoc = 1;
        //private int ConexionExt = 2;
        private int idsociedad = 1;
        private DateTime fechaini;
        private DateTime fechafin;
        private DataTable dtsucursal = new DataTable();

        private int variddepto;
        private int varidsucursal;
        private string varcodigo;

        public frmSubAreas(DataTable pdtuser)
        {
            InitializeComponent();
            dtpFechaini.Value = DateTime.Today;
            //dtpFechafin.Value = DateTime.Today;
            sucursalactual = principal.sucursalactual;
            idsucursalactual = principal.idsucursalactual;
            dtUserLogeado = pdtuser;
        }

    

        private void frmSubAreas_Load(object sender, EventArgs e)
        {

            MostrarSubAreas();
            HabilitarTbx(false);
            HabilitarBtn();
            LimpiarTbx();
            ListarSucursales();
            ListaInacistencias();
            CargarEmpleados();
            //ListarDeptos();




        }
        public void CargarEmpleados()
        {
            dtAuxEmpleadosGral = NEmpleados.NMostrarEmpleadosDetalles(1, 1, 1, 0, "", string.Empty,
                0, 0, ConexionLoc);
        }
        // Obtener los departamentos
        //public void ListarDeptos()
        //{
        //    DataTable dtlistardepto = new DataTable();
        //    dtlistardepto.Columns.Add("iddepto", typeof(int));
        //    dtlistardepto.Columns.Add("nombre", typeof(string));
        //    dtlistardepto.Rows.Add(0, "SELECCIONE:");

        //    DataTable dt = NDeptos.NMostrarDeptos(ConexionLoc);
        //    dtlistardepto.Merge(dt);
        //    cbxDeptos.ValueMember = "iddepto";
        //    cbxDeptos.DisplayMember = "nombre";
        //    cbxDeptos.DataSource = dtlistardepto;

        //    cbxDeptos.SelectedIndex = 0; // seleccionamos el primer departamento (SELECCIONE:)
        //}
        public void ListaInacistencias()
        {
            //DataTable dtlistarsuc = new DataTable();
            //dtlistarsuc.Columns.Add("idsubarea", typeof(int));
            //dtlistarsuc.Columns.Add("nombrearea", typeof(string));
            //dtlistarsuc.Rows.Add(0, "SELECCIONE:");

            //DataTable dt = NSubAreas.NMostrarSubAreas(ConexionLoc);


            //dtlistarsuc.Merge(dt);
            //cbInacistencias.ValueMember = "idsubarea";
            //cbInacistencias.DisplayMember = "nombrearea";
            //cbInacistencias.DataSource = dtlistarsuc;
            cbInacistencias.DataSource = GetInasistencias();
            cbInacistencias.ValueMember = "Id";
            cbInacistencias.DisplayMember = "Tipo";


        }
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

            if (dtUserLogeado.Rows[0]["tipo"].ToString() == "GERENTE")
            {
                cbxSucursales.SelectedIndex = idsucursalactual;
                cbxSucursales.Enabled = false;
            }
            else { cbxSucursales.SelectedIndex = 0; }

        }
        // Ocultar columnas
        private void OcultarColumnas()
        {
            dgwCategorias.Columns["Eliminar"].Visible = false;
            dgwCategorias.Columns["idsociedad"].Visible = false;
            dgwCategorias.Columns["idsubarea"].Visible = false;
            dgwCategorias.Columns["fmodifica"].Visible = false;
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

        private void MostrarSubAreas()
        {
            dgwCategorias.DataSource = NSubAreas.NMostrarSubAreas(ConexionLoc);
            if (dgwCategorias != null)
            {
                OcultarColumnas();
                lblRegistros.Text = "No. de Sub Areas: " + Convert.ToString(dgwCategorias.Rows.Count);
                ColorFila(dgwCategorias);
                dgwCategorias.ClearSelection();
            }
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

        public void ColorFila(DataGridView pDataGrid)
        {
            pDataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
            pDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                resultadoSQL = "";
                if (this.tbxNombre.Text == string.Empty)
                {
                    MensajeError("Faltan algunos datos por ingresar, serán remarcados");

                }
                else
                {
                    if (this.EsNuevo == true)
                    {
                        
                        resultadoSQL = NSubAreas.NAgregarSubArea(this.tbxNombre.Text.Trim().ToUpper(),
                                                                 this.tbxDescripcion.Text.Trim().ToUpper(),
                                                                 DateTime.Now,
                                                                 ConexionLoc);
                    }
                    else
                    {

                        resultadoSQL = NSubAreas.NEditarSubArea(Convert.ToInt32(tbxFolio.Text),
                                                                this.tbxNombre.Text.Trim().ToUpper(),
                                                                this.tbxDescripcion.Text.Trim().ToUpper(),
                                                                DateTime.Now,
                                                                ConexionLoc);
                    }

                    if (resultadoSQL.Equals("ok"))
                    {
                        if (this.EsNuevo == true) this.MensajeOK("Sub Area agregada correctamente");
                        else this.MensajeOK("Sub Area modificada correctamente");
                    }
                    else this.MensajeError(resultadoSQL);

                    EsNuevo = false;
                    EsEditar = false;
                    HabilitarBtn();
                    LimpiarTbx();
                    MostrarSubAreas();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + er.StackTrace);
            }
        }

        private void dgwCategorias_DoubleClick(object sender, EventArgs e)
        {
            this.tbxFolio.Text = Convert.ToString(this.dgwCategorias.CurrentRow.Cells["idsubarea"].Value);
            this.tbxNombre.Text = Convert.ToString(this.dgwCategorias.CurrentRow.Cells["nombrearea"].Value);
            this.tbxDescripcion.Text = Convert.ToString(this.dgwCategorias.CurrentRow.Cells["descripcion"].Value);

            this.lblFmodifica.Visible = true;
            this.lblFmodifica.Text = "Fecha de modificación: " + (Convert.ToDateTime(this.dgwCategorias.CurrentRow.Cells["fmodifica"].Value)).ToShortDateString();
        }

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DialogoOpcion;
                DialogoOpcion = MessageBox.Show("¿Desea eliminar los departamentos marcados?", "SiiAsistencias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogoOpcion == DialogResult.OK)
                {
                    string codigo;
                    resultadoSQL = "";
                    foreach (DataGridViewRow row in dgwCategorias.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            resultadoSQL = NSubAreas.NEliminarSubArea(Convert.ToInt32(codigo), ConexionLoc);

                            if (resultadoSQL.Equals("ok")) this.MensajeOK("Sub Area eliminada correctamente");
                            else this.MensajeError(resultadoSQL);
                        }
                    }

                    MostrarSubAreas();
                    cbxEliminar.Checked = false;
                }

            }
            catch (Exception er) { MessageBox.Show(er.Message + er.StackTrace); }
        }

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

        private void dgwCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwCategorias.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgwCategorias.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void cbxSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSucursales.SelectedValue != null)
            {
                varidsucursal = Convert.ToInt32(cbxSucursales.SelectedValue);

            }

            if (cbxSucursales.SelectedValue != null)
            {
               
                    varidsucursal = Convert.ToInt32(cbxSucursales.SelectedValue);
                    //if (varidsucursal >= 0) { ListarEmpleados(varidsucursal, cbxEmpleados); }
                
                
            }
        }
        // Obtener los empleados
        public void ListarEmpleados(int pidsucursal, ComboBox pcombo)
        {
            DataTable dtlistaremp = new DataTable();
            dtlistaremp.Columns.Add("codigo", typeof(string));
            dtlistaremp.Columns.Add("nombrecompleto", typeof(string));
            dtlistaremp.Rows.Add("0", "SELECCIONE:");


            DataTable dt = NEmpleados.NMostrarEmpleadosDetalles(3, 1, 1, pidsucursal, "", "", 1, 1, ConexionLoc);

            //Seteo de combobox con los datos de las subareas
            var combobox = (DataGridViewComboBoxColumn)dgvInasistencias.Columns["SubareaInas"];
            combobox.DisplayMember = "nombre";
            combobox.ValueMember = "id";
            combobox.DataSource = GetSubAreas();

            //Remover empleados a fin de dejar los que tienen inacistencia
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
               

                foreach (DataGridViewRow row in dgvPrueba.Rows)
                {
                    if (dt.Rows[i]["codigo"].ToString() == row.Cells["codigox"].Value.ToString())
                    {
                       
                        dt.Rows.RemoveAt(i);
                        break;
                    }
                    
                }

                
            }
            int diaSemana = (int)DateTime.Now.DayOfWeek;
            int valor;
            dtEmpleadosCInasistencias = dt;
            //
           
            foreach(DataRow  row in dt.Rows)
            {
                if (diaSemana.ToString() == row["descansos"].ToString())
                {
                    valor = 2;
                }
                else
                {
                    valor = 6;
                }
                dgvInasistencias.Rows.Add(row["codigo"].ToString(), row["nombrecompleto"].ToString(),valor, row["depto"].ToString());

            }

            //foreach (DataRow row in dtAuxEmpleadosGral.Rows)
            //{
            //    if (row["codigo"].ToString() == cbxEmpleados.SelectedValue.ToString())
            //    {
            //        depto = row["depto"].ToString();
            //    }
            //}
            //dgvPrueba.Rows.Add(cbxEmpleados.SelectedValue, cbxEmpleados.Text, cbInacistencias.SelectedValue, depto);


            DataView dv = dt.DefaultView;

            dv.Sort = "nombrecompleto";
            DataTable dtAux = dv.ToTable();

            dtlistaremp.Merge(dtAux);
            pcombo.ValueMember = "codigo";
            pcombo.DisplayMember = "nombrecompleto";
            pcombo.DataSource = dtlistaremp;

            pcombo.SelectedIndex = 0; // seleccionamos el primer empleado (SELECCIONE:)
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                fechaini = dtpFechaini.Value;
                string apoyoSucursal = "";
                DataTable dtauxiliar = new DataTable();
                DataTable dtSucursales = NSucursales.NMostrarSucursales(1, idsucursalactual, ConexionLoc);
                List<Inasistencias> ListInasistencia = GetInasistencias();
                varcodigo = "0";
                int idSubarea;
                dgvPrueba.Rows.Clear();

                dtauxiliar = NRegistros.NMostrarRegistrosAsistenciasSucursal(fechaini, fechaini, varidsucursal, ConexionLoc);
                //dtauxiliar = NRegistros.NMostrarRegistrosAsistencias(2, fechaini, fechaini, varidsucursal, variddepto, varcodigo, ConexionLoc);


                //Seteo de combobox con los datos de las subareas
                var combobox2 = (DataGridViewComboBoxColumn)dgvPrueba.Columns["Subareax"];
                combobox2.DisplayMember = "nombre";
                combobox2.ValueMember = "id";
                combobox2.DataSource = GetSubAreas();


                //Se recorre 2  data table debido a que uno contiene toda la informacion del empleado y el otro su asistencia
                foreach (DataRow rowAux in dtAuxEmpleadosGral.Rows)
                {
                    foreach (DataRow row in dtauxiliar.Rows)
                    {
                        if (rowAux["codigo"].ToString() == row["codigo"].ToString())
                        {
                            //Asignacion y recorrdio de FOR cuando el empleado tiene asistencia pero tambien su subarea es una inasistencia
                           idSubarea =Convert.ToInt32( row["idsubarea"]);
                           for (int i = 2; i <= 6; i++)
                            {
                                if(i== idSubarea)
                                {
                                    idSubarea = 1;
                                }
                            }

                            if (Convert.ToInt32(row["idsucursal"]) != varidsucursal)
                            {
                                //foreach para revisar si el empleado proviene de otra sucursal como apoyo
                                apoyoSucursal = "APOYO";
                                foreach (DataRow RowSuc in dtSucursales.Rows)
                                {
                                    if (RowSuc["idsucursal"].ToString() == row["idsucursal"].ToString())
                                    {
                                        apoyoSucursal = apoyoSucursal + " " + RowSuc["sucursal"];
                                    }

                                }
                                dgvPrueba.Rows.Add(rowAux["codigo"].ToString(), rowAux["nombrecompleto"].ToString() + " (" + apoyoSucursal + ")", idSubarea, rowAux["depto"].ToString());
                                break;
                            }
                            else
                            {
                                dgvPrueba.Rows.Add(rowAux["codigo"].ToString(), rowAux["nombrecompleto"].ToString(), idSubarea, rowAux["depto"].ToString());
                                break;
                            }


                        }
                    }

                }
                this.dgvPrueba.Columns["depto"].SortMode= DataGridViewColumnSortMode.Automatic;
               
                //Llama al metodo para listar empleados en combobox
                ListarEmpleados(varidsucursal, cbxEmpleados);
            }
            catch(Exception er)
            {
                MensajeError("Error al consultar: "+er.Message);
            }
            

        }

        private void dgvEmpleadosAreas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //Seria buena idear dejar este proceso por cualquier validacion
            //Evitar un error cuando los valores no son iguales en el combobox con su origen
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dgvPrueba.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dgvPrueba.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dgvPrueba.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void dgvEmpleadosAreas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ExportarExcel(DataGridView dgv)
        {
            try
            {
                DateTime fecha = dtpFechaini.Value;
                //Date table que guardar los datos del datagrid
                DataTable dtInfo = new DataTable();
                dtInfo.Columns.Add("codigo");
                dtInfo.Columns.Add("nombre");
                dtInfo.Columns.Add("subarea");
                dtInfo.Columns.Add("depto");
                //Contadores de asistencias
                int totalCajas = 0, totalPiso = 0, totalBodega = 0, totalOtros = 0;
                
                //Se optienen las categorias
                List<subarea> ListCat = new List<subarea>();
                ListCat = GetSubAreas();

                //Encabezado
                Color colorEncabezado = ColorTranslator.FromHtml("#11A3FC");
                //Sub encabezado
                Color colorSubEncabezado = ColorTranslator.FromHtml("#51BAFA");
                
                //Cajas
                Color colorCaja = ColorTranslator.FromHtml("#97F9F0");
                //PisoVenta 
                Color colorPisoVenta = ColorTranslator.FromHtml("#85D9FA");
                //Color Bodega 
                Color colorBodega = ColorTranslator.FromHtml("#FACD84");
                //Color Inasistencias 
                Color colorInasistencias = ColorTranslator.FromHtml("#FC4762");
                //Color encargados 20B0E6
                Color colorEncargados = ColorTranslator.FromHtml("#20B0E6");
                //Color otros deptos
                Color colorOtrosDeptos= ColorTranslator.FromHtml("#79EAFC");
                //Color total areas FFA76A
                Color colorTotalAreas = ColorTranslator.FromHtml("#FFA76A");

                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);


                excel.Range["A1:A1000"].NumberFormat = "@";
                int indiceFila = 2;
                int indiceColumna = 0;
                DataRow dtRow;

                //Se guarda la informacion del datagrid en un data table ademas de setear el subarea con su nombre
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    indiceFila++;
                    indiceColumna = 0;
                    dtRow = dtInfo.NewRow();
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        indiceColumna++;

                        if (indiceColumna == 3)
                        {
                            foreach (subarea Area in ListCat)
                            {
                                if (Area.id == Convert.ToInt32(row.Cells[col.Name].Value.ToString()))
                                {
                                    dtRow[indiceColumna - 1] = Area.nombre;
                                    //excel.Cells[indiceFila + 1, indiceColumna] = Area.nombre;
                                }
                            }
                        }
                        else
                        {
                            dtRow[indiceColumna - 1] = row.Cells[col.Name].Value.ToString();
                            //excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value.ToString();
                        }


                    }
                    dtInfo.Rows.Add(dtRow);
                }

                //Se diseña el  reporte de excel en 2 secciones
                //indiceFila= es el contador para las filas
                //Cabecera
                int iniciaReporte2seccion = 1;
                int iniciaReporte1seccion = 3;
                excel.Cells[1, "A"] = "Reporte de Sucursal: " + cbxSucursales.Text;
                excel.Cells[2, "A"] = "Fecha: " + fechaini.ToString("dd-MM-yyyy");
                //Remuevo primero a los empleados con inasistencia
                int guardaFinFila = 0;
                indiceFila = iniciaReporte2seccion;
                excel.Cells[indiceFila, "D"] = "INASISTENCIAS";
                excel.Cells[indiceFila, "D"].Interior.Color = colorInasistencias;
                excel.Cells[indiceFila, "E"].Interior.Color = colorInasistencias;
                indiceFila++;
                excel.Cells[indiceFila, "D"] = "MOTIVO";
                excel.Cells[indiceFila, "D"].Interior.Color = colorInasistencias;
                excel.Cells[indiceFila, "E"] = "NOMBRE";
                excel.Cells[indiceFila, "E"].Interior.Color = colorInasistencias;
                indiceFila++;
                //Se imprimen los empleados con inasistencias y se remueven del data table
                for (int i = dtInfo.Rows.Count - 1; i >= 0; i--)
                {

                    if (dtInfo.Rows[i]["subarea"].ToString() == "DESCANSO")
                    {
                        excel.Cells[indiceFila, "D"] = "DESCANSO";
                        excel.Cells[indiceFila, "E"] = dtInfo.Rows[i]["nombre"].ToString();
                        indiceFila++;
                        dtInfo.Rows.RemoveAt(i);
                    }
                    else if (dtInfo.Rows[i]["subarea"].ToString() == "VACACIONES")
                    {
                        excel.Cells[indiceFila, "D"] = "VACACIONES";
                        excel.Cells[indiceFila, "E"] = dtInfo.Rows[i]["nombre"].ToString();
                        indiceFila++;
                        dtInfo.Rows.RemoveAt(i);
                    }
                    else if (dtInfo.Rows[i]["subarea"].ToString() == "PERMISO")
                    {
                        excel.Cells[indiceFila, "D"] = "PERMISO";
                        excel.Cells[indiceFila, "E"] = dtInfo.Rows[i]["nombre"].ToString();
                        indiceFila++;
                        dtInfo.Rows.RemoveAt(i);
                    }
                    else if (dtInfo.Rows[i]["subarea"].ToString() == "INCAPACIDAD")
                    {
                        excel.Cells[indiceFila, "D"] = "INCAPACIDAD";
                        excel.Cells[indiceFila, "E"] = dtInfo.Rows[i]["nombre"].ToString();
                        indiceFila++;
                        dtInfo.Rows.RemoveAt(i);
                    }
                    else if (dtInfo.Rows[i]["subarea"].ToString() == "FALTA")
                    {
                        excel.Cells[indiceFila, "D"] = "FALTA";
                        excel.Cells[indiceFila, "E"] = dtInfo.Rows[i]["nombre"].ToString();
                        indiceFila++;
                        dtInfo.Rows.RemoveAt(i);
                    }

                }
                foreach(DataRow row in dtEmpleadosCInasistencias.Rows)
                {
                    excel.Cells[indiceFila, "D"] = "NO-ASIGANDO";
                    excel.Cells[indiceFila, "E"] = row["nombrecompleto"].ToString();
                    indiceFila++;
                }

                //guardamos el renglon donde nos quedamos
                guardaFinFila = indiceFila;
                //Primera seccion
                indiceFila = iniciaReporte1seccion;
                excel.Cells[indiceFila, "A"] = "CAJAS";
                excel.Cells[indiceFila, "A"].Interior.Color = colorCaja;
                excel.Cells[indiceFila, "B"].Interior.Color = colorCaja;
                indiceFila++;
                excel.Cells[indiceFila, "A"] = "SUBAREA";
                excel.Cells[indiceFila, "A"].Interior.Color = colorCaja;
                excel.Cells[indiceFila, "B"] = "LISTA DE EMPLEADOS";
                excel.Cells[indiceFila, "B"].Interior.Color = colorCaja;
                indiceFila++;

                //Impresion del area de cajas
                foreach (DataRow row in dtInfo.Rows)
                {
                    if (row["depto"].ToString() == "CAJAS")
                    {
                        excel.Cells[indiceFila, "A"] = row["subarea"].ToString();
                        excel.Cells[indiceFila, "B"] = row["nombre"].ToString();
                        indiceFila++;
                        totalCajas++;
                    }
                    if (row["depto"].ToString() == "HOSTESS")
                    {
                        excel.Cells[indiceFila, "A"] = row["subarea"].ToString();
                        excel.Cells[indiceFila, "B"] = row["nombre"].ToString();
                        indiceFila++;
                        totalCajas++;
                    }
                    if (row["depto"].ToString() == "VERIFICADOR")
                    {
                        excel.Cells[indiceFila, "A"] = row["subarea"].ToString();
                        excel.Cells[indiceFila, "B"] = row["nombre"].ToString();
                        indiceFila++;
                        totalCajas++;
                    }

                }
                //Impresion del area de Piso de venta
                indiceFila += 2;
                excel.Cells[indiceFila, "A"] = "PISO DE VENTA";
                excel.Cells[indiceFila, "A"].Interior.Color = colorPisoVenta;
                excel.Cells[indiceFila, "B"].Interior.Color = colorPisoVenta;
                indiceFila++;
                excel.Cells[indiceFila, "A"] = "SUBAREA";
                excel.Cells[indiceFila, "A"].Interior.Color = colorPisoVenta;
                excel.Cells[indiceFila, "B"] = "LISTA DE EMPLEADOS";
                excel.Cells[indiceFila, "B"].Interior.Color = colorPisoVenta;
                indiceFila++;
                foreach (DataRow row in dtInfo.Rows)
                {
                    if (row["depto"].ToString() == "ASESORA DE VENTA")
                    {
                        excel.Cells[indiceFila, "A"] = row["subarea"].ToString();
                        excel.Cells[indiceFila, "B"] = row["nombre"].ToString();
                        indiceFila++;
                        totalPiso++;
                    }

                }
                //Impresion del area de bodega
                indiceFila += 2;
                excel.Cells[indiceFila, "A"] = "BODEGA";
                excel.Cells[indiceFila, "A"].Interior.Color = colorBodega;
                excel.Cells[indiceFila, "B"].Interior.Color = colorBodega;
                indiceFila++;
                excel.Cells[indiceFila, "A"] = "SUBAREA";
                excel.Cells[indiceFila, "A"].Interior.Color = colorBodega;
                excel.Cells[indiceFila, "B"] = "LISTA DE EMPLEADOS";
                excel.Cells[indiceFila, "B"].Interior.Color = colorBodega;
                indiceFila++;
                foreach (DataRow row in dtInfo.Rows)
                {
                    if (row["depto"].ToString() == "ALMACENISTA")
                    {
                        excel.Cells[indiceFila, "A"] = row["subarea"].ToString();
                        excel.Cells[indiceFila, "B"] = row["nombre"].ToString();
                        indiceFila++;
                        totalBodega++;
                    }
                    if (row["depto"].ToString() == "ALMACEN ETIQUETADO")
                    {
                        excel.Cells[indiceFila, "A"] = row["subarea"].ToString();
                        excel.Cells[indiceFila, "B"] = row["nombre"].ToString();
                        indiceFila++;
                        totalBodega++;
                    }

                }
                //Seccion 2

                //Se recupera el renglon donde quedo la impresion
                indiceFila = guardaFinFila;
                //Seccion de encargados
                indiceFila += 2;
                excel.Cells[indiceFila, "D"] = "ENCARGADOS";
                excel.Cells[indiceFila, "D"].Interior.Color = colorEncargados;
                excel.Cells[indiceFila, "E"].Interior.Color = colorEncargados;
                indiceFila++;
                excel.Cells[indiceFila, "D"] = "PUESTO";
                excel.Cells[indiceFila, "D"].Interior.Color = colorEncargados;
                excel.Cells[indiceFila, "E"] = "LISTA DE EMPLEADOS";
                excel.Cells[indiceFila, "E"].Interior.Color = colorEncargados;
                indiceFila++;
                foreach (DataRow row in dtInfo.Rows)
                {
                    if (row["depto"].ToString() == "ENC CAJAS")
                    {
                        excel.Cells[indiceFila, "D"] = row["depto"].ToString();
                        excel.Cells[indiceFila, "E"] = row["nombre"].ToString();
                        indiceFila++;
                        totalOtros++;
                    }
                    if (row["depto"].ToString() == "ENC ALMACEN")
                    {
                        excel.Cells[indiceFila, "D"] = row["depto"].ToString();
                        excel.Cells[indiceFila, "E"] = row["nombre"].ToString();
                        indiceFila++;
                        totalOtros++;
                    }
                    if (row["depto"].ToString() == "GERENTE")
                    {
                        excel.Cells[indiceFila, "D"] = row["depto"].ToString();
                        excel.Cells[indiceFila, "E"] = row["nombre"].ToString();
                        indiceFila++;
                        totalOtros++;
                    }

                }
                //Seccion de OTROS de departamentos
                indiceFila += 2;
                excel.Cells[indiceFila, "D"] = "OTROS DEPARTAMENTOS";
                excel.Cells[indiceFila, "D"].Interior.Color = colorOtrosDeptos;
                excel.Cells[indiceFila, "E"].Interior.Color = colorOtrosDeptos;
                indiceFila++;
                excel.Cells[indiceFila, "D"] = "DEPTO";
                excel.Cells[indiceFila, "D"].Interior.Color = colorOtrosDeptos;
                excel.Cells[indiceFila, "E"] = "LISTA DE EMPLEADOS";
                excel.Cells[indiceFila, "E"].Interior.Color = colorOtrosDeptos;
                indiceFila++;
                //Se imprimen los demas departamentos a exepcion de estas areas
                foreach (DataRow row in dtInfo.Rows)
                {
                    if (row["depto"].ToString() == "ENC CAJAS")
                    {
                        continue;
                    }
                    else if (row["depto"].ToString() == "GERENTE")
                    {
                        continue;
                    }
                    else if (row["depto"].ToString() == "ENC ALMACEN")
                    {
                        continue;
                    }
                    else if (row["depto"].ToString() == "CAJAS")
                    {
                        continue;
                    }
                    else if (row["depto"].ToString() == "HOSTESS")
                    {
                        continue;
                    }
                    else if (row["depto"].ToString() == "VERIFICADOR")
                    {
                        continue;
                    }
                    else if (row["depto"].ToString() == "ASESORA DE VENTA")
                    {
                        continue;
                    }
                    else if (row["depto"].ToString() == "ALMACENISTA")
                    {
                        continue;
                    }
                    else if (row["depto"].ToString() == "ALMACEN ETIQUETADO")
                    {
                        continue;
                    }
                    else
                    {
                        excel.Cells[indiceFila, "D"] = row["depto"].ToString();
                        excel.Cells[indiceFila, "E"] = row["nombre"].ToString();
                        totalOtros++;
                        indiceFila++;

                    }

                }
                //Seccion total de asistencias
                indiceFila += 2;
                excel.Cells[indiceFila, "D"] = "PERSONAL POR AREAS";
                excel.Cells[indiceFila, "D"].Interior.Color = colorEncabezado;
                excel.Cells[indiceFila, "E"].Interior.Color = colorEncabezado;
                indiceFila++;
                excel.Cells[indiceFila, "D"] = "AREA";
                excel.Cells[indiceFila, "D"].Interior.Color = colorSubEncabezado;
                excel.Cells[indiceFila, "E"] = "TOTAL";
                excel.Cells[indiceFila, "E"].Interior.Color = colorSubEncabezado;
                indiceFila++;
                excel.Cells[indiceFila, "D"] = "CAJAS";
                excel.Cells[indiceFila, "E"] = totalCajas;
                indiceFila++;
                excel.Cells[indiceFila, "D"] = "PISO VENTA";
                excel.Cells[indiceFila, "E"] = totalPiso;
                indiceFila++;
                excel.Cells[indiceFila, "D"] = "BODEGA";
                excel.Cells[indiceFila, "E"] = totalBodega;
                indiceFila++;
                excel.Cells[indiceFila, "D"] = "OTROS DEPTOS";
                excel.Cells[indiceFila, "E"] = totalOtros;
                indiceFila++;
                excel.Cells[indiceFila, "D"] = "TOTAL EMPLEADOS";
                excel.Cells[indiceFila, "E"] = totalCajas + totalPiso + totalBodega + totalOtros;



                //Permiten que las columnas del Excel ocupen todo el ancho del texto
                excel.Columns[1].AutoFit();
                excel.Columns[2].AutoFit();
                excel.Columns[3].AutoFit();
                excel.Columns[4].AutoFit();
                excel.Columns[5].AutoFit();
                excel.Visible = true;
            }
            catch (Exception er)
            {
                MensajeError("Error al generar el reporte: "+er.Message);
            }
            
        }
        private void GuardarEmpAreas_Click(object sender, EventArgs e)
        {
            int idObser;
            //Mejorar  este proceso para validar todos los registros
            string resultado = "";
            string resultado2 = "";
            foreach (DataGridViewRow row in dgvPrueba.Rows)
            {
                resultado = NEmpleados.NEditarEmpleadoSubAreas(row.Cells["codigox"].Value.ToString(), Convert.ToInt32(row.Cells["Subareax"].Value), ConexionLoc);
            }


            foreach (DataGridViewRow row in dgvInasistencias.Rows)
            {

                if (row.Cells["ObservInas"].Value == null)
                {
                    resultado2 = NInasistencia.NAgregarInasistencia(row.Cells["codigoInas"].Value.ToString(), dtpFechaini.Value, dtpFechaini.Value, Convert.ToInt32(row.Cells["SubareaInas"].Value), idsucursalactual, "0", ConexionLoc);

                }
                else
                {
                    resultado2 = NInasistencia.NAgregarInasistencia(row.Cells["codigoInas"].Value.ToString(), dtpFechaini.Value, dtpFechaini.Value, Convert.ToInt32(row.Cells["SubareaInas"].Value), idsucursalactual, row.Cells["ObservInas"].Value.ToString(), ConexionLoc);

                }






                //resultado = NEmpleados.NEditarEmpleadoSubAreas(row.Cells["codigox"].Value.ToString(), Convert.ToInt32(row.Cells["Subareax"].Value), ConexionLoc);
            }
            if (resultado.Equals("ok")) this.MensajeOK("Se ingreso correctamente el registro");
            else this.MensajeError(resultado);


            
        }
        private List<subarea> GetSubAreas()
        {
            DataTable dtSubAreas = new DataTable();

            List<subarea> ListArea = new List<subarea>();

            dtSubAreas = NSubAreas.NMostrarSubAreas(ConexionLoc);
            
            foreach (DataRow row in dtSubAreas.Rows)
            {
              
                    subarea objSub = new subarea();

                    objSub.id = Convert.ToInt32(row["idsubarea"].ToString());
                    objSub.nombre = row["nombrearea"].ToString();
                    ListArea.Add(objSub);
                
               
            }

            return ListArea;
        }
        private List<Inasistencias> GetInasistencias()
        {
            return new List<Inasistencias>
            {
                new Inasistencias{Id=0,Tipo="SELECCIONE:"},
                new Inasistencias{Id=2,Tipo="DESCANSO"},
                new Inasistencias{Id=3,Tipo="VACACIONES"},
                new Inasistencias{Id=4,Tipo="PERMISO"},
                new Inasistencias{Id=5,Tipo="INCAPACIDAD"},
                new Inasistencias{Id=6,Tipo="FALTA"}

            };
        }

        private void btInsertarExcepcion_Click(object sender, EventArgs e)
        {
            string codigo = cbxEmpleados.SelectedValue.ToString();
            string depto = "";
            bool existe = false;
            foreach (DataGridViewRow row in dgvInasistencias.Rows)
            {
                if (row.Cells[0].Value.ToString() == codigo)
                {
                    row.Cells[4].Value = tbExcepcion.Text.ToUpper();
                    MensajeOK("Observacion guardada registrado");
                }
            }
        //    if (Convert.ToInt32(cbInacistencias.SelectedValue.ToString()) == 0)
        //    {
        //        MensajeError("Seleccione un estado valido");
        //    }
        //    else if (existe)
        //    {
        //        //MessageBox.Show("Empleado duplicado");
        //        MensajeError("Empleado duplicado");
        //    }
        //    else { 

        //        foreach (DataRow row in dtAuxEmpleadosGral.Rows)
        //        {
        //            if (row["codigo"].ToString() == cbxEmpleados.SelectedValue.ToString())
        //            {
        //                depto = row["depto"].ToString();
        //            }
        //        }
        //    dgvPrueba.Rows.Add(cbxEmpleados.SelectedValue, cbxEmpleados.Text, cbInacistencias.SelectedValue, depto);
        //    MensajeOK("Empleado registrado");
        //}

    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExportarExcel(dgvPrueba);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPrueba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }

    public class subarea
    {
        public int id { get; set; }
        public string nombre { get; set; }
    }

    public class Inasistencias
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
    }

    
}
