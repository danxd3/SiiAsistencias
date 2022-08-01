using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace CDatos
{
    public class DRegistros : DConexion
    {
        private int _Idregistros;
        private string _Codigo;
        private DateTime _FechaHora;
        private int _Status;
        private int _Idsociedad;
        private int _Idsucursal;
        private int _Activo;
        private int _Sync;

        private int _Opcion;
        private DateTime _FechaHrEntrada;
        private DateTime _FechaHrSalida;
        private DateTime _Fechaini;
        private DateTime _Fechafin;
        private int _Iddepto;
        private int _OpConexion;
        
        public int Idregistros { get => _Idregistros; set => _Idregistros = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public DateTime FechaHora { get => _FechaHora; set => _FechaHora = value; }
        public int Status { get => _Status; set => _Status = value; }
        public int Idsociedad { get => _Idsociedad; set => _Idsociedad = value; }
        public int Idsucursal { get => _Idsucursal; set => _Idsucursal = value; }
        public int Activo { get => _Activo; set => _Activo = value; }
        public int Sync { get => _Sync; set => _Sync = value; }
        public int Opcion { get => _Opcion; set => _Opcion = value; }        
        public DateTime FechaHrEntrada { get => _FechaHrEntrada; set => _FechaHrEntrada = value; }
        public DateTime FechaHrSalida { get => _FechaHrSalida; set => _FechaHrSalida = value; }        
        public DateTime Fechaini { get => _Fechaini; set => _Fechaini = value; }
        public DateTime Fechafin { get => _Fechafin; set => _Fechafin = value; }
        public int Iddepto { get => _Iddepto; set => _Iddepto = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }
        

        public DRegistros()
        {
        }

        public DRegistros(int pidregistro, string pcodigo, DateTime pfechahora, int pstatus, int pidsociedad, int pidsucursal,
            int pactivo, int psync, int popcion, DateTime pfechahrentrada, DateTime pfechahrsalida, DateTime pfechaini,
            DateTime pfechafin, int piddepto, int popconexion)
        {
            this.Idregistros = pidregistro;
            this.Codigo = pcodigo;
            this.FechaHora = pfechahora;
            this.Status = pstatus;
            this.Idsociedad = pidsociedad;
            this.Idsucursal = pidsucursal;
            this.Activo = pactivo;
            this.Sync = psync;
            this.Opcion = popcion;
            this.FechaHrEntrada = pfechahrentrada;
            this.FechaHrSalida = pfechahrsalida;
            this.Fechaini = pfechaini;
            this.Fechafin = pfechafin;
            this.Iddepto = piddepto;
            this.OpConexion = popconexion;
        }

        // Agregar registros de asistencias
        public string DAgregarRegistros(DRegistros objRegistro)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objRegistro.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Insertar_Registros";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xidregistro", objRegistro.Idregistros).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objRegistro.Codigo;
                        sqlcmd.Parameters.Add("xfechahorareg", MySqlDbType.DateTime).Value = objRegistro.FechaHora;
                        sqlcmd.Parameters.Add("xstatus", MySqlDbType.Int32).Value = objRegistro.Status;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objRegistro.Idsucursal;

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

        // Mostrar registros para al calculo de asistencias
        public DataTable DMostrarRegistrosAsistencias(DRegistros objRegistro)
        {
            DataTable dtresultado = new DataTable("tbregistros");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objRegistro.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Registros_Asistencias";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xopcion", MySqlDbType.Int32).Value = objRegistro.Opcion;
                        sqlcmd.Parameters.Add("xfechaini", MySqlDbType.Date).Value = objRegistro.Fechaini;
                        sqlcmd.Parameters.Add("xfechafin", MySqlDbType.Date).Value = objRegistro.Fechafin;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objRegistro.Idsucursal;
                        sqlcmd.Parameters.Add("xiddepto", MySqlDbType.Int32).Value = objRegistro.Iddepto;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objRegistro.Codigo;                        

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
        //Mostrar registros de asistencia en sucursal
        public DataTable DMostrarRegistrosAsistenciasSucursal(DRegistros objRegistro)
        {
            DataTable dtresultado = new DataTable("tbregistros");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objRegistro.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Asistencias_PAreas";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xfechaini", MySqlDbType.Date).Value = objRegistro.Fechaini;
                        sqlcmd.Parameters.Add("xfechafin", MySqlDbType.Date).Value = objRegistro.Fechafin;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objRegistro.Idsucursal;
                       
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
        
        // Mostrar registros para la revision, sincronizacion
        public DataTable DMostrarRegistros(DRegistros objRegistro)
        {
            DataTable dtresultado = new DataTable("tbregistros");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objRegistro.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Registros";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xopcion", MySqlDbType.Int32).Value = objRegistro.Opcion;
                        sqlcmd.Parameters.Add("xsync", MySqlDbType.Int32).Value = objRegistro.Sync;
                        sqlcmd.Parameters.Add("xfechaini", MySqlDbType.Date).Value = objRegistro.Fechaini;
                        sqlcmd.Parameters.Add("xfechafin", MySqlDbType.Date).Value = objRegistro.Fechafin;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objRegistro.Idsucursal;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objRegistro.Codigo;
                        sqlcmd.Parameters.Add("xiddepto", MySqlDbType.Int32).Value = objRegistro.Iddepto;

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

        // Actualizar registros sincronizados
        public DataTable DActualizarRegistrosSync(DRegistros objRegistro)
        {
            DataTable dtresultado = new DataTable("tbregistros");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objRegistro.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Actualizar_Registros_Sync";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xidregistro", MySqlDbType.Int32).Value = objRegistro.Idregistros;

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

        //// Mostrar registros
        //public DataTable DMostrarRegistros(DRegistros objRegistro)
        //{
        //    //DataTable dtresultado = new DataTable("tbregistros");
        //    //MySqlConnection sqlcon = new MySqlConnection();
        //    //try
        //    //{
        //    //    using (var conexion = CreaConexion(objRegistro.OpConexion))
        //    //    {
        //    //        conexion.Open();
        //    //        using (var sqlcmd = new MySqlCommand())
        //    //        {
        //    //            sqlcmd.Connection = conexion;
        //    //            sqlcmd.CommandText = "SP_Obtener_Registros";
        //    //            sqlcmd.CommandType = CommandType.StoredProcedure;
        //    //            sqlcmd.Parameters.AddWithValue("xopcion", objRegistro.Opcion);
        //    //            sqlcmd.Parameters.AddWithValue("xidsociedad", objRegistro.Idsociedad);
        //    //            sqlcmd.Parameters.AddWithValue("xidsucursal", objRegistro.Idsucursal);
        //    //            sqlcmd.Parameters.AddWithValue("xcodigo", objRegistro.Codigo);
        //    //            sqlcmd.Parameters.Add("xfechaini", MySqlDbType.Date).Value = objRegistro.Fechaini;
        //    //            sqlcmd.Parameters.Add("xfechafin", MySqlDbType.Date).Value = objRegistro.Fechafin;

        //    //            MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
        //    //            da.Fill(dtresultado);
        //    //        }
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    dtresultado = null;
        //    //}
        //    //finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
        //    //return dtresultado;
        //}

        //// Listar Registros por departamentos
        //public DataTable DMostrarRegistrosPrueba(DRegistros objRegistro)
        //{
        //    DataTable dtresultado = new DataTable("tbregistros");
        //    MySqlConnection sqlcon = new MySqlConnection();
        //    try
        //    {
        //        using (var conexion = GetConexion())
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "SP_Listar_Registros";
        //                sqlcmd.CommandType = CommandType.StoredProcedure;
        //                sqlcmd.Parameters.Add("xfechaini", MySqlDbType.Date).Value = objRegistro.Fechaini;
        //                sqlcmd.Parameters.Add("xfechafin", MySqlDbType.Date).Value = objRegistro.Fechafin;

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

        public DataTable DMostrarRegistrosxRevisar(DRegistros objRegistro)
        {
            DataTable dtresultado = new DataTable("tbregistros");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Listar_Registros_ES";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xfechaini", MySqlDbType.Date).Value = objRegistro.Fechaini;
                        sqlcmd.Parameters.Add("xfechafin", MySqlDbType.Date).Value = objRegistro.Fechafin;
                        sqlcmd.Parameters.Add("xopcion", MySqlDbType.Int32).Value = objRegistro.Opcion;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objRegistro.Idsucursal;
                        sqlcmd.Parameters.Add("xiddepto", MySqlDbType.Int32).Value = objRegistro.Iddepto;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objRegistro.Codigo;

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

        // Modificar estados de los registros
        public string DModificarRegistrosEstados(DRegistros objRegistro)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objRegistro.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Actualizar_Registros_Estados";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xidregistro", MySqlDbType.Int32).Value = objRegistro.Idregistros;
                        sqlcmd.Parameters.Add("xestado", MySqlDbType.Int32).Value = objRegistro.Status;

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

        // Modificar estados de los registros
        public string DModificarRegistrosActivos(DRegistros objRegistro)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objRegistro.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Actualizar_Registros_Activos";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xidregistro", MySqlDbType.Int32).Value = objRegistro.Idregistros;

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

        //// Modificar estados de los registros sincronizados
        //public string DModificarSincronizados(DRegistros objRegistro)
        //{
        //    string resultado = "";
        //    MySqlConnection sqlcon = new MySqlConnection();
        //    try
        //    {
        //        using (var conexion = GetConexion())
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "UPDATE tbregistros SET sync = 1 WHERE idregistros = @idregistro";
        //                sqlcmd.Parameters.AddWithValue("@idregistro", objRegistro.Idregistros);

        //                resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        resultado = ex.Message;
        //    }
        //    finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
        //    return resultado;
        //}

        //// Modificar registros cuando las lecturas son continuas
        //public DataTable DMostarRegistrosContinuos(DRegistros objRegistro)
        //{
        //    DataTable dtresultado = new DataTable("tbregistros");
        //    MySqlConnection sqlcon = new MySqlConnection();
        //    try
        //    {
        //        using (var conexion = GetConexion())
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "SP_Listar_Registro_Continuo_Empleado";
        //                sqlcmd.CommandType = CommandType.StoredProcedure;
        //                sqlcmd.Parameters.AddWithValue("xcodigo", objRegistro.Codigo);
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

        //// Agregar registros de asistencias ext
        //public string DAgregarRegistrosExt(DRegistros objRegistro)
        //{
        //    string resultado = "";
        //    MySqlConnection sqlcon = new MySqlConnection();
        //    try
        //    {
        //        using (var conexion = conext.GetConexion())
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "INSERT INTO tbregistros (idempleado, codigo, fechahorareg, status, idsucursal) " +
        //                                     "VALUES(@idempleado, @codigo, @fechahorareg, @status, @idsucursal)";
        //                sqlcmd.Parameters.AddWithValue("@idempleado", objRegistro.Idempleado);
        //                sqlcmd.Parameters.AddWithValue("@codigo", objRegistro.Codigo);
        //                sqlcmd.Parameters.AddWithValue("@fechahorareg", objRegistro.Fecharegistro);
        //                sqlcmd.Parameters.AddWithValue("@status", objRegistro.Status);
        //                sqlcmd.Parameters.AddWithValue("@idsucursal", objRegistro.Idsucursal);

        //                resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        resultado = ex.Message;
        //    }
        //    finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
        //    return resultado;
        //}
    }
}
