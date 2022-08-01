using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CDatos
{
    public class DIniciasys : DConexion
    {
        private int _Idinisys;
        private DateTime _Fhinisys;
        private int _Idsucursal;
        private int _Sync;
        private int _Idsociedad;
        private int _Opcionsql;
        private DateTime _Fechaini;
        private DateTime _Fechafin;
        private int _Opconexion;

        public int Idinisys { get => _Idinisys; set => _Idinisys = value; }
        public DateTime Fhinisys { get => _Fhinisys; set => _Fhinisys = value; }
        public int Idsucursal { get => _Idsucursal; set => _Idsucursal = value; }        
        public int Sync { get => _Sync; set => _Sync = value; }
        public int Idsociedad { get => _Idsociedad; set => _Idsociedad = value; }        
        public int Opcionsql { get => _Opcionsql; set => _Opcionsql = value; }
        public DateTime Fechaini { get => _Fechaini; set => _Fechaini = value; }
        public DateTime Fechafin { get => _Fechafin; set => _Fechafin = value; }
        public int Opconexion { get => _Opconexion; set => _Opconexion = value; }        

        public DIniciasys() { }

        public DIniciasys(int pidinisys, DateTime pfhinisys, int pidsucursal, int psync, int pidsociedad, int popcionsql, DateTime pfechaini,
            DateTime pfechafin, int popconexion)
        {
            this.Idinisys = pidinisys;
            this.Fhinisys = pfhinisys;
            this.Idsucursal = pidsucursal;
            this.Sync = psync;
            this.Idsociedad = pidsociedad;
            this.Opcionsql = popcionsql;
            this.Fechaini = pfechaini;
            this.Fechafin = pfechafin;
            this.Opconexion = popconexion;
        }

        // Agregar IniciaSys
        public string DAgregarIniciasys(DIniciasys objIniciasys)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objIniciasys.Opconexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Insertar_InicioSys";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xidinisys", objIniciasys.Idinisys).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add("xfhinisys", MySqlDbType.DateTime).Value = objIniciasys.Fhinisys;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objIniciasys.Idsucursal;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
                    }
                }
            }
            catch (Exception ex) { resultado = ex.Message; }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return resultado;
        }

        // Mostrar IniciaSys
        public DataTable DMostrarIniciasys(DIniciasys objIniciasys)
        {
            DataTable dtresultado = new DataTable("tbiniciasys");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objIniciasys.Opconexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Iniciasys";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xopcion", MySqlDbType.Int32).Value = objIniciasys.Opcionsql;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objIniciasys.Idsucursal;
                        sqlcmd.Parameters.Add("xfechaini", MySqlDbType.DateTime).Value = objIniciasys.Fechaini;
                        sqlcmd.Parameters.Add("xfechafin", MySqlDbType.DateTime).Value = objIniciasys.Fechafin;

                        MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
                        da.Fill(dtresultado);
                    }
                }
            }
            catch (Exception ex) { dtresultado = null; }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return dtresultado;
        }

    }
}
