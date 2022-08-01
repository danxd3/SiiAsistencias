using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public class DDescansos : DConexion
    {
        int _Iddescanso;
        DateTime _Fecha;
        string _Codigo;
        private string _TxtBuscar;
        private int _Opcion;
        private DateTime _Fechaini;
        private DateTime _Fechafin;
        private int _OpConexion;

        public int Iddescanso { get => _Iddescanso; set => _Iddescanso = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string TxtBuscar { get => _TxtBuscar; set => _TxtBuscar = value; }
        public int Opcion { get => _Opcion; set => _Opcion = value; }
        public DateTime Fechaini { get => _Fechaini; set => _Fechaini = value; }
        public DateTime Fechafin { get => _Fechafin; set => _Fechafin = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }
        
        public DDescansos() { }

        public DDescansos(int piddescanso, DateTime pfecha, string pcodigo, string ptxtbuscar, int popcion, DateTime pfechaini, 
            DateTime pfechafin, int popconexion)
        {
            this.Iddescanso = piddescanso;
            this.Fecha = pfecha;
            this.Codigo = pcodigo;
            this.TxtBuscar = ptxtbuscar;
            this.Opcion = popcion;
            this.Fechaini = pfechaini;
            this.Fechafin = pfechafin;
            this.OpConexion = popconexion;
        }

        // Agregar Descansos
        public string DAgregarDescansos(DDescansos objDescanso)
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
                        sqlcmd.CommandText = "SP_Insertar_Descansos";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xiddescanso", objDescanso.Iddescanso).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add("xfecha", MySqlDbType.Date).Value = objDescanso.Fecha;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objDescanso.Codigo;

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

        // Mostrar los descansos
        public DataTable DMostrarDescansos(DDescansos objDescanso)
        {
            DataTable dtresultado = new DataTable("tbdescansos");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objDescanso.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Descansos";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xopcion", MySqlDbType.Int32).Value = objDescanso.Opcion;
                        sqlcmd.Parameters.Add("xfechaini", MySqlDbType.Date).Value = objDescanso.Fechaini;
                        sqlcmd.Parameters.Add("xfechafin", MySqlDbType.Date).Value = objDescanso.Fechafin;

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
