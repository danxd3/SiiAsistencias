using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CDatos;
using System.Data;

namespace CNegocio
{
    public class NSubAreas
    {
        //Agregar SubArea
        public static string NAgregarSubArea(string pnombre, string pdescribe, DateTime pfmodifica, int popconexion)
        {
            DSubAreas objSubAreas = new DSubAreas();
            objSubAreas.Nombre = pnombre;
            objSubAreas.Descripcion = pdescribe;
            objSubAreas.Fmodifica = pfmodifica;
            objSubAreas.OpConexion = popconexion;

            return objSubAreas.DAgregarSubAreas(objSubAreas);
        }

        //Editar SubArea
        public static string NEditarSubArea(int pidsubarea, string pnombre, string pdescribe, DateTime pfmodifica, int popconexion)
        {
            //Subareas QUE NO PUEDE SER EDITAS POR QUE SON NECESARIAS PARA LOS REPORTES
            //1 NO-ASIGNADO
            //2 DESCANSO
            //3 VACACIONES
            //4 PERMISO
            //5 INCAPACIDAD
            //6 FALTA
            if (pidsubarea <= 6)
            {
                return "No se puede editar estas subareas";
            }
            else
            {
                DSubAreas objSubAreas = new DSubAreas();
                objSubAreas.IdSubArea = pidsubarea;
                objSubAreas.Nombre = pnombre;
                objSubAreas.Descripcion = pdescribe;
                objSubAreas.Fmodifica = pfmodifica;
                objSubAreas.OpConexion = popconexion;

                return objSubAreas.DEditarSubArea(objSubAreas);
            }
            

        }

        //Eliminar SubArea
        public static string NEliminarSubArea(int pidsubarea, int popconexion)
        {
            //Subareas QUE NO PUEDE SER EDITAS POR QUE SON NECESARIAS PARA LOS REPORTES
            //1 NO-ASIGNADO
            //2 DESCANSO
            //3 VACACIONES
            //4 PERMISO
            //5 INCAPACIDAD
            //6 FALTA
            if (pidsubarea <= 6)
            {
                return "No se puede eliminar estas subareas";
            }
            else
            {
                DSubAreas objSubArea = new DSubAreas();
                objSubArea.IdSubArea = pidsubarea;
                objSubArea.OpConexion = popconexion;

                return objSubArea.DEliminarSubArea(objSubArea);
            }
               
        }

        // Mostrar SubArea
        public static DataTable NMostrarSubAreas(int popconexion)
        {
            DSubAreas objdepto = new DSubAreas();
            objdepto.OpConexion = popconexion;

            return objdepto.DMostrarSubAreas(objdepto);
        }
    }
}
