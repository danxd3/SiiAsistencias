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

namespace CPresentacion
{
    public partial class frmRegistros : Form
    {
        frmPrincipal principal = new frmPrincipal();
        private string sucursalactual = string.Empty;
        private int idsucursalactual = 0;
        public DataTable dtUserLogeado = new DataTable();

        private int ConexionLoc = 1;
        private int ConexionExt = 2;
        private int idsociedad = 1;
        private DateTime fechaini;
        private DateTime fechafin;
        private DataTable dtsucursal = new DataTable();

        private int variddepto;
        private int varidsucursal;
        private string varcodigo;






        //private int auxidsucreg;
        //private int auxiddeptoreg;
        //private string auxcodigoreg;

        //int auxtbempleados = 0;
        //int auxtbdeptos = 0;
        //int auxtbhorarios = 0;
        //int auxtbregistros = 0;
        //int auxtbobservaciones = 0;
        //int idsucursalnube = 0;

        public frmRegistros(DataTable pdtuser)
        {
            InitializeComponent();
            dtpFechaini.Value = DateTime.Today;
            dtpFechafin.Value = DateTime.Today;
            sucursalactual = principal.sucursalactual;
            idsucursalactual = principal.idsucursalactual;
            dtUserLogeado = pdtuser;
        }
        
        private void frmRegistros_Load(object sender, EventArgs e)
        {   
            ListarSucursales();
            ListarDeptos();
            //colorcombobox();
        }

        /* ------------------------ EVENTO DE LOS BOTONES -----------------------------------*/
        
