using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Gestion_Sall_De_Sport.Classes
{
    public class BaseDeDonner
    {
        public static SqlConnection conect()
        {
            string string_conection = Properties.Settings.Default.DB;
            return new SqlConnection(string_conection);
        }
        public static DataTable Select_Table(string table_name)
        {
            SqlConnection Conection = conect();
            string query = "select * from " + table_name;
            if (Conection.State != ConnectionState.Open) { Conection.Open(); }
            DataTable table = new DataTable(table_name);
            SqlDataAdapter adapter = new SqlDataAdapter(query,Conection);
            adapter.Fill(table);
            Conection.Close();
            return table;
        }

        public static void Excut_Query(string query)
        {
            SqlConnection Conection = conect();
            if (Conection.State != ConnectionState.Open) { Conection.Open(); }
            SqlCommand sql_excute = new SqlCommand(query,Conection);
            sql_excute.ExecuteNonQuery();
            Conection.Close();
        }

    }
}
