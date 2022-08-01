
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

namespace CPresentacion
{
    public partial class frmEmpleados : Form
    {
        frmPrincipal formprincipal = new frmPrincipal();    // Instanciamos el formulario principal

        private bool EsNuevo = false;                       // Registro nuevo
        private bool EsEditar = false;                      // Registro se modificará
        private int counttbxvacios = 0;                     // Variable para validar los campos obligatorios a ingresar
        private int ConexionLoc = 1;                        // Conexion local
        private int ConexionExt = 2;                        // Conexion externa
        private int idsociedad = 1;                         // Id sociedad
        private int activobaja = 0;                         // activos o bajas de los empleados

        private string sucursalactual = "";                 // Sucursal actual
        private int idsucursalactual = 0;                   // Id sucursal actual

        // Variables del empleado
        private int variddepto = 0;
        private int varidhorario = 0;
        private int varidsucursal = 0;
        private string varcodigo = "";
        private string resultadoSQL = "";

        

        private DataTable dtUserLogeado = new DataTable();

        //private int idsucursalempleado = 0;

        public frmEmpleados(DataTable pdtuser)
        {
            InitializeComponent();

            this.ttpMensaje.SetToolTip(this.tbxBuscar, "Ingrese el nombre del empleado a buscar");
            this.ttpMensaje.SetToolTip(this.tbxNombre, "Ingrese el nombre del empleado");
            this.ttpMensaje.SetToolTip(this.tbxApellidos, "Ingrese los apellidos del empleado");
            this.ttpMensaje.SetToolTip(this.cbxDeptos, "Seleccione un departamento");
            this.ttpMensaje.SetToolTip(this.cbxHorarios, "Seleccione un horario");
            this.ttpMensaje.SetToolTip(this.pbxImagen, "Seleccione una imagen, opcional");

            sucursalactual = formprincipal.sucursalactual;
            idsucursalactual = formprincipal.idsucursalactual;
            dtUserLogeado = pdtuser;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            ValidaActivoBaja();
            MostrarEmpleados(1, activobaja, idsucursalactual,varcodigo, "", variddepto, varidhorario);
            HabilitarTbx(false);
            HabilitarBtn();            
            ListarSucursales(cbxSucursales , 1 , idsucursalactual, ConexionLoc);
        }

        /* ---------- Evento de los botones ---------- */

        // Nuevo empleado
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EsNuevo = true;
            EsEditar = false;
            HabilitarBtn();
            LimpiarTbx();
            HabilitarTbx(true);
            tbxCodigo.Focus();
            SeleccionarDepto();
            SeleccionarHorario();
            lblFIngreso.Visible = true;
            lblFIngreso.Text = "Fecha de ingreso: " + DateTime.Now.ToShortDateString();
            this.tbcArticulos.SelectedIndex = 1;
        }

