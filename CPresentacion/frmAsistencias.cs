using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;

namespace CPresentacion
{
    public partial class frmAsistencias : CaptureForm
    {
        frmPrincipal principal = new frmPrincipal();            // Instancia al formulario principal

        private DPFP.Template Template;                         // Almacenará el template, la huella
        private DPFP.Verification.Verification Verificator;     // Almacenará el resultado de la veridicacion
        private Form currentForm;                               // Formulario actual        
        private string sucursal = string.Empty;                 // Nombre de la sucursal actual
        private int idsucursal = 0;                             // Id de la sucursal actual
        string codigo = string.Empty;                           // Almacenará el codigo del empleado

        DataTable dthuellas = new DataTable();                  // DataTable donde se almacenaran la huellas

        private int ConexionLoc = 1;
        private int ConexionExt = 2;

        public frmAsistencias()
        {
            InitializeComponent();
            this.ttpMensaje.SetToolTip(this.gbxES, "Selecciones una opción en caso de registrar entrada o salida en otra sucursal");
            sucursal = principal.sucursalactual;
            idsucursal = principal.idsucursalactual;
        }

        private void frmAsistencias_Load(object sender, EventArgs e)
        {
            dthuellas = NHuellas.NMostrarHuellas(1, "", ConexionLoc);
            pictureBox1.Focus();
        }

        /* ---------- EVENTOS ---------- */
        
        // Quita la selección de los radiobutton
        private void btnES_Click(object sender, EventArgs e) { ValidaES(); }

        // Activo la opción de registrar por pin
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int auxtiporeg = 0;
            if (rbnEntrada.Checked == true) { auxtiporeg = 1; }
            else if (rbnSalida.Checked == true) { auxtiporeg = 2; }
            else if (rbnEntradaVisita.Checked == true) { auxtiporeg = 3; }
            else if (rbnSalidaVisita.Checked == true) { auxtiporeg = 4; }

            this.Enabled = false;
            frmAsistenciasPin AsistenciasPin = new frmAsistenciasPin(auxtiporeg);
            AsistenciasPin.ShowDialog();
            ValidaES();
            this.Enabled = true;
        }

        /* ---------- EVENTOS DEL SDK DEL LECTOR ---------- */

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de Huella Digital";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        protected override void Process(DPFP.Sample Sample)
        {
            Control.CheckForIllegalCrossThreadCalls = false; // Cancelamos la excepciones de subprocesos
            codigo = string.Empty;
            timer1.Stop(); 
            this.pnlMensaje.Controls.Clear();
            pnlMensaje.Visible = false;

            bool estaAbierto = detectarFormularioAbierto("frmAsistenciasPin");
            if(estaAbierto == false)
            {
                base.Process(Sample);
                // Process the sample and create a feature set for the enrollment purpose.
                DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
                // Check quality of the sample and start verification if it's good
                // TODO: move to a separate task
                if (features != null)
                {
                    // Compare the feature set with our template
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                    DPFP.Template template = new DPFP.Template();
                    Stream stream;

                    byte[] huella = features.Bytes;
                    //DataTable tabla = NHuellas.NMostrarHuellas();
                    int idempleado = 0;

                    for (int i = 0; i < dthuellas.Rows.Count; i++)
                    {
                        byte[] raw = (byte[])dthuellas.Rows[i]["finger"];
                        stream = new MemoryStream();
                        stream = new MemoryStream(raw);
                        template = new DPFP.Template(stream);
                        Verificator.Verify(features, template, ref result);
                        UpdateStatus(result.FARAchieved);
                        if (result.Verified)
                        {
                            codigo = dthuellas.Rows[i]["codigo"].ToString();
                            MakeReport("The fingerprint was VERIFIED. " + idempleado.ToString());
                            break;
                        }
                    }
                    // Empleado encontrado
                    if (codigo != string.Empty)
                    {
                        DataTable dtEmpleado = NEmpleados.NMostrarEmpleadosVerificados(1, codigo, "", ConexionLoc); //Almacenamos los campos a utilizar del empleado
                        IngresarAsistencia(dtEmpleado);
                    }
                    // Empleado no encontrado
                    else
                    {
                        AbrirFormularioInt(new frmMensajeAsistencias(0, "", ""));
                        pnlMensaje.Visible = true;
                    }
                }
            }            
            timer1.Interval = 5000;
            timer1.Start();
            timer1.Tick += (psender, pe) => { timer1.Stop(); pnlMensaje.Visible = false; };
            ValidaES();   
        }

