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

namespace Maloprodaja.Forme.Izvestaji
{
    public partial class frmIzvestajPrometaPoDanima : Form
    {
        public frmIzvestajPrometaPoDanima()
        {
            InitializeComponent();
            InitSetup();
            cmbGetPoslovnaJedinica();
           
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
            DataGridViewIzvestajPoDanima.Columns[1].DefaultCellStyle.Format = "dd.MM.yyyy";
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

        #region Ukupno
        public void UkupnoCena()
        {
            lblUkupno.Text = "0";
            lblGotovina.Text = "0";
            lblKartica.Text = "0";
            lblCek.Text = "0";
            lblVirman.Text = "0";
            lblvaucer.Text = "0";
            lblIPS.Text = "0";
            lblOstalo.Text = "0";

            for (int i = 0; i < DataGridViewIzvestajPoDanima.Rows.Count; i++)
            {
                if (DataGridViewIzvestajPoDanima.Rows[i].Cells[4].Value.ToString() == "/")
                {
                    continue;
                }
                lblUkupno.Text = Convert.ToString(decimal.Parse(lblUkupno.Text) + decimal.Parse(DataGridViewIzvestajPoDanima.Rows[i].Cells[2].Value.ToString()));
                lblGotovina.Text = Convert.ToString(decimal.Parse(lblGotovina.Text) + decimal.Parse(DataGridViewIzvestajPoDanima.Rows[i].Cells[3].Value.ToString()));
                lblKartica.Text = Convert.ToString(decimal.Parse(lblKartica.Text) + decimal.Parse(DataGridViewIzvestajPoDanima.Rows[i].Cells[4].Value.ToString()));
                lblCek.Text = Convert.ToString(decimal.Parse(lblCek.Text) + decimal.Parse(DataGridViewIzvestajPoDanima.Rows[i].Cells[5].Value.ToString()));
                lblVirman.Text = Convert.ToString(decimal.Parse(lblVirman.Text) + decimal.Parse(DataGridViewIzvestajPoDanima.Rows[i].Cells[6].Value.ToString()));
                lblvaucer.Text = Convert.ToString(decimal.Parse(lblvaucer.Text) + decimal.Parse(DataGridViewIzvestajPoDanima.Rows[i].Cells[7].Value.ToString()));
                lblIPS.Text = Convert.ToString(decimal.Parse(lblIPS.Text) + decimal.Parse(DataGridViewIzvestajPoDanima.Rows[i].Cells[8].Value.ToString()));
                lblOstalo.Text = Convert.ToString(decimal.Parse(lblOstalo.Text) + decimal.Parse(DataGridViewIzvestajPoDanima.Rows[i].Cells[9].Value.ToString()));
            }

        }
        #endregion Ukupno

        #region btnpretraga
        private void btnPretraga_Click(object sender, EventArgs e)
        {
            string upit = "SELECT max(Mp.Naziv) as 'Poslovna jedinica', CAST(Racuni.DatumRacuna AS DATE) as 'Datum'," +
                " sum(RacunStavka.Ukupno) as 'Ukupno', " +
                " ISNULL(dbo.GetTipPlacanjaSum(1, max(Racuni.DatumRacuna),max(Racuni.DatumRacuna)),0) as 'Gotovina'," +
                " ISNULL(dbo.GetTipPlacanjaSum(2, max(Racuni.DatumRacuna),max(Racuni.DatumRacuna)),0) as 'Kartica'," +
                " ISNULL(dbo.GetTipPlacanjaSum(3, max(Racuni.DatumRacuna),max(Racuni.DatumRacuna)),0) as 'Ček'," +
                " ISNULL(dbo.GetTipPlacanjaSum(4, max(Racuni.DatumRacuna),max(Racuni.DatumRacuna)),0) as 'Virman'," +
                " ISNULL(dbo.GetTipPlacanjaSum(5, max(Racuni.DatumRacuna),max(Racuni.DatumRacuna)),0) as 'Vaučer'," +
                " ISNULL(dbo.GetTipPlacanjaSum(6, max(Racuni.DatumRacuna),max(Racuni.DatumRacuna)),0) as 'IPS'," +
                " ISNULL(dbo.GetTipPlacanjaSum(0, max(Racuni.DatumRacuna),max(Racuni.DatumRacuna)),0) as 'Ostalo'" +
                " from Racuni " +
                " inner join RacunStavka on RacunStavka.RacunRefId = Racuni.Id " +
                " inner join Mp on Racuni.MpRefId = Mp.Id " +
                " where 1=1 ";

            if (!String.IsNullOrEmpty(dateTimePickerOd.Text))
            {
                upit = upit + " and CONVERT(DATE, Racuni.DatumRacuna) >= CONVERT(DATE, '" + dateTimePickerOd.Value.Date.ToString("yyyy-MM-dd") + "') and CONVERT(DATE, Racuni.DatumRacuna) <=  CONVERT(DATE, '" + dateTimePickerDo.Value.Date.ToString("yyyy-MM-dd") + "')";
            }
            if (Convert.ToInt32(cmbPoslovnaJedinica.SelectedValue) != 0)
            {
                upit = upit + " and Racuni.MpRefId = " + Convert.ToInt32(cmbPoslovnaJedinica.SelectedValue) + "";
            }

            upit = upit + " GROUP BY CAST(Racuni.DatumRacuna AS DATE)";


            try
            {

                DataGridViewIzvestajPoDanima.DataSource = HelperService.getDataTable(upit);
                UkupnoCena();
                GridColumnSetup();
                DataGridViewIzvestajPoDanima.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri pretrazi prometa po danu!");
            }
        }

        #endregion btnPretraga

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
                MessageBox.Show("Greska pri ucitavanju poslovne jednice!");
            }
        }

        #endregion cmbGetPoslovnaJednica

        #region btnClose
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion btnClose
    }
}