        // Modificar empleado
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.tbxFolio.Text.Equals(""))
            {
                this.EsEditar = true;
                this.HabilitarBtn();
                this.HabilitarTbx(true);
            }
            else this.MensajeError("Seleccione el empleado a modificar");
        }

        // Baja o reactivar empleados 
        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.Rows.Count >= 1)
                {
                    string textopregunta = "";
                    string textoresultado = "";
                    int auxbaja;

                    if (rbnActivo.Checked == true) { textopregunta = "¿Desea desactivar los empleados?"; textoresultado = "Empleado desactivado correctamente"; }
                    if (rbnBaja.Checked == true) { textopregunta = "¿Desea reactivar los empleados?"; textoresultado = "Empleado reactivado correctamente"; }

                    if (ckbbaja.Text == "Baja") { auxbaja = 0; }
                    else { auxbaja = 1; }

                    ValidaActivoBaja();
                    DialogResult opcionpregunta;
                    opcionpregunta = MessageBox.Show(textopregunta, "SiiAsistencias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcionpregunta == DialogResult.OK)
                    {

                        foreach (DataGridViewRow row in dgvEmpleados.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells["coldesactivar"].Value))
                            {
                                resultadoSQL = "";
                                resultadoSQL = NEmpleados.NActivarDesactivarEmpleados(row.Cells["colcodigo"].Value.ToString(), 
                                                                                      auxbaja, 
                                                                                      ConexionLoc);

                                if (resultadoSQL.Equals("ok")) this.MensajeOK(textoresultado);
                                else this.MensajeError(resultadoSQL);
                            }
                        }
                        MostrarEmpleados(1, activobaja, idsucursalactual, varcodigo, "", variddepto, varidhorario);
                        ckbbaja.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // Imprimir empleados
        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        // Buscar empleados
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Buscarxnombre();
        }

        // Guardar empleados  
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ValidaCampos();
            //    if (validatbxvacios >= 0) MensajeError("Faltan ingresar algunos datos, serán remarcados");
            //    else
            //    {
            //        if (this.EsNuevo == true) AgregarEmpleados();
            //        else ModificarEmpleado();

            //        EsNuevo = false;
            //        EsEditar = false;
            //        HabilitarBtn();
            //        Template = null;
            //        LimpiarTbx();
            //        MostrarEmpleados(opcion, idsucursalactual, 1);
            //        this.tbcArticulos.SelectedIndex = 0;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
        }

        // Cancelar registro
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //this.EsEditar = false;
            //this.EsNuevo = false;
            //this.HabilitarBtn();
            //this.HabilitarTbx(false);
            //this.LimpiarTbx();
            //this.eprError.Clear();
            //this.lblFIngreso.Visible = false;
            //this.lblFModificacion.Visible = false;
            //this.tbcArticulos.SelectedIndex = 0;            
        }

        // Capturar huella
        private void btnHuella_Click(object sender, EventArgs e)
        {
            //CapturarHuella capturar = new CapturarHuella();
            //capturar.OnTemplate += this.OnTemplate;
            //capturar.ShowDialog();
        }

        // Agregar foto
        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            //OpenFileDialog explorador = new OpenFileDialog();
            //DialogResult resultado = explorador.ShowDialog();

            //if (resultado == DialogResult.OK)
            //{
            //    this.pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            //    this.pbxImagen.Image = Image.FromFile(explorador.FileName);
            //}
        }

        // Eliminar foto
        private void btnEliminarImg_Click(object sender, EventArgs e)
        {
            //this.pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            //this.pbxImagen.Image = global::CPresentacion.Properties.Resources.sin_imagen;
        }

        // Activa las opciones de sincronizacion
        private void btnActivar_Click(object sender, EventArgs e)
        {
            //if (tbxFolio.Text != string.Empty)
            //{
            //    cbxSucursal.Enabled = true;
            //    btnAceptar.Enabled = true;
            //    cbxSucursal.DataSource = NSucursales.NMostrarSucursales(1,1,ConexionLoc);
            //    cbxSucursal.ValueMember = "idsucursal";
            //    cbxSucursal.DisplayMember = "sucursal";
            //}
            //else
            //{
            //    MessageBox.Show("No se puede sincronizar empleado sin antes seleccionarlo");
            //}
        }

        // Sincroniza el empleado con la sucursal seleccionada
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int idsucursalsync;
            //    string resultado = "";
            //    int tienehuella = 0;
            //    int activo = 0;
            //    int pinactivo = 0;

            //    System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //    this.pbxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //    byte[] imagen = ms.GetBuffer();
            //    if (ckbActivo.Checked == true) activo = 1;
            //    if (ckbHuella.Checked == true) tienehuella = 1;
            //    if (ckbPin.Checked == true) pinactivo = 1;
            //    ValoresDiasDescansos();
                
            //    idsucursalsync = Convert.ToInt32(cbxSucursal.SelectedValue);

            //    DataTable dtconsuc = NSucursales.NMostrarSucursales(2, idsucursalsync, ConexionLoc); // almacena los datos de la sucursal seleccionada

            //    // actualizamos los parametros para la conexion externa
            //    resultado = NConexion.NConexionExt(dtconsuc.Rows[0]["dirhost"].ToString(),
            //                                       dtconsuc.Rows[0]["basedatos"].ToString(),
            //                                       dtconsuc.Rows[0]["usuario"].ToString(),
            //                                       dtconsuc.Rows[0]["contrasena"].ToString(),
            //                                       dtconsuc.Rows[0]["puerto"].ToString());

            //    DataTable dtempsyn = NEmpleados.NMostrarEmpleadosDetalles(4, 1, 1, idsucursalactual, this.tbxCodigo.Text.Trim(),
            //        "",variddepto, varidhorario, ConexionLoc); // verificamos si el empleado ya existe
                
            //    if (dtempsyn.Rows.Count == 0)
            //    {
            //        DataTable dtfinger = NHuellas.NBuscarxCodigo(this.tbxCodigo.Text.Trim()); // obtenemos la huella del empleado

            //        resultado = NEmpleados.NAgregarEmpleados(this.tbxCodigo.Text.Trim(),
            //                                                 this.tbxNombre.Text.Trim().ToUpper(),
            //                                                 this.tbxApellidos.Text.Trim().ToUpper(),
            //                                                 variddepto,
            //                                                 varidhorario,
            //                                                 imagen,
            //                                                 activo,
            //                                                 tienehuella,
            //                                                 idsucursalempleado,
            //                                                 ndescansos,
            //                                                 descansos.ToUpper().Trim(),
            //                                                 pinactivo,
            //                                                 this.tbxPin.Text.Trim(),
            //                                                 fechaingresoemp,
            //                                                 fechamodificaemp,
            //                                                 ConexionExt);
            //        MessageBox.Show(resultado.ToString());

            //        byte[] huella = (byte[])dtfinger.Rows[0]["finger"]; // guardamos la huella en la variable huella
            //        resultado = NHuellas.NAgregarHuellasExt(Convert.ToInt32(resultado), this.tbxCodigo.Text.Trim(), huella);

            //        if (resultado.Equals("ok")) this.MensajeOK("Empleado sincronizado correctamente");
            //        else this.MensajeError(resultado);
            //    }
            //    else
            //    {   
            //        if(Convert.ToDateTime(dtempsyn.Rows[0]["fmodifica"]) != fechamodificaemp)
            //        {
            //            DialogResult DialogoOpcion;
            //            DialogoOpcion = MessageBox.Show("El registro ya se encuentra sincronizado, ¿Desea actualizarlo?", "SiiAsistencias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //            if (DialogoOpcion == DialogResult.OK)
            //            {
            //                if (ckbActivo.Checked == true) activo = 1;
            //                if (ckbHuella.Checked == true) tienehuella = 1;
            //                if (ckbPin.Checked == true) pinactivo = 1;
            //                ValoresDiasDescansos();

            //                resultado = NEmpleados.NEditarEmpleados(this.tbxCodigo.Text.Trim(),
            //                                                        this.tbxNombre.Text.Trim().ToUpper(),
            //                                                        this.tbxApellidos.Text.Trim().ToUpper(),
            //                                                        Convert.ToInt32(this.cbxDeptos.SelectedValue),
            //                                                        Convert.ToInt32(this.cbxHorarios.SelectedValue),
            //                                                        foto,
            //                                                        activo,
            //                                                        tienehuella,
            //                                                        ndescansos,
            //                                                        descansos.ToUpper().Trim(),
            //                                                        pinactivo,
            //                                                        this.tbxPin.Text.Trim(),
            //                                                        DateTime.Now,
            //                                                        idsucursalempleado,
            //                                                        ConexionExt);                                
                            
            //                if (resultado.Equals("ok")) this.MensajeOK("Se modifico correctamente el registro");
            //                else this.MensajeError(resultado);
            //            }                            
            //        }
            //        else this.MensajeError("El empleado ya se encuentra sincronizado y actualizado");
            //        cbxSucursal.Text = string.Empty;
            //        this.tbpMantenimiento.Focus();
            //    }
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }

            //cbxSucursal.Enabled = false;
            //btnAceptar.Enabled = false;
        }

        /* ---------- Otros eventos ---------- */

        // Doble click sobre las filas del datagrid
        private void dgvEmpleados_DoubleClick(object sender, EventArgs e)
        {
            //if(dgvEmpleados.Rows.Count > 0)
            //{
            //    SeleccionarDepto();
            //    SeleccionarHorario();

            //    this.tbxFolio.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["idempleados"].Value);
            //    this.tbxCodigo.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["codigo"].Value);
            //    this.tbxNombre.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["nombre"].Value);
            //    this.tbxApellidos.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["apellidos"].Value);
            //    this.cbxDeptos.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["depto"].Value);
            //    this.cbxHorarios.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["horario"].Value);

            //    int activo = Convert.ToInt32(this.dgvEmpleados.CurrentRow.Cells["activo"].Value);
            //    if (activo == 1) ckbActivo.Checked = true; else ckbActivo.Checked = false;

            //    int thuella = Convert.ToInt32(this.dgvEmpleados.CurrentRow.Cells["tienehuella"].Value);
            //    if (thuella == 1) ckbHuella.Checked = true;

            //    byte[] imagenbuffer = (byte[])this.dgvEmpleados.CurrentRow.Cells["foto"].Value;
            //    System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenbuffer);
            //    this.pbxImagen.Image = Image.FromStream(ms);
            //    pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            //    string dias = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["numerodias"].Value);
            //    ObtenerDias(dias);

            //    this.idd = Convert.ToInt32(this.dgvEmpleados.CurrentRow.Cells["iddepto"].Value);
            //    this.idh = Convert.ToInt32(this.dgvEmpleados.CurrentRow.Cells["idhorario"].Value);

            //    int pinactivo = Convert.ToInt32(this.dgvEmpleados.CurrentRow.Cells["pinactivo"].Value);
            //    if (pinactivo == 1) ckbPin.Checked = true;

            //    this.tbxPin.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["pin"].Value);

            //    idsucursalempleado = Convert.ToInt32(this.dgvEmpleados.CurrentRow.Cells["idsucursal"].Value);

            //    this.lblFIngreso.Visible = true;
            //    fechaingresoemp = Convert.ToDateTime(this.dgvEmpleados.CurrentRow.Cells["fechaingreso"].Value.ToString());
            //    this.lblFIngreso.Text = "Fecha de ingreso: " + fechaingresoemp.ToShortDateString();

            //    this.lblFModificacion.Visible = true;
            //    fechamodificaemp = Convert.ToDateTime(this.dgvEmpleados.CurrentRow.Cells["fechamodifica"].Value.ToString());
            //    this.lblFModificacion.Text = "Fecha de modificación: " + fechamodificaemp.ToShortDateString();

            //    this.tbcArticulos.SelectedIndex = 1;
            //}            
        }

        // CheckBox que habilita la columna para marcar los registros a desactivar/activar. 
        private void cbxEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbbaja.Checked)
            {
                this.dgvEmpleados.Columns[0].Visible = true;

                LimpiarTbx();
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnImprimir.Enabled = false;
            }
            else
            {
                this.dgvEmpleados.Columns[0].Visible = false;
                HabilitarBtn();
            }
        }

        // Permite marcar filas a eliminar
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmpleados.Columns["coldesactivar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvEmpleados.Rows[e.RowIndex].Cells["coldesactivar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        // Textbox buscar
        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            //Buscarxnombre();
        }

        // Permite solo numeros para el pin
        private void tbxPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }

            //else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }

            //else { e.Handled = true; }
        }

        // valida si RadioButton de activos cambia de estado
        private void rbnActivo_CheckedChanged(object sender, EventArgs e)
        {
            idsucursal = Convert.ToInt32(cbxSucursales.SelectedValue);
            if (idsucursal > 0) { opcion = 3; }
            else { opcion = 1; }

            ValidaActivoBaja();
            MostrarEmpleados(opcion, idsucursal, baja);
            OcultarColumnas();
            ckbbaja.Checked = false;
        }

        // valida si RadioButton de baja cambia de estado
        private void rbnBaja_CheckedChanged(object sender, EventArgs e)
        {
            //idsucursal = Convert.ToInt32(cbxSucursales.SelectedValue);
            //if (idsucursal > 0) { opcion = 3; }
            //else { opcion = 1; }

            //ValidaActivoBaja();
            //MostrarEmpleados(opcion, idsucursal, baja);
            //OcultarColumnas();
            //ckbbaja.Checked = false;
        }

        // Saber si cambiamos de sucursal para mostrar los empleados
        private void cbxSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbxSucursales.SelectedValue != null)
            //{
            //    idsucursal = Convert.ToInt32(cbxSucursales.SelectedValue);
            //    if(idsucursal > 0) { opcion = 3; }
            //    else { opcion = 1; }

            //    ValidaActivoBaja();
            //    MostrarEmpleados(opcion, idsucursal, baja);
            //}
        }




        

        

        

        

        

        /* ---------- Métodos y funciones ---------- */
        // Mensaje de OK
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
            //tbxBuscar.Text = string.Empty;
            //tbxFolio.Text = string.Empty;
            //tbxCodigo.Text = string.Empty;
            //tbxNombre.Text = string.Empty;
            //tbxApellidos.Text = string.Empty;
            //ckbActivo.Checked = true;
            //ckbHuella.Checked = false;
            //cbxDeptos.Text = string.Empty;
            //cbxHorarios.Text = string.Empty;
            //this.pbxImagen.Image = global::CPresentacion.Properties.Resources.sin_imagen;
            //ckblun.Checked = false;
            //ckbmar.Checked = false;
            //ckbmie.Checked = false;
            //ckbjue.Checked = false;
            //ckbvie.Checked = false;
            //ckbsab.Checked = false;
            //ckbdom.Checked = false;
            //ckbPin.Checked = false;
            //tbxPin.Text = string.Empty;
        }

        // Habilitar los textbox
        private void HabilitarTbx(bool valor)
        {
            tbxNombre.ReadOnly = !valor;
            tbxApellidos.ReadOnly = !valor;
            tbxCodigo.ReadOnly = !valor;
            cbxDeptos.Enabled = valor;
            cbxHorarios.Enabled = valor;
            ckbActivo.Enabled = valor;
            ckblun.Enabled = valor;
            ckbmar.Enabled = valor;
            ckbmie.Enabled = valor;
            ckbjue.Enabled = valor;
            ckbvie.Enabled = valor;
            ckbsab.Enabled = valor;
            ckbdom.Enabled = valor;
            ckbPin.Enabled = valor;
            tbxPin.ReadOnly = !valor;
        }

        // Habilitar los botones
        private void HabilitarBtn()
        {
            if (this.EsNuevo || this.EsEditar)
            {
                HabilitarTbx(true);
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnBaja.Enabled = false;
                btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;
                btnAgregarImg.Enabled = true;
                btnEliminarImg.Enabled = true;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                HabilitarTbx(false);
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnBaja.Enabled = true;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                btnAgregarImg.Enabled = false;
                btnEliminarImg.Enabled = false;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        

        // Mostrar los registros
        private void MostrarEmpleados(int popcion, int pactivo, int pidsucursal, string pcodigo, string pnombre, int piddepto, 
            int idhorario)
        {
            dgvEmpleados.DataSource = NEmpleados.NMostrarEmpleadosDetalles(popcion,
                                                                           idsociedad,
                                                                           pactivo,
                                                                           pidsucursal,
                                                                           pcodigo,
                                                                           pnombre,
                                                                           piddepto,
                                                                           idhorario,
                                                                           ConexionLoc);
            if (dgvEmpleados != null)
            {
                OcultarColumnas();
                lblRegistros.Text = "No. de empleados: " + Convert.ToString(dgvEmpleados.Rows.Count);
                ColorFila(dgvEmpleados);
                dgvEmpleados.ClearSelection();
            }
        }

        // Ocultar columnas
        private void OcultarColumnas()
        {
            dgvEmpleados.Columns["coldesactivar"].Visible = false;
            dgvEmpleados.Columns["nombrecompleto"].Visible = false;
            dgvEmpleados.Columns["iddepto"].Visible = false;
            dgvEmpleados.Columns["idhorario"].Visible = false;
            dgvEmpleados.Columns["horario"].Visible = false;
            dgvEmpleados.Columns["foto"].Visible = false;
            dgvEmpleados.Columns["descansos"].Visible = false;
            dgvEmpleados.Columns["activo"].Visible = false;
            dgvEmpleados.Columns["estadoreg"].Visible = false;
            dgvEmpleados.Columns["fultimoreg"].Visible = false;
            dgvEmpleados.Columns["idsociedad"].Visible = false;
            dgvEmpleados.Columns["idsucursal"].Visible = false;
            dgvEmpleados.Columns["pin"].Visible = false;
        }

        public void ColorFila(DataGridView pDataGrid)
        {
            pDataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
            pDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        // Agregar empleados
        private void AgregarEmpleados()
        {
            //string resultado = "";
            //int tienehuella = 0;
            //int activo = 0;
            //int pinactivo = 0;
            //idsucursal = principal.idsucursalactiva;
            //string txtsucursal = principal.sucursalactiva;

            //if (dtUserLogeado.Rows[0]["tipo"].ToString() == "ADMINISTRADOR" || dtUserLogeado.Rows[0]["tipo"].ToString() == "SUPERVISOR")
            //{
            //    if(cbxSucursales.Text == "SELECCIONE:") { idsucursal = principal.idsucursalactiva; }
            //    else { idsucursal = Convert.ToInt32(cbxSucursales.SelectedIndex + 1); txtsucursal = cbxSucursales.Text; }
            //}

            //DialogResult opnpresuc;
            //opnpresuc = MessageBox.Show("¿Se agregará el empleado a la sucursal " + txtsucursal + "?", "SiiAsistencias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (opnpresuc == DialogResult.OK)
            //{
            //    System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //    this.pbxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //    byte[] imagen = ms.GetBuffer();

            //    if (ckbActivo.Checked == true) activo = 1;
            //    if (ckbHuella.Checked == true) tienehuella = 1;
            //    if (ckbPin.Checked == true) pinactivo = 1;

            //    ValoresDiasDescansos();

            //    resultado = NEmpleados.NAgregarEmpleados(this.tbxCodigo.Text.Trim(),
            //                                             this.tbxNombre.Text.Trim().ToUpper(),
            //                                             this.tbxApellidos.Text.Trim().ToUpper(),
            //                                             Convert.ToInt32(this.cbxDeptos.SelectedValue),
            //                                             Convert.ToInt32(this.cbxHorarios.SelectedValue),
            //                                             imagen,
            //                                             activo,
            //                                             tienehuella,
            //                                             idsucursal,
            //                                             ndescansos,
            //                                             descansos.ToUpper().Trim(),
            //                                             pinactivo,
            //                                             this.tbxPin.Text.Trim(),
            //                                             DateTime.Now,
            //                                             DateTime.Now);
            //    if (ckbHuella.Checked == true)
            //    {
            //        byte[] huella = Template.Bytes; // guardamos la huella en la variable huella
            //        resultado = NHuellas.NAgregarHuellas(Convert.ToInt32(resultado),
            //                                             this.tbxCodigo.Text.Trim(),
            //                                             huella);
            //    }
            //    if (resultado.Equals("ok")) this.MensajeOK("Se ingreso correctamente el registro");
            //    else this.MensajeError(resultado);
            //} 
        }

        // Modificar empleados
        private void ModificarEmpleado()
        {

            //string resultado = "";
            //int tienehuella = 0;
            //int activo = 0;
            //int pinactivo = 0;
            //idsucursal = principal.idsucursalactiva;

            //if (ckbActivo.Checked == true) activo = 1;
            //if (ckbHuella.Checked == true) tienehuella = 1;
            //if (ckbPin.Checked == true) pinactivo = 1;

            //if (ckbModificaSucursal.Checked == true)
            //{
            //    if(cbxSucursal.Text != "SELECCIONE:")
            //    {
            //        idsucursal = cbxSucursal.SelectedIndex + 1;
            //    }
            //}

            //ValoresDiasDescansos();
            //byte[] huella;

            //if (tienehuella == 1)
            //{
            //    resultado = NEmpleados.NEditarEmpleados(Convert.ToInt32(this.tbxFolio.Text),
            //                                                        this.tbxCodigo.Text.Trim(),
            //                                                        this.tbxNombre.Text.Trim().ToUpper(),
            //                                                        this.tbxApellidos.Text.Trim().ToUpper(),
            //                                                        Convert.ToInt32(this.cbxDeptos.SelectedValue),
            //                                                        Convert.ToInt32(this.cbxHorarios.SelectedValue),
            //                                                        activo,
            //                                                        tienehuella,
            //                                                        ndescansos,
            //                                                        descansos.ToUpper().Trim(),
            //                                                        pinactivo,
            //                                                        this.tbxPin.Text.Trim(),
            //                                                        DateTime.Now,
            //                                                        idsucursal);
            //    if (Template != null)
            //    {
            //        huella = Template.Bytes; // guardamos la huella en la variable huella
            //        resultado = NHuellas.NAgregarHuellas(Convert.ToInt32(this.tbxFolio.Text),
            //                                             this.tbxCodigo.Text.Trim(),
            //                                             huella);
            //    }
            //}
            //else
            //{
            //    resultado = NEmpleados.NEditarEmpleados(Convert.ToInt32(this.tbxFolio.Text),
            //                                                        this.tbxCodigo.Text.Trim(),
            //                                                        this.tbxNombre.Text.Trim().ToUpper(),
            //                                                        this.tbxApellidos.Text.Trim().ToUpper(),
            //                                                        Convert.ToInt32(this.cbxDeptos.SelectedValue),
            //                                                        Convert.ToInt32(this.cbxHorarios.SelectedValue),
            //                                                        activo,
            //                                                        tienehuella,
            //                                                        ndescansos,
            //                                                        descansos.ToUpper().Trim(),
            //                                                        pinactivo,
            //                                                        this.tbxPin.Text.Trim(),
            //                                                        DateTime.Now,
            //                                                        idsucursal);
            //}
            //if (resultado.Equals("ok")) this.MensajeOK("Se modifico correctamente el registro");
            //else this.MensajeError(resultado);
        }

        // Buscar por nombre
        private void Buscarxnombre()
        {
            //dgvEmpleados.DataSource = NEmpleados.NMostrarEmpleados(4, idsociedad, idsucursal, 1, tbxBuscar.Text);
            //OcultarColumnas();
            //lblRegistros.Text = "No. de registros: " + Convert.ToString(dgvEmpleados.Rows.Count);
        }

        // Llenar el combobox de departamentos
        private void SeleccionarDepto()
        {
            cbxDeptos.DataSource = NDeptos.NMostrarDeptos(ConexionLoc);
            cbxDeptos.ValueMember = "iddepto";
            cbxDeptos.DisplayMember = "nombre";
        }

        // Llenar el combobox de horarios
        private void SeleccionarHorario()
        {
            cbxHorarios.DataSource = NHorarios.NMostrarHorarios(ConexionLoc);
            cbxHorarios.ValueMember = "idhorario";
            cbxHorarios.DisplayMember = "detalle";
        }

        // Validar campos llenos
        //private int ValidaCampos()
        //{
        //    //eprError.Clear();
        //    //validatbxvacios = 0;
        //    //if (this.tbxCodigo.Text == string.Empty)
        //    //{ eprError.SetError(tbxCodigo, "Ingrese el número de empleado"); validatbxvacios++; }

        //    //if (this.tbxNombre.Text == string.Empty)
        //    //{ eprError.SetError(tbxNombre, "Ingrese el nombre del empleado"); validatbxvacios++; }

        //    //if (this.tbxApellidos.Text == string.Empty)
        //    //{ eprError.SetError(tbxApellidos, "Ingrese los apellidos del empleado"); validatbxvacios++; }

        //    //if (this.cbxDeptos.Text == string.Empty)
        //    //{ eprError.SetError(cbxDeptos, "Seleccione el departamento del empleado"); validatbxvacios++; }

        //    //if (this.cbxHorarios.Text == string.Empty)
        //    //{ eprError.SetError(cbxHorarios, "Seleccione el horario del empleado"); validatbxvacios++; }

        //    //else { validatbxvacios--; }

        //    //return validatbxvacios;
        //}

        // Captura de la huella
        //private void OnTemplate(DPFP.Template template)
        //{
        //    this.Invoke(new Function(delegate ()
        //    {
        //        Template = template;
        //        if (Template != null)
        //        {
        //            MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
        //            ckbHuella.Checked = true;
        //            auxhuella = 1;
        //        }
        //        else
        //        {
        //            MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
        //        }
        //    }));
        //}

        // dias de descansos
        private void ValoresDiasDescansos()
        {
            //descansos = string.Empty;
            //ndescansos = string.Empty;
            
            //if (ckblun.Checked == true)
            //{ descansos = "lunes/"; ndescansos = "1"; }                
            //if (ckbmar.Checked == true)
            //{ descansos = descansos + "martes/";    ndescansos = ndescansos + "2"; }
            //if (ckbmie.Checked == true)
            //{ descansos = descansos + "miercoles/"; ndescansos = ndescansos + "3"; }                
            //if (ckbjue.Checked == true)
            //{ descansos = descansos + "jueves/";    ndescansos = ndescansos + "4"; }
            //if (ckbvie.Checked == true)
            //{ descansos = descansos + "viernes/";   ndescansos = ndescansos + "5"; }
            //if (ckbsab.Checked == true)
            //{ descansos = descansos + "sabado/";    ndescansos = ndescansos + "6"; }
            //if (ckbdom.Checked == true)
            //{ descansos = descansos + "domingo/";   ndescansos = ndescansos + "0"; }
        }

        // Obtener los dias para marcar los checkbox
        private void ObtenerDias(string pnumerodescansos)
        {
            //for (int i = 0; i < pnumerodescansos.Length; i++)
            //{
            //    int aux = Convert.ToInt32(pnumerodescansos.Substring(i, 1));
            //    if (aux == 1) ckblun.Checked = true;
            //    if (aux == 2) ckbmar.Checked = true;
            //    if (aux == 3) ckbmie.Checked = true;
            //    if (aux == 4) ckbjue.Checked = true;
            //    if (aux == 5) ckbvie.Checked = true;
            //    if (aux == 6) ckbsab.Checked = true;
            //    if (aux == 0) ckbdom.Checked = true;
            //}
        } 

        //Validacion de activos o baja
        public void ValidaActivoBaja()
        {
            if(rbnActivo.Checked == true) { activobaja = 1; ckbbaja.Text = "Baja"; btnBaja.Text = "Baja"; }
            if(rbnBaja.Checked == true) { activobaja = 0; ckbbaja.Text = "Reactivar"; btnBaja.Text = "Reactivar"; }
        }

        //Mostrar las sucursales
        public void ListarSucursales(ComboBox pcombo, int popcion, int pidsucursal, int popconexion)
        {
            DataTable dtsucursal = new DataTable();
            dtsucursal.Columns.Add("idsucursal", typeof(int));
            dtsucursal.Columns.Add("sucursal", typeof(string));
            dtsucursal.Rows.Add(0, "SELECCIONE:");

            DataTable dt = NSucursales.NMostrarSucursales(popcion, pidsucursal, popconexion);
            dtsucursal.Merge(dt);
            pcombo.ValueMember = "idsucursal";
            pcombo.DisplayMember = "sucursal";
            pcombo.DataSource = dtsucursal;
            pcombo.SelectedIndex = 0;
        }

        private void ckbModificaSucursal_CheckedChanged(object sender, EventArgs e)
        {
            //if(ckbModificaSucursal.Checked == true)
            //{
            //    cbxSucursal.Enabled = true;
            //    ListarSucursales(cbxSucursal);
                
            //}
            //else
            //{
            //    cbxSucursal.Enabled = false;
            //}
        }
    }
}
