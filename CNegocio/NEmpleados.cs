using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CDatos;

namespace CNegocio
{
    public class NEmpleados
    {
        // Agregar empleados
        public static string NAgregarEmpleados(string pcodigo, string pnombre, string papellidos, int piddepto, int pidhorario, byte[] pimagen, 
            int pactivo, int ptienehuella, int pidsucursal, string pdescansos, string pdiasdescansos, int ppinactivo, string ppin, 
            DateTime pfingreso, DateTime pfmodifica, int popconexion)
        {
            DEmpleados objEmpleado = new DEmpleados();
            objEmpleado.Codigo = pcodigo;
            objEmpleado.Nombre = pnombre;
            objEmpleado.Apellidos = papellidos;
            objEmpleado.Iddepto = piddepto;
            objEmpleado.Idhorario = pidhorario;
            objEmpleado.Imagen = pimagen;
            objEmpleado.Activo = pactivo;
            objEmpleado.Tienehuella = ptienehuella;
            objEmpleado.Idsucursal = pidsucursal;
            objEmpleado.Descansos = pdescansos;
            objEmpleado.DiasDescansos = pdiasdescansos;
            objEmpleado.Pinactivo = ppinactivo;
            objEmpleado.Pin = ppin;
            objEmpleado.FIngreso = pfingreso;
            objEmpleado.FModificacion = pfmodifica;
            objEmpleado.OpConexion = popconexion;

            return objEmpleado.DAgregarEmpleados(objEmpleado);
        }

        // Editar empleados
        public static string NEditarEmpleados(string pcodigo, string pnombre, string papellidos, int piddepto, int pidhorario, byte[] pfoto, 
            int pactivo, int ptienehuella, string pdescansos, string pdiasdescansos, int ppinactivo, string ppin, DateTime pfmodifica, 
            int pidsucursal, int popconexion)
        {
            DEmpleados objEmpleado = new DEmpleados();
            objEmpleado.Codigo = pcodigo;
            objEmpleado.Nombre = pnombre;
            objEmpleado.Apellidos = papellidos;
            objEmpleado.Iddepto = piddepto;
            objEmpleado.Idhorario = pidhorario;
            objEmpleado.Imagen = pfoto;
            objEmpleado.Activo = pactivo;
            objEmpleado.Tienehuella = ptienehuella;
            objEmpleado.Descansos = pdescansos;
            objEmpleado.DiasDescansos = pdiasdescansos;
            objEmpleado.Pinactivo = ppinactivo;
            objEmpleado.Pin = ppin;
            objEmpleado.FModificacion = pfmodifica;
            objEmpleado.Idsucursal = pidsucursal;
            objEmpleado.OpConexion = popconexion;

            return objEmpleado.DEditarEmpleados(objEmpleado);
        }

        // Activar Desactivar empleados
        public static string NActivarDesactivarEmpleados(string pcodigo, int pactivo, int popconecion)
        {
            DEmpleados objEmpleado = new DEmpleados();
            objEmpleado.Codigo = pcodigo;
            objEmpleado.Activo = pactivo;
            objEmpleado.OpConexion = popconecion;

            return objEmpleado.DActivarDesactivarEmpleados(objEmpleado);
        }

        // Eliminar empleados
        public static string NEliminarEmpleados(string pcodigo)
        {
            DEmpleados objEmpleado = new DEmpleados();
            objEmpleado.Codigo = pcodigo;

            return objEmpleado.DEliminarEmpleados(objEmpleado);
        }

        // Mostrar detalles de los empleados
        public static DataTable NMostrarEmpleadosDetalles(int popcion, int pidsociedad, int pactivo, int pidsucursal, string pcodigo, string ptxtbucar,
            int piddepto, int idhorario, int popconecion)
        {
            DEmpleados objEmpleado = new DEmpleados();
            objEmpleado.Opcion = popcion;
            objEmpleado.Idsociedad = pidsociedad;
            objEmpleado.Activo = pactivo;
            objEmpleado.Idsucursal = pidsucursal;
            objEmpleado.Codigo = pcodigo;            
            objEmpleado.Txtbuscar = ptxtbucar;
            objEmpleado.Iddepto = piddepto;
            objEmpleado.Idhorario = idhorario;
            objEmpleado.OpConexion = popconecion;

            return objEmpleado.DMostrarEmpleadosDetalles(objEmpleado);
        }

        // Mostrar detalles de los empleados
        public static DataTable NMostrarEmpleadosVerificados(int popcion, string pcodigo, string ppin, int popconecion)
        {
            DEmpleados objEmpleado = new DEmpleados();
            objEmpleado.Opcion = popcion;
            objEmpleado.Codigo = pcodigo;
            objEmpleado.Pin = ppin;
            objEmpleado.OpConexion = popconecion;

            return objEmpleado.DMostrarEmpleadosVerificados(objEmpleado);
        }

        // Metodo para actualizar el estado del registro en empleados
        public static string NActualizarEmpleadosAsistencia(string pcodigo, int pestadoreg, DateTime pultimoreg, int popconexion)
        {
            DEmpleados objEmpleado = new DEmpleados();
            objEmpleado.Codigo = pcodigo;
            objEmpleado.Estadoreg = pestadoreg;
            objEmpleado.FUltimoReg = pultimoreg;
            objEmpleado.OpConexion = popconexion;

            return objEmpleado.DActualizarEmpleadosAsistencia(objEmpleado);
        }       

        // Contar empleados por sucursal
        public static DataTable NContarEmpleadosxSucursal(int popconexion)
        {
            DEmpleados objEmpleado = new DEmpleados();
            objEmpleado.OpConexion = popconexion;

            return objEmpleado.DContarEmpleadosxSucursal(objEmpleado);
        }

        public static string NEditarEmpleadoSubAreas(string pcodigo, int psubarea, int popconexion)
        {
            DEmpleados objEmpleado = new DEmpleados();
            objEmpleado.Codigo = pcodigo;
            objEmpleado.IdSubArea = psubarea;
            objEmpleado.OpConexion = popconexion;

            return objEmpleado.DEditarEmpleadoSubArea(objEmpleado);
        }
    }
}
