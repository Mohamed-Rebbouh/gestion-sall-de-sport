using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Sall_De_Sport.Classes
{
    public  class Vente
    {
        private string name, fname;
        private int contiti;
        private float price;

        public Vente(string name,string fname ,int c, float price)
        {
            this.name = name;
            this.fname = fname;
            this.contiti = c;
            this.price = price;

        }

        public void Insert()
        {

            SqlConnection conection = Classes.BaseDeDonner.conect();
            string query = "insert into vente (Name_v,FName_v,Contiti,Price) vlaues('" + this.name + "','" + fname + "'," + this.contiti + "," + this.price + ")";
            Classes.BaseDeDonner.Excut_Query(query);



        }
        
    }
}
