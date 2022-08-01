using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public class DDataBase : DConexion
    {
        string _Ruta;
        private int _OpConexion;

        public string Ruta { get => _Ruta; set => _Ruta = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }

        public DDataBase()
        {
        }

        public DDataBase(string pruta, int popconexion)
        {
            this.Ruta = pruta;
            this.OpConexion = popconexion;
        }

        public string DBackup(DDataBase objDataBase)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conn = CreaConexion(objDataBase.OpConexion))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(objDataBase.Ruta);
                            conn.Close();

                            if (mb.LastError == null) resultado = "ok";
                            
                            else resultado = "No se realizo corrcetamente el respaldo";
                        }
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
