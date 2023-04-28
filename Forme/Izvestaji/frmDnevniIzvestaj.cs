using DocumentFormat.OpenXml.Spreadsheet;
using Maloprodaja.Forme.Porudzbenica;
using Maloprodaja.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESC_POS_USB_NET.Printer;
using ESC_POS_USB_NET.Enums;
using Fonts = ESC_POS_USB_NET.Enums.Fonts;
using System.Configuration;
using Maloprodaja.Klase;

namespace Maloprodaja.Forme.Izvestaji
{
    public partial class frmDnevniIzvestaj : Form
    {
        string mpId = "1";
        string posPrinterName = "CP-Q3";
        public frmDnevniIzvestaj()
        {
            InitializeComponent();
            InitSetup();
            cmboboxVrstaDokumenta();
            cmbGetPoslovnaJedinica();
            cmbGetkorisnici();
        }
        void InitSetup()
        {
            WindowState = FormWindowState.Maximized;
            InitializeDataGridView();
            DateTimePickerSetup();

        }


        #region dateTimePickerSetup
        public void DateTimePickerSetup()
        {
            dateTimePickerOd.Format = DateTimePickerFormat.Custom;
            dateTimePickerOd.CustomFormat = "dd.MM.yyyy";

            dateTimePickerDo.Format = DateTimePickerFormat.Custom;
            dateTimePickerDo.CustomFormat = "dd.MM.yyyy";
        }
        #endregion dateTimePickerSetup

        #region DataGridViewInitialize

        public void GridColumnSetup()
        {
            DataGridViewDnevniIzvestaj.Columns[2].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
        }

        private void InitializeDataGridView()
        {
            // Initialize basic DataGridView properties.
            DataGridViewDnevniIzvestaj.Dock = DockStyle.Fill;
            DataGridViewDnevniIzvestaj.BackgroundColor = System.Drawing.Color.LightGray;
            DataGridViewDnevniIzvestaj.BorderStyle = BorderStyle.Fixed3D;

            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            DataGridViewDnevniIzvestaj.AllowUserToAddRows = false;
            DataGridViewDnevniIzvestaj.AllowUserToDeleteRows = false;
            DataGridViewDnevniIzvestaj.AllowUserToOrderColumns = true;
            DataGridViewDnevniIzvestaj.ReadOnly = true;
            DataGridViewDnevniIzvestaj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewDnevniIzvestaj.MultiSelect = false;
            DataGridViewDnevniIzvestaj.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DataGridViewDnevniIzvestaj.AllowUserToResizeColumns = false;
            DataGridViewDnevniIzvestaj.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewDnevniIzvestaj.AllowUserToResizeRows = false;
            DataGridViewDnevniIzvestaj.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            DataGridViewDnevniIzvestaj.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            DataGridViewDnevniIzvestaj.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            DataGridViewDnevniIzvestaj.RowHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            DataGridViewDnevniIzvestaj.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            DataGridViewDnevniIzvestaj.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;

            // Set the row and column header styles.
            DataGridViewDnevniIzvestaj.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            DataGridViewDnevniIzvestaj.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            DataGridViewDnevniIzvestaj.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

            // Empty cell default value
            DataGridViewDnevniIzvestaj.DefaultCellStyle.NullValue = "/";



        }

        #endregion DataGridViewInitialize

        #region btnStampaj

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            //frmIzvestajPrometaPoDanima frm = new frmIzvestajPrometaPoDanima();
            //frm.ShowDialog();
            StampaDnevnogIzvestaja();


        }

        #endregion btnStampaj

        #region Ukupno
        public void UkupnoCena()
        {
            decimal sum = 0;
          
            for (int i = 0; i < DataGridViewDnevniIzvestaj.Rows.Count; ++i)
            {
                if (DataGridViewDnevniIzvestaj.Rows[i].Cells[3].Value.ToString() == "/")
                {
                    continue;
                }
                sum += Convert.ToDecimal(DataGridViewDnevniIzvestaj.Rows[i].Cells[3].Value);
            }
            lblUkupno.Text = sum.ToString();
            lblOsnovica.Text = sum.ToString();
        }
        #endregion Ukupno

