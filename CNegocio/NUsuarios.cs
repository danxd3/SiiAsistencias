using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CDatos;
using System.Data;

namespace CNegocio
{
    public class NUsuarios
    {
        // Agregar usuarios
        public static string NAgregarUsuarios(string pnombre, string pusuario, string pclave, string ptipo, int popconexion)
        {
            DUsuarios objUsuario = new DUsuarios();
            objUsuario.Nombre = pnombre;
            objUsuario.Usuario = pusuario;
            objUsuario.Clave = pclave;
            objUsuario.Tipo = ptipo;
            objUsuario.OpConexion = popconexion;

            return objUsuario.DagregarUsuarios(objUsuario);
        }

        // Editar usuarios
        public static string NEditarUsuarios(int pidusuario, string pnombre, string pusuario, string pclave, string ptipo, 
            bool pcambiaclave, int popconexion)
        {
            DUsuarios objUsuario = new DUsuarios();
            objUsuario.Idusuario = pidusuario;
            objUsuario.Nombre = pnombre;
            objUsuario.Usuario = pusuario;
            objUsuario.Clave = pclave;
            objUsuario.Tipo = ptipo;
            objUsuario.CambiaClave = pcambiaclave;
            objUsuario.OpConexion = popconexion;

            return objUsuario.DEditarUsuarios(objUsuario);
        }

        // Eliminar usuarios
        public static string NEliminarUsuarios(int pidusuario, int popconexion)
        {
            DUsuarios objUsuario = new DUsuarios();
            objUsuario.Idusuario = pidusuario;
            objUsuario.OpConexion = popconexion;

            return objUsuario.DEliminarUsuario(objUsuario);
        }

        // Mostrar usuarios
        public static DataTable NMostrarUsuarios(int popcion, string ptxtbuscar, int popconexion)
        {
            DUsuarios objUsuario = new DUsuarios();
            objUsuario.Opcion = popconexion;
            objUsuario.Txtbuscar = ptxtbuscar;
            objUsuario.OpConexion = popconexion;

            return objUsuario.DMostrarUsuarios(objUsuario);
        }


        // Mostrar usuarios login
        public static DataTable Login(string usuario, string password, int popconexion)
        {
            DUsuarios objUsuarios = new DUsuarios();
            objUsuarios.Usuario = usuario;
            objUsuarios.Clave = password;
            objUsuarios.OpConexion = popconexion;

            return objUsuarios.Login(objUsuarios);
        }
        
    }
}
