using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CDatos
{
    public class DSubAreas : DConexion
    {
        private int _IdSubArea;
        private string _Nombre;
        private string _Descripcion;
        private DateTime _Fmodifica;
        private string _Txtbucar;
        private int _OpConexion;

        public int IdSubArea { get => _IdSubArea; set => _IdSubArea = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public DateTime Fmodifica { get => _Fmodifica; set => _Fmodifica = value; }
        public string Txtbucar { get => _Txtbucar; set => _Txtbucar = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }

        public DSubAreas()
        {
        }

        public DSubAreas(int pidsubarea, string pnombre, string pdescripcion, DateTime pfmodifica, string ptxtbuscar, int popconexion)
        {
            this.IdSubArea = pidsubarea;
            this.Nombre = pnombre;
            this.Descripcion = pdescripcion;
            this.Fmodifica = pfmodifica;
            this.Txtbucar = ptxtbuscar;
            this.OpConexion = popconexion;
        }
        //Agregar SubAreas
        public string DAgregarSubAreas(DSubAreas objSubArea)
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
                        sqlcmd.CommandText = "SP_Insertar_SubArea";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xidsubarea", objSubArea.IdSubArea).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add("xnombrearea", MySqlDbType.VarChar).Value = objSubArea.Nombre;
                        sqlcmd.Parameters.Add("xdescripcion", MySqlDbType.VarChar).Value = objSubArea.Descripcion;
                        sqlcmd.Parameters.Add("xfmodifica", MySqlDbType.Date).Value = objSubArea.Fmodifica;
                        
                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego la sub area correctamente";
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
        //Editar SubAreas
        public string DEditarSubArea(DSubAreas objSubArea)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using(var sqlcmd=new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Actualizar_SubArea";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xidsubarea", MySqlDbType.Int32).Value = objSubArea.IdSubArea;
                        sqlcmd.Parameters.Add("xnombrearea", MySqlDbType.VarChar).Value = objSubArea.Nombre;
                        sqlcmd.Parameters.Add("xdescripcion", MySqlDbType.VarChar).Value = objSubArea.Descripcion;
                        sqlcmd.Parameters.Add("xfmodifica", MySqlDbType.Date).Value = objSubArea.Fmodifica;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se edito el departamento correctamente";
                    }
                }
            }catch(Exception er)
            {
                resultado = er.Message;
            }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return resultado;
        }


        // Mostrar departamentos
        public DataTable DMostrarSubAreas(DSubAreas objDepto)
        {
            DataTable dtresultado = new DataTable("tbsubareas");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_SubAreas";
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

        public string DEliminarSubArea(DSubAreas objSubArea)
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
                        sqlcmd.CommandText = "SP_Eliminar_SubArea";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xidsubarea", MySqlDbType.Int32).Value = objSubArea.IdSubArea;
                        

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se pudo eliminar la Sub Area correctamente";
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
