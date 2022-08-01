using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using System.Data;

namespace CNegocio
{
    public class NIniciasys
    {
        // Agregar Iniciasys
        public static string NAgregarIniciasys(int popconexion,  DateTime pfhinisys, int pidsucursal)
        {
            DIniciasys objIniciasys = new DIniciasys();
            objIniciasys.Opconexion = popconexion;
            objIniciasys.Fhinisys = pfhinisys;
            objIniciasys.Idsucursal = pidsucursal;

            return objIniciasys.DAgregarIniciasys(objIniciasys);
        }

        // Mostrar los descansos
        public static DataTable NMostrarIniciasys(int popconexion, int popcionsql, int pidsucursal, DateTime pfechaini, DateTime pfechafin)
        {
            DIniciasys objIniciasys = new DIniciasys();
            objIniciasys.Opconexion = popconexion;
            objIniciasys.Opcionsql = popcionsql;
            objIniciasys.Idsucursal = pidsucursal;
            objIniciasys.Fechaini = pfechaini;
            objIniciasys.Fechafin = pfechafin;

            return objIniciasys.DMostrarIniciasys(objIniciasys);
        }

    }
}
