using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace projet_Stage
{
    class CConnection
    {
        private static SqlConnection cn;
        public static SqlDataReader dr;
        private static SqlCommand cmd;

        public static void Connecter()
        {
            cn = new SqlConnection("server=localhost;database=PROJET_STAGE;integrated security=true;");
            cn.Open();
        }
        public static void SQuery(string query)
        {
            cmd = new SqlCommand(query, cn);
            dr = cmd.ExecuteReader();
        }
        public static void DIUQuery(string query)
        {
            cmd = new SqlCommand(query, cn);
            cmd.ExecuteNonQuery();
        }
        public static void Deconnecter()
        {
            cn.Close();
        }

    }
}
