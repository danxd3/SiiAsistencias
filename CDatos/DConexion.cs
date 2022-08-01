using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Xml;

namespace CDatos
{
    public class DConexion
    {
        // Instancia de la clase que permitira encriptar o desencriptar contraseñas
        Clases.clsMd5 md5 = new Clases.clsMd5(); 

        private string _Server;
        private string _User;
        private string _Password;
        private string _DataBase;
        private string _Port;
        private int _Conexion;

        private string conexionstring;

        public string Server { get => _Server; set => _Server = value; }
        public string User { get => _User; set => _User = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string DataBase { get => _DataBase; set => _DataBase = value; }
        public string Port { get => _Port; set => _Port = value; }
        public int Conexion { get => _Conexion; set => _Conexion = value; }

        public DConexion() { }

        public DConexion(string pserver, string puser, string ppasword, string pdatabase, string pport)
        {
            this.Server = pserver;
            this.User = puser;
            this.Password = ppasword;
            this.DataBase = pdatabase;
            this.Port = pport;
        }

        public MySqlConnection CreaConexion(int popcion)
        {
            Conexion = popcion;

            if (Conexion == 1) //Conexion local
            {
                this.Server = ConfigurationManager.AppSettings["host"];
                this.User = ConfigurationManager.AppSettings["user"];
                this.Password = ConfigurationManager.AppSettings["pass"];
                this.DataBase = ConfigurationManager.AppSettings["database"];
                this.Port = ConfigurationManager.AppSettings["port"];

                conexionstring = "server=" + Server + ";port=" + Port + ";database=" + DataBase + ";uid=" + User + ";pwd=" + Password + ";";
            }
            else // Conexion externa
            {
                string encrypt = ConfigurationManager.AppSettings["passext"];
                if (encrypt != string.Empty)
                {
                    encrypt = md5.Decrypt(encrypt);
                }

                this.Server = ConfigurationManager.AppSettings["hostext"];
                this.Port = ConfigurationManager.AppSettings["portext"];
                this.DataBase = ConfigurationManager.AppSettings["databaseext"];
                this.User = ConfigurationManager.AppSettings["userext"];
                this.Password = encrypt;

                conexionstring = "server=" + Server + ";port=" + Port + ";database=" + DataBase + ";uid=" + User + ";pwd=" + Password + ";";
            }

            return new MySqlConnection(conexionstring);
        }

        //Agregar parametros de conexion ext
        public static string DParametrosConexion(DConexion objConexion)
        {
            string resultado = "";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "hostext") node.Attributes[1].Value = objConexion.Server;
                        if (node.Attributes[0].Value == "databaseext") node.Attributes[1].Value = objConexion.DataBase;
                        if (node.Attributes[0].Value == "userext") node.Attributes[1].Value = objConexion.User;
                        if (node.Attributes[0].Value == "passext") node.Attributes[1].Value = objConexion.Password;
                        if (node.Attributes[0].Value == "portext") node.Attributes[1].Value = objConexion.Port;
                    }
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
            return resultado;
        }

    }
}
