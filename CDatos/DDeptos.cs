using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace CDatos
{
    public class DDeptos : DConexion
    {

        private int _IdDepto;
        private string _Nombre;
        private string _Descripcion;
        private DateTime _Fmodifica;
        private string _Txtbucar;
        private int _OpConexion;

        public int IdDepto { get => _IdDepto; set => _IdDepto = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public DateTime Fmodifica { get => _Fmodifica; set => _Fmodifica = value; }
        public string Txtbucar { get => _Txtbucar; set => _Txtbucar = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }        

        public DDeptos()
        {
        }

        public DDeptos(int piddepto, string pnombre, string pdescripcion, DateTime pfmodifica, string ptxtbuscar, int popconexion)
        {
            this.IdDepto = piddepto;
            this.Nombre = pnombre;
            this.Descripcion = pdescripcion;
            this.Fmodifica = pfmodifica;
            this.Txtbucar = ptxtbuscar;
            this.OpConexion = popconexion;
        }

        // Agregar departamentos
        public string DAgregarDepto(DDeptos objDepto)
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
                        sqlcmd.CommandText = "SP_Insertar_Deptos";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xiddepto", objDepto.IdDepto).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add("xnombre", MySqlDbType.VarChar).Value = objDepto.Nombre;
                        sqlcmd.Parameters.Add("xdescripcion", MySqlDbType.VarChar).Value = objDepto.Descripcion;
                        sqlcmd.Parameters.Add("xfmodifica", MySqlDbType.Date).Value = objDepto.Fmodifica;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el departamento correctamente";
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

        // Editar departamentos
        public string DEditarDeptos(DDeptos objDepto)
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
                        sqlcmd.CommandText = "SP_Actualizar_Deptos";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xiddepto", MySqlDbType.Int32).Value = objDepto.IdDepto;
                        sqlcmd.Parameters.Add("xnombre", MySqlDbType.VarChar).Value = objDepto.Nombre;
                        sqlcmd.Parameters.Add("xdescripcion", MySqlDbType.VarChar).Value = objDepto.Descripcion;
                        sqlcmd.Parameters.Add("xfmodifica", MySqlDbType.Date).Value = objDepto.Fmodifica;
                        
                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se edito el departamento correctamente";
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

        // Eliminar departamentos
        public string DEliminarDeptos(DDeptos objDepto)
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
                        sqlcmd.CommandText = "SP_Eliminar_Deptos";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xiddepto", MySqlDbType.Int32).Value = objDepto.IdDepto;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se pudo eliminar el departamento correctamente";
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

        // Mostrar departamentos
        public DataTable DMostrarDeptos(DDeptos objDepto)
        {
            DataTable dtresultado = new DataTable("tbdeptos");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Deptos";
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
    }
}
