using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;   

namespace CRUD
{
    public class BdComun
    {
        public static MySqlConnection ObtenerConexion()
        {
            string conectionString= @"server=127.0.0.1; database=Programacion; Uid=root; pwd=pollo2419;";
            MySqlConnection conectar  = new MySqlConnection(conectionString);
            conectar.Open();
            return conectar;
        }
    }
}
