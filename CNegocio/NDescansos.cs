using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;

namespace CNegocio
{
    public class NDescansos
    {
        // Agregar descansos
        public static string NAgregarDescansos(DateTime pfecha, string pcodigo, int popconexion)
        {
            DDescansos objDescanso = new DDescansos();
            objDescanso.Fecha = pfecha;
            objDescanso.Codigo = pcodigo;
            objDescanso.OpConexion = popconexion;

            return objDescanso.DAgregarDescansos(objDescanso);
        }

        // Mostrar los descansos
        public static DataTable NMostrarDescansos(int popcion, DateTime pfechaini, DateTime pfechafin, int popconexion)
        {
            DDescansos objDescanso = new DDescansos();
            objDescanso.Opcion = popcion;
            objDescanso.Fechaini = pfechaini;
            objDescanso.Fechafin = pfechafin;
            objDescanso.OpConexion = popconexion;

            return objDescanso.DMostrarDescansos(objDescanso);
        }
    }
}
