using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CDatos;
using System.Data;

namespace CNegocio
{
    public class NConexion
    {
        // Crear parametros conexion ext
        public static string  NConexionExt(string phost, string pbd, string puser, string pclave, string pport)
        {
            DConexion objConexion = new DConexion();
            objConexion.Server = phost;
            objConexion.DataBase = pbd;
            objConexion.User = puser;
            objConexion.Password = pclave;
            objConexion.Port = pport;

            return DConexion.DParametrosConexion(objConexion);
        }
    }
}
