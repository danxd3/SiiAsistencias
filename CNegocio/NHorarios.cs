using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CDatos;
using System.Data;

namespace CNegocio
{
    public class NHorarios
    {
        // Agregar horarios
        public static string NAgregarHorarios(string pnombre, string phrentrada, string phrsalida, string ptolerancia, DateTime pfmodifica,
            int popconexion)
        {
            DHorarios objHorario = new DHorarios();
            objHorario.Nombre = pnombre;
            objHorario.Hrentrada = phrentrada;
            objHorario.Hrsalida = phrsalida;
            objHorario.Tolerancia = ptolerancia;
            objHorario.Fmodifica = pfmodifica;
            objHorario.OpConexion = popconexion;
            
            return objHorario.DAgregarHorarios(objHorario);
        }

        // Editar horarios
        public static string NEditarHorarios(int pidhorario, string pnombre, string phrentrada, string phrsalida, string ptolerancia,
            DateTime pfmodifica, int popconexion)
        {
            DHorarios objHorario = new DHorarios();
            objHorario.Idhorario = pidhorario;
            objHorario.Nombre = pnombre;
            objHorario.Hrentrada = phrentrada;
            objHorario.Hrsalida = phrsalida;
            objHorario.Tolerancia = ptolerancia;
            objHorario.Fmodifica = pfmodifica;
            objHorario.OpConexion = popconexion;

            return objHorario.DEditarHorarios(objHorario);
        }

        // Metodo para eliminar horarios
        public static string NEliminarHorarios(int pidhorario, int popconexion)
        {
            DHorarios objHorario = new DHorarios();
            objHorario.Idhorario = pidhorario;
            objHorario.OpConexion = popconexion;

            return objHorario.DEliminarHorarios(objHorario);
        }

        // Mostrar horarios
        public static DataTable NMostrarHorarios(int popconexion)
        {
            DHorarios objHorario = new DHorarios();
            objHorario.OpConexion = popconexion;

            return objHorario.DMostrarHorarios(objHorario);
        }
    }
}
