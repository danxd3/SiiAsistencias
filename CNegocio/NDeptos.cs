using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CDatos;
using System.Data;

namespace CNegocio
{
    public class NDeptos
    {
        // Agregar departamentos
        public static string NAgregarDepto(string pnombre, string pdescribe, DateTime pfmodifica, int popconexion)
        {
            DDeptos objDDepto = new DDeptos();
            objDDepto.Nombre = pnombre;
            objDDepto.Descripcion = pdescribe;
            objDDepto.Fmodifica = pfmodifica;
            objDDepto.OpConexion = popconexion;

            return objDDepto.DAgregarDepto(objDDepto);
        }

        // Editar deptos
        public static string NEditarDeptos(int piddepto, string pnombre, string pdescribe, DateTime pfmodifica, int popconexion)
        {
            DDeptos objDepto = new DDeptos();
            objDepto.IdDepto = piddepto;
            objDepto.Nombre = pnombre;
            objDepto.Descripcion = pdescribe;
            objDepto.Fmodifica = pfmodifica;
            objDepto.OpConexion = popconexion;

            return objDepto.DEditarDeptos(objDepto);
        }

        // Metodo para eliminar deptos
        public static string NEliminarDeptos(int piddepto, int popconexion)
        {
            DDeptos objdepto = new DDeptos();
            objdepto.IdDepto = piddepto;
            objdepto.OpConexion = popconexion;

            return objdepto.DEliminarDeptos(objdepto);
        }

        // Mostrar departamentos
        public static DataTable NMostrarDeptos(int popconexion)
        {
            DDeptos objdepto = new DDeptos();
            objdepto.OpConexion = popconexion;

            return objdepto.DMostrarDeptos(objdepto);
        }
    }
}
