using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace CDatos
{
    public class DEmpleados : DConexion
    {
        private string _Codigo;
        private string _Nombre;
        private string _Apellidos;
        private int _Iddepto;
        private int _Idhorario;
        private byte[] _Imagen;
        private string _Descansos;
        private string _DiasDescansos;
        private int _Activo;
        private int _Tienehuella;
        private int _Estadoreg;
        private DateTime _FUltimoReg;
        private int _Idsociedad;
        private int _Idsucursal;
        private int _Pinactivo;
        private string _Pin;
        private DateTime _FIngreso;
        private DateTime _FModificacion;
        private string _Txtbuscar;
        private int _Opcion;
        private int _OpConexion;
        private int _IdSubArea;

        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public int Iddepto { get => _Iddepto; set => _Iddepto = value; }
        public int Idhorario { get => _Idhorario; set => _Idhorario = value; }
        public byte[] Imagen { get => _Imagen; set => _Imagen = value; }
        public int Activo { get => _Activo; set => _Activo = value; }
        public int Tienehuella { get => _Tienehuella; set => _Tienehuella = value; }
        public string Txtbuscar { get => _Txtbuscar; set => _Txtbuscar = value; }
        public int Estadoreg { get => _Estadoreg; set => _Estadoreg = value; }
        public int Idsucursal { get => _Idsucursal; set => _Idsucursal = value; }
        public int Opcion { get => _Opcion; set => _Opcion = value; }
        public int Idsociedad { get => _Idsociedad; set => _Idsociedad = value; }
        public string Descansos { get => _Descansos; set => _Descansos = value; }
        public string DiasDescansos { get => _DiasDescansos; set => _DiasDescansos = value; }
        public DateTime FUltimoReg { get => _FUltimoReg; set => _FUltimoReg = value; }
        public int Pinactivo { get => _Pinactivo; set => _Pinactivo = value; }
        public string Pin { get => _Pin; set => _Pin = value; }
        public DateTime FIngreso { get => _FIngreso; set => _FIngreso = value; }
        public DateTime FModificacion { get => _FModificacion; set => _FModificacion = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }
        public int IdSubArea { get => _IdSubArea; set => _IdSubArea=value; }
        // Constructor vacio
        public DEmpleados()
        {
        }

        // Constructor empleados
        public DEmpleados(string pcodigo, string pnombre, string papellido, int piddepto, int pidhorario, byte[] pimagen,
            string pdescansos, string pdiasdescansos, int pactivo, int ptienehuella, int pestadoreg, DateTime pfultimoreg,
            int pidsociedad, int pidsucursal, int ppinactivo, string ppin, DateTime pfingreso, DateTime pfmodifica,
            string ptxtbuscar, int popcion, int popconexion)
        {
            this.Codigo = pcodigo;
            this.Nombre = pnombre;
            this.Apellidos = papellido;
            this.Iddepto = piddepto;
            this.Idhorario = pidhorario;
            this.Imagen = pimagen;
            this.Descansos = pdescansos;
            this.DiasDescansos = pdiasdescansos;
            this.Activo = pactivo;
            this.Tienehuella = ptienehuella;
            this.Estadoreg = pestadoreg;
            this.FUltimoReg = pfultimoreg;
            this.Idsociedad = pidsociedad;
            this.Idsucursal = pidsucursal;
            this.Pinactivo = ppinactivo;
            this.Pin = ppin;
            this.FIngreso = pfingreso;
            this.FModificacion = pfmodifica;
            this.Txtbuscar = ptxtbuscar;            
            this.Opcion = popcion;
            this.OpConexion = popconexion;
           
        }

        // Agregar empleados
        public string DAgregarEmpleados(DEmpleados objEmpleado)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objEmpleado.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Insertar_Empleados";
                        sqlcmd.CommandType = CommandType.StoredProcedure;                        
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objEmpleado.Codigo;
                        sqlcmd.Parameters.Add("xnombre", MySqlDbType.VarChar).Value = objEmpleado.Nombre;
                        sqlcmd.Parameters.Add("xapellidos", MySqlDbType.VarChar).Value = objEmpleado.Apellidos;
                        sqlcmd.Parameters.Add("xiddepto", MySqlDbType.Int32).Value = objEmpleado.Iddepto;
                        sqlcmd.Parameters.Add("xidhorario", MySqlDbType.Int32).Value = objEmpleado.Idhorario;
                        sqlcmd.Parameters.Add("xfoto", MySqlDbType.MediumBlob).Value = objEmpleado.Imagen;                        
                        sqlcmd.Parameters.Add("xactivo", MySqlDbType.Int32).Value = objEmpleado.Activo;
                        sqlcmd.Parameters.Add("xtienehuella", MySqlDbType.Int32).Value = objEmpleado.Tienehuella;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objEmpleado.Idsucursal;
                        sqlcmd.Parameters.Add("xdescansos", MySqlDbType.VarChar).Value = objEmpleado.Descansos;
                        sqlcmd.Parameters.Add("xdiasdescansos", MySqlDbType.VarChar).Value = objEmpleado.DiasDescansos;
                        sqlcmd.Parameters.Add("xpinactivo", MySqlDbType.Int32).Value = objEmpleado.Pinactivo;
                        sqlcmd.Parameters.Add("xpin", MySqlDbType.VarChar).Value = objEmpleado.Pin;
                        sqlcmd.Parameters.Add("xfingreso", MySqlDbType.Date).Value = objEmpleado.FIngreso;
                        sqlcmd.Parameters.Add("xfmodifica", MySqlDbType.Date).Value = objEmpleado.FModificacion;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";                   
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return resultado;
        }

        // Editar empleados
        public string DEditarEmpleados(DEmpleados objEmpleado)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Actualizar_Empleados";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objEmpleado.Codigo;
                        sqlcmd.Parameters.Add("xnombre", MySqlDbType.VarChar).Value = objEmpleado.Nombre;
                        sqlcmd.Parameters.Add("xapellidos", MySqlDbType.VarChar).Value = objEmpleado.Apellidos;
                        sqlcmd.Parameters.Add("xiddepto", MySqlDbType.Int32).Value = objEmpleado.Iddepto;
                        sqlcmd.Parameters.Add("xidhorario", MySqlDbType.Int32).Value = objEmpleado.Idhorario;
                        sqlcmd.Parameters.Add("xfoto", MySqlDbType.MediumBlob).Value = objEmpleado.Imagen;
                        sqlcmd.Parameters.Add("xactivo", MySqlDbType.Int32).Value = objEmpleado.Activo;
                        sqlcmd.Parameters.Add("xtienehuella", MySqlDbType.Int32).Value = objEmpleado.Tienehuella;
                        sqlcmd.Parameters.Add("xdescansos",MySqlDbType.VarChar).Value = objEmpleado.Descansos;
                        sqlcmd.Parameters.Add("xdiasdescansos", MySqlDbType.VarChar).Value = objEmpleado.DiasDescansos;
                        sqlcmd.Parameters.Add("xpinactivo", MySqlDbType.Int32).Value = objEmpleado.Pinactivo;
                        sqlcmd.Parameters.Add("xpin", MySqlDbType.VarChar).Value = objEmpleado.Pin;
                        sqlcmd.Parameters.Add("xfmodifica", MySqlDbType.Date).Value = objEmpleado.FModificacion;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objEmpleado.Idsucursal;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return resultado;
        }

        // Activar o desactivar empleados
        public string DActivarDesactivarEmpleados(DEmpleados objEmpleado)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Actualizar_Bajas_Empleados";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objEmpleado.Codigo;
                        sqlcmd.Parameters.Add("xactivo", MySqlDbType.Int32).Value = objEmpleado.Activo;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return resultado;
        }

        // Eliminar empleados
        public string DEliminarEmpleados(DEmpleados objEmpleado)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Eliminar_Empleados";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objEmpleado.Codigo;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return resultado;
        }

        // Mostrar empleados
        public DataTable DMostrarEmpleadosDetalles(DEmpleados objEmpleado)
        {
            DataTable dtresultado = new DataTable("tbempleados");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Empleados_Detalle";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xopcion", MySqlDbType.Int32).Value = objEmpleado.Opcion; 
                        sqlcmd.Parameters.Add("xidsociedad", MySqlDbType.Int32).Value = objEmpleado.Idsociedad;
                        sqlcmd.Parameters.Add("xactivo", MySqlDbType.Int32).Value = objEmpleado.Activo;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objEmpleado.Idsucursal;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objEmpleado.Codigo;
                        sqlcmd.Parameters.Add("xnombre", MySqlDbType.VarChar).Value = objEmpleado.Txtbuscar;
                        sqlcmd.Parameters.Add("xiddepto", MySqlDbType.Int32).Value = objEmpleado.Iddepto;
                        sqlcmd.Parameters.Add("xidhorario", MySqlDbType.Int32).Value = objEmpleado.Idhorario;

                        MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
                        da.Fill(dtresultado);
                    }
                }
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return dtresultado;
        }

        // Mostrar empleados verificados para registrar asistencias
        public DataTable DMostrarEmpleadosVerificados(DEmpleados objEmpleado)
        {
            DataTable dtresultado = new DataTable("tbempleados");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objEmpleado.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Empleados_Verificados";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xopcion", MySqlDbType.Int32).Value = objEmpleado.Opcion;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objEmpleado.Codigo;
                        sqlcmd.Parameters.Add("xpin", MySqlDbType.VarChar).Value = objEmpleado.Pin;

                        MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
                        da.Fill(dtresultado);
                    }
                }
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return dtresultado;
        }

        //// Buscar empleado por id
        //public DataTable DBuscarxCodigo(DEmpleados objEmpleado)
        //{
        //    DataTable dtresultado = new DataTable("tbempleados");
        //    MySqlConnection sqlcon = new MySqlConnection();
        //    try
        //    {
        //        using (var conexion = GetConexion())
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "SP_Listar_Empleado_Verificado";
        //                sqlcmd.CommandType = CommandType.StoredProcedure;
        //                sqlcmd.Parameters.AddWithValue("xcodigo", objEmpleado.Codigo);
        //                MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
        //                da.Fill(dtresultado);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        dtresultado = null;
        //    }
        //    finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
        //    return dtresultado;
        //}

        //// Buscar empleado por id
        //public DataTable DBuscarxCodigoPin(DEmpleados objEmpleado)
        //{
        //    DataTable dtresultado = new DataTable("tbempleados");
        //    MySqlConnection sqlcon = new MySqlConnection();
        //    try
        //    {
        //        using (var conexion = GetConexion())
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "SP_Listar_Empleado_Verificado_Pin";
        //                sqlcmd.CommandType = CommandType.StoredProcedure;
        //                sqlcmd.Parameters.AddWithValue("xcodigo", objEmpleado.Codigo);
        //                sqlcmd.Parameters.AddWithValue("xpin", objEmpleado.Pin);
        //                MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
        //                da.Fill(dtresultado);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        dtresultado = null;
        //    }
        //    finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
        //    return dtresultado;
        //}

        //// Buscar empleado por codigo
        //public DataTable DBuscarxCodigoExt(DEmpleados objEmpleado)
        //{
        //    DataTable dtresultado = new DataTable("tbempleados");
        //    MySqlConnection sqlcon = new MySqlConnection();
        //    try
        //    {
        //        using (var conexion = conext.GetConexion())
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "SELECT codigo, fmodifica from tbempleados where codigo = @codigo";
        //                sqlcmd.Parameters.AddWithValue("@codigo", objEmpleado.Codigo);
        //                MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
        //                da.Fill(dtresultado);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        dtresultado = null;
        //    }
        //    finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
        //    return dtresultado;
        //}

        // Actualizar estado del registro en el empleado, para saber si es entrada o salida
        public string DActualizarEmpleadosAsistencia(DEmpleados objEmpleado)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Actualizar_Empleados_Asistencias";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objEmpleado.Codigo;
                        sqlcmd.Parameters.Add("xstatus", MySqlDbType.Int32).Value = objEmpleado.Estadoreg;
                        sqlcmd.Parameters.Add("xfultimoreg", MySqlDbType.DateTime).Value = objEmpleado.FUltimoReg;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return resultado;
        }        

        // Contar empleados por sucursal
        public DataTable DContarEmpleadosxSucursal(DEmpleados objEmpleado)
        {
            DataTable dtresultado = new DataTable("tbempleados");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Contar_Empleados_Sucursal";
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
                        da.Fill(dtresultado);
                    }
                }
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return dtresultado;
        }


        //Actualizar subarea de empleado
        public string DEditarEmpleadoSubArea(DEmpleados objEmpleado)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Actualiza_Empleado_SubArea";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objEmpleado.Codigo;
                        sqlcmd.Parameters.Add("xidsubarea", MySqlDbType.Int32).Value = objEmpleado.IdSubArea;
                        

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se edito el empleado correctamente";
                    }
                }
            }
            catch (Exception er)
            {
                resultado = er.Message;
            }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return resultado;
        }
    }
}
