using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using System.Data;

namespace CNegocio
{
    public class NDataBase
    {
        // Realizar respaldos
        public static string NBackup(string pruta, int popconexion)
        {
            DDataBase objDataBase = new DDataBase();
            objDataBase.Ruta = pruta;
            objDataBase.OpConexion = popconexion;
            return objDataBase.DBackup(objDataBase);
        }
    }
}
