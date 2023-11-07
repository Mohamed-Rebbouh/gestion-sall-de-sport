using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Sall_De_Sport.Classes
{
    public  class Product
    {
        private string name;
        private float price;

        public Product(string name,float price)
        {
            this.name = name;
            this.price = price;

        }

        public void Insert()
        {
            SqlConnection conection = Classes.BaseDeDonner.conect();
            string query = "insert into product (Name_p,Price) values('" + this.name + "','" + this.price + "')";
            Classes.BaseDeDonner.Excut_Query(query);

        }


    }
}
