using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace N_Tier.ORM
{
    internal class Tools
    {
        //C:\Users\ilker\Desktop\C# personel takip programı\N-Tier\N-Tier.sln

        
        private static SqlConnection baglanti =
            new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti2"].ConnectionString);

        public static SqlConnection Baglanti
        {
            get { return baglanti; }

        }

        public static bool ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();

                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

    }
}
