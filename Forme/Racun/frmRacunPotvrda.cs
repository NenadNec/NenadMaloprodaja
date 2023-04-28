using ESC_POS_USB_NET.Enums;
using ESC_POS_USB_NET.Printer;
using Maloprodaja.Helper;
using Maloprodaja.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maloprodaja.Forme.Racun
{
    public partial class frmRacunPotvrda : Form
    {
        List<StavkaRacuna> lista = new List<StavkaRacuna>();
        int tipPlacanja = 0;
        List<int> tipPlac = new List<int>();
        int noviRedniBrojRacuna = 0;

        public event RacunHandler ReturnValue;
        public delegate void RacunHandler(string poruka);
        //public frmRacunPotvrda()
        //{
        //    InitializeComponent();
        //}

        public frmRacunPotvrda(List<StavkaRacuna> ListaStavki, decimal Ukupno, int TipPLacanja)
        {
            InitializeComponent();
            this.KeyPreview = true;
            lista = ListaStavki;
            lblIznosRacuna.Text = Ukupno.ToString();
            numGotovina.Select(0, numGotovina.Text.Length);
            tipPlacanja = 0;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Racunaj()
        {
            decimal ukupno = numGotovina.Value +
                numPlatnaKartica.Value +
                numCek.Value +
                numVirman.Value +
                numInstant.Value +
                numVaucer.Value +
                numOstalo.Value;
            lblUkupno.Text = ukupno.ToString();
            lblKusur.Text = (ukupno - Convert.ToDecimal(lblIznosRacuna.Text)).ToString();
        }

        private void numGotovina_ValueChanged(object sender, EventArgs e)
        {
            Racunaj();
        }

        private void numPlatnaKartica_ValueChanged(object sender, EventArgs e)
        {
            Racunaj();
        }

        private void numCek_ValueChanged(object sender, EventArgs e)
        {
            Racunaj();
        }

        private void numVirman_ValueChanged(object sender, EventArgs e)
        {
            Racunaj();
        }

        private void numInstant_ValueChanged(object sender, EventArgs e)
        {
            Racunaj();
        }

        private void numVaucer_ValueChanged(object sender, EventArgs e)
        {
            Racunaj();
        }

        private void numOstalo_ValueChanged(object sender, EventArgs e)
        {
            Racunaj();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // your logic here. For example:
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.F1:
                    numGotovina.Focus();
                    numGotovina.Select(0, numGotovina.Text.Length);
                    break;

                case Keys.F2:
                    numPlatnaKartica.Focus();
                    numPlatnaKartica.Select(0, numPlatnaKartica.Text.Length);
                    break;

                case Keys.F3:
                    numCek.Focus();
                    numCek.Select(0, numCek.Text.Length);
                    break;

                case Keys.F4:
                    numVirman.Focus();
                    numVirman.Select(0, numVirman.Text.Length);
                    break;

                case Keys.F5:
                    numInstant.Focus();
                    numInstant.Select(0, numInstant.Text.Length);
                    break;

                case Keys.F6:
                    numVaucer.Focus();
                    numVaucer.Select(0, numVaucer.Text.Length);
                    break;

                case Keys.F7:
                    numOstalo.Focus();
                    numOstalo.Select(0, numOstalo.Text.Length);
                    break;

                case Keys.F12:
                    InsertRacun();
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void numGotovina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUnesi.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void numPlatnaKartica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUnesi.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void numCek_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUnesi.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void numVirman_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUnesi.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void numInstant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUnesi.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void numVaucer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUnesi.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void numOstalo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUnesi.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            InsertRacun();
        }

        public void InsertRacun()
        {
            if (Convert.ToDecimal(lblUkupno.Text)-Convert.ToDecimal(lblIznosRacuna.Text) < 0)
            {
                MessageBox.Show("Uneti iznos ne može podmiriti račun!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                Klase.Racun r = new Klase.Racun();
                r.BrojRacuna = VratiBrojRacuna();
                r.TipRacuna = 0;
                r.TipTransakcije = 0;

                r.TipPlacanja = 0;
                r.OperaterRefId = Operater.Id;
                r.MpRefId = HelperService.mpId;
                r.ListaStavki = lista;

                bool result = InsertRacunUBazu(r);

                if (result)
                {
                    MessageBox.Show("Uspešno kreiran racun!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.ReturnValue("Uspesno");
                    this.Close();
                }
            }
        } 

        public IDictionary<int, decimal> GetDictionaryTipPlacanja()
        {

            IDictionary<int, decimal> result = new Dictionary<int, decimal>();

            if (numOstalo.Value > 0)
            {
                result.Add(0, numOstalo.Value);
            }
            if (numGotovina.Value > 0)
            {
                result.Add(1, numGotovina.Value);
            }
            if (numPlatnaKartica.Value > 0)
            {
                result.Add(2, numPlatnaKartica.Value);
            }
            if (numCek.Value > 0)
            {
                result.Add(3, numCek.Value);
            }
            if (numVirman.Value > 0)
            {
                result.Add(4, numVirman.Value);
            }
            if (numVaucer.Value > 0)
            {
                result.Add(5, numVaucer.Value);
            }
            if (numInstant.Value > 0)
            {
                result.Add(6, numInstant.Value);
            }

            return result;
        }
       
            

        public bool InsertRacunUBazu(Klase.Racun r)
        {
            bool result = false;
            int idRacuna = 0;
            //StavkaRacuna sr = new StavkaRacuna();

            string connectionString = HelperService.configConn;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                SqlCommand insertRacuna = new SqlCommand("INSERT INTO [dbo].[Racuni]([BrojRacuna],[TipRacuna],[TipTransakcije],[DatumRacuna],[OperaterRefId],[MpRefId]) VALUES(@BrojRacuna,@TipRacuna,@TipTransakcije,getdate(),@OperaterRefId,@MpRefId) select scope_identity()", conn, tran);

                insertRacuna.Parameters.Add("@BrojRacuna", SqlDbType.NVarChar).Value = r.BrojRacuna;
                insertRacuna.Parameters.Add("@TipRacuna", SqlDbType.Int).Value = r.TipRacuna;
                insertRacuna.Parameters.Add("@TipTransakcije", SqlDbType.Int).Value = r.TipTransakcije;
                insertRacuna.Parameters.Add("@OperaterRefId", SqlDbType.Int).Value = r.OperaterRefId;
                insertRacuna.Parameters.Add("@MpRefId", SqlDbType.Int).Value = r.MpRefId;

                try
                {
                    idRacuna = Convert.ToInt32(insertRacuna.ExecuteScalar());

                    //Nacin placanja
                    foreach (KeyValuePair<int, decimal> tipPlacanja in GetDictionaryTipPlacanja())
                    {
                        SqlCommand insertNacinPlacanja = new SqlCommand("INSERT INTO [dbo].[RacunTipPlacanja]([RacunRefId], [TipPlacanjaRefId], [Iznos]) VALUES(@RacunRefId,@TipPlacanjaRefId,@Iznos)", conn, tran);

                        insertNacinPlacanja.Parameters.Add("@RacunRefId", SqlDbType.Int).Value = idRacuna;
                        insertNacinPlacanja.Parameters.Add("@TipPlacanjaRefId", SqlDbType.Int).Value = tipPlacanja.Key;
                        insertNacinPlacanja.Parameters.Add("@Iznos", SqlDbType.Decimal).Value = tipPlacanja.Value;

                        insertNacinPlacanja.ExecuteNonQuery();
                    }


                    foreach (StavkaRacuna item in r.ListaStavki)
                    {
                        // Upis u tabelu RacunStavka
                        SqlCommand insertStavkaRacuna = new SqlCommand("INSERT INTO [dbo].[RacunStavka]([RacunRefId],[ArtikalRefId],[Kolicina],[Cena],[Popust],[Ukupno]) VALUES(@RacunRefId,@ArtikalRefId,@Kolicina,@Cena,@Popust,@Ukupno)", conn, tran);

                        insertStavkaRacuna.Parameters.Add("@RacunRefId", SqlDbType.Int).Value = idRacuna;
                        insertStavkaRacuna.Parameters.Add("@ArtikalRefId", SqlDbType.Int).Value = item.ArtikalRefId;
                        insertStavkaRacuna.Parameters.Add("@Kolicina", SqlDbType.Decimal).Value = item.Kolicina;
                        insertStavkaRacuna.Parameters.Add("@Cena", SqlDbType.Decimal).Value = item.Cena;
                        insertStavkaRacuna.Parameters.Add("@Popust", SqlDbType.Decimal).Value = item.Popust;
                        insertStavkaRacuna.Parameters.Add("@Ukupno", SqlDbType.Decimal).Value = item.Ukupno;

                        insertStavkaRacuna.ExecuteNonQuery();

                        //Upis u tabelu Promet
                        SqlCommand insertPromet = new SqlCommand("INSERT INTO [dbo].[Promet] ([ArtikalRefId] ,[MagacinRefId] ,[DokTip] ,[DokId] ,[DatumPrometa] ,[Ulaz] ,[Izlaz]) VALUES(@ArtikalRefId,@MagacinRefId,@DokTip,@RacunRefId,getdate(),@Ulaz,@Izlaz)", conn, tran);

                        insertPromet.Parameters.Add("@MagacinRefId", SqlDbType.Int).Value = 1;
                        insertPromet.Parameters.Add("@DokTip", SqlDbType.Int).Value = 0;
                        insertPromet.Parameters.Add("@RacunRefId", SqlDbType.Int).Value = idRacuna;
                        insertPromet.Parameters.Add("@ArtikalRefId", SqlDbType.Int).Value = item.ArtikalRefId;
                        insertPromet.Parameters.Add("@Ulaz", SqlDbType.Decimal).Value = 0;
                        insertPromet.Parameters.Add("@Izlaz", SqlDbType.Decimal).Value = item.Kolicina;

                        insertPromet.ExecuteNonQuery();

                    }

                    tran.Commit();

                    //PrintReceipt(r);

                    result = true;
                }
                catch (SqlException sqlEx)
                {
                    LogProxy.log.Error(sqlEx.Message);
                    tran.Rollback();
                }
                catch (Exception ex)
                {
                    LogProxy.log.Error(ex.Message);
                    tran.Rollback();
                }
                finally
                {
                    if(conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

            return result;
        }

        public string VratiBrojRacuna()
        {
            ProveraRacuna item = new ProveraRacuna();
            item = GetBrojRacuna();
            noviRedniBrojRacuna = item.RedniBrojRacuna + 1;
            string godina = DateTime.Now.Year.ToString();
            if (godina != item.Godina)
            {
                noviRedniBrojRacuna = 1;
            }
            
            return godina + "-" + Convert.ToString(noviRedniBrojRacuna);
        }

        public ProveraRacuna GetBrojRacuna()
        {
            ProveraRacuna result = new ProveraRacuna();
            string connectionString = HelperService.configConn;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT TOP 1 SUBSTRING(BrojRacuna, CHARINDEX('-', BrojRacuna)+1, LEN(BrojRacuna)),SUBSTRING(BrojRacuna, 1, 4) FROM Racuni (nolock) ORDER BY Id desc";

                using (SqlCommand sCmd = new SqlCommand(queryString, connection))
                {
                    sCmd.Connection.Open();
                    sCmd.CommandType = CommandType.Text;

                    using (SqlDataReader reader = sCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                result.RedniBrojRacuna = string.IsNullOrEmpty(reader[0].ToString()) ? 0 : Convert.ToInt32(reader[0]);
                                result.Godina = string.IsNullOrEmpty(reader[1].ToString()) ? DateTime.Now.Year.ToString() : reader[1].ToString();
                            }
                        }

                    }
                }
            }
            return result;
        }

        void PrintReceipt(Klase.Racun r)
        {
            Printer printer = new Printer(HelperService.receiptPrinterName, "windows-1256");
            System.Text.EncodingProvider ppp = System.Text.CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(ppp);
            printer.AlignCenter();
            printer.Append("RIBELA COMPANY");
            printer.Append("BEOGRADSKA 5 CACAK");
            printer.Append("PIB: 110337232 MB: 64818511");
            printer.Append("TELEFON: 069/51-51-444");
            printer.Append("REGISTAR KASA: " + HelperService.mpId);
            printer.BoldMode(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            printer.Separator('=');
            printer.BoldMode("PROMET PRODAJA");
            printer.Separator('=');
            printer.AlignLeft();
            printer.BoldMode("Broj racuna: " + r.BrojRacuna);
            printer.BoldMode("Vreme racuna: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            printer.BoldMode("Operater: " + Operater.ImePrezime);
            printer.Separator();
            printer.BoldMode("NAZIV                 CENA     KOL       UKUPNO");
            printer.Separator();
            foreach (var item in r.ListaStavki)
            {
                //string sifra = WithMaxLength(Convert.ToString(item.Id), 10);
                string naziv = WithMaxLength(Convert.ToString(item.ArtikalNaziv), 16);
                string cena = WithMaxLength(Convert.ToString(item.Cena), 12);
                string kolicina = WithMaxLength(Convert.ToString(item.Kolicina), 8);
                string stavkaUkupno = WithMaxLength(Convert.ToString(item.Ukupno), 12);

                printer.BoldMode(naziv.PadRight(16, ' ') + cena.PadLeft(12, ' ') + kolicina.PadLeft(8, ' ') + stavkaUkupno.PadLeft(12, ' '));
            }
            string ukupno = r.ListaStavki.Sum(x => Convert.ToDecimal(x.Ukupno)).ToString();
            printer.Separator('=');
            printer.DoubleWidth2();
            printer.Append("UKUPNO:" + ukupno.PadLeft(17, ' '));
            printer.Separator('=');
            //printer.Append(valuta.PadLeft(48, ' '));
            printer.NormalWidth();
            printer.InitializePrint();
            printer.SetLineHeight(24);
            printer.AlignLeft();
            printer.AlignCenter();
            printer.Font("OVO JE NEFISKALNI ISECAK", Fonts.FontD);
            printer.Font("Molimo sacekajte racun!", Fonts.FontD);
            printer.Font("www.ribelacompany.rs", Fonts.FontD);
            printer.Font("HVALA NA KUPOVINI!", Fonts.FontD);
            printer.Separator('=');
            printer.SetLineHeight(40);
            printer.Ean13("1234567891231");
            printer.NewLines(3);

            //printer.TestPrinter();
            printer.FullPaperCut();
            printer.PrintDocument();
        }

        public string WithMaxLength(string value, int maxLength)
        {
            return value.Substring(0, Math.Min(value.Length, maxLength));
        }

     
    }
}
