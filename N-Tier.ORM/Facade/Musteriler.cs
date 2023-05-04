using N_Tier.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.ORM.Facade
{
    internal class Musteriler
    {
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select *from Musteri", Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        //insert metodu
        public static bool Insert(Musteri k)
        {
            SqlCommand komut = new SqlCommand("entity_facade @p1,@p2,@p3,@p4");
            
            komut.Parameters.AddWithValue("@p1", k.Adi);
            komut.Parameters.AddWithValue("@p2", k.Soyadi);
            komut.Parameters.AddWithValue("@p3", k.Cinsiyet);
            komut.Parameters.AddWithValue("@p4", k.TcNO);

            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);
        }

        //Update metodu
        public static bool Update(Musteri k)
        {
            SqlCommand komut = new SqlCommand("entity_facade2 @p1,@p2,@p3,@p4,@p5");
            komut.Parameters.AddWithValue("@p1", k.Adi);
            komut.Parameters.AddWithValue("@p2", k.Soyadi);
            komut.Parameters.AddWithValue("@p3", k.Cinsiyet);
            komut.Parameters.AddWithValue("@p4", k.TcNO);
            komut.Parameters.AddWithValue("@p5", k.Id);

            return Tools.ExecuteNonQuery(komut);
        }
        //Delete metodu
        public static bool Delete(Musteri k)
        {
            SqlCommand komut = new SqlCommand("entity_facade3 @z");
            komut.Parameters.AddWithValue("@z", k.Id);
            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);
        }

    }
}
