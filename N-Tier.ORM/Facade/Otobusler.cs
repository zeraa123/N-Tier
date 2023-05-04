using N_Tier.ORM.Entity;
using N_Tier.ORM_Otobus.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.ORM.Facade
{
    internal class Otobusler
    {
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select *from Otobus", Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Insert(Otobus o)
        {
            SqlCommand komut = new SqlCommand("Otobus_Insert_Proc @p1,@p2,@p3,@p4");

            komut.Parameters.AddWithValue("@p1", o.Plaka);
            komut.Parameters.AddWithValue("@p2", o.Marka);
            komut.Parameters.AddWithValue("@p3", o.Firma);
            komut.Parameters.AddWithValue("@p4", o.Koltuk);

            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);
        }

        public static bool Update(Otobus o)
        {
            SqlCommand komut = new SqlCommand("Otobus_Update_Proc @p1,@p2,@p3,@p4,@p5");
            komut.Parameters.AddWithValue("@p1", o.Plaka);
            komut.Parameters.AddWithValue("@p2", o.Marka);
            komut.Parameters.AddWithValue("@p3", o.Firma);
            komut.Parameters.AddWithValue("@p4", o.Koltuk);
            komut.Parameters.AddWithValue("@p5", o.OtobusId);

            return Tools.ExecuteNonQuery(komut);
        }
        public static bool Delete(Otobus o)
        {
            SqlCommand komut = new SqlCommand("Otobus_Delete_Proc @z");
            komut.Parameters.AddWithValue("@z", o.OtobusId);
            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);
        }
    }
}
