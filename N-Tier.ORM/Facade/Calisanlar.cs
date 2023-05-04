using N_Tier.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N_Tier.ORM_Otobus.Entity;

namespace N_Tier.ORM.Facade
{
    internal class Calisanlar
    {
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select *from Calisan", Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        //insert metodu
        public static bool Insert(Calisan c)
        {
            SqlCommand komut = new SqlCommand("Calisan_Insert_proc @p1,@p2,@p3,@p4");

            komut.Parameters.AddWithValue("@p1", c.Adi);
            komut.Parameters.AddWithValue("@p2", c.Soyadi);
            komut.Parameters.AddWithValue("@p3", c.Cinsiyet);
            komut.Parameters.AddWithValue("@p4", c.TcNo);

            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);
        }

        //Update metodu
        public static bool Update(Calisan k)
        {
            SqlCommand komut = new SqlCommand("Calisan_Update_proc @p1,@p2,@p3,@p4,@p5");
            komut.Parameters.AddWithValue("@p1", k.Adi);
            komut.Parameters.AddWithValue("@p2", k.Soyadi);
            komut.Parameters.AddWithValue("@p3", k.Cinsiyet);
            komut.Parameters.AddWithValue("@p4", k.TcNo);
            komut.Parameters.AddWithValue("@p5", k.Id);

            return Tools.ExecuteNonQuery(komut);
        }
        //Delete metodu
        public static bool Delete(Calisan k)
        {
            SqlCommand komut = new SqlCommand("Calisan_delete_proc @z");
            komut.Parameters.AddWithValue("@z", k.Id);
            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);
        }
    }
}
