using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Gestion_de_Notas
{
    public static class ConfigConnection
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["Notas"].ConnectionString;
        //public static string connectionString = ConfigurationManager.ConnectionStrings["secayo"].ConnectionString;
    }
}
