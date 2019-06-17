using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMyBed
{
    class RezervasyonDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial Catalog=FindMyBed;Integrated Security=true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Bölge> GetBölge()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT * FROM Bölgeler", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Bölge> bölgeler = new List<Bölge>();
            while (reader.Read())
            {
                Bölge bölge = new Bölge
                {
                    bölgeID = (int)reader["Id"],
                    bölgeAd = reader["BölgeAdı"].ToString()
                };
                bölgeler.Add(bölge);
            }
            reader.Close();
            _connection.Close();
            return bölgeler;
        }
        public List<Misafir> GetMisafir()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT * FROM Misafirler ORDER BY Ad ASC", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Misafir> misafirler = new List<Misafir>();
            while (reader.Read())
            {

                Misafir misafir = new Misafir
                {
                    Id = (int)reader["Id"],
                    Ad = reader["Ad"].ToString(),
                    Soyad = reader["Soyad"].ToString(),
                    KimlikId = reader["KimlikId"].ToString(),
                    Telefon = reader["Telefon"].ToString(),
                    Email = reader["Email"].ToString(),
                };
                misafirler.Add(misafir);
            }
            reader.Close();
            _connection.Close();
            return misafirler;
        }
        public DataTable GetVillalar(string giriş, string çıkış, int id)
        {
            ConnectionControl();
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(@"
                SELECT * FROM Villalar WHERE (Villalar.Id NOT IN( SELECT VillaID FROM OtelRezervasyon WHERE (GirişTarihi<'" + giriş +
                "'" + "AND ÇıkışTarihi>'" + giriş + "') OR" +
                "(GirişTarihi> '" + çıkış +
                "'" + "AND ÇıkışTarihi<'" + çıkış + "') OR"
                +
                "(ÇıkışTarihi " +
                "= '" + çıkış +
                "'" + "AND GirişTarihi='" + giriş + "') )) AND BölgeID=" + id, _connection);
            sa.Fill(dt);
            _connection.Close();
            return dt;

        }
        public string GetResimYolu(string id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand(@"
                SELECT ResimYolu FROM Villalar WHERE Id=" + id, _connection);

            string sonuç = command.ExecuteScalar().ToString();
            return sonuç;
        }
        public int GetBölgeId(string id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand(@"
                SELECT Id FROM Bölgeler WHERE BölgeAdı=" + "'" + id + "'", _connection);

            int sonuç = Convert.ToInt32(command.ExecuteScalar().ToString());
            return sonuç;
        }
        public int GetVillaId(string id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand(@"
                SELECT Id FROM Villalar WHERE VillaAd=" + "'" + id + "'", _connection);

            int sonuç = Convert.ToInt32(command.ExecuteScalar().ToString());
            return sonuç;
        }
        public int GetMisafirId()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand(@"
                SELECT TOP 1 Id FROM Misafirler ORDER BY Id DESC", _connection);

            int sonuç = Convert.ToInt32(command.ExecuteScalar().ToString());
            return sonuç;
        }
        public int GetRezervasyonId()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand(@"
                SELECT TOP 1 Id FROM Rezervasyonlar ORDER BY Id DESC", _connection);

            int sonuç = Convert.ToInt32(command.ExecuteScalar().ToString());
            return sonuç;
        }
        public void Add(Misafir misafir)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Misafirler VALUES(@Ad,@Soyad,@KimlikId,@Telefon,@Email)", _connection);
            command.Parameters.AddWithValue("@Ad", misafir.Ad);
            command.Parameters.AddWithValue("@Soyad", misafir.Soyad);
            command.Parameters.AddWithValue("@KimlikId", misafir.KimlikId);
            command.Parameters.AddWithValue("@Telefon", misafir.Telefon);
            command.Parameters.AddWithValue("@Email", misafir.Email);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Add(OtelRezervasyon otelRezervasyon)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO OtelRezervasyon VALUES(@VillaId,@RezervasyonId,@GirişTarihi,@ÇıkışTarihi)", _connection);
            command.Parameters.AddWithValue("@VillaId", otelRezervasyon.VillaId);
            command.Parameters.AddWithValue("@RezervasyonId", otelRezervasyon.RezervasyonId);
            command.Parameters.AddWithValue("@GirişTarihi", otelRezervasyon.GirişT);
            command.Parameters.AddWithValue("@ÇıkışTarihi", otelRezervasyon.ÇıkışT);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Add(Rezervasyon rezervasyon)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Rezervasyonlar VALUES(@GirişTarihi,@ÇıkışTarihi,@BölgeId,@Ücret,@VillaId,@MisafirId)", _connection);

            command.Parameters.AddWithValue("@GirişTarihi", rezervasyon.GirişTarihi);
            command.Parameters.AddWithValue("@ÇıkışTarihi", rezervasyon.ÇıkışTarihi);
            command.Parameters.AddWithValue("@BölgeId", rezervasyon.BölgeId);
            command.Parameters.AddWithValue("@Ücret", rezervasyon.Ücret);
            command.Parameters.AddWithValue("@VillaId", rezervasyon.VillaId);
            command.Parameters.AddWithValue("@MisafirID", rezervasyon.MisafirId);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
