using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Sall_De_Sport.Classes
{
    public  class Entrinement
    {
        private string name;
        private string fname;
        private DateTime time;
        public Entrinement(string name ,string fname ,DateTime date)
        {
            this.name = name;
            this.fname = fname;
            this.time = date;
        }
        public void Insert()
        {
            SqlConnection conection = Classes.BaseDeDonner.conect();
            string query = "insert into entrinement (Name_e,Fname_e,Time_e) values('" + this.name + "','" + this.fname + "','" + this.time + "')";
            Classes.BaseDeDonner.Excut_Query(query);
        }
    }
}
