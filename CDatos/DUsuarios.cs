using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace CDatos
{
    public class DUsuarios : DConexion
    {
        Clases.clsMd5 md5 = new Clases.clsMd5();

        int _Idusuario;
        string _Nombre;
        string _Usuario;
        string _Clave;
        string _Tipo;
        string _Txtbuscar;
        private bool _CambiaClave;
        private int _Opcion;
        private int _OpConexion;

        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Txtbuscar { get => _Txtbuscar; set => _Txtbuscar = value; }
        public bool CambiaClave { get => _CambiaClave; set => _CambiaClave = value; }
        public int Opcion { get => _Opcion; set => _Opcion = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }
        

        public DUsuarios()
        {
        }

        public DUsuarios(int pidusuario, string pnombre, string pusuario, string pclave, string ptipo, string ptxtbuscar, 
            bool pcambiaclave, int popcion, int popconexion)
        {
            this.Idusuario = pidusuario;
            this.Nombre = pnombre;
            this.Usuario = pusuario;
            this.Clave = pclave;
            this.Tipo = ptipo;
            this.Txtbuscar = ptxtbuscar;
            this.CambiaClave = pcambiaclave;
            this.OpConexion = popconexion;
        }

        // Agregar usuarios
        public string DagregarUsuarios(DUsuarios objUsuario)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            string encrypt = md5.Encrypt(objUsuario.Clave);
            try
            {
                using (var conexion = CreaConexion(objUsuario.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Insertar_Usuarios";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xidusuario", objUsuario.Idusuario).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add("xnombre", MySqlDbType.VarChar).Value = objUsuario.Nombre;
                        sqlcmd.Parameters.Add("xusuario", MySqlDbType.VarChar).Value = objUsuario.Usuario;
                        sqlcmd.Parameters.Add("xclave", MySqlDbType.VarChar).Value = encrypt;
                        sqlcmd.Parameters.Add("xtipo", MySqlDbType.VarChar).Value = objUsuario.Tipo;
                        
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

        // Editar usuario
        public string DEditarUsuarios(DUsuarios objUsuario)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();

            bool opcion = objUsuario.CambiaClave;
            string encrypt = objUsuario.Clave;

            if (opcion == true) encrypt = md5.Encrypt(objUsuario.Clave);

            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Actualizar_Usuarios";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xidusuario", MySqlDbType.Int32).Value =  objUsuario.Idusuario;
                        sqlcmd.Parameters.Add("xnombre", MySqlDbType.VarChar).Value = objUsuario.Nombre;
                        sqlcmd.Parameters.Add("xusuario", MySqlDbType.VarChar).Value = objUsuario.Usuario;
                        sqlcmd.Parameters.Add("xclave", MySqlDbType.VarChar).Value = encrypt;
                        sqlcmd.Parameters.Add("xtipo", MySqlDbType.VarChar).Value = objUsuario.Tipo;

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

        // Metodo para eliminar usuarios
        public string DEliminarUsuario(DUsuarios objUsuario)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objUsuario.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Eliminar_Usuario";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xidusuario", MySqlDbType.Int32).Value = objUsuario.Idusuario;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            return resultado;
        }

        // Metodo para mostrar usuario
        public DataTable DMostrarUsuarios(DUsuarios objUsuario)
        {
            DataTable dtresultado = new DataTable("tbusuario");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objUsuario.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Usuarios";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xopcion", MySqlDbType.Int32).Value = objUsuario.Opcion;
                        sqlcmd.Parameters.Add("xtxtbuscar", MySqlDbType.VarChar).Value = objUsuario.Txtbuscar;

                        MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
                        da.Fill(dtresultado);
                    }
                }
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            return dtresultado;
        }

        // Metodo del login
        public DataTable Login(DUsuarios objUsuario)
        {
            DataTable dtresultado = new DataTable("tbusuario");
            string auxpass = md5.Encrypt(objUsuario.Clave);

            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(objUsuario.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Usuarios_Login";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xusuario", MySqlDbType.VarChar).Value = objUsuario.Usuario;
                        sqlcmd.Parameters.Add("xclave", MySqlDbType.VarChar).Value = auxpass;

                        MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);
                        da.Fill(dtresultado);
                    }
                }
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            return dtresultado;
        }
    }
}
