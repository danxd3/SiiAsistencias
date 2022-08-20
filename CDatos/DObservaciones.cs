using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CDatos
{
    public class DObservaciones : DConexion
    {
        private int _Idobservaciones;
        private int _General;
        private string _Codigo;
        private DateTime _Fecha;
        private string _Observacion;
        private int _Opcion;
        private DateTime _Fechaini;
        private DateTime _Fechafin;
        private int _Idsucursal;
        private int _OpConexion;

        public int Idobservaciones { get => _Idobservaciones; set => _Idobservaciones = value; }
        public int General { get => _General; set => _General = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Observacion { get => _Observacion; set => _Observacion = value; }
        public int Idsucursal { get => _Idsucursal; set => _Idsucursal = value; }
        public int Opcion { get => _Opcion; set => _Opcion = value; }
        public DateTime Fechaini { get => _Fechaini; set => _Fechaini = value; }
        public DateTime Fechafin { get => _Fechafin; set => _Fechafin = value; }
        
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }

        public DObservaciones() { }

        public DObservaciones(int pidobservacion, int pgeneral, string pcodigo, DateTime pfecha, string pobservacion,
            int pidsucursal, int popcion, DateTime pfechaini, DateTime pfechafin, int popconexion)
        {
            this.Idobservaciones = pidobservacion;
            this.General = pgeneral;
            this.Codigo = pcodigo;
            this.Fecha = pfecha;
            this.Observacion = pobservacion;
            this.Idsucursal = pidsucursal;
            this.Opcion = popcion;
            this.Fechaini = pfechaini;
            this.Fechafin = pfechafin;
            this.OpConexion = popconexion;            
        }

        // Agregar observación
        public string DAgregarObservacion(DObservaciones objObservacion)
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
                        sqlcmd.CommandText = "SP_Insertar_Observaciones";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xidobservacion", objObservacion.Idobservaciones).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add("xgeneral", MySqlDbType.Int32).Value = objObservacion.General;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objObservacion.Codigo;
                        sqlcmd.Parameters.Add("xfecha", MySqlDbType.Date).Value = objObservacion.Fecha;
                        sqlcmd.Parameters.Add("xobservacion", MySqlDbType.VarChar).Value = objObservacion.Observacion;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.VarChar).Value = objObservacion.Idsucursal;
                        
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

        // Agregar observación
        //public int  DAgregarObservacionReturnId(DObservaciones objObservacion)
        //{
        //    int resultado = -1;
        //    MySqlConnection sqlcon = new MySqlConnection();

        //    try
        //    {
        //        using (var conexion = CreaConexion(OpConexion))
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "SP_Insertar_Observaciones";
        //                sqlcmd.CommandType = CommandType.StoredProcedure;
        //                sqlcmd.Parameters.AddWithValue("xidobservacion", objObservacion.Idobservaciones).Direction = ParameterDirection.Output;
        //                sqlcmd.Parameters.Add("xgeneral", MySqlDbType.Int32).Value = objObservacion.General;
        //                sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objObservacion.Codigo;
        //                sqlcmd.Parameters.Add("xfecha", MySqlDbType.Date).Value = objObservacion.Fecha;
        //                sqlcmd.Parameters.Add("xobservacion", MySqlDbType.VarChar).Value = objObservacion.Observacion;
        //                sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.VarChar).Value = objObservacion.Idsucursal;

        //                resultado = sqlcmd.ExecuteNonQuery() == 1 ? (int)sqlcmd.LastInsertedId : -1;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        resultado = -1;
        //    }
        //    finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
        //    return resultado;
        //}


        // Mostrar observaciones
        public DataTable DMostrarObservaciones(DObservaciones objObservacion)
        {
            DataTable dtresultado = new DataTable("tbobservaciones");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objObservacion.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Observaciones";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xopcion", objObservacion.Opcion);
                        sqlcmd.Parameters.AddWithValue("xfechaini", objObservacion.Fechaini);
                        sqlcmd.Parameters.AddWithValue("xfechafin", objObservacion.Fechafin);
                        sqlcmd.Parameters.AddWithValue("xidsucursal", objObservacion.Idsucursal);

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

        // Actualizar observaciones sincronizadas
        public string DModificarSincronizados(DObservaciones objObservacion)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();

            try
            {
                using (var conexion = CreaConexion(objObservacion.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Observaciones";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xidobservacion", MySqlDbType.Int32).Value = objObservacion.Idobservaciones;

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
    }
}
