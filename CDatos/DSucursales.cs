using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace CDatos
{
    public class DSucursales : DConexion
    {
        Clases.clsMd5 md5 = new Clases.clsMd5();

        private int _Idsucursal;
        private string _Sucursal;
        private string _HostS;
        private string _DBS;
        private string _UsuarioS;
        private string _ClaveS;
        private int _PuertoS;
        private int _Actual;
        private int _Activo;
        private int _Idsociedad;
        private int _Nube;
        private int _Opcion;
        private int _OpConexion;

        public int Idsucursal { get => _Idsucursal; set => _Idsucursal = value; }
        public string Sucursal { get => _Sucursal; set => _Sucursal = value; }
        public string HostS { get => _HostS; set => _HostS = value; }
        public string DBS { get => _DBS; set => _DBS = value; }
        public string UsuarioS { get => _UsuarioS; set => _UsuarioS = value; }
        public string ClaveS { get => _ClaveS; set => _ClaveS = value; }
        public int PuertoS { get => _PuertoS; set => _PuertoS = value; }
        public int Actual { get => _Actual; set => _Actual = value; }
        public int Idsociedad { get => _Idsociedad; set => _Idsociedad = value; }
        public int Nube { get => _Nube; set => _Nube = value; }
        public int Opcion { get => _Opcion; set => _Opcion = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }
        public int Activo { get => _Activo; set => _Activo = value; }

        public DSucursales() { }

        public DSucursales(int pidsucursal, string psucursal, string phosts, string pdbs, string pusuarios, string pclaves, int ppuertos,
            int pactual, int pactivo, int pidsociedad, int pnube, int popcion, int popconexion)
        {
            this.Idsucursal = pidsucursal;
            this.Sucursal = psucursal;
            this.HostS = phosts;
            this.DataBase = pdbs;
            this.User = pusuarios;
            this.ClaveS = pclaves;
            this.PuertoS = ppuertos;
            this.Actual = pactual;
            this.Activo = pactivo;
            this.Idsociedad = pidsociedad;
            this.Nube = pnube;
            this.Opcion = popcion;
            this.OpConexion = popconexion;
        }

        // Agregar sucursal
        public string DAgregarSucursales(DSucursales objSucursal)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            string encrypt = md5.Encrypt(objSucursal.ClaveS);

            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Insertar_Sucursales";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("xidsucursal", objSucursal.Idsucursal).Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add("xsucursal", MySqlDbType.VarChar).Value = objSucursal.Sucursal;
                        sqlcmd.Parameters.Add("xdirhost", MySqlDbType.VarChar).Value = objSucursal.HostS;
                        sqlcmd.Parameters.Add("xbasedatos", MySqlDbType.VarChar).Value = objSucursal.DBS;
                        sqlcmd.Parameters.Add("xusuario", MySqlDbType.VarChar).Value = objSucursal.UsuarioS;
                        sqlcmd.Parameters.Add("xcontrasena", MySqlDbType.VarChar).Value = encrypt;
                        sqlcmd.Parameters.Add("xpuerto", MySqlDbType.Int32).Value = objSucursal.PuertoS;
                        sqlcmd.Parameters.Add("xactual", MySqlDbType.Int32).Value = objSucursal.Actual;
                        sqlcmd.Parameters.Add("xactivo", MySqlDbType.Int32).Value = objSucursal.Activo;
                        sqlcmd.Parameters.Add("xnube", MySqlDbType.Int32).Value = objSucursal.Nube;

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

        // Editar sucursales
        public string DEditarSucursales(DSucursales objSucursal)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();
            int opcion = objSucursal.Opcion;
            string encrypt = objSucursal.ClaveS;

            if(opcion != 1) encrypt = md5.Encrypt(objSucursal.ClaveS);
            
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Actualizar_Sucursales";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objSucursal.Idsucursal;
                        sqlcmd.Parameters.Add("xsucursal", MySqlDbType.VarChar).Value = objSucursal.Sucursal;
                        sqlcmd.Parameters.Add("xhost", MySqlDbType.VarChar).Value = objSucursal.HostS;
                        sqlcmd.Parameters.Add("xbd", MySqlDbType.VarChar).Value = objSucursal.DBS;
                        sqlcmd.Parameters.Add("xuser", MySqlDbType.VarChar).Value = objSucursal.UsuarioS;
                        sqlcmd.Parameters.Add("xpass", MySqlDbType.VarChar).Value = encrypt; 
                        sqlcmd.Parameters.Add("xport", MySqlDbType.Int32).Value = objSucursal.PuertoS;
                        sqlcmd.Parameters.Add("xactual", MySqlDbType.Int32).Value = objSucursal.Actual;
                        sqlcmd.Parameters.Add("xactivo", MySqlDbType.Int32).Value = objSucursal.Activo;
                        sqlcmd.Parameters.Add("xnube", MySqlDbType.Int32).Value = objSucursal.Nube;
                        sqlcmd.Parameters.Add("xopcion", MySqlDbType.Int32).Value = opcion;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se actualizo el registro correctamente";
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

        // Eliminar sucursales
        public string DEliminarSucursales(DSucursales objSucursal)
        {
            string resultado = "";
            MySqlConnection sqlcon = new MySqlConnection();

            try
            {
                using (var conexion = CreaConexion(objSucursal.OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Eliminar_Sucursales";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objSucursal.Idsucursal;

                        resultado = sqlcmd.ExecuteNonQuery() == 1 ? "ok" : "No se actualizo el registro correctamente";
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

        //// Buscar sucursales actual
        //public DataTable DBuscarSucursalActual()
        //{
        //    DataTable dtresultado = new DataTable("tbsucursales");
        //    MySqlConnection sqlcon = new MySqlConnection();
        //    try
        //    {
        //        using (var conexion = GetConexion())
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "select idsucursal, sucursal from tbsucursales where actual = 1";
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

        //// Mostrar sucursales
        //public DataTable DMostrarSucursales()
        //{
        //    DataTable dtresultado = new DataTable("tbsucursales");
        //    MySqlConnection sqlcon = new MySqlConnection();
        //    try
        //    {
        //        using (var conexion = GetConexion())
        //        {
        //            conexion.Open();
        //            using (var sqlcmd = new MySqlCommand())
        //            {
        //                sqlcmd.Connection = conexion;
        //                sqlcmd.CommandText = "SELECT * FROM tbsucursales";
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

        // Mostrar sucursales
        public DataTable DMostrarSucursales(DSucursales objSucursal)
        {
            DataTable dtresultado = new DataTable("tbsucursales");
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Mostrar_Sucursales";
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add("xopcion", MySqlDbType.Int32).Value = objSucursal.Opcion;
                        sqlcmd.Parameters.Add("xidsucursal", MySqlDbType.Int32).Value = objSucursal.Idsucursal;

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
