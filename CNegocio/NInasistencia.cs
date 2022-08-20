using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CDatos;
using System.Data;

namespace CNegocio
{
    public class NInasistencia
    {

        //Agregar SubArea
        public static string NAgregarInasistencia(string pcodigo , DateTime pfechainicial, DateTime pfechafinal,int pstatus, int psucursal, string pobservaciones,int popconexion)
        {
         
            DInacistencia objInasistencia = new DInacistencia();
            
            objInasistencia.Codigo = pcodigo;
            objInasistencia.FechaInicial = pfechainicial;
            objInasistencia.FechaFinal = pfechafinal;
            objInasistencia.Status = pstatus;
            objInasistencia.Observaciones = pobservaciones;
            objInasistencia.OpConexion = popconexion;

            return objInasistencia.DAgregarInasisitencias(objInasistencia);
        }
    }
}
