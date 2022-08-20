using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CDatos
{
    public class DInacistencia:DConexion
    {
        private int _IdInasistencia;
        private string _Codigo;
        private DateTime _FechaInicial;
        private DateTime _FechaFinal;
        private int _Status;
        private string _Observaciones;
        private int _idSucursal;
        private int _Sync;
        private int _OpConexion;
        private int _Opcion;

        public int IdInasistencia { get => _IdInasistencia; set => _IdInasistencia = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public DateTime FechaInicial { get => _FechaInicial; set => _FechaInicial = value; }
        public DateTime FechaFinal { get => _FechaFinal; set => _FechaFinal = value; }
        public int Status { get => _Status; set => _Status = value; }
        public string Observaciones { get => _Observaciones; set => _Observaciones = value; }
        public int IdSucursal { get => _idSucursal; set => _idSucursal = value; }
        public int Sync { get => _Sync; set => _Sync = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }
        public int Opcion { get => _Opcion; set => _Opcion = value; }

        public DInacistencia()
        {

        }

        public DInacistencia(int pidinasistencia, string pcodigo, DateTime pfechainicial,DateTime pfechafinal, int pstatus,int pidsucursal,string pobservaciones,
            int psync,int popconexion,int popcion)
        {
            this.IdInasistencia = pidinasistencia;
            this.Codigo = pcodigo;
            this.FechaInicial = pfechainicial;
            this.FechaFinal = pfechafinal;
            this.Status = pstatus;
            this.Observaciones = pobservaciones;
            this.IdSucursal = pidsucursal;
            this.Sync = psync;
            this.OpConexion = popconexion;
            this.Opcion = popcion;
        }


        // Agregar registros de Inasistencias
        public string DAgregarInasisitencias(DInacistencia objRegistro)
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
                        sqlcmd.CommandText = "SP_Insertar_Inasistencia";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xidinasistencia", objRegistro.IdInasistencia).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.AddWithValue("xidobservacion", objRegistro.IdInasistencia).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add("xcodigo", MySqlDbType.VarChar).Value = objRegistro.Codigo;
                        sqlcmd.Parameters.Add("xfechainicial", MySqlDbType.DateTime).Value = objRegistro.FechaInicial;
                        sqlcmd.Parameters.Add("xfechafinal", MySqlDbType.DateTime).Value = objRegistro.FechaFinal;
                        sqlcmd.Parameters.Add("xstatus", MySqlDbType.Int32).Value = objRegistro.Status;
                        sqlcmd.Parameters.Add("xobservacion", MySqlDbType.VarChar).Value = objRegistro.Observaciones;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objRegistro.IdSucursal;

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
