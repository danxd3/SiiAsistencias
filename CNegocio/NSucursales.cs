using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CDatos;
using System.Data;

namespace CNegocio
{
    public class NSucursales
    {
        // Agregar sucursales
        public static string NAgregarSucursales(string psucursal, string phost, string pdb, string puser, string ppass, int pport, 
            int pactual, int pactiva, int pnube, int popconexion)
        {
            DSucursales objSucursal = new DSucursales();
            objSucursal.Sucursal = psucursal;
            objSucursal.HostS = phost;
            objSucursal.DBS = pdb;
            objSucursal.UsuarioS = puser;
            objSucursal.ClaveS = ppass;
            objSucursal.PuertoS = pport;
            objSucursal.Actual = pactual;
            objSucursal.Activo = pactiva;
            objSucursal.Nube = pnube;
            objSucursal.OpConexion = popconexion;

            return objSucursal.DAgregarSucursales(objSucursal);
        }

        // Editar sucursales
        public static string NEditarSucursales(int pidsucursal, string psucursal, string phost, string pdb, string puser, string ppass, 
            int pport, int pactual, int pactivo, int pnube, int popcion, int popconexion) 
        {
            DSucursales objSucursal = new DSucursales();
            objSucursal.Idsucursal = pidsucursal;
            objSucursal.Sucursal = psucursal;
            objSucursal.HostS = phost;
            objSucursal.DBS = pdb;
            objSucursal.UsuarioS = puser;
            objSucursal.ClaveS = ppass;
            objSucursal.PuertoS = pport;
            objSucursal.Actual = pactual;
            objSucursal.Activo = pactivo;
            objSucursal.Nube = pnube;
            objSucursal.Opcion = popcion;
            objSucursal.OpConexion = popconexion;

            return objSucursal.DEditarSucursales(objSucursal);
        }

        // Eliminar sucursales
        public static string NEliminarSucursales(int pidsucursal, int popconexion)
        {
            DSucursales objSucursal = new DSucursales();
            objSucursal.Idsucursal = pidsucursal;
            objSucursal.OpConexion = popconexion;

            return objSucursal.DEliminarSucursales(objSucursal);
        }

        //// Metodo para mostrar sucursales actual
        //public static DataTable NBuscarSucursalActual()
        //{
        //    return new DSucursales().DBuscarSucursalActual();
        //}


        //// Metodo para mostrar departamentos
        //public static DataTable NMostrarSucursales()
        //{
        //    return new DSucursales().DMostrarSucursales();
        //}

        // Mostrar sucursales
        public static DataTable NMostrarSucursales(int popcion, int pidsucursal, int popconexion)
        {
            DSucursales objSucursal = new DSucursales();
            objSucursal.Opcion = popcion;
            objSucursal.Idsucursal = pidsucursal;
            objSucursal.OpConexion = popconexion;

            return objSucursal.DMostrarSucursales(objSucursal);
        }
    }
}
