using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBaglanti
{
    public static class db
    {
        public static SqlConnection conn()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        }
    }
}
