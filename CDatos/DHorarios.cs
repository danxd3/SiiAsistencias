using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CDatos
{
    public class DHorarios : DConexion
    {
        private int _Idhorario;
        private string _Nombre;
        private string _Hrentrada;
        private string _Hrsalida;
        private string _Tolerancia;
        private string _Txtbuscar;
        private DateTime _Fmodifica;
        private int _OpConexion;

        public int Idhorario { get => _Idhorario; set => _Idhorario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Hrentrada { get => _Hrentrada; set => _Hrentrada = value; }
        public string Hrsalida { get => _Hrsalida; set => _Hrsalida = value; }
        public string Tolerancia { get => _Tolerancia; set => _Tolerancia = value; }
        public string Txtbuscar { get => _Txtbuscar; set => _Txtbuscar = value; }
        public DateTime Fmodifica { get => _Fmodifica; set => _Fmodifica = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }        

        public DHorarios() { }

        public DHorarios(int pidhorario, string pnombre, string phrentrada, string phrsalida, string ptolerancia, string ptxtbuscar, 
            DateTime pfmodifica, int popconexion)
        {
            this.Idhorario = pidhorario;
            this.Nombre = pnombre;
            this.Hrentrada = phrentrada;
            this.Hrsalida = phrsalida;
            this.Tolerancia = ptolerancia;
            this.Fmodifica = pfmodifica;
            this.OpConexion = popconexion;
        }

        // Agregar horarios
        public string DAgregarHorarios(DHorarios objHorario)
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
                        sqlcmd.CommandText = "SP_Insertar_Horarios";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xidhorario", objHorario.Idhorario).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add("xnombre", MySqlDbType.VarChar).Value = objHorario.Nombre;
                        sqlcmd.Parameters.Add("xhrentrada", MySqlDbType.VarChar).Value = objHorario.Hrentrada;
                        sqlcmd.Parameters.Add("xhrsalida", MySqlDbType.VarChar).Value = objHorario.Hrsalida;
                        sqlcmd.Parameters.Add("xtolerancia", MySqlDbType.VarChar).Value = objHorario.Tolerancia;
                        sqlcmd.Parameters.Add("xfmodifica", MySqlDbType.Date).Value = objHorario.Fmodifica;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se pudo agregar correctamente el Horario";
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

        // Editar horarios
        public string DEditarHorarios(DHorarios objHorario)
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
                        sqlcmd.CommandText = "SP_Actualizar_Horarios";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xidhorario", MySqlDbType.Int32).Value = objHorario.Idhorario;
                        sqlcmd.Parameters.Add("xnombre", MySqlDbType.VarChar).Value = objHorario.Nombre;
                        sqlcmd.Parameters.Add("xhrentrada", MySqlDbType.VarChar).Value = objHorario.Hrentrada;
                        sqlcmd.Parameters.Add("xhrsalida", MySqlDbType.VarChar).Value = objHorario.Hrsalida;
                        sqlcmd.Parameters.Add("xtolerancia", MySqlDbType.VarChar).Value = objHorario.Tolerancia;
                        sqlcmd.Parameters.Add("xfmodifica", MySqlDbType.Date).Value = objHorario.Fmodifica;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se pudo editar correctamente el Horario";
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

        // Eliminar horarios
        public string DEliminarHorarios(DHorarios objHorario)
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
                        sqlcmd.CommandText = "SP_Eliminar_Horarios";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xidhorario", MySqlDbType.Int32).Value = objHorario.Idhorario;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se pudo eliminar correctamente el Horario";
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

        // Mostrar horarios
        public DataTable DMostrarHorarios(DHorarios objHorario)
        {
            DataTable dtresultado = new DataTable("tbhorarios");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Horarios";
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