        #region cmbVrstDokumenta
        public void cmboboxVrstaDokumenta()
        {
            DataTable dtk = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand("select Id, Naziv from TipRacuna", conn))
                    {
                        dtk.Load(dCmd.ExecuteReader());
                    }
                    conn.Close();
                    cmbVrstaDokumenta.DataSource = dtk;
                    cmbVrstaDokumenta.DisplayMember = "Naziv";
                    cmbVrstaDokumenta.ValueMember = "Id";
                }
                dtk.Rows.Add(new object[]{
                    -1,
                    "Sve"
                });
                cmbVrstaDokumenta.SelectedValue = -1;
             



            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju vrste dokumenta!");
            }
        }



        #endregion cmbVrstaDokumenta

        #region cmbGetPoslovnaJednica
        public void cmbGetPoslovnaJedinica()
        {
            DataTable dtk = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand("select Id, Naziv from Mp", conn))
                    {
                        dtk.Load(dCmd.ExecuteReader());
                    }
                    conn.Close(); // lets close explicitely
                    cmbPoslovnaJedinica.DataSource = dtk;
                    cmbPoslovnaJedinica.DisplayMember = "Naziv";
                    cmbPoslovnaJedinica.ValueMember = "Id";
                }
                dtk.Rows.Add(new Object[]{
                    0,
                    "Sve"
                });

                cmbPoslovnaJedinica.SelectedValue = 0;

            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju poslovne jedinice!");
            }
        }

        #endregion cmbGetPoslovnaJednica

        #region cmbGetkorisnici
        public void cmbGetkorisnici()
        {
            DataTable dtk = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand("select Id, ImePrezime from Operater", conn))
                    {
                        dtk.Load(dCmd.ExecuteReader());
                    }
                    conn.Close(); // lets close explicitely
                    cmbKorisnici.DataSource = dtk;
                    cmbKorisnici.DisplayMember = "ImePrezime";
                    cmbKorisnici.ValueMember = "Id";
                }
                dtk.Rows.Add(new Object[]{
                    0,
                    "Svi"
                });

                cmbKorisnici.SelectedValue = 0;

            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju korisnika!");
            }
        }
        #endregion cmbKorisnici

        #region btnPretraga
        private void btnPretraga_Click_1(object sender, EventArgs e)
        {
            string upit = "SELECT dbo.GetDokument(Racuni.Id) as 'Dokument', max(Racuni.BrojRacuna) as 'Broj racuna', max(Racuni.DatumRacuna) as 'Datum', (select sum(RacunStavka.Ukupno) " +
                "from RacunStavka where RacunStavka.RacunRefId = Racuni.Id) as 'Iznos', ISNULL((select sum(Iznos) " +
                "from RacunTipPlacanja where RacunTipPlacanja.RacunRefId = Racuni.Id and RacunTipPlacanja.TipPlacanjaRefId = 1),0) as 'Gotovina', ISNULL((select sum(Iznos) " +
                "from RacunTipPlacanja where RacunTipPlacanja.RacunRefId = Racuni.Id and RacunTipPlacanja.TipPlacanjaRefId = 2),0) as 'Kartica', ISNULL((select sum(Iznos) " +
                "from RacunTipPlacanja where RacunTipPlacanja.RacunRefId = Racuni.Id and RacunTipPlacanja.TipPlacanjaRefId = 3),0) as 'Cek', ISNULL((select sum(Iznos) " +
                "from RacunTipPlacanja where RacunTipPlacanja.RacunRefId = Racuni.Id and RacunTipPlacanja.TipPlacanjaRefId = 4),0) as 'Virman', ISNULL((select sum(Iznos) " +
                "from RacunTipPlacanja where RacunTipPlacanja.RacunRefId = Racuni.Id and RacunTipPlacanja.TipPlacanjaRefId = 5),0) as 'Vaucer', ISNULL((select sum(Iznos) " +
                "from RacunTipPlacanja where RacunTipPlacanja.RacunRefId = Racuni.Id and RacunTipPlacanja.TipPlacanjaRefId = 6),0) as 'IPS', ISNULL((select sum(Iznos) " +
                "from RacunTipPlacanja where RacunTipPlacanja.RacunRefId = Racuni.Id and RacunTipPlacanja.TipPlacanjaRefId = 0),0) as 'Ostalo' " +
                "from Racuni inner join RacunStavka on RacunStavka.RacunRefId = Racuni.Id " +
                "inner join  Operater on Racuni.OperaterrefId = Operater.Id inner join Mp on Racuni.MpRefId = Mp.Id where 1=1";

            if (!String.IsNullOrEmpty(dateTimePickerOd.Text))
            {
                upit = upit + " and CONVERT(DATE, Racuni.DatumRacuna) >= CONVERT(DATE, '" + dateTimePickerOd.Value.Date.ToString("yyyy-MM-dd") + "') and CONVERT(DATE, Racuni.DatumRacuna) <=  CONVERT(DATE, '" + dateTimePickerDo.Value.Date.ToString("yyyy-MM-dd") + "')";

            }

            if (Convert.ToInt32(cmbKorisnici.SelectedValue) != 0)
            {
                upit = upit + " and Racuni.OperaterRefId = " + Convert.ToInt32(cmbKorisnici.SelectedValue) + "";
            }
            if (Convert.ToInt32(cmbPoslovnaJedinica.SelectedValue) != 0)
            {
                upit = upit + " and Racuni.MpRefId = " + Convert.ToInt32(cmbPoslovnaJedinica.SelectedValue) + "";
            }
            if (Convert.ToInt32(cmbVrstaDokumenta.SelectedValue) != -1)
            {
                upit = upit + " and Racuni.TipRacuna = " + Convert.ToInt32(cmbVrstaDokumenta.SelectedValue) + "";
            }

            upit = upit + " GROUP BY Racuni.Id";

            try
            {
                DataGridViewDnevniIzvestaj.DataSource = HelperService.getDataTable(upit);
                GridColumnSetup();
                DataGridViewDnevniIzvestaj.ClearSelection();
                UkupnoCena();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri pretrazi dnevnog izvestaja!");
            }
        }

        #endregion btnPretraga

        #region btnReset
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerOd.Value = DateTime.Today;
                dateTimePickerDo.Value = DateTime.Today;
                cmbKorisnici.SelectedValue = 0;
                cmbPoslovnaJedinica.SelectedValue = 0;
                cmbVrstaDokumenta.SelectedValue = -1;
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri resetovanju filtera!");
            }
        }

        #endregion btnReset

        #region Stampa
        void StampaDnevnogIzvestaja()
        {
            Printer printer = new Printer(posPrinterName, "windows-1256");
            System.Text.EncodingProvider ppp = System.Text.CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(ppp);
            printer.AlignCenter();
            printer.Append("RIBELA COMPANY");
            printer.Append("BEOGRADSKA 5 CACAK");
            printer.Append("PIB: 110337232 MB: 64818511");
            printer.Append("TELEFON: 069/51-51-444");
            printer.Append("REGISTAR KASA: " + mpId);
            printer.BoldMode(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            printer.Separator('=');
            printer.BoldMode("DNEVNI IZVESTAJ");
            printer.Separator('=');
            printer.AlignLeft();
            //printer.BoldMode("KARTA: SALTER-" + DateTime.Now.Year.ToString() + "-" + ticketId.ToString());
            printer.BoldMode("OPERATER: " + Operater.ImePrezime);
            //printer.BoldMode("RELACIJA: " + global.NazivStanice1 + " - " + global.NazivStanice2);
            //printer.BoldMode("CENA: " + global.Cena);
            printer.Separator('=');
            printer.InitializePrint();
            printer.SetLineHeight(24);
            printer.AlignLeft();
            printer.AlignCenter();
            printer.Font("OVO JE NEFISKALNI ISECAK", Fonts.FontD);
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

        #endregion Stampa

        #region btnClose
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion btnClose
    }
}
