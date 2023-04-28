using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using ESC_POS_USB_NET.Printer;
using Maloprodaja.Forme.Porudzbenica;
using Maloprodaja.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ESC_POS_USB_NET.Printer;
using ESC_POS_USB_NET.Enums;
using Fonts = ESC_POS_USB_NET.Enums.Fonts;
using System.Configuration;
using Maloprodaja.Klase;
using System.Text;

namespace Maloprodaja.Forme.Artikli
{
    public partial class frmArtikliLista : Form

    {
        string mpId = "1";
        string posPrinterName = "CP-Q3";

        Helper.HelperService ConfigConn = new Helper.HelperService();
        public frmArtikliLista()
        {
            InitializeComponent();
            InitSetup();
            ComboGrupaArtikala();
            ComboVrstaArtikla();
           

        }

        void InitSetup()
        {
            WindowState = FormWindowState.Maximized;
            InitializeDataGridView();
        }


        #region comboboxGrupaArtikala
        public void ComboGrupaArtikala()
        {
            DataTable dtk = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand("select Id, Naziv from GrupeArtikla", conn))
                    {
                        dtk.Load(dCmd.ExecuteReader());
                    }
                    conn.Close(); // lets close explicitely
                    cmbGrupaArtikla.DataSource = dtk;
                    cmbGrupaArtikla.DisplayMember = "Naziv";
                    cmbGrupaArtikla.ValueMember = "Id";
                }
                dtk.Rows.Add(new Object[]{
                    0,
                    "Sve"
                });

