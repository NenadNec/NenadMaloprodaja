using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maloprodaja.Klase
{
    public class GlobalnaKlasa
    {
        public GlobalnaKlasa()
        {
            LogProxy.Configure();
        }
        public static List<IdentifikacijaKupca> VratiListuIdentifikacija()
        {
            List<IdentifikacijaKupca> list = new List<IdentifikacijaKupca>();

            var connectionString = ConfigurationManager.ConnectionStrings["Maloprodaja"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand("SELECT Code, Name FROM MP_Identifikacija_Kupca (nolock) WHERE IsDocument = 0 ORDER BY Code", conn))
                    {
                        SqlDataReader reader = dCmd.ExecuteReader();

                        while (reader.Read())
                        {
                            IdentifikacijaKupca item = new IdentifikacijaKupca();

                            item.code = reader.GetString(0);
                            item.name = reader.GetString(1);

                            list.Add(item);
                        }
                    }
                    conn.Close();
                }
                return list;
            }
            catch (Exception ex)
            {
                LogProxy.log.Error(ex.Message + "Error:" + ex.StackTrace);
                return list; ;
            }
        }

        public static DataTable getDataTable()
        {

            DataTable dt = new DataTable();

            var connectionString = ConfigurationManager.ConnectionStrings["Maloprodaja"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand(@"SELECT TOP 20
                                   f.id AS 'Inerni broj',
                                   f.idBlagajna AS 'Interni broj blagajne',
                                   convert(varchar, f.sdcDateTime, 104) + ' ' + CONVERT(varchar, f.sdcDateTime, 108) as 'Vreme računa',
                                   f.invoiceCounter AS 'Brojač računa',
                                   f.invoiceNumber AS 'Broj računa',
                                   f.totalAmount AS 'Ukupan iznos računa',
                                   f.mrc AS 'Kod proizvođača',
                                   f.request AS 'Zahtev',
                                   f.refundirano 'Status refundacije'
                                   FROM PfrResponse f
                                   LEFT JOIN Blagajna b ON b.id = f.idBlagajna
                                   WHERE 1 = 1 ORDER BY sdcDateTime DESC;", conn))
                    {
                        dt.Load(dCmd.ExecuteReader());
                    }
                    conn.Close();
                }
                return dt;
            }
            catch (SqlException ex)
            {
                LogProxy.log.Error(ex.Message + "Error:" + ex.StackTrace);
                return dt; ;
            }
        }

        public static List<Proizvod> UcitajProizvode()
        {
            List<Proizvod> lista = new List<Proizvod>();
            try
            {

                var connectionString = ConfigurationManager.ConnectionStrings["Maloprodaja"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand("SELECT p.id, p.nazivProizvoda, p.sifraProizvoda, p.poreskaLabela, p.napomena, p.poreskaStopa, p.cena FROM Proizvodi p;", conn))
                    {

                        dCmd.CommandType = CommandType.Text;
                        using (SqlDataReader reader = dCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Proizvod proizvod = new Proizvod();
                                proizvod.id = Convert.ToInt32(reader.GetValue(0));
                                proizvod.nazivProizvoda = reader[1].ToString();
                                proizvod.sifraProizvoda = reader[2].ToString();
                                proizvod.poreskaLabela = reader[3].ToString();
                                proizvod.napomena = reader[4].ToString();
                                proizvod.poreskaStopa = Convert.ToDouble(reader[5]);
                                proizvod.cena = Convert.ToDouble(reader[6]);
                                lista.Add(proizvod);
                            }
                        }
                    }
                    conn.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                LogProxy.log.Error(ex.Message + "Error:" + ex.StackTrace);
                return lista;
            }
        }

        public static List<IdentifikacijaKupca> VratiListuIdentifikacijaZaDokumenta()
        {
            List<IdentifikacijaKupca> list = new List<IdentifikacijaKupca>();

            var connectionString = ConfigurationManager.ConnectionStrings["Maloprodaja"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand("SELECT Code, Name FROM MP_Identifikacija_Kupca (nolock) WHERE IsDocument = 1 ORDER BY Code", conn))
                    {
                        SqlDataReader reader = dCmd.ExecuteReader();

                        while (reader.Read())
                        {
                            IdentifikacijaKupca item = new IdentifikacijaKupca();

                            item.code = reader.GetString(0);
                            item.name = reader.GetString(1);

                            list.Add(item);
                        }
                    }
                    conn.Close();
                }
                return list;
            }
            catch(Exception ex)
            {
                LogProxy.log.Error(ex.Message + "Error:" + ex.StackTrace);
                return list; ;
            }
        }
        public static void SacuvajProizvod(Proizvod p)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Maloprodaja"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand dCmd = new SqlCommand("insert into Proizvodi(nazivProizvoda, sifraProizvoda, poreskaLabela, napomena, poreskaStopa, cena) values(N'" + p.nazivProizvoda + "', N'" + p.sifraProizvoda + "',N'" + p.poreskaLabela + "',N'" + p.napomena + "'," + p.poreskaStopa + "," + p.cena + ")", conn))
                {
                    try
                    {
                        dCmd.CommandType = CommandType.Text;
                        dCmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) 
                    { 
                        LogProxy.log.Error(ex.Message + "Error:" + ex.StackTrace);
                    }
                    finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }

                    conn.Close();
                }
            }
        }

        public static List<Proizvod> VratiProizvode()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Maloprodaja"].ConnectionString;
            List<Proizvod> list = new List<Proizvod>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction tn;
                conn.Open();
                using (SqlCommand dCmd = new SqlCommand("select * from Proizvodi", conn))
                {
                    try
                    {
                        dCmd.CommandType = CommandType.Text;

                        using (SqlDataReader reader = dCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Proizvod p = new Proizvod();
                                p.nazivProizvoda = reader[1].ToString();
                                p.sifraProizvoda = reader[2].ToString();
                                p.poreskaLabela = reader[3].ToString();
                                p.napomena = reader[4].ToString();
                                p.poreskaStopa = Convert.ToDouble(reader[5].ToString());
                                p.cena = Convert.ToDouble(reader[6].ToString());
                                list.Add(p);
                            }
                        }

                    }
                    catch (SqlException ex) 
                    { 
                        LogProxy.log.Error(ex.Message + "Error:" + ex.StackTrace); 
                    }
                    finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }

                    conn.Close();
                }
            }

            return list;
        }
    }
}