        // Obtener los registros
        private void btnResgistros_Click(object sender, EventArgs e)
        {
            ckbDetallado.Enabled = true;
            ckbDetallado.Checked = false;

            DataTable dtregistros = new DataTable();
            dtregistros.Columns.Add("codigo", typeof(String));
            dtregistros.Columns.Add("nombre", typeof(String));
            dtregistros.Columns.Add("fecha", typeof(String));
            dtregistros.Columns.Add("horaentrada", typeof(String));
            dtregistros.Columns.Add("idsucursale", typeof(String));
            dtregistros.Columns.Add("sucursale", typeof(string));
            dtregistros.Columns.Add("horasalida", typeof(String));
            dtregistros.Columns.Add("idsucursals", typeof(string));
            dtregistros.Columns.Add("sucursals", typeof(string));
            dtregistros.Columns.Add("Bono A.", typeof(String));
            dtregistros.Columns.Add("Bono P.", typeof(String));
            dtregistros.Columns.Add("puntual", typeof(String));
            dtregistros.Columns.Add("HR EXTRAS", typeof(String));
            dtregistros.Columns.Add("Observaciones", typeof(String));

            dgvRecords.DataSource = dtregistros;

            fechaini = dtpFechaini.Value;
            fechafin = dtpFechafin.Value;

            if (fechaini > fechafin)
            {
                this.MensajeError("Fecha de inicio debe ser menor o igual a la fecha final");
                dtpFechaini.Value = DateTime.Today;
                dtpFechafin.Value = DateTime.Today;
            }
            else
            {
                DataTable dtauxiliar = new DataTable();

                if (varidsucursal >= 1 && variddepto <= 0 && Convert.ToInt32(varcodigo) <= 0)
                {
                    dtauxiliar = NRegistros.NMostrarRegistrosAsistencias(2, fechaini, fechafin, varidsucursal, variddepto, varcodigo, ConexionLoc);
                }
                else if (varidsucursal <= 0 && variddepto >= 1 && Convert.ToInt32(varcodigo) <= 0)
                {
                    dtauxiliar = NRegistros.NMostrarRegistrosAsistencias(3, fechaini, fechafin, varidsucursal, variddepto, varcodigo, ConexionLoc);
                }
                else if (varidsucursal >= 1 && variddepto >= 1 && Convert.ToInt32(varcodigo) <= 0)
                {
                    dtauxiliar = NRegistros.NMostrarRegistrosAsistencias(4, fechaini, fechafin, varidsucursal, variddepto, varcodigo, ConexionLoc);
                }
                else if (varidsucursal >= 1 && Convert.ToInt32(varcodigo) >= 1)
                {
                    dtauxiliar = NRegistros.NMostrarRegistrosAsistencias(5 ,fechaini, fechafin, varidsucursal, variddepto, varcodigo, ConexionLoc);
                }
                else
                {
                    dtauxiliar = NRegistros.NMostrarRegistrosAsistencias(1, fechaini, fechafin, varidsucursal, variddepto, varcodigo, ConexionLoc);
                }

                if (dtauxiliar.Rows.Count > 0)
                {
                    string auxcodigo = string.Empty;
                    string auxnombre = string.Empty;
                    DateTime auxfecha;
                    string auxsolofecha = string.Empty;
                    string auxhora = string.Empty;
                    string auxestatus = string.Empty;
                    string auxidsucursal = string.Empty;
                    string auxsucursal = string.Empty;

                    // Calculo de diferencia de dias, genera los dias consecutivos
                    TimeSpan Diff_dates = dtpFechafin.Value.Subtract(dtpFechaini.Value);
                    int difdias = Convert.ToInt32(Diff_dates.Days);
                    int aux = 0;

                    foreach (DataRow row in dtauxiliar.Rows) // recorrido de la tabla auxiliar
                    {
                        if (auxcodigo != row["codigo"].ToString())
                        {
                            auxcodigo = row["codigo"].ToString();
                            auxsucursal = row["codigo"].ToString(); ;
                            DateTime d = dtpFechaini.Value;

                            for (int i = 0; i <= difdias; i++)
                            {

                                dtregistros.Rows.Add(row["codigo"].ToString(), row["nombrecompleto"].ToString());
                                dtregistros.Rows[i + aux]["fecha"] = d.ToShortDateString();
                                d = d.AddDays(1);
                            }
                            aux = aux + difdias + 1;
                        }
                    }

                    // Agreagamos los datos al datagrid (hr entrada, salida y sucursal de registros)
                    auxcodigo = "";
                    foreach(DataRow Rowregistros in dtregistros.Rows)
                    {
                        auxcodigo = Rowregistros["codigo"].ToString();
                        auxfecha = Convert.ToDateTime(Rowregistros["fecha"]);

                        foreach(DataRow Rowauxiliar in dtauxiliar.Rows)
                        {
                            var varfechaent = Rowauxiliar["fecha"].ToString();
                            var varfechasal = Rowauxiliar["fechasalida"].ToString();
                            var varcodigodt = Rowauxiliar["codigo"].ToString();

                            if (varfechaent == "") varfechaent = "01/01/1900";
                            if (varfechasal == "") varfechasal = "01/01/1900";
                            
                            if(auxcodigo == varcodigodt && (auxfecha == Convert.ToDateTime(varfechaent) || auxfecha == Convert.ToDateTime(varfechasal)))
                            {
                                Rowregistros["horaentrada"] = Rowauxiliar["hrentrada"].ToString();
                                Rowregistros["idsucursale"] = Rowauxiliar["idsucent"].ToString();
                                Rowregistros["sucursale"] = Rowauxiliar["sucursalent"].ToString();

                                Rowregistros["horasalida"] = Rowauxiliar["hrsalida"].ToString();
                                Rowregistros["idsucursals"] = Rowauxiliar["idsucsal"].ToString();
                                Rowregistros["sucursals"] = Rowauxiliar["sucursalsal"].ToString();
                            }
                        }
                    }

                    // Calculo de descansos de los empleados
                    int opcionEmpSQL = 0;
                    if (varidsucursal >= 1 && Convert.ToInt32(varcodigo) <= 0) opcionEmpSQL = 3;
                    else if (varidsucursal >= 1 && Convert.ToInt32(varcodigo) >= 1) opcionEmpSQL = 4;
                    else opcionEmpSQL = 1;

                    DataTable dtdetallesemp = NEmpleados.NMostrarEmpleadosDetalles(opcionEmpSQL, 1, 1, varidsucursal, varcodigo, "", 1, 1,ConexionLoc );
                    foreach (DataRow fila in dtregistros.Rows) // recorrido de la tabla registros
                    {
                        if (fila["horaentrada"].ToString() == string.Empty && fila["horasalida"].ToString() == string.Empty)
                        {
                            foreach (DataRow filaempleado in dtdetallesemp.Rows)
                            {
                                if (fila["codigo"].ToString() == filaempleado["codigo"].ToString())
                                {
                                    string descanso = filaempleado["descansos"].ToString();
                                    DateTime fechan = Convert.ToDateTime(fila["fecha"].ToString());
                                    byte dia = (byte)fechan.DayOfWeek;
                                    string auxdia = Convert.ToString(dia);

                                    for (int i = 0; i < descanso.Length; i++)
                                    {
                                        if (descanso.Substring(i, 1) == auxdia)
                                        {
                                            fila["horaentrada"] = "DESCANSO";
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // LLenamos con descansos manuales
                    DataTable dtDescansos = NDescansos.NMostrarDescansos(1, fechaini, fechafin, ConexionLoc);
                    auxcodigo = "";
                    foreach (DataRow Rowdescansos in dtDescansos.Rows) // recorrido de la tabla registros
                    {
                        auxcodigo = Rowdescansos["codigo"].ToString();
                        var varfecha = Convert.ToDateTime(Rowdescansos["fecha"]);
                        string fecha = varfecha.ToShortDateString();

                        foreach (DataRow Rowregistros in dtregistros.Rows)
                        {
                            if (Rowregistros["codigo"].ToString() == auxcodigo && Rowregistros["fecha"].ToString() == fecha)
                            {
                                Rowregistros["horaentrada"] = "DESCANSO M";
                            }
                        }
                    }

                    // Calculo de faltas
                    foreach (DataRow Rowregistros in dtregistros.Rows) // recorrido de la tabla registros
                    {
                        if (Rowregistros["horaentrada"].ToString() == "" && Rowregistros["horasalida"].ToString() == "")
                        {
                            Rowregistros["horaentrada"] = "FALTA";
                        }
                    }

                    // Calculo bono de asistencias

                    // Cuando tiene falta
                    foreach (DataRow Rowregistros in dtregistros.Rows) // recorrido de la tabla registros
                    {
                        if (Rowregistros["horaentrada"].ToString() == "FALTA")
                        {
                            auxcodigo = Rowregistros["codigo"].ToString();
                            foreach (DataRow row in dtregistros.Rows)
                            {
                                if (row["codigo"].ToString() == auxcodigo)
                                {
                                    row["Bono A."] = "NO";
                                    row["Bono P."] = "NO";
                                    break;
                                }
                            }
                        }
                    }
                    // Los que si tuvieron asistencias
                    auxcodigo = "";
                    foreach (DataRow Rowregistros in dtregistros.Rows)
                    {
                        if (auxcodigo != Rowregistros["codigo"].ToString() && Rowregistros["Bono A."].ToString() == string.Empty)
                        {
                            Rowregistros["Bono A."] = "SI";
                        }
                        auxcodigo = Rowregistros["codigo"].ToString();
                    }

                    // Calcular bono de puntualidad  
                    auxcodigo = "";
                    int auxtol = 0;
                    foreach (DataRow Rowempleados in dtdetallesemp.Rows)
                    {
                        auxcodigo = Rowempleados["codigo"].ToString();
                        foreach (DataRow fila in dtregistros.Rows)
                        {
                            if (fila["codigo"].ToString() == auxcodigo && fila["Bono A."].ToString() == "SI")
                            {
                                foreach (DataRow auxrecorrido in dtregistros.Rows)
                                {
                                    if (fila["codigo"].ToString() == auxrecorrido["codigo"].ToString() && auxrecorrido["horaentrada"].ToString() != "FALTA"
                                        && auxrecorrido["horaentrada"].ToString() != "DESCANSO" && auxrecorrido["horaentrada"].ToString() != "DESCANSO M")
                                    {
                                        if (auxrecorrido["horaentrada"].ToString() == string.Empty)
                                        {
                                            auxrecorrido["puntual"] = "inpuntual";
                                        }
                                        else
                                        {
                                            DateTime auxfentrada = Convert.ToDateTime(auxrecorrido["fecha"].ToString());
                                            DateTime auxhentrada = Convert.ToDateTime(Rowempleados["hrentrada"].ToString());
                                            auxfecha = new DateTime(auxfentrada.Year, auxfentrada.Month, auxfentrada.Day, auxhentrada.Hour, auxhentrada.Minute, auxhentrada.Second);

                                            //auxtol = Convert.ToInt32(filaempleado["tolerancia"].ToString());
                                            DateTime tolerancia = new DateTime(auxfecha.Year, auxfecha.Month, auxfecha.Day, auxfecha.Hour, (auxfecha.Minute + 1), 00);

                                            DateTime feereg = Convert.ToDateTime(auxrecorrido["fecha"].ToString());
                                            DateTime hrereg = Convert.ToDateTime(auxrecorrido["horaentrada"].ToString());
                                            DateTime auxfhregistro = new DateTime(feereg.Year, feereg.Month, feereg.Day, hrereg.Hour, hrereg.Minute, hrereg.Second);

                                            int comparahrentrada = DateTime.Compare(auxfhregistro, tolerancia);
                                            if (comparahrentrada <= 0) { auxrecorrido["puntual"] = "puntual"; }
                                            else { auxrecorrido["puntual"] = "inpuntual"; }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    auxcodigo = string.Empty;
                    foreach (DataRow fila in dtregistros.Rows)
                    {
                        if (fila["Bono A."].ToString() == "SI")
                        {
                            auxcodigo = fila["codigo"].ToString();
                            foreach (DataRow row in dtregistros.Rows)
                            {
                                if (row["codigo"].ToString() == auxcodigo)
                                {
                                    if (row["puntual"].ToString() == "inpuntual")
                                    {
                                        foreach (DataRow auxrecorrido in dtregistros.Rows)
                                        {
                                            if (auxrecorrido["codigo"].ToString() == auxcodigo)
                                            {
                                                auxrecorrido["Bono P."] = "NO";
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    auxcodigo = string.Empty;
                    foreach (DataRow fila in dtregistros.Rows)
                    {
                        if (fila["Bono A."].ToString() == "SI" && fila["Bono P."].ToString() == string.Empty)
                        {
                            fila["Bono P."] = "SI";
                        }
                    }

                    // Calculo de horas extras
                    auxcodigo = string.Empty;
                    foreach (DataRow row in dtregistros.Rows)
                    {
                        auxcodigo = row["codigo"].ToString();
                        string hrentrada = row["horaentrada"].ToString();
                        string hrsalida = row["horasalida"].ToString();
                        int hrextra = 0;

                        if (hrentrada != "FALTA" && hrentrada != "DESCANSO" && hrentrada != "DESCANSO M" && hrentrada != string.Empty)
                        {
                            DateTime entradareg = Convert.ToDateTime(hrentrada);

                            foreach (DataRow fila in dtdetallesemp.Rows)
                            {
                                if (auxcodigo == fila["codigo"].ToString())
                                {
                                    DateTime entradaemp = Convert.ToDateTime(fila["hrentrada"].ToString());
                                    DateTime auxentradaemp = entradaemp.AddMinutes(-60);

                                    int comparaentrada = DateTime.Compare(entradareg, auxentradaemp);

                                    if (comparaentrada <= 0)
                                    {
                                        TimeSpan diferenciahr = entradaemp.Subtract(entradareg);
                                        hrextra = Convert.ToInt32(diferenciahr.Hours.ToString());
                                        row["HR EXTRAS"] = diferenciahr.Hours.ToString();
                                    }
                                }
                            }
                        }
                        if (hrsalida != string.Empty)
                        {
                            DateTime salidareg = Convert.ToDateTime(hrsalida);

                            foreach (DataRow fila in dtdetallesemp.Rows)
                            {
                                if (auxcodigo == fila["codigo"].ToString())
                                {
                                    DateTime entradaemp = Convert.ToDateTime(fila["hrsalida"].ToString());
                                    DateTime auxentradaemp = entradaemp.AddMinutes(60);

                                    int comparaentrada = DateTime.Compare(salidareg, auxentradaemp);

                                    if (comparaentrada >= 0)
                                    {
                                        TimeSpan diferenciahr = salidareg.Subtract(entradaemp);
                                        row["HR EXTRAS"] = (Convert.ToUInt32(diferenciahr.Hours.ToString()) + hrextra);
                                    }
                                }
                            }
                        }
                    }

                    // Generar Observaciones
                    DataTable dtobservaciones = NObservaciones.NMostrarObservaciones(2, dtpFechaini.Value, dtpFechafin.Value, idsucursalactual, ConexionLoc);
                    auxcodigo = string.Empty;
                    foreach (DataRow fila in dtobservaciones.Rows)
                    {
                        auxcodigo = fila["codigoobs"].ToString();
                        DateTime fechaobs = Convert.ToDateTime(fila["fecha"].ToString());
                        string auxfobs = fechaobs.ToShortDateString();
                        int idsucursalobs = Convert.ToInt32(fila["idsucursal"]);

                        if (Convert.ToInt32(fila["general"].ToString()) == 1)
                        {
                            foreach (DataRow rowdtregistros in dtregistros.Rows)
                            {
                                int auxidsucent = 0;
                                int auxidsucsal = 0;

                                if (rowdtregistros["idsucursale"].ToString() != string.Empty)
                                { auxidsucent = Convert.ToInt32(rowdtregistros["idsucursale"]); }
                                if (rowdtregistros["idsucursals"].ToString() != string.Empty)
                                { auxidsucsal = Convert.ToInt32(rowdtregistros["idsucursals"]); }

                                if (auxfobs == rowdtregistros["fecha"].ToString() && (idsucursalobs == auxidsucent || idsucursalobs == auxidsucsal))
                                {
                                    rowdtregistros["Observaciones"] = fila["observacion"].ToString();
                                }
                            }
                        }
                        else
                        {
                            foreach (DataRow rowdtregistros in dtregistros.Rows)
                            {
                                int auxidsucent = 0;
                                int auxidsucsal = 0;

                                if (rowdtregistros["idsucursale"].ToString() != string.Empty)
                                { auxidsucent = Convert.ToInt32(rowdtregistros["idsucursale"]); }
                                if (rowdtregistros["idsucursals"].ToString() != string.Empty)
                                { auxidsucsal = Convert.ToInt32(rowdtregistros["idsucursals"]); }

                                string auxcodigoreg = rowdtregistros["codigo"].ToString();

                                if (auxcodigoreg == auxcodigo && auxfobs == rowdtregistros["fecha"].ToString())
                                {
                                    rowdtregistros["Observaciones"] = fila["observacion"].ToString();
                                }
                            }
                        }
                    }

                    // Generar observaciones automaticas, para cuando se abre o incia el sistema tarde
                    DataTable dtIniciasys = NIniciasys.NMostrarIniciasys(ConexionLoc, 4, 1, dtpFechaini.Value, dtpFechafin.Value.AddDays(+1));
                    int idsucini = 0;
                    var fechainisys = "";
                    foreach (DataRow drInisys in dtIniciasys.Rows)
                    {
                        idsucini = Convert.ToInt32(drInisys["idsucursal"]);
                        fechainisys = Convert.ToDateTime(drInisys["fhinisys"]).ToShortDateString();

                        foreach (DataRow drRegistros in dtregistros.Rows)
                        {
                            if(drRegistros["fecha"].ToString() == fechainisys)
                            {
                                if(drRegistros["idsucursale"].ToString() != string.Empty)
                                {
                                    if (Convert.ToInt32(drRegistros["idsucursale"]) == idsucini)
                                    {
                                        string auxcodigoemp = drRegistros["codigo"].ToString();
                                        foreach (DataRow drEmpleados in dtdetallesemp.Rows)
                                        {
                                            if(drEmpleados["codigo"].ToString() == auxcodigoemp)
                                            {
                                                DateTime auxfhinisys = Convert.ToDateTime(drInisys["fhinisys"].ToString());
                                                DateTime auxhentrada = Convert.ToDateTime(drEmpleados["hrentrada"].ToString());
                                                auxfecha = new DateTime(auxfhinisys.Year, auxfhinisys.Month, auxfhinisys.Day, auxhentrada.Hour, auxhentrada.Minute, auxhentrada.Second);

                                                int comparahrentrada = DateTime.Compare(auxfhinisys, auxfecha);

                                                if(comparahrentrada > 0)
                                                {
                                                    DateTime hrereg = Convert.ToDateTime(drRegistros["horaentrada"].ToString());
                                                    DateTime auxfhregistro = new DateTime(auxfhinisys.Year, auxfhinisys.Month, auxfhinisys.Day, hrereg.Hour, hrereg.Minute, hrereg.Second);

                                                    int comparahr = DateTime.Compare(auxfhregistro, auxfhinisys.AddMinutes(+5));

                                                    if(comparahr <= 0 && comparahrentrada > 0)
                                                    {
                                                        string auxstring = ("Se inicio tarde el sistema: " + auxfhinisys.ToShortTimeString()).ToUpper();
                                                        if(drRegistros["Observaciones"].ToString() == string.Empty)
                                                        {
                                                            drRegistros["Observaciones"] = auxstring;
                                                        }
                                                        else
                                                        {
                                                            drRegistros["Observaciones"] = drRegistros["Observaciones"].ToString() + " - " + auxstring;
                                                        }
                                                        
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }

                    }

                    // Calculo de descansos laborados
                    foreach (DataRow fila in dtregistros.Rows) // recorrido de la tabla registros
                    {
                        if (fila["horaentrada"].ToString() != string.Empty && fila["horaentrada"].ToString() != "DESCANSO")
                        {
                            foreach (DataRow filaempleado in dtdetallesemp.Rows)
                            {
                                if (fila["codigo"].ToString() == filaempleado["codigo"].ToString())
                                {
                                    string descanso = filaempleado["descansos"].ToString();
                                    DateTime fechan = Convert.ToDateTime(fila["fecha"].ToString());
                                    byte dia = (byte)fechan.DayOfWeek;
                                    string auxdia = Convert.ToString(dia);

                                    for (int i = 0; i < descanso.Length; i++)
                                    {
                                        if (descanso.Substring(i, 1) == auxdia)
                                        {
                                            fila["horaentrada"] = fila["horaentrada"].ToString() + " - DL";
                                        }
                                    }
                                }
                            }
                        }
                    }

                    dgvRecords.DataSource = dtregistros; // llenamos el datagrid
                    if (dgvRecords != null)
                    {
                        dgvRecords.Columns["idsucursale"].Visible = false;
                        dgvRecords.Columns["idsucursals"].Visible = false;
                        dgvRecords.Columns["sucursale"].Visible = false;
                        dgvRecords.Columns["sucursals"].Visible = false;
                        dgvRecords.Columns["puntual"].Visible = false;

                        Font myFont = new System.Drawing.Font(dgvRecords.Font, FontStyle.Bold);
                        var VarCodigo = "";
                        for (int i = 0; i < dgvRecords.Rows.Count; i++)
                        {
                            var VarBonoA = dgvRecords.Rows[i].Cells["BonoA"].Value.ToString();
                            var VarBonoP = dgvRecords.Rows[i].Cells["BonoP"].Value.ToString();
                            if (VarBonoA == "NO")
                            {
                                dgvRecords.Rows[i].Cells["BonoA"].Style.ForeColor = Color.Red;
                                dgvRecords.Rows[i].Cells["BonoA"].Style.Font = myFont;
                                VarCodigo = dgvRecords.Rows[i].Cells["codigo"].Value.ToString();
                            }
                            if (VarBonoP == "NO")
                            {
                                dgvRecords.Rows[i].Cells["BonoP"].Style.ForeColor = Color.Red;
                                dgvRecords.Rows[i].Cells["BonoP"].Style.Font = myFont;
                            }
                            if (VarCodigo == dgvRecords.Rows[i].Cells["codigo"].Value.ToString())
                            {
                                dgvRecords.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            }
                        }
                        ckbDetallado.Enabled = true;
                    }
                }
            }
            int contador = dgvRecords.RowCount;
            lblTotal.Text = "Total de registros: " + contador;
        }
        // Boton para mostrar el reporte
        private void btnImprimir_Click(object sender, EventArgs e)
        {
        }

        

        /* ------------------------ OTROS EVENTOS -----------------------------------*/

        // Evento el cual obtine el id del departamento para obtener sus empleados
        private void cbxDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        // Obtener el numero de la fila
        private void dgvRecords_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex == numero.Index)
            //{
            //    e.Value = e.RowIndex + 1;
            //}
        }        
        
        /* ------------------------ METODOS PARA OBTENER LOS REGISTROS -----------------------------------*/

        //// Listar registros por fecha
        //private void ListarRecDate()
        //{
        //    fechaini = dtpFechaini.Value.ToShortDateString();
        //    fechafin = dtpFechafin.Value.ToShortDateString();
        //    //dgvRecords.DataSource = Clases.Consultas.ListarRecFecha(fechaini, fechafin);
        //}
        //// Listar registros por fecha y departamento
        //private void ListarRecDateDep(string iddepto)
        //{
        //    fechaini = dtpFechaini.Value.ToShortDateString();
        //    fechafin = dtpFechafin.Value.ToShortDateString();
        //    //dgvRecords.DataSource = Clases.Consultas.ListarRecDateDep(fechaini, fechafin, iddepto);
        //}
        //// Listar registros por fecha y empleado
        //private void ListarRecDateEmp(string idemp)
        //{
        //    fechaini = dtpFechaini.Value.ToShortDateString();
        //    fechafin = dtpFechafin.Value.ToShortDateString();
        //    //dgvRecords.DataSource = Clases.Consultas.ListarRecDateEmp(fechaini, fechafin, idemp);
        //}
        //// Listar registros por fecha y estatus
        //private void ListarRecDateSta(string idsta)
        //{
        //    fechaini = dtpFechaini.Value.ToShortDateString();
        //    fechafin = dtpFechafin.Value.ToShortDateString();
        //    //dgvRecords.DataSource = Clases.Consultas.ListarRecDateSta(fechaini, fechafin, idsta);
        //}
        //// Listar registros por fecha, depto y estatus
        //private void ListarRecDateDepSta(string iddepto, string idsta)
        //{
        //    fechaini = dtpFechaini.Value.ToShortDateString();
        //    fechafin = dtpFechafin.Value.ToShortDateString();
        //    //dgvRecords.DataSource = Clases.Consultas.ListarRecDateDepSta(fechaini, fechafin, iddepto, idsta);
        //}
        //// Listar registros por fecha, empleado y estatus
        //private void ListarRecDateEmpSta(string idemp, string idsta)
        //{
        //    fechaini = dtpFechaini.Value.ToShortDateString();
        //    fechafin = dtpFechafin.Value.ToShortDateString();
        //    //dgvRecords.DataSource = Clases.Consultas.ListarRecDateEmpSta(fechaini, fechafin, idemp, idsta);
        //}

        /* ------------------------ OTROS METODOS -----------------------------------*/

        // Asigna color a las filas
        public void ColorFila()
        {
            //dgvRecords.RowsDefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
            //dgvRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
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

        private void colorcombobox()
        {
            //int contador = cbxDeptoxxxx.Items.Count;
            //for (int i = 1; i <= contador; i++)
            //{
            //    if (i % 2 == 0)
            //    {

            //        //cbxDepto.BackColor = Color.FromArgb(222, 222, 222);
            //    }
            //    else
            //    {
            //        //cbxDepto.BackColor = Color.White;
            //    }
            //}
        }

        /* ------------------------ CONSULTAS -----------------------------------*/
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

            if (dtUserLogeado.Rows[0]["tipo"].ToString() == "GERENTE")
            {
                cbxSucursales.SelectedIndex = idsucursalactual;
                cbxSucursales.Enabled = false;
            }
            else { cbxSucursales.SelectedIndex = 0; }

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

            cbxDeptos.SelectedIndex = 0;
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

        /* Obtener los status
        public DataTable ListarStatus()
        {

            //try
            //{
            //    if (conexion.Abrirconexion() == true)
            //    {
            //        da.SelectCommand = new OleDbCommand("Select StatusID, StatusText From Status", conexion.conexion);
            //        da.Fill(dt);
            //        cbxAlimentos.ValueMember = "StatusID";
            //        cbxAlimentos.DisplayMember = "StatusText";
            //        cbxAlimentos.DataSource = dt;

            //        conexion.Cerrarconexion();
            //    }
            //}
            //catch (OleDbException ex)
            //{
            //    MessageBox.Show(ex.Message, "Error de conexión");
            //}
        }  */

        // Metodo para ocultar columnas
        private void OcultarColumnas()
        {
            //dgvRecords.Columns["idsociedad"].Visible = false;
            //dgvRecords.Columns["idsucursal"].Visible = false;
            //dgvRecords.Columns["idempleado"].Visible = false;
        }

        // Al seleccionar una sucursal nos mostrará los empleados de esa sucursal
        private void cbxSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSucursales.SelectedValue != null)
            {
                varidsucursal = Convert.ToInt32(cbxSucursales.SelectedValue);
                if (varidsucursal >= 0) { ListarEmpleados(varidsucursal, cbxEmpleados); }
            }
        }

        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            //SaveFileDialog fichero = new SaveFileDialog();
            //fichero.Filter = "Excel (*.xls)|*.xls";
            //if (fichero.ShowDialog() == DialogResult.OK)
            //{
            //    Microsoft.Office.Interop.Excel.Application aplicacion;
            //    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
            //    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
            //    aplicacion = new Microsoft.Office.Interop.Excel.Application();
            //    libros_trabajo = aplicacion.Workbooks.Add();
            //    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            //    //Recorremos el DataGridView rellenando la hoja de trabajo
            //    for (int i = 0; i < grd.Rows.Count - 1; i++)
            //    {
                    
            //        for (int j = 0; j < grd.Columns.Count; j++)
            //        {
            //            if (!grd.Columns[j].Visible) continue;
            //            hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //    libros_trabajo.SaveAs(fichero.FileName,
            //    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            //    libros_trabajo.Close(true);
            //    aplicacion.Quit();
            //}
        }

        private void ExportarDatos(DataGridView datalistado)
        {
            //try
            //{
            //    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
            //    excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
            //    int IndiceColumna = 0;

                

            //    foreach (DataGridViewColumn columna in datalistado.Columns) //Aquí empezamos a leer las columnas del listado a exportar
            //    {
            //        IndiceColumna++;
            //        excel.Cells[1, IndiceColumna] = columna.Name;
            //    }
            //    int IndiceFila = 0;
            //    foreach (DataGridViewRow fila in datalistado.Rows) //Aquí leemos las filas de las columnas leídas
            //    {
            //        IndiceFila++;
            //        IndiceColumna = 0;
            //        foreach (DataGridViewColumn columna in datalistado.Columns)
            //        {
            //            IndiceColumna++;
            //            excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value.ToString();
            //        }
            //    }
            //    excel.Visible = true;
            //}
            //catch (Exception)
            //{
            //    MensajeError("No hay Registros a Exportar.");
            //}
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvRecords.Rows.Count > 0)
            {

                string namefini = dtpFechaini.Value.ToString("dd-MM-yyyy");
                string nameffin = dtpFechafin.Value.ToString("dd-MM-yyyy");
                string NameArchivo = string.Empty;

                string archivo = "REPORTE DE ASISTENCIAS DEL ";
                if (cbxSucursales.SelectedIndex == 0) { archivo = "REPORTE DE ASISTENCIAS GENERAL DEL "; }
                else { archivo = "REPORTE DE ASISTENCIAS " + cbxSucursales.Text.ToString() + " DEL "; }
                string NombreFinal = archivo + namefini + " AL " + nameffin;

                DialogResult opnpreexp;
                opnpreexp = MessageBox.Show("Seleccione el reporte: \n\n" +
                                            "Acepta - Reporte de pago \n" +
                                            "Cancelar - Reporte detallado", "SiiAsistencias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opnpreexp == DialogResult.OK)
                {
                    NameArchivo = "BONO DE ASISTENCIA Y PUNTUALIDAD (";

                    if (cbxSucursales.Text == "SELECCIONE:")
                    { NameArchivo = NameArchivo + "GENERAL) DEL " + namefini + " AL " + nameffin; }
                    else
                    { NameArchivo = NameArchivo + cbxSucursales.Text + ") DEL " + namefini + " AL " + nameffin; }

                    DataTable dtPagos = new DataTable();
                    dtPagos.Columns.Add("Nombre", typeof(string));
                    dtPagos.Columns.Add("Asistencia", typeof(string));
                    dtPagos.Columns.Add("Puntualidad", typeof(string));
                    dtPagos.Columns.Add("Firma", typeof(string));
                    dtPagos.Columns.Add("Observacion", typeof(string));

                    var varNombre = string.Empty;
                    var varBA = string.Empty;
                    var varBP = string.Empty;
                    var varOb = string.Empty;

                    // recorrido - nombre
                    for (int i = 0; i < dgvRecords.Rows.Count; i++)
                    {
                        if (varNombre != dgvRecords.Rows[i].Cells["nombre"].Value.ToString())
                        {
                            varNombre = dgvRecords.Rows[i].Cells["nombre"].Value.ToString();
                            dtPagos.Rows.Add(varNombre);
                        }
                    }

                    // recorrido - asistencia
                    for (int i = 0; i < dgvRecords.Rows.Count; i++)
                    {
                        varBA = dgvRecords.Rows[i].Cells["BonoA"].Value.ToString();
                        varNombre = dgvRecords.Rows[i].Cells["nombre"].Value.ToString();

                        if (varBA == "SI")
                        {
                            foreach (DataRow row in dtPagos.Rows) // recorrido de la tabla auxiliar
                            {
                                if (varNombre == row["nombre"].ToString())
                                {
                                    row["Asistencia"] = "$ 100.00";
                                    break;
                                }
                            }
                        }
                    }

                    // recorrido - puntualidad
                    for (int i = 0; i < dgvRecords.Rows.Count; i++)
                    {
                        varBP = dgvRecords.Rows[i].Cells["BonoP"].Value.ToString();
                        varNombre = dgvRecords.Rows[i].Cells["nombre"].Value.ToString();

                        if (varBP == "SI")
                        {
                            foreach (DataRow row in dtPagos.Rows) // recorrido de la tabla auxiliar
                            {
                                if (varNombre == row["nombre"].ToString())
                                {
                                    row["Puntualidad"] = "$ 100.00";
                                    break;
                                }
                            }
                        }
                    }

                    // recorrido - observaciones
                    for (int i = 0; i < dgvRecords.Rows.Count; i++)
                    {
                        varOb = dgvRecords.Rows[i].Cells["observaciones"].Value.ToString();

                        if (varOb != string.Empty)
                        {
                            varNombre = dgvRecords.Rows[i].Cells["nombre"].Value.ToString();
                            foreach (DataRow row in dtPagos.Rows) // recorrido de la tabla auxiliar
                            {
                                if (varNombre == row["nombre"].ToString())
                                {
                                    if (row["Observacion"].ToString() == string.Empty)
                                    {
                                        row["Observacion"] = varOb;
                                    }
                                    else
                                    {
                                        row["Observacion"] = row["Observacion"].ToString() + ", " + varOb;
                                    }
                                    break;
                                }
                            }
                        }
                    }

                    // Eliminar filas vacias
                    for (int i = dtPagos.Rows.Count - 1; i >= 0; i--)
                    {
                        DataRow dr = dtPagos.Rows[i];
                        if (dr["Asistencia"].ToString() == string.Empty && dr["Puntualidad"].ToString() == string.Empty)
                            dr.Delete();
                    }
                    dtPagos.AcceptChanges();

                    if (dtPagos != null) Clases.ExportarExcel.ExportToExcelPago(dtPagos, NameArchivo);
                }
                else
                {
                    Clases.ExportarExcel.ExportToExcelWithFormatting(dgvRecords, NombreFinal);
                }


            }
            else MensajeError("No se encontraron registros");
        }

        

        public void ExportToExcelWithFormatting(DataGridView dataGridView1)
        {
            //string fileName;
            //string namefini = dtpFechaini.Value.ToString("dd-MM-yyyy");
            //string nameffin = dtpFechafin.Value.ToString("dd-MM-yyyy");
            //string archivo = "REPORTE DE ASISTENCIAS DEL ";

            //if(cbxSucursales.SelectedIndex == 0) { archivo = "REPORTE DE ASISTENCIAS GENERAL DEL "; }
            //else { archivo = "REPORTE DE ASISTENCIAS " + cbxSucursales.Text.ToString() + " DEL "; }

            //string NombreFinal = archivo + namefini + " AL " + nameffin;

            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            //saveFileDialog1.Title = "To Excel";
            //saveFileDialog1.FileName = NombreFinal;

            //int auxcontador = 0;

            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    fileName = saveFileDialog1.FileName;
            //    var workbook = new XLWorkbook();
            //    var worksheet = workbook.Worksheets.Add(this.Text);

            //    // titulo documento
            //    for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //    {
            //        if (dataGridView1.Columns[i].Visible == true) { auxcontador++; }
            //    }
            //    string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Abecedario
            //    string abcd = alfabeto.Substring((auxcontador-1), 1);
            //    worksheet.Cell(1, 1).Value = NombreFinal;
            //    string celdatotal = auxcontador.ToString();
            //    worksheet.Range("A1:"+ abcd+"2").Merge();
            //    worksheet.Cell(1,1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            //    worksheet.Cell(1, 1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            //    //Encabezado del DataGrid

            //    auxcontador = 0;
            //    for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //    {
            //        if (dataGridView1.Columns[i].Visible == true) { auxcontador++; worksheet.Cell(3, auxcontador).Value = dataGridView1.Columns[i].HeaderCell.Value; }
            //    }

            //    auxcontador = 0;

            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //        {
            //            if (dataGridView1.Columns[j].Visible == true) { auxcontador++; worksheet.Cell(i + 4, auxcontador).Value = dataGridView1.Rows[i].Cells[j].Value.ToString(); }
                        
            //            if (worksheet.Cell(i + 2, j + 1).Value.ToString().Length > 0)
            //            {
            //                XLAlignmentHorizontalValues align;

            //                switch (dataGridView1.Rows[i].Cells[j].Style.Alignment)
            //                {
            //                    case DataGridViewContentAlignment.BottomRight:
            //                        align = XLAlignmentHorizontalValues.Right;
            //                        break;
            //                    case DataGridViewContentAlignment.MiddleRight:
            //                        align = XLAlignmentHorizontalValues.Right;
            //                        break;
            //                    case DataGridViewContentAlignment.TopRight:
            //                        align = XLAlignmentHorizontalValues.Right;
            //                        break;
            //                    case DataGridViewContentAlignment.BottomCenter:
            //                        align = XLAlignmentHorizontalValues.Center;
            //                        break;
            //                    case DataGridViewContentAlignment.MiddleCenter:
            //                        align = XLAlignmentHorizontalValues.Center;
            //                        break;
            //                    case DataGridViewContentAlignment.TopCenter:
            //                        align = XLAlignmentHorizontalValues.Center;
            //                        break;
            //                    default:
            //                        align = XLAlignmentHorizontalValues.Left;
            //                        break;
            //                }

            //                worksheet.Cell(i + 2, auxcontador).Style.Alignment.Horizontal = align;

            //                XLColor xlColor = XLColor.FromColor(dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor);
            //                worksheet.Cell(i + 2, auxcontador).AddConditionalFormat().WhenLessThan(1).Fill.SetBackgroundColor(xlColor);

            //                worksheet.Cell(i + 2, auxcontador).Style.Font.FontName = dataGridView1.Font.Name;
            //                worksheet.Cell(i + 2, auxcontador).Style.Font.FontSize = dataGridView1.Font.Size;
            //            }
            //        }
            //        auxcontador = 0;
            //    }
            //    worksheet.Columns().AdjustToContents();
            //    workbook.SaveAs(fileName);
            //    //MessageBox.Show("Exportación exitosa");
            //}
        }

        private void dgvRecords_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
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


        //Modificacion DaN

        private void tbcArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerSucursales(3, 0); // Mostrar servidor nube
            idsucursalactual = principal.idsucursalactual;

            if (this.tbcArticulos.SelectedIndex == 1)
            {
                if (idsucursalactual == Convert.ToInt32(dtsucursal.Rows[0]["idsucursal"]))
                {
                    MensajeError("No puedes sincronizar por que la sucursal actual es la nube");
                    this.tbcArticulos.SelectedIndex = 0;
                }
                else
                {
                    lblServerGral.Text = "SERVIDOR GENERAL : ";
                    cbxSucursales.Enabled = false;
                    cbxDeptos.Enabled = false;
                    cbxEmpleados.Enabled = false;
                    btnResgistros.Enabled = false;
                    btnImprimir.Enabled = false;
                    btnExportar.Enabled = false;
                    lblTotal.Visible = false;
                    ckbDetallado.Visible = false;
                    lblServerGral.Text = lblServerGral.Text + " " + dtsucursal.Rows[0]["sucursal"].ToString();
                }
            }
            else
            {
                cbxSucursales.Enabled = true;
                cbxDeptos.Enabled = true;
                cbxEmpleados.Enabled = true;
                btnResgistros.Enabled = true;
                btnImprimir.Enabled = true;
                btnExportar.Enabled = true;
                lblTotal.Visible = true;
                ckbDetallado.Visible = true;
            }
        }

        public void ObtenerSucursales(int popcion, int pidsucursal)
        {
            //dtsucursal.Clear();
            //dtsucursal = NSucursales.NBuscarSucursal(popcion, pidsucursal);
        }

        public void ValidaElementosxSincronizar(int popcionEI)
        {
            //int opcionExIm = popcionEI;
            //string resultado = "";
            //string auxcodigo = "";            

            //// actualizamos los parametros para la conexion externa
            //resultado = NConexion.NConexionExt(dtsucursal.Rows[0]["dirhost"].ToString(),
            //                                   dtsucursal.Rows[0]["basedatos"].ToString(),
            //                                   dtsucursal.Rows[0]["usuario"].ToString(),
            //                                   dtsucursal.Rows[0]["contrasena"].ToString(),
            //                                   dtsucursal.Rows[0]["puerto"].ToString());
            //resultado = "";

            //// Exportar al servidor general
            //if (opcionExIm == 1)
            //{
            //    // Departamentos
            //    if (ckbDeptos.Checked == true)
            //    {
            //        DataTable dtDepto = NDeptos.NMostrarDeptos();
            //        DataTable dtDeptoext = NDeptos.NMostrarDeptosExt();
            //        bool agregar = true;
            //        string auxdepto = "";
            //        string auxdescribe = "";
            //        resultado = "";

            //        if (dtDepto.Rows.Count > 0) // Validamos si tenemos empleados locales
            //        {
            //            if(dtDeptoext != null) // validamos si se pudo conectar a server general
            //            {
            //                foreach (DataRow rowdepto in dtDepto.Rows) // Recorremos el dtempleados local
            //                {                                
            //                    auxdepto = rowdepto["nombre"].ToString();                                
            //                    auxdescribe = rowdepto["descripcion"].ToString();
            //                    agregar = true;

            //                    if (dtDeptoext.Rows.Count == 0)
            //                    {
            //                        resultado = NDeptos.NAgregarDeptoExt(auxdepto.Trim().ToUpper(), auxdescribe.Trim().ToUpper());
            //                        MessageBox.Show("Departamento " + auxdepto + ", Agregado", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    }
            //                    else
            //                    {
            //                        foreach (DataRow rowdeptoext in dtDeptoext.Rows) // Recorremos el dtempleados servidor general
            //                        {
            //                            if (auxdepto == rowdeptoext["nombre"].ToString()) { agregar = false; break; }
            //                        }
            //                        if(agregar == true)
            //                        {
            //                            resultado = NDeptos.NAgregarDeptoExt(auxdepto.Trim().ToUpper(), auxdescribe.Trim().ToUpper());
            //                            MessageBox.Show("Departamento " + auxdepto + ", Agregado", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                        }
            //                        else
            //                        {
            //                            MessageBox.Show("Departamento " + auxdepto + ", ya se encuentra agregado", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                        }
            //                    }                                
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("No se pudo establecer la conexión con el servidor", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //            }
            //        }
            //    }
            //    //Horarios
            //    if (ckbHorarios.Checked == true)
            //    {
            //        DataTable dtHor = NHorarios.NMostrarHorarios();
            //        DataTable dtHorext = NHorarios.NMostrarHorariosExt();
            //        bool agregar = true;
            //        string auxhorario = "";
            //        string auxhrent = "";
            //        string auxhrsal = "";
            //        string auxtol = "";
            //        resultado = "";

            //        if (dtHor.Rows.Count > 0) // Validamos si tenemos empleados locales
            //        {
            //            if (dtHorext != null) // validamos si se pudo conectar a server general
            //            {
            //                foreach (DataRow rowhorario in dtHor.Rows) // Recorremos el dthorarios local
            //                {
            //                    auxhorario = rowhorario["nombre"].ToString();
            //                    auxhrent = rowhorario["hrentrada"].ToString();
            //                    auxhrsal = rowhorario["hrsalida"].ToString();
            //                    auxtol = rowhorario["tolerancia"].ToString();
            //                    agregar = true;

            //                    if (dtHorext.Rows.Count == 0)
            //                    {
            //                        resultado = NHorarios.NAgregarHorariosExt(auxhorario.Trim().ToUpper(), auxhrent, auxhrsal, auxtol);
            //                        MessageBox.Show("Horario " + auxhorario + ", Agregado", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    }
            //                    else
            //                    {
            //                        foreach (DataRow rowhorarioext in dtHorext.Rows) // Recorremos el dthorarios servidor general
            //                        {
            //                            if (auxhorario == rowhorarioext["nombre"].ToString()) { agregar = false; break; }
            //                        }
            //                        if (agregar == true)
            //                        {
            //                            resultado = NHorarios.NAgregarHorariosExt(auxhorario.Trim().ToUpper(), auxhrent, auxhrsal, auxtol);
            //                            MessageBox.Show("Horario " + auxhorario + ", Agregado", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                        }
            //                        else
            //                        {
            //                            MessageBox.Show("Horario " + auxhorario + ", ya se encuentra agregado", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                        }
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("No se pudo establecer la conexión con el servidor", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //    //Empleados
            //    if (ckbEmpleados.Checked == true)
            //    {
            //        DataTable dtEmp = NEmpleados.NMostrarEmpleados(2, idsociedad, idsucursal, 1, "");
            //        DataTable dtEmpext = NEmpleados.NMostrarEmpleadosExt(2, idsociedad, idsucursal, 1, "");
            //        DataTable dtHuellas = NHuellas.NMostrarHuellas();
            //        int auxidemp;
            //        string auxcodigoemp = "";
            //        string auxnombreemp = "";
            //        string auxapellidos = "";
            //        int auxiddepto;
            //        int auxidhorario;
            //        byte[] auxfoto;
            //        string auxdescans = "";
            //        string auxdiasdes = "";
            //        int auxactivo;
            //        int auxtienehuella;
            //        int auxestadoreg;
            //        DateTime auxultimoreg = new DateTime();
            //        int auxpinactivo;
            //        string auxpin = "";
            //        int auxidsucemp;
            //        DateTime fingreso;
            //        DateTime fmodifica;
            //        int contadoremp = 0;
            //        int contadorhue = 0;
            //        int contadormodifica = 0;
            //        int idsucursalemp = 0;
            //        bool agregar = true;
                    
            //        resultado = "";

            //        if (dtEmp.Rows.Count > 0) // Validamos si tenemos empleados locales
            //        {
            //            if (dtEmpext != null) // validamos si se pudo conectar a server general
            //            {
            //                foreach (DataRow rowemp in dtEmp.Rows) // Recorremos el dtempleados local
            //                {
            //                    auxcodigoemp = rowemp["Codigo"].ToString();
            //                    auxnombreemp = rowemp["Nombre"].ToString();
            //                    auxapellidos = rowemp["Apellidos"].ToString();
            //                    auxiddepto =  Convert.ToInt32(rowemp["iddepto"]);
            //                    auxidhorario = Convert.ToInt32(rowemp["idhorario"]);
            //                    auxfoto = (byte[])rowemp["Foto"];
            //                    auxdescans = rowemp["numerodias"].ToString();
            //                    auxdiasdes = rowemp["Diasdescansos"].ToString();
            //                    auxactivo = Convert.ToInt32(rowemp["Activo"]);
            //                    auxtienehuella = Convert.ToInt32(rowemp["Huella"]);
            //                    auxestadoreg = Convert.ToInt32(rowemp["estadoreg"]);
            //                    auxultimoreg = Convert.ToDateTime(rowemp["fultimoreg"]);
            //                    auxpinactivo = Convert.ToInt32(rowemp["pinactivo"]);
            //                    auxpin = rowemp["pin"].ToString();
            //                    auxidsucemp = Convert.ToInt32(rowemp["idsucursal"]);
            //                    fingreso = Convert.ToDateTime(rowemp["fechaingreso"]);
            //                    fmodifica = Convert.ToDateTime(rowemp["fechamodifica"]);
            //                    auxidemp = Convert.ToInt32(rowemp["idempleados"]);
            //                    idsucursalemp = Convert.ToInt32(rowemp["idsucursal"]);
            //                    resultado = "";
            //                    agregar = true;

            //                    if (dtEmpext.Rows.Count == 0) // Validamos que la tabla empleados ext no tenga registros
            //                    {
            //                        resultado = NEmpleados.NAgregarEmpleadosExt(auxcodigoemp, auxnombreemp, auxapellidos, auxiddepto, 
            //                                                                    auxidhorario, auxfoto, auxactivo, auxtienehuella, 
            //                                                                    auxidsucemp, auxdescans, auxdiasdes, auxpinactivo, 
            //                                                                    auxpin, fingreso, fmodifica);
            //                        if(Convert.ToInt32(resultado) > 0) // Empleado agregado
            //                        {
            //                            contadoremp++;
            //                            foreach (DataRow rowhuella in dtHuellas.Rows) //Recorrido de dthuellas
            //                            {
            //                                byte[] auxhuella = (byte[])rowhuella["finger"];
            //                                if (auxcodigoemp == rowhuella["codigo"].ToString())
            //                                {
            //                                    resultado = NHuellas.NAgregarHuellasExt(Convert.ToInt32(resultado),
            //                                                                            auxcodigoemp,
            //                                                                            auxhuella);
            //                                    if(resultado == "ok") { contadorhue++; } // Huella agregada
            //                                }
            //                            }
            //                        }                                 
            //                    }
            //                    else
            //                    {
            //                        foreach (DataRow rowempext in dtEmpext.Rows) // Recorremos el dthorarios servidor general
            //                        {                                        
            //                            if (auxcodigoemp == rowempext["Codigo"].ToString())
            //                            {
            //                                DateTime fmodificaempext = Convert.ToDateTime(rowempext["fechamodifica"].ToString());
            //                                int varComparaFechas = DateTime.Compare(fmodifica, fmodificaempext);

            //                                if(varComparaFechas > 0)
            //                                {
            //                                    resultado = NEmpleados.NEditarEmpleadosExt(auxidemp, auxcodigoemp, auxnombreemp,
            //                                                                               auxapellidos, auxiddepto, auxidhorario,
            //                                                                               auxactivo, auxtienehuella, auxdescans,
            //                                                                               auxdiasdes, auxpinactivo, auxpin, fmodifica,
            //                                                                               idsucursalemp);
            //                                    contadormodifica++;
            //                                }
            //                                agregar = false;
            //                                break;
            //                            }
            //                        }
            //                        if (agregar == true)
            //                        {
            //                            resultado = NEmpleados.NAgregarEmpleadosExt(auxcodigoemp, auxnombreemp, auxapellidos, 
            //                                                                        auxiddepto, auxidhorario, auxfoto, auxactivo, 
            //                                                                        auxtienehuella, auxidsucemp, auxdescans, 
            //                                                                        auxdiasdes, auxpinactivo, auxpin, fingreso,
            //                                                                        fmodifica);
            //                            if (Convert.ToInt32(resultado) > 0) // Empleado agregado
            //                            {
            //                                contadoremp++;
            //                                foreach (DataRow rowhuella in dtHuellas.Rows) //Recorrido de dthuellas
            //                                {
            //                                    byte[] auxhuella = (byte[])rowhuella["finger"];
            //                                    if (auxcodigoemp == rowhuella["codigo"].ToString())
            //                                    {
            //                                        resultado = NHuellas.NAgregarHuellasExt(Convert.ToInt32(resultado),
            //                                                                                auxcodigoemp,
            //                                                                                auxhuella);
            //                                        if (resultado == "ok") { contadorhue++; } // Huella agregada
            //                                    }
            //                                }
            //                            }
                                            
            //                        }
            //                    }
            //                }
            //                MessageBox.Show("Empleados agregados : " + contadoremp + 
            //                                "\nHuellas agregadas : " + contadorhue + 
            //                                "\nEmpleados modificados : " + contadormodifica, 
            //                                "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                MessageBox.Show("No se pudo establecer la conexión con el servidor", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    } 
            //    // Registros de asistencias
            //    if (ckbAsistencias.Checked == true)
            //    {
            //        string fini = dtpFechaini.Value.ToString("yyyy/MM/dd");
            //        string ffin = dtpFechafin.Value.ToString("yyyy/MM/dd");
            //        DataTable dtAsis = NRegistros.NMostrarRegistrosxRevisar(fini, ffin, 6, idsociedad, 0, "");
            //        DataTable dtEmpext = NEmpleados.NMostrarEmpleadosExt(2, idsociedad, idsucursal, 1, "");

            //        int auxidemp;
            //        string auxcodigoemp = "";
            //        DateTime auxfhregistro = new DateTime();
            //        int auxestado;
            //        int auxidsucursal;
            //        resultado = "";
            //        int contadorreg = 0;

            //        if (dtAsis.Rows.Count > 0) // Validamos si tenemos registros locales
            //        {
            //            MessageBox.Show("Registros por sincronizar : " + dtAsis.Rows.Count, "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            if (dtEmpext != null) // validamos si se pudo conectar a server general
            //            {
            //                foreach (DataRow rowregasis in dtAsis.Rows) // Recorremos el dtregistros local
            //                {
            //                    auxfhregistro = Convert.ToDateTime(rowregasis["fechahorareg"]);
            //                    auxestado = Convert.ToInt32(rowregasis["estadoval"]);
            //                    auxidsucursal = Convert.ToInt32(rowregasis["idsucursal"]);

            //                    foreach (DataRow rowempext in dtEmpext.Rows) //Recorrido de dtempleados ext
            //                    {
            //                        if(rowregasis["codigo"].ToString() == rowempext["Codigo"].ToString())
            //                        {
            //                            auxcodigoemp = rowempext["Codigo"].ToString();
            //                            auxidemp = Convert.ToInt32(rowempext["idempleados"]);
            //                            resultado = NRegistros.NAgregarRegistrosExt(auxidemp, auxcodigoemp, auxfhregistro, auxestado, auxidsucursal);

            //                            if(resultado == "ok")
            //                            {
            //                                contadorreg++;
            //                                rowregasis["sync"] = 1;
            //                                break;
            //                            }
            //                        }
            //                    }
            //                }

            //                foreach(DataRow rowactreg in dtAsis.Rows)
            //                {
            //                    if(Convert.ToInt32(rowactreg["sync"]) == 1)
            //                    {
            //                        resultado = "";
            //                        resultado = NRegistros.NModificarSincronizados(Convert.ToInt32(rowactreg["idregistro"]));
            //                    }
            //                }                            
            //                MessageBox.Show("Registros sincronizados : " + contadorreg, "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                MessageBox.Show("No se pudo establecer la conexión con el servidor", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        else { MessageBox.Show("No encontraron resgistros por sincronizar", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //    }
            //    // Observaciones
            //    if (ckbObservaciones.Checked == true)
            //    {
            //        DataTable dtObs = NObservaciones.NMostrarObservaciones(3, dtpFechaini.Value, dtpFechafin.Value, idsucursal);
            //        DataTable dtEmpext = NEmpleados.NMostrarEmpleadosExt(2, idsociedad, idsucursal, 1, "");

            //        resultado = "";
            //        int auxgeneral;
            //        string auxcodigoemp = "";
            //        DateTime auxfecha = new DateTime();
            //        string auxobservacion = "";
            //        int auxidsuc;
            //        int contadorobs = 0;

            //        if (dtObs.Rows.Count > 0) // Validamos si tenemos registros locales
            //        {
            //            MessageBox.Show("Observaciones por sincronizar : " + dtObs.Rows.Count, "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            if (dtEmpext != null) // validamos si se pudo conectar a server general
            //            {
            //                foreach (DataRow rowobs in dtObs.Rows) // Recorremos el dtregistros local
            //                {
            //                    auxgeneral = Convert.ToInt32(rowobs["general"]);
            //                    auxcodigoemp = rowobs["codigoobs"].ToString();
            //                    auxfecha = Convert.ToDateTime(rowobs["fecha"]);
            //                    auxobservacion = rowobs["observacion"].ToString();
            //                    auxidsuc = Convert.ToInt32(rowobs["idsucursal"]);

            //                    foreach (DataRow rowempext in dtEmpext.Rows) //Recorrido de dtempleados ext
            //                    {
            //                        if (auxcodigoemp == rowempext["Codigo"].ToString() || auxgeneral == 1)
            //                        {
            //                            resultado = NObservaciones.NAgregarObservacionExt(auxgeneral, auxcodigoemp, auxfecha, auxobservacion, auxidsuc);
            //                            if (resultado == "ok")
            //                            {
            //                                contadorobs++;
            //                                rowobs["sync"] = 1;
            //                                break;
            //                            }
            //                        }
            //                    }
            //                }
            //                foreach (DataRow rowactobs in dtObs.Rows)
            //                {
            //                    if (Convert.ToInt32(rowactobs["sync"]) == 1)
            //                    {
            //                        resultado = "";
            //                        resultado = NObservaciones.NModificarSincronizados(Convert.ToInt32(rowactobs["idobservacion"]));
            //                    }
            //                }
            //                MessageBox.Show("Observaciones sincronizados : " + contadorobs, "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else { MessageBox.Show("No se pudo establecer la conexión con el servidor", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //        }
            //        else { MessageBox.Show("No encontraron observaciones por sincronizar", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //    }
            //}
            //// Importar del servidor general
            //else
            //{
            //    if (ckbEmpleados.Checked == true)
            //    {
            //        DataTable dtEmp = NEmpleados.NMostrarEmpleados(2, idsociedad, idsucursal, 1, "");
            //    }
            //    if (ckbDeptos.Checked == true)
            //    {
            //        DataTable dtDepto = NDeptos.NMostrarDeptos();
            //    }
            //    if (ckbHorarios.Checked == true)
            //    {
            //        DataTable dtHor = NHorarios.NMostrarHorarios();
            //    }
            //    if (ckbAsistencias.Checked == true)
            //    {
            //        string fini = dtpFechaini.Value.ToString("yyyy/MM/dd");
            //        string ffin = dtpFechafin.Value.ToString("yyyy/MM/dd");
            //        DataTable dtAsis = NRegistros.NMostrarRegistrosxRevisar(fini, ffin, 1, idsociedad, 0, "");
            //    }
            //    if (ckbObservaciones.Checked == true)
            //    {
            //        DataTable dtObs = NObservaciones.NMostrarObservaciones(2, dtpFechaini.Value, dtpFechafin.Value, idsucursal);
            //    }


            //}

            
            //ckbEmpleados.Checked = false;
            //ckbDeptos.Checked = false;
            //ckbHorarios.Checked = false;
            //ckbAsistencias.Checked = false;
            //ckbObservaciones.Checked = false;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            
            //string txtmensaje = string.Empty;

            //if (ckbEmpleados.Checked == true) { txtmensaje = txtmensaje + "* Empleados \n"; }
            //if (ckbDeptos.Checked == true) { txtmensaje = txtmensaje + "* Departamentos \n"; }
            //if (ckbHorarios.Checked == true) { txtmensaje = txtmensaje + "* Horarios \n"; }
            //if (ckbAsistencias.Checked == true) { txtmensaje = txtmensaje + "* Asistencias \n"; }
            //if (ckbObservaciones.Checked == true) { txtmensaje = txtmensaje + "* Observaciones \n"; }
            //if (ckbEmpleados.Checked == false && ckbDeptos.Checked == false && ckbHorarios.Checked == false && ckbAsistencias.Checked == false && ckbObservaciones.Checked == false)
            //{ //txtmensaje = "* Empleados \n* Departamentos \n* Horarios \n* Asistencias \n* Observaciones"; 
            //    MessageBox.Show("Seleccione unas de las opciones por sincronizar","SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //MessageBox.Show("Los elementos por sincronizar son: \n" + txtmensaje, "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ValidaElementosxSincronizar(1);
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {

        }

        private void cbxDeptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDeptos.SelectedValue != null) variddepto = Convert.ToInt32(cbxDeptos.SelectedValue);
        }

        private void cbxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEmpleados.SelectedValue != null) varcodigo = cbxEmpleados.SelectedValue.ToString();
        }

        private void ckbDetallado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDetallado.Checked == true)
            {
                dgvRecords.Columns["sucursale"].Visible = true;
                dgvRecords.Columns["sucursals"].Visible = true;
                dgvRecords.Columns["puntual"].Visible = true;
            }
            else
            {
                dgvRecords.Columns["sucursale"].Visible = false;
                dgvRecords.Columns["sucursals"].Visible = false;
                dgvRecords.Columns["puntual"].Visible = false;
            }
        }

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

        private void mitemDescanso_Click(object sender, EventArgs e)
        {
            string auxcodigo;
            DateTime auxfecha;
            string resultado = "";

            if (dgvRecords.SelectedRows.Count == 1)
            {
                if (dgvRecords.CurrentRow.Cells["horaentrada"].Value.ToString() == "FALTA")
                {
                    auxcodigo = dgvRecords.CurrentRow.Cells["codigo"].Value.ToString();
                    auxfecha = Convert.ToDateTime(dgvRecords.CurrentRow.Cells["fecha"].Value);
                    try
                    {
                        resultado = NDescansos.NAgregarDescansos(auxfecha, auxcodigo, ConexionLoc);
                        if (resultado == "ok") MensajeOK("Descanso asignado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                else MensajeError("No se puede asignar descanso, cuando hay registro");                
            }
        }
    }
}
