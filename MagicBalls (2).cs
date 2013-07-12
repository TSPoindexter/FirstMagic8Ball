using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Magic8Ball
{
    public class MagicBalls
    {
        

        public static string Magic()
        {
            List<string> magicList = new List<string>();

            int ran;
            Random rdm = new Random();
            ran = rdm.Next(20);

            string connectionString =
                "Data Source=(local);Initial Catalog=Magic;"
                + "Integrated Security=true";

            string queryString = string.Format("SELECT fortune from dbo.magic4 WHERE number = {0}", ran);

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
            
                var command = new SqlCommand(queryString, connection);

                string query = "select * from magic4";

                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

               SqlDataReader sqlReader = cmd.ExecuteReader(); 
               while(sqlReader.Read()){

               magicList.Add(sqlReader["fortune"].ToString());

               }

                conn.Close();
               

                return magicList.ElementAt(ran);
            }
        }
    }
}