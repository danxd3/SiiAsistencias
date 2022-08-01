using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CDatos;

namespace CNegocio
{
    public class NHuellas
    {
        // Agregar huellas
        public static string NAgregarHuellas(string pcodigo, byte[] pfinger, DateTime pfmodifica, int popconexion)
        {
            DHuellas objHuella = new DHuellas();
            objHuella.Codigo = pcodigo;
            objHuella.Finger = pfinger;
            objHuella.Fmodifica = pfmodifica;
            objHuella.OpConexion = popconexion;

            return objHuella.DAgregarHuellas(objHuella);
        }

        // Editar huellas
        public static string NEditarHuellas(string pcodigo, byte[] pfinger, DateTime pfmodifica, int popconexion)
        {
            DHuellas objHuella = new DHuellas();
            objHuella.Codigo = pcodigo;
            objHuella.Finger = pfinger;
            objHuella.Fmodifica = pfmodifica;
            objHuella.OpConexion = popconexion;

            return objHuella.DEditarHuellas(objHuella);
        }

        // Eliminar huellas
        public static string NEliminarHuellas(string pcodigo, int popconexion)
        {
            DHuellas objHuella = new DHuellas();
            objHuella.Codigo = pcodigo;
            objHuella.OpConexion = popconexion;

            return objHuella.DEliminarHuellas(objHuella);
        }

        // Mostrar huellas
        public static DataTable NMostrarHuellas(int popcion, string pcodigo, int popconexion)
        {
            DHuellas objHuella = new DHuellas();
            objHuella.Opcion = popcion;
            objHuella.Codigo = pcodigo;
            objHuella.OpConexion = popconexion;

            return objHuella.DMostrarHuellas(objHuella);
        }

        //// Metodo buscarxnombre de la clase DArticulos
        //public static DataTable BuscarxHuellas(byte[] pfinger)
        //{
        //    DHuellas objHuella = new DHuellas();
        //    objHuella.Finger = pfinger;

        //    return objHuella.DBuscarxHuella(objHuella);
        //}

        //// Metodo buscar x codigo
        //public static DataTable NBuscarxCodigo(string pcodigo)
        //{
        //    DHuellas objHuella = new DHuellas();
        //    objHuella.Codigo = pcodigo;

        //    return objHuella.DBuscarxCodigo(objHuella);
        //}
                
    }
}
