using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace CDatos
{
    public class DHuellas : DConexion
    {
        private int _Idfinger;
        private int _Idempleado;
        private string _Codigo;
        private byte[] _Finger;
        private DateTime _Fmodifica;
        private int _Opcion;
        private int _OpConexion;

        public int Idfinger { get => _Idfinger; set => _Idfinger = value; }
        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public byte[] Finger { get => _Finger; set => _Finger = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public DateTime Fmodifica { get => _Fmodifica; set => _Fmodifica = value; }
        public int Opcion { get => _Opcion; set => _Opcion = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }
        
        public DHuellas()
        {
        }

        public DHuellas(int pidfinger, int pidempleado, string pcodigo, byte[] pfinger, DateTime pfmodifica, int popcion,
            int popconexion)
        {
            this.Idfinger = pidfinger;
            this.Idempleado = pidempleado;
            this.Codigo = pcodigo;
            this.Finger = pfinger;
            this.Fmodifica = pfmodifica;
            this.Opcion = popcion;
            this.OpConexion = popconexion;
        }

        // Agregar huellas
        public string DAgregarHuellas(DHuellas objHuellas)
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
                        sqlcmd.CommandText = "SP_Insertar_Huellas";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xidhuella", objHuellas.Idfinger).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objHuellas.Codigo;
                        sqlcmd.Parameters.Add("xfinger", MySqlDbType.MediumBlob).Value = objHuellas.Finger;
                        sqlcmd.Parameters.Add("xfmodifica", MySqlDbType.Date).Value = objHuellas.Fmodifica;

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

        // Editar huellas
        public string DEditarHuellas(DHuellas objHuellas)
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
                        sqlcmd.CommandText = "SP_Actualizar_Huellas";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objHuellas.Codigo;
                        sqlcmd.Parameters.Add("xfinger", MySqlDbType.MediumBlob).Value = objHuellas.Finger;
                        sqlcmd.Parameters.Add("xfmodifica", MySqlDbType.Date).Value = objHuellas.Fmodifica;

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

        // Eliminar huellas
        public string DEliminarHuellas(DHuellas objHuella)
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
                        sqlcmd.CommandText = "SP_Eliminar_Huellas";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objHuella.Codigo;

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

        // Mostrar huellas
        public DataTable DMostrarHuellas(DHuellas objHuella)
        {
            DataTable dtresultado = new DataTable("tbfingers");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objHuella.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Huellas";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xopcion", MySqlDbType.Int32).Value = objHuella.Opcion;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objHuella.Codigo;

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

        //// Buscar Huella
        //public DataTable DBuscarxHuella(DHuellas objHuellas)
        //{
        //    DataTable dtresultado = new DataTable("tbhuellas");
        //    MySqlConnection sqlcon = new MySqlConnection();
        //    try
        //    {
        //        using (var conexion = GetConexion())
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "SELECT idempleado, finger FROM tbfingers where finger = @finger";
        //                sqlcmd.Parameters.AddWithValue("@finger", objHuellas.Finger);
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

        //// Buscar Huella
        //public DataTable DBuscarxCodigo(DHuellas objHuellas)
        //{
        //    DataTable dtresultado = new DataTable("tbhuellas");
        //    MySqlConnection sqlcon = new MySqlConnection();
        //    try
        //    {
        //        using (var conexion = GetConexion())
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "SELECT codigo, finger FROM tbfingers where codigo = @codigo";
        //                sqlcmd.Parameters.AddWithValue("@codigo", objHuellas.Codigo);
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
        
    }
}