                cmbGrupaArtikla.SelectedValue = 0;

            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju vrste artikala!");
            }
        }
    
        #endregion comboboxGrupaArtikala

        #region comboboxVrsteArtikla
        public void ComboVrstaArtikla()
         {
            DataTable dtk = new DataTable();
            try
            {

                using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand("select Id, Naziv from VrstaArtikla", conn))
                    {
                        dtk.Load(dCmd.ExecuteReader());
                    }
                    conn.Close();
                    cmbVrstaArtikla.DataSource = dtk;
                    cmbVrstaArtikla.DisplayMember = "Naziv";
                    cmbVrstaArtikla.ValueMember = "Id";
                }

                dtk.Rows.Add(new Object[]{
                    0,
                    "Sve"
                });
                cmbVrstaArtikla.SelectedValue = 0;
            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju vrste artikala!");
            }
        }

        #endregion comboboxVrsteArtikla

        #region btnDodajArtikal
        private void btnDodajArtikal_Click(object sender, EventArgs e)
        {
            frmIUArtikal frm = new frmIUArtikal(0, 0);
            frm.ShowDialog();
          
        }

        #endregion btnDodajArtikal

        #region BtnObrisi
        private void btnObrisiArtikal_Click(object sender, EventArgs e)
        {
            /*foreach (DataGridViewCell oneCell in DataGridViewArtikli.SelectedCells)
            {
                if (oneCell.Selected)
                {
                   
                    string IdSelected = DataGridViewArtikli.SelectedRows[0].Cells[3].Value.ToString();
                    if (IdSelected == "")
                    {

                    }
                    else
                    {

                        using (SqlConnection connection = new SqlConnection(HelperConn.configConn))
                        {
                            connection.Open();
                            using (SqlCommand cmd = new SqlCommand("delete from Artikal where Sifra= '" + IdSelected + "'", connection))
                            {
                                cmd.ExecuteNonQuery();
                                connection.Close();
                               // IdSelected = DataGridViewArtikli.SelectedRows[0].Cells[3].Value.ToString();
                            }
                        }
                    }

                }
            }*/

        }
        #endregion BtnObrisi

        #region btnPretraga
        private void btnPretraga_Click(object sender, EventArgs e)
        {
            string upit = "SELECT a.Id, a.Naziv AS 'Naziv artikla', a.GTIN, a.Sifra, g.Naziv AS 'Grupa artikla', v.Naziv AS 'Vrsta artikla' , j.Naziv AS 'Jedinica mere', [dbo].[GetCenaArtikla](a.Id) as 'Cena' FROM Artikal a INNER JOIN GrupeArtikla AS g ON g.Id = a.GrupeArtiklaRefId INNER JOIN VrstaArtikla v ON v.Id = a.VrstaArtiklaRefId INNER JOIN JedinicaMere j ON j.Id = a.JedinicaMereRefId INNER JOIN PoreskeStope ps ON ps.Id = a.PoreskeStopeRefid WHERE 1=1";
            if (!String.IsNullOrEmpty(txtNazivArtikla.Text))
            {
                upit = upit + " AND a.Naziv like '%"+ txtNazivArtikla.Text + "%'";
                 
            }
            if (!String.IsNullOrEmpty(txtGTINartikla.Text))
            {

                upit = upit + " AND a.GTIN like '%"+ txtGTINartikla.Text +"%'";

            }
            if (!String.IsNullOrEmpty(txtSifraArtikla.Text))
            {

                upit = upit + " AND a.Sifra like '%"+ txtSifraArtikla.Text + "%'";

            }
            if (Convert.ToInt32(cmbGrupaArtikla.SelectedValue) != 0)
            {

                upit = upit + " AND g.Id ='" + Convert.ToInt32(cmbGrupaArtikla.SelectedValue) +"'";

            }
            if (Convert.ToInt32(cmbVrstaArtikla.SelectedValue) != 0)
            {

                upit = upit + " AND v.Id = '"+ Convert.ToInt32(cmbVrstaArtikla.SelectedValue) +"'";

            }

            try
            {
                
                DataGridViewArtikli.DataSource = HelperService.getDataTable(upit);
                GridColumnsSetup();
                DataGridViewArtikli.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri pretrazi artikala!");
            }
        }

        #endregion Pretraga

        #region btnReset
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtGTINartikla.Clear();
                txtNazivArtikla.Clear();
                txtSifraArtikla.Clear();
                cmbVrstaArtikla.SelectedValue = 0;
                cmbGrupaArtikla.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri resetovanju filtera!");
            }

        }

        #endregion btnReset

        #region btnIzmeni
        private void btnIzmeniArtikal_Click(object sender, EventArgs e)
        {
            try
            {
                int ArtikalId = 0;
                if (this.DataGridViewArtikli.SelectedRows.Count > 0)
                {
                    ArtikalId = Convert.ToInt32(this.DataGridViewArtikli.CurrentRow.Cells[0].Value);
                    if (ArtikalId != 0)
                    {
                        frmIUArtikal frm = new frmIUArtikal(1, ArtikalId);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Niste selektovali red artikla!");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Greska pri izmeni artikla!");
                MessageBox.Show(ex.Message.ToString());
            }

        }








        #endregion btnIzmeni

        #region btnZatvori
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion btnZatvori

        #region DataGridViewInitialize
        public void GridColumnsSetup()
        {
            this.DataGridViewArtikli.Columns["Id"].Visible = false;
            this.DataGridViewArtikli.Columns["Cena"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("sr-Latn-RS");
            this.DataGridViewArtikli.Columns["Cena"].DefaultCellStyle.Format = "c";
        }

        // Configures the appearance and behavior of a DataGridView control.
        private void InitializeDataGridView()
        {
            // Initialize basic DataGridView properties.
            DataGridViewArtikli.Dock = DockStyle.Fill;
            DataGridViewArtikli.BackgroundColor = System.Drawing.Color.LightGray;
            DataGridViewArtikli.BorderStyle = BorderStyle.Fixed3D;

            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            DataGridViewArtikli.AllowUserToAddRows = false;
            DataGridViewArtikli.AllowUserToDeleteRows = false;
            DataGridViewArtikli.AllowUserToOrderColumns = true;
            DataGridViewArtikli.ReadOnly = true;
            DataGridViewArtikli.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewArtikli.MultiSelect = false;
            DataGridViewArtikli.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DataGridViewArtikli.AllowUserToResizeColumns = false;
            DataGridViewArtikli.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewArtikli.AllowUserToResizeRows = false;
            DataGridViewArtikli.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            DataGridViewArtikli.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            DataGridViewArtikli.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            DataGridViewArtikli.RowHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            DataGridViewArtikli.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            DataGridViewArtikli.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;

            // Set the row and column header styles.
            DataGridViewArtikli.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            DataGridViewArtikli.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            DataGridViewArtikli.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

            // Empty cell default value
            DataGridViewArtikli.DefaultCellStyle.NullValue = "/";

        }

        #endregion DataGridViewInitialize

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
            printer.BoldMode("LISTA ARTIKALA");
            printer.Separator('=');
            printer.AlignLeft();

            printer.BoldMode("SIFRA     ARTIKAL                           CENA");
            foreach (DataGridViewRow row in DataGridViewArtikli.Rows)
            {
                string sifra = WithMaxLength(Convert.ToString(row.Cells["Sifra"].Value), 10);
                string naziv = WithMaxLength(Convert.ToString(row.Cells["Naziv artikla"].Value), 26);
                string cena = WithMaxLength(Convert.ToString(row.Cells["Cena"].Value), 12);

                printer.BoldMode(sifra.PadRight(10, ' ') + naziv.PadRight(26, ' ') + cena.PadLeft(12, ' '));
            }

            printer.Separator('=');
            printer.InitializePrint();
            printer.SetLineHeight(24);
            printer.AlignLeft();
            printer.AlignCenter();
            printer.Font("OVO JE STAMPANA LISTA ARTIKALA", Fonts.FontD);
            printer.Font("www.ribelacompany.rs", Fonts.FontD);
            //printer.Font("HVALA NA KUPOVINI!", Fonts.FontD);
            printer.Separator('=');
            //printer.SetLineHeight(40);
            //printer.Ean13("1234567891231");
            printer.NewLines(3);

            //printer.TestPrinter();
            printer.FullPaperCut();
            printer.PrintDocument();
        }

        void StampaDnevnogIzvestaja2()
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
            printer.BoldMode("PROMET PRODAJA");
            printer.Separator('=');
            printer.AlignLeft();
            printer.BoldMode("Broj racuna: POS-2022-001");
            printer.BoldMode("Vreme racuna: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            printer.BoldMode("Operater: " + Operater.ImePrezime);
            printer.Separator();
            printer.BoldMode("NAZIV                 CENA     KOL       UKUPNO");
            printer.Separator();
            foreach (DataGridViewRow row in DataGridViewArtikli.Rows)
            {
                string sifra = WithMaxLength(Convert.ToString(row.Cells["Sifra"].Value), 10);
                string naziv = WithMaxLength(Convert.ToString(row.Cells["Naziv artikla"].Value), 16);
                string cena = WithMaxLength(Convert.ToString(row.Cells["Cena"].Value), 12);
                string kolicina = "1";

                printer.BoldMode(naziv.PadRight(16, ' ') + cena.PadLeft(12, ' ') + kolicina.PadLeft(8, ' ') + cena.PadLeft(12, ' '));
            }
            string ukupno = "4960.00";
            string valuta = "RSD";
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

        #endregion

        private void btnStampa_Click(object sender, EventArgs e)
        {
            StampaDnevnogIzvestaja2();
        }
    }
}
