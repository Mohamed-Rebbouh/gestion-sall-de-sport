using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Sall_De_Sport.Classes
{
    public class Client
    {

        private string name { get; set; }

        private string Fname { get; set; }

        public Client(string name,string Fname)
        {

            this.name = name;
            this.Fname = Fname;
        }

        public void Insert()
        {
            SqlConnection conection = Classes.BaseDeDonner.conect();
            string query = "insert into client (Name_c,FName_c)values('" + this.name + "','" + this.Fname + "')";
            Classes.BaseDeDonner.Excut_Query(query);
        }






    }
}