        /* ---------- METODOS Y FUNCIONES ---------- */

        // Registrar asistencias
        public void IngresarAsistencia(DataTable pdtempleado)
        {
            DataTable dtEmpleado = pdtempleado;                                                     // Datos del empleado verificado

            // Asignacion de los campos del DT a variables
            //int idempleado = Convert.ToInt32(dtEmpleado.Rows[0]["idempleado"]);                     //idempleado
            string codigo = dtEmpleado.Rows[0]["codigo"].ToString();                                //Codigo
            string nombre = dtEmpleado.Rows[0]["nombrecompleto"].ToString();                        //nombre
            int estado = Convert.ToInt32(dtEmpleado.Rows[0]["estadoreg"]);                            //estado
            int tol = Convert.ToInt32(dtEmpleado.Rows[0]["tolerancia"]);                            //tolerancia
            DateTime hrentrada = Convert.ToDateTime(dtEmpleado.Rows[0]["hrentrada"].ToString());    //hora entrada
            DateTime hrsalida = Convert.ToDateTime(dtEmpleado.Rows[0]["hrsalida"].ToString());      //hora salida
            DateTime fultimoreg = Convert.ToDateTime(dtEmpleado.Rows[0]["fecha"].ToString());       //fecha ultimo registro 
            DateTime hultimoreg = Convert.ToDateTime(dtEmpleado.Rows[0]["hora"].ToString());        //fecha ultimo registro 
            DateTime timenow = DateTime.Now;                                                        //horaactual       
            DateTime tolerancia = new DateTime(hrentrada.Year, hrentrada.Month, hrentrada.Day, hrentrada.Hour, tol, 00);

            // Comparaciones de las hora entrada y salida con la hr actual
            int comparahrentrada = DateTime.Compare(timenow, hrentrada);
            int comparatolerancia = DateTime.Compare(timenow, tolerancia);
            int comparahrsalida = DateTime.Compare(timenow, hrsalida);

            string resultado = "";
            string resultado1 = "";
            int actualizaestado = 0;
            int mensaje = 0;

            var auxfultimoreg = fultimoreg.ToShortDateString();
            var auxfahora = timenow.ToShortDateString();

            try
            {
                // Valida si esta seleccionada la opcion de entrada
                if (rbnEntrada.Checked == true)
                {
                    actualizaestado = 1;                    
                    if (comparahrentrada <= 0)  mensaje = 1;                                // Antes de la HR de entrada
                    else if (comparahrentrada > 0 && comparatolerancia <= 0)  mensaje = 2;  // Durante la tolerancia
                    else  mensaje = 3;                                                      // Despues de la HR de entrada

                    resultado = NRegistros.NAgregarRegistros(codigo, timenow, actualizaestado, idsucursal, ConexionLoc);
                    resultado1 = NEmpleados.NActualizarEmpleadosAsistencia(codigo, actualizaestado, Convert.ToDateTime(auxfahora), ConexionLoc);
                }
                // Valida si esta seleccionada la opcion de salida
                else if (rbnSalida.Checked == true)
                {
                    actualizaestado = 2;
                    if (comparahrsalida < 0) mensaje = 4;       // Despues de la HR de salida
                    else mensaje = 5;                           // Antes de la HR de salida

                    resultado = NRegistros.NAgregarRegistros(codigo, timenow, actualizaestado, idsucursal, ConexionLoc);
                    resultado1 = NEmpleados.NActualizarEmpleadosAsistencia(codigo, 0, Convert.ToDateTime(auxfahora), ConexionLoc);
                }
                // Valida si esta seleccionada la opcion de entrada visita
                else if (rbnEntradaVisita.Checked == true)
                {
                    actualizaestado = 3;
                    mensaje = 6;
                    resultado = NRegistros.NAgregarRegistros(codigo, timenow, actualizaestado, idsucursal, ConexionLoc);
                }
                // Valida si esta seleccionada la opcion de salida visita
                else if (rbnSalidaVisita.Checked == true)
                {
                    actualizaestado = 4;
                    mensaje = 7;
                    resultado = NRegistros.NAgregarRegistros(codigo, timenow, actualizaestado, idsucursal, ConexionLoc);
                }
                // Valida la fecha del ultimo registro
                else if (auxfultimoreg == auxfahora)
                {
                    DateTime sumarminutos = hultimoreg.AddMinutes(30);
                    int comparareg = DateTime.Compare(timenow, sumarminutos);

                    // Registro anterior en caso de que no hallan pasado menos de 30 min
                    if (comparareg == -1)
                    {
                        DataTable dtRegContinuos = NRegistros.NMostrarRegistros(6, 1, DateTime.Now, DateTime.Now, 1, codigo, 1, ConexionLoc);

                        if (Convert.ToInt32(dtRegContinuos.Rows[0]["idestado"]) == 1) mensaje = 1;
                        else mensaje = 4;

                        timenow = Convert.ToDateTime(dtRegContinuos.Rows[0]["fechahorareg"].ToString());
                    }
                    else
                    {
                        if(estado == 0)
                        {
                            actualizaestado = 1;
                            if (comparahrentrada <= 0) mensaje = 1;                                // Antes de la HR de entrada
                            else if (comparahrentrada > 0 && comparatolerancia <= 0) mensaje = 2;  // Durante la tolerancia
                            else mensaje = 3;                                                      // Despues de la HR de entrada

                            resultado = NRegistros.NAgregarRegistros(codigo, timenow, actualizaestado, idsucursal, ConexionLoc);
                            resultado1 = NEmpleados.NActualizarEmpleadosAsistencia(codigo, actualizaestado, DateTime.Now, ConexionLoc);
                        }
                        else
                        {
                            actualizaestado = 2;
                            if (comparahrsalida < 0) mensaje = 4;       // Despues de la HR de salida
                            else mensaje = 5;                           // Antes de la HR de salida

                            resultado = NRegistros.NAgregarRegistros(codigo, timenow, actualizaestado, idsucursal, ConexionLoc);
                            resultado1 = NEmpleados.NActualizarEmpleadosAsistencia(codigo, 0, DateTime.Now, ConexionLoc);
                        }                        
                    }
                }
                else
                {
                    DateTime sumarminutos = hrentrada.AddMinutes(300);
                    int comparareg = DateTime.Compare(timenow, sumarminutos);

                    if (comparareg == -1)
                    {
                        actualizaestado = 1;
                        if (comparahrentrada <= 0) mensaje = 1;                                // Antes de la HR de entrada
                        else if (comparahrentrada > 0 && comparatolerancia <= 0) mensaje = 2;  // Durante la tolerancia
                        else mensaje = 3;                                                      // Despues de la HR de entrada

                        resultado = NRegistros.NAgregarRegistros(codigo, timenow, actualizaestado, idsucursal, ConexionLoc);
                        resultado1 = NEmpleados.NActualizarEmpleadosAsistencia(codigo, actualizaestado, DateTime.Now, ConexionLoc);
                    }
                    else
                    {
                        actualizaestado = 2;
                        if (comparahrsalida < 0) mensaje = 4;       // Despues de la HR de salida
                        else mensaje = 5;                           // Antes de la HR de salida

                        resultado = NRegistros.NAgregarRegistros(codigo, timenow, actualizaestado, idsucursal, ConexionLoc);
                        resultado1 = NEmpleados.NActualizarEmpleadosAsistencia(codigo, 0, DateTime.Now, ConexionLoc);
                    }                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }

            AbrirFormularioInt(new frmMensajeAsistencias(mensaje, nombre, timenow.ToString()));
            pnlMensaje.Visible = true;
        }
  
        // Quitamos la seleccion de los radiobutton
        private void ValidaES()
        {
            rbnEntrada.Checked = false;
            rbnSalida.Checked = false;
            rbnEntradaVisita.Checked = false;
            rbnSalidaVisita.Checked = false;
        }

        
        // Abrir los formularios en el panel
        private void AbrirFormularioInt(Form FormHijo)
        {            
            pnlMensaje.Visible = true;
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = FormHijo;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            pnlMensaje.Controls.Add(FormHijo);
            pnlMensaje.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        // Detecta formulario abierto
        public static bool detectarFormularioAbierto(string formulario)
        {
            bool abierto = false;
            if (Application.OpenForms[formulario] != null) abierto = true; 
            return abierto;
        }
    }
}
