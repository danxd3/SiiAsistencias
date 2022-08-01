using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using System.Data;

namespace CNegocio
{
    public class NObservaciones
    {
        // Agregar departamentos
        public static string NAgregarObservacion(int pgeneral, string pcodigo, DateTime pfecha, string pobservacion, 
            int pidsucursal, int popconexion)
        {
            DObservaciones objObservacion = new DObservaciones();
            objObservacion.General = pgeneral;
            objObservacion.Codigo = pcodigo;
            objObservacion.Fecha = pfecha;
            objObservacion.Observacion = pobservacion;
            objObservacion.Idsucursal = pidsucursal;
            objObservacion.OpConexion = popconexion;

            return objObservacion.DAgregarObservacion(objObservacion);
        }

        // Mostrar observaciones
        public static DataTable NMostrarObservaciones(int popcion, DateTime pfechaini, DateTime pfechafin, int pidsucursal,
            int popconexion)
        {
            DObservaciones objObservacion = new DObservaciones();
            objObservacion.Opcion = popcion;
            objObservacion.Fechaini = pfechaini;
            objObservacion.Fechafin = pfechafin;
            objObservacion.Idsucursal = pidsucursal;
            objObservacion.OpConexion = popconexion;

            return objObservacion.DMostrarObservaciones(objObservacion);
        }

        

        // Actualizar observaciones sincronizadas
        public static string NModificarSincronizados(int pidobservacion, int popconexion)
        {
            DObservaciones objObservacion = new DObservaciones();
            objObservacion.Idobservaciones = pidobservacion;
            objObservacion.OpConexion = popconexion;

            return objObservacion.DModificarSincronizados(objObservacion);
        }
    }
}
