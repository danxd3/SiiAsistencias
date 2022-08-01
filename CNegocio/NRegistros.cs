using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CDatos;
using System.Data;

namespace CNegocio
{
    public class NRegistros
    {
        // Agregar registros de asistencias
        public static string NAgregarRegistros(string pcodigo, DateTime pfechahorareg, int pstatus, int pidsucursal, int popconexion)
        {
            DRegistros objRegistro = new DRegistros();
            objRegistro.Codigo = pcodigo;
            objRegistro.FechaHora = pfechahorareg;
            objRegistro.Status = pstatus;
            objRegistro.Idsucursal = pidsucursal;
            objRegistro.OpConexion = popconexion;

            return objRegistro.DAgregarRegistros(objRegistro); 
        }

        // Mostrar registros para al calculo de asistencias
        public static DataTable NMostrarRegistrosAsistencias(int popcion, DateTime pfechaini, DateTime pfechafin, int pidsucursal,
            int piddepto, string pcodigo, int popconexion)
        {
            DRegistros objRegistro = new DRegistros();
            objRegistro.Opcion = popcion;
            objRegistro.Fechaini = pfechaini;
            objRegistro.Fechafin = pfechafin;
            objRegistro.Idsucursal = pidsucursal;
            objRegistro.Iddepto = piddepto;
            objRegistro.Codigo = pcodigo;
            objRegistro.OpConexion = popconexion;
            
            return objRegistro.DMostrarRegistrosAsistencias(objRegistro);
        }

        // Mostrar registros para al calculo de asistencias
        public static DataTable NMostrarRegistrosAsistenciasSucursal( DateTime pfechaini, DateTime pfechafin, int pidsucursal,
             int popconexion)
        {
            DRegistros objRegistro = new DRegistros();
           
            objRegistro.Fechaini = pfechaini;
            objRegistro.Fechafin = pfechafin;
            objRegistro.Idsucursal = pidsucursal;
            objRegistro.OpConexion = popconexion;

            return objRegistro.DMostrarRegistrosAsistenciasSucursal(objRegistro);
        }

        // Mostrar registros para la revision, sincronizacion
        public static DataTable NMostrarRegistros(int popcion, int psync, DateTime pfechaini, DateTime pfechafin, int pidsucursal, 
            string pcodigo, int piddepto, int popconexion)
        {
            DRegistros objRegistro = new DRegistros();
            objRegistro.Opcion = popcion;
            objRegistro.Sync = psync;
            objRegistro.Fechaini = pfechaini;
            objRegistro.Fechafin = pfechafin;
            objRegistro.Idsucursal = pidsucursal;
            objRegistro.Codigo = pcodigo;
            objRegistro.Iddepto = piddepto;
            objRegistro.OpConexion = popconexion;

            return objRegistro.DMostrarRegistros(objRegistro);
        }

        // Mostrar registros para la revision, sincronizacion
        public static DataTable NActualizarRegistrosSync(int pidregistro, int popconexion)
        {
            DRegistros objRegistro = new DRegistros();
            objRegistro.Idregistros = pidregistro;
            objRegistro.OpConexion = popconexion;

            return objRegistro.DActualizarRegistrosSync(objRegistro);
        }

        //// Mostrar registros
        //public static DataTable NMostrarRegistrosPrueba(string pfechaini, string pfechafin)
        //{
        //    DRegistros objRegistros = new DRegistros();
        //    objRegistros.Fechaini = pfechaini;
        //    objRegistros.Fechafin = pfechafin;
        //    return objRegistros.DMostrarRegistrosPrueba(objRegistros);
        //}

        public static DataTable NMostrarRegistrosxRevisar(DateTime pfechaini, DateTime pfechafin, int popcion, int pidsucursal,
            int piddepto, string pcodigo, int popconexion)
        {
            DRegistros objRegistros = new DRegistros();
            objRegistros.Fechaini = pfechaini;
            objRegistros.Fechafin = pfechafin;
            objRegistros.Opcion = popcion;
            objRegistros.Idsucursal = pidsucursal;
            objRegistros.Iddepto = piddepto;
            objRegistros.Codigo = pcodigo;
            objRegistros.OpConexion = popconexion;

            return objRegistros.DMostrarRegistrosxRevisar(objRegistros);
        }

        // Metodo para agregar departamentos
        public static string NModificarRegistrosEstados(int pidregistro, int pestado, int popconexion)
        {
            DRegistros objRegistro = new DRegistros();
            objRegistro.Idregistros = pidregistro;
            objRegistro.Status = pestado;
            objRegistro.OpConexion = popconexion;

            return objRegistro.DModificarRegistrosEstados(objRegistro);
        }

        // Metodo para agregar departamentos
        public static string NModificarRegistrosActivos(int pidregistro, int popconexion)
        {
            DRegistros objRegistro = new DRegistros();
            objRegistro.Idregistros = pidregistro;
            objRegistro.OpConexion = popconexion;
            return objRegistro.DModificarRegistrosActivos(objRegistro);
        }

        //// Mostrar registros con lecturas continuas
        //public static DataTable NMostarRegistrosContinuos(string pcodigo)
        //{
        //    DRegistros objRegistros = new DRegistros();
        //    objRegistros.Codigo = pcodigo;
        //    return objRegistros.DMostarRegistrosContinuos(objRegistros);
        //}

        //// Metodo para agregar registros de asistencias ext
        //public static string NAgregarRegistrosExt(int pidempleado, string pcodigo, DateTime pfechahorareg, int pstatus, int pidsucursal)
        //{
        //    DRegistros objRegistro = new DRegistros();
        //    objRegistro.Idempleado = pidempleado;
        //    objRegistro.Codigo = pcodigo;
        //    objRegistro.Fecharegistro = pfechahorareg;
        //    objRegistro.Status = pstatus;
        //    objRegistro.Idsucursal = pidsucursal;

        //    return objRegistro.DAgregarRegistrosExt(objRegistro);
        //}

        //// Metodo modificar registros sincronizados
        //public static string NModificarSincronizados(int pidregistro)
        //{
        //    DRegistros objRegistro = new DRegistros();
        //    objRegistro.Idregistros = pidregistro;
        //    return objRegistro.DModificarSincronizados(objRegistro);
        //}
    }
}
