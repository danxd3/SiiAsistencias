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
    public partial class frmAsistenciasPin : Form
    {
        frmPrincipal principal = new frmPrincipal();            // Instancia al formulario principal

        private int TipoRegistro;
        /*  TipoRegistro = 0, buscará el tipo de registro
         *  TipoRegistro = 1, entrada
         *  TipoRegistro = 2, salida
         *  TipoRegistro = 3, entrada visita
         *  TipoRegistro = 4, salida visita
         */
        private int idsucursal = 0;
        private int ConexionLoc = 1;
        private int ConexionExt = 2;

        public frmAsistenciasPin(int ptiporeg)
        {
            InitializeComponent();
            this.TipoRegistro = ptiporeg;
            idsucursal = principal.idsucursalactual;
        }

        /* ---------- EVENTOS ---------- */

        // Agregar registro de asistencia
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbxCodigo.Text == string.Empty || tbxPin.Text == string.Empty)
            {
                MessageBox.Show("Favor rellenar todos los campos", "SiiAsistencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Control.CheckForIllegalCrossThreadCalls = false; // Cancelamos la excepciones de subprocesos
                string codigo = tbxCodigo.Text;
                string pin = tbxPin.Text;
                DataTable dtEmpleado = NEmpleados.NMostrarEmpleadosVerificados(2, codigo, pin, ConexionLoc ); //Almacenamos los campos a utilizar del empleado

                if (dtEmpleado.Rows.Count >= 1) IngresarAsistencia(dtEmpleado); 
                else
                {
                    frmMensajeAsistencias frmMensaje = new frmMensajeAsistencias(0, "", "");
                    frmMensaje.ShowDialog();
                    this.Dispose();
                }
            }
            this.Close();
        }

        // Valida los caracteres del textbox codigo
        private void tbxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) e.Handled = false;         // Letras
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;  // Teclas especiales
            else e.Handled = true;                                  // Solo los numeros

            if (e.KeyChar == (char)13)                              // Si es un enter
            { e.Handled = true; SendKeys.Send("{TAB}"); }
        }

        // Valida los caracteres del textbox pin
        private void tbxPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) e.Handled = false;         // Letras
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;  // Teclas especiales
            else e.Handled = true;                                  // Solo los numeros

            if (e.KeyChar == (char)13)                              // Si es un enter
            { e.Handled = true; SendKeys.Send("{TAB}"); }
        }

        /* ---------- METODOS Y FUNCIONES ---------- */

        // Ingresa las asistencias
        public void IngresarAsistencia(DataTable pdtempleado)
        {
            DataTable dtEmpleado = pdtempleado;

            // Asignacion de los campos del DT a variables
            //int idempleado = Convert.ToInt32(dtEmpleado.Rows[0]["idempleado"]);                     //idempleado
            string codigo = dtEmpleado.Rows[0]["codigo"].ToString();                                //Codigo
            string nombre = dtEmpleado.Rows[0]["nombrecompleto"].ToString();                                //nombre
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
            int actestadoes = 0;
            int mensaje = 0;

            var auxfultimoreg = fultimoreg.ToShortDateString();
            var auxfahora = timenow.ToShortDateString();

            try
            {
                // Valida si esta seleccionada la opcion de entrada
                if (TipoRegistro == 1)
                {
                    actestadoes = 1;
                    if (comparahrentrada <= 0) mensaje = 1;                                // Antes de la HR de entrada
                    else if (comparahrentrada > 0 && comparatolerancia <= 0) mensaje = 2;  // Durante la tolerancia
                    else mensaje = 3;                                                      // Despues de la HR de entrada

                    resultado = NRegistros.NAgregarRegistros(codigo, timenow, actestadoes, idsucursal,ConexionLoc);
                    resultado1 = NEmpleados.NActualizarEmpleadosAsistencia(codigo,actestadoes,Convert.ToDateTime(auxfahora),ConexionLoc);
                }
                // Valida si esta seleccionada la opcion de salida
                else if (TipoRegistro == 2)
                {
                    actestadoes = 2;
                    if (comparahrsalida < 0) mensaje = 4;       // Despues de la HR de salida
                    else mensaje = 5;                           // Antes de la HR de salida

                    resultado = NRegistros.NAgregarRegistros(codigo, timenow, actestadoes, idsucursal, ConexionLoc);
                    resultado1 = NEmpleados.NActualizarEmpleadosAsistencia(codigo, 0, Convert.ToDateTime(auxfahora), ConexionLoc);
                }
                // Valida si esta seleccionada la opcion de entrada visita
                else if (TipoRegistro == 3)
                {
                    actestadoes = 3;
                    mensaje = 6;
                    resultado = NRegistros.NAgregarRegistros(codigo, timenow, actestadoes, idsucursal, ConexionLoc);
                }
                // Valida si esta seleccionada la opcion de salida visita
                else if (TipoRegistro == 4)
                {
                    actestadoes = 4;
                    mensaje = 7;
                    resultado = NRegistros.NAgregarRegistros(codigo, timenow, actestadoes, idsucursal, ConexionLoc);
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
                        if (estado == 0)
                        {
                            actestadoes = 1;
                            if (comparahrentrada <= 0) mensaje = 1;                                // Antes de la HR de entrada
                            else if (comparahrentrada > 0 && comparatolerancia <= 0) mensaje = 2;  // Durante la tolerancia
                            else mensaje = 3;                                                      // Despues de la HR de entrada

                            resultado = NRegistros.NAgregarRegistros(codigo, timenow, actestadoes, idsucursal, ConexionLoc);
                            resultado1 = NEmpleados.NActualizarEmpleadosAsistencia(codigo, actestadoes, DateTime.Now, ConexionLoc);
                        }
                        else
                        {
                            actestadoes = 2;
                            if (comparahrsalida < 0) mensaje = 4;       // Despues de la HR de salida
                            else mensaje = 5;                           // Antes de la HR de salida

                            resultado = NRegistros.NAgregarRegistros(codigo, timenow, actestadoes, idsucursal, ConexionLoc);
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
                        actestadoes = 1;
                        if (comparahrentrada <= 0) mensaje = 1;                                // Antes de la HR de entrada
                        else if (comparahrentrada > 0 && comparatolerancia <= 0) mensaje = 2;  // Durante la tolerancia
                        else mensaje = 3;                                                      // Despues de la HR de entrada

                        resultado = NRegistros.NAgregarRegistros(codigo, timenow, actestadoes, idsucursal, ConexionLoc);
                        resultado1 = NEmpleados.NActualizarEmpleadosAsistencia(codigo, actestadoes, DateTime.Now, ConexionLoc);
                    }
                    else
                    {
                        actestadoes = 2;
                        if (comparahrsalida < 0) mensaje = 4;       // Despues de la HR de salida
                        else mensaje = 5;                           // Antes de la HR de salida

                        resultado = NRegistros.NAgregarRegistros(codigo, timenow, actestadoes, idsucursal, ConexionLoc);
                        resultado1 = NEmpleados.NActualizarEmpleadosAsistencia(codigo, 0, DateTime.Now, ConexionLoc);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
            frmMensajeAsistencias frmMensaje = new frmMensajeAsistencias(mensaje, nombre, timenow.ToString());
            frmMensaje.ShowDialog();
            this.Dispose();
        }
    }
}
