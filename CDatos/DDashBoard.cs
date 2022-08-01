using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CDatos
{
    public class DDashBoard : DConexion
    {
        private int _CounSucursal;
        private int _CountHorarios;
        private int _CountDeptos;
        private int _OpConexion;

        public int CounSucursal { get => _CounSucursal; set => _CounSucursal = value; }
        public int CountHorarios { get => _CountHorarios; set => _CountHorarios = value; }
        public int CountDeptos { get => _CountDeptos; set => _CountDeptos = value; }
        public int OpConexion { get => _OpConexion; set => _OpConexion = value; }

        public DDashBoard() { }

        public DDashBoard(int pcountsucursal, int pcountdeptos, int pcounthorarios, int popconexion)
        {
            this.CounSucursal = pcountsucursal;
            this.CountDeptos = pcountdeptos;
            this.CountHorarios = pcounthorarios;
            this.OpConexion = popconexion;
        }

        // Mostrar las cantidades de los elementos
        public List<DDashBoard> DContadorElementos(DDashBoard objDashboard)
        {
            var ListaElementos = new List<DDashBoard>();
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                using (var conexion = CreaConexion(OpConexion))
                {
                    conexion.Open();
                    using (var sqlcmd = new MySqlCommand())
                    {
                        sqlcmd.Connection = conexion;
                        sqlcmd.CommandText = "SP_Contador_DashBoard";
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        MySqlParameter sucursal = new MySqlParameter("countsucursal", MySqlDbType.Int32);
                        sucursal.Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add(sucursal);

                        MySqlParameter depto = new MySqlParameter("countdeptos", MySqlDbType.Int32);
                        depto.Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add(depto);

                        MySqlParameter horario = new MySqlParameter("counthorarios", MySqlDbType.Int32);
                        horario.Direction = ParameterDirection.Output;
                        sqlcmd.Parameters.Add(horario);

                        sqlcmd.ExecuteNonQuery();
                        int auxsuc = Int32.Parse(sqlcmd.Parameters["countsucursal"].Value.ToString());
                        if(Convert.ToBoolean(auxsuc) != false)
                        {
                            var lista = new DDashBoard()
                            {
                                CounSucursal = Convert.ToInt32(sqlcmd.Parameters["countsucursal"].Value),
                                CountDeptos = Convert.ToInt32(sqlcmd.Parameters["countdeptos"].Value),
                                CountHorarios = Convert.ToInt32(sqlcmd.Parameters["counthorarios"].Value),
                            };
                            ListaElementos.Add(lista);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ListaElementos = null;
            }
            finally { if (sqlcon.State == ConnectionState.Open) sqlcon.Close(); }
            return ListaElementos;
        }

    }
}
