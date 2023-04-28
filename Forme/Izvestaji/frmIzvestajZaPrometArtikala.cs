using Maloprodaja.Helper;
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

namespace Maloprodaja.Forme.Izvestaji
{
    public partial class frmIzvestajZaPrometArtikala : Form
    {
        public frmIzvestajZaPrometArtikala()
        {
            InitializeComponent();
            InitSetup();
            cmbGetkorisnici();
            cmbGetPoslovnaJedinica();
            this.chckPregledPosatima.Checked = true;
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

            dateTimeSatiOd.Format = DateTimePickerFormat.Custom;
            dateTimeSatiOd.CustomFormat = "HH:mm".ToString();

            dateTimeSatiDo.Format = DateTimePickerFormat.Custom;
            dateTimeSatiDo.CustomFormat = "HH:mm".ToString();
        }
        #endregion dateTimePickerSetup

        #region DataGridViewInitialize

        public void GridColumnSetup()
        {
            DataGridViewIzvestajPoDanima.Columns[1].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
        }

        private void InitializeDataGridView()
        {
            // Initialize basic DataGridView properties.
            DataGridViewIzvestajPoDanima.Dock = DockStyle.Fill;
            DataGridViewIzvestajPoDanima.BackgroundColor = System.Drawing.Color.LightGray;
            DataGridViewIzvestajPoDanima.BorderStyle = BorderStyle.Fixed3D;

            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            DataGridViewIzvestajPoDanima.AllowUserToAddRows = false;
            DataGridViewIzvestajPoDanima.AllowUserToDeleteRows = false;
            DataGridViewIzvestajPoDanima.AllowUserToOrderColumns = true;
            DataGridViewIzvestajPoDanima.ReadOnly = true;
            DataGridViewIzvestajPoDanima.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewIzvestajPoDanima.MultiSelect = false;
            DataGridViewIzvestajPoDanima.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DataGridViewIzvestajPoDanima.AllowUserToResizeColumns = false;
            DataGridViewIzvestajPoDanima.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewIzvestajPoDanima.AllowUserToResizeRows = false;
            DataGridViewIzvestajPoDanima.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            DataGridViewIzvestajPoDanima.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            DataGridViewIzvestajPoDanima.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            DataGridViewIzvestajPoDanima.RowHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            DataGridViewIzvestajPoDanima.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            DataGridViewIzvestajPoDanima.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;

            // Set the row and column header styles.
            DataGridViewIzvestajPoDanima.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            DataGridViewIzvestajPoDanima.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            DataGridViewIzvestajPoDanima.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

            // Empty cell default value
            DataGridViewIzvestajPoDanima.DefaultCellStyle.NullValue = "/";



        }

        #endregion DataGridViewInitialize

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

        #endregion cmbGetkorisnici

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

        #region Ukupno
        public void UkupnoCena()
        {
          
            lblUlaz.Text = "0";
            lblIzlaz.Text = "0";

            for (int i = 0; i < DataGridViewIzvestajPoDanima.Rows.Count; i++)
            {
                if (DataGridViewIzvestajPoDanima.Rows[i].Cells[4].Value.ToString() == "/")
                {
                    continue;
                }
                lblUlaz.Text = Convert.ToString(decimal.Parse(lblUlaz.Text) + decimal.Parse(DataGridViewIzvestajPoDanima.Rows[i].Cells[3].Value.ToString()));
                lblIzlaz.Text = Convert.ToString(decimal.Parse(lblIzlaz.Text) + decimal.Parse(DataGridViewIzvestajPoDanima.Rows[i].Cells[4].Value.ToString()));
               
              
            }

        }

        #endregion Ukupno

        #region chckPretragaPregled

        private void chckPregledPosatima_CheckedChanged(object sender, EventArgs e)
        {
            if (chckPregledPosatima.Checked)
            {
               
                chckPregledPosatima.Checked = true;
                dateTimeSatiOd.Enabled = true;
                dateTimeSatiDo.Enabled = true;      


            }
            else
            {
               
                chckPregledPosatima.Checked = false;
                dateTimeSatiOd.Enabled = false;
                dateTimeSatiDo.Enabled = false;

            }
        }




        #endregion chckPretragaPregled

        #region btnPretraga
        private void btnPretraga_Click(object sender, EventArgs e)
        {
            string upit = "select max(a.Naziv) as 'Artikal', max(p.DatumPrometa) as 'Datum prometa', 'Maloprodajni racun' as 'Tip dokumenta', max(p.Ulaz) as 'Ulaz', max(p.Izlaz) as 'Izlaz'  " +
                "from Promet p inner join Artikal a on p.ArtikalRefId = a.Id " +
                "inner join RacunStavka rs on  a.Id = rs.ArtikalRefId " +
                "inner join Racuni r on r.Id = rs.RacunRefId " +
                "inner join Mp on r.MpRefId = Mp.Id " +
                "where 1=1";

            if (!String.IsNullOrEmpty(dateTimePickerOd.Text))
            {
                upit = upit + " and CONVERT(DATE, p.DatumPrometa)  >=  CONVERT(DATE,'"+ dateTimePickerOd.Value.Date.ToString("yyyy-MM-dd") + "') and CONVERT(DATE, p.DatumPrometa) <= CONVERT(DATE,'"+ dateTimePickerDo.Value.Date.ToString("yyyy-MM-dd") + "')";

            }
            if (chckPregledPosatima.Checked)
            {
                upit = upit + " and cast(p.DatumPrometa as time) between '"+ dateTimeSatiOd.Value.ToString("HH:mm") + "' and '"+ dateTimeSatiDo.Value.ToString("HH:mm") + "'";

            }
            if (Convert.ToInt32(cmbKorisnici.SelectedValue) != 0)
            {
                upit = upit + " and r.OperaterRefId = " + Convert.ToInt32(cmbKorisnici.SelectedValue) + "";
            }
            if (Convert.ToInt32(cmbPoslovnaJedinica.SelectedValue) != 0)
            {
                upit = upit + " and r.MpRefId = " + Convert.ToInt32(cmbPoslovnaJedinica.SelectedValue) + "";
            }


            upit = upit + " group by p.Id";

            try
            {

                DataGridViewIzvestajPoDanima.DataSource = HelperService.getDataTable(upit);
                UkupnoCena();
                GridColumnSetup();
                DataGridViewIzvestajPoDanima.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri pretrazi izvestaja za promet artikala!");
            }
        }

        #endregion btnPretraga

        #region btnClose

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion btnClose
    }
}
