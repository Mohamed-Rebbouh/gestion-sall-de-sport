using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Sall_De_Sport.Classes
{
    public  class Abonment
    {
        private DateTime Date_debut;
        private DateTime Date_fin;
        private int NBR_Seance;
        public Abonment(DateTime date_d,DateTime date_f,int nbr)
        {
        
            Date_debut = date_d;
            Date_fin = date_f;
            NBR_Seance = nbr;

        }
        public void Insert()
        {
            SqlConnection conection = Classes.BaseDeDonner.conect();
            string query = "insert into abonment (date_debut,date_fin,nbr) values('"+this.Date_debut+"','"+this.Date_fin+"',"+this.NBR_Seance+")";
            Classes.BaseDeDonner.Excut_Query(query);
        }






    }
}
