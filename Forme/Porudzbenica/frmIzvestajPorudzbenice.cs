using DocumentFormat.OpenXml.Wordprocessing;
using Maloprodaja.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace Maloprodaja.Forme.Porudzbenica
{
    public partial class frmIzvestajPorudzbenice : Form
    {

        public frmIzvestajPorudzbenice()
        {
            InitializeComponent();
            InitSetup();

        }


        #region DateTimePickerInitialize
        public void DateTimePickerSetup()
        {
            dateTimeDatumDo.Format = DateTimePickerFormat.Custom;
            dateTimeDatumDo.CustomFormat = "dd.MM.yyyy";

            dateTimeDatumOd.Format = DateTimePickerFormat.Custom;
            dateTimeDatumOd.CustomFormat = "dd.MM.yyyy";
        }

        #endregion DateTimePickerInitialize

        #region DataGridViewDesignInitialization
        void InitSetup()
        {
            WindowState = FormWindowState.Maximized;
            InitializeDataGridView();
            DateTimePickerSetup();



        }

        public void GridColumnsSetup()
        {
            this.DataGridViewIzvestajPorudzbenica.Columns["Id"].Visible = false;
            DataGridViewIzvestajPorudzbenica.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
            DataGridViewIzvestajPorudzbenica.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";

        }

        private void InitializeDataGridView()
        {
            // Initialize basic DataGridView properties.
            DataGridViewIzvestajPorudzbenica.Dock = DockStyle.Fill;
            DataGridViewIzvestajPorudzbenica.BackgroundColor = System.Drawing.Color.LightGray;
            DataGridViewIzvestajPorudzbenica.BorderStyle = BorderStyle.Fixed3D;

            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            DataGridViewIzvestajPorudzbenica.AllowUserToAddRows = false;
            DataGridViewIzvestajPorudzbenica.AllowUserToDeleteRows = false;
            DataGridViewIzvestajPorudzbenica.AllowUserToOrderColumns = true;
            DataGridViewIzvestajPorudzbenica.ReadOnly = true;
            DataGridViewIzvestajPorudzbenica.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewIzvestajPorudzbenica.MultiSelect = false;
            DataGridViewIzvestajPorudzbenica.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DataGridViewIzvestajPorudzbenica.AllowUserToResizeColumns = false;
            DataGridViewIzvestajPorudzbenica.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewIzvestajPorudzbenica.AllowUserToResizeRows = false;
            DataGridViewIzvestajPorudzbenica.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            DataGridViewIzvestajPorudzbenica.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            DataGridViewIzvestajPorudzbenica.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            DataGridViewIzvestajPorudzbenica.RowHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            DataGridViewIzvestajPorudzbenica.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            DataGridViewIzvestajPorudzbenica.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;

            // Set the row and column header styles.
            DataGridViewIzvestajPorudzbenica.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            DataGridViewIzvestajPorudzbenica.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            DataGridViewIzvestajPorudzbenica.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

            // Empty cell default value
            DataGridViewIzvestajPorudzbenica.DefaultCellStyle.NullValue = "/";
           

            /////grid2


            dataGridViewDetalji.Dock = DockStyle.Fill;
            dataGridViewDetalji.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewDetalji.BorderStyle = BorderStyle.Fixed3D;

            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            dataGridViewDetalji.AllowUserToAddRows = false;
            dataGridViewDetalji.AllowUserToDeleteRows = false;
            dataGridViewDetalji.AllowUserToOrderColumns = true;
            dataGridViewDetalji.ReadOnly = true;
            dataGridViewDetalji.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDetalji.MultiSelect = false;
            dataGridViewDetalji.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewDetalji.AllowUserToResizeColumns = false;
            dataGridViewDetalji.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewDetalji.AllowUserToResizeRows = false;
            dataGridViewDetalji.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            dataGridViewDetalji.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewDetalji.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            dataGridViewDetalji.RowHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            dataGridViewDetalji.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewDetalji.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;

            // Set the row and column header styles.
            dataGridViewDetalji.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridViewDetalji.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewDetalji.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

            // Empty cell default value
            dataGridViewDetalji.DefaultCellStyle.NullValue = "/";

        }

        #endregion DataGridViewDesignInitialization

        #region btnPretrazi
        private void btnPretraziIzvestaj_Click(object sender, EventArgs e)
        {
            string upit = "select p.Id, p.BrojPorudzbenice as 'Broj porudzbenice' , p.Porucilac, p.DatumPorudzbenice, p. DatumIsporuke as 'Datum isporuke', p.Napomena " +
                "from Porudzbenica p where ";

            if (!String.IsNullOrEmpty(dateTimeDatumOd.Text))
            {
                upit = upit + "p.datumPorudzbenice between convert (date, '" + dateTimeDatumOd.Text + "',103) and  convert (date,'" + dateTimeDatumDo.Text + "',103)";

            }
            
            try
            {

                DataGridViewIzvestajPorudzbenica.DataSource = HelperService.getDataTable(upit);
                GridColumnsSetup();
                DataGridViewIzvestajPorudzbenica.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri pretrazi izvestaja porudzbenice!");
            }
        }


        #endregion btnPretrazi

        #region CellClickDetailjiPorudzbenice
        private void DataGridViewIzvestajPorudzbenica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdPorudzbenice = 0;
            IdPorudzbenice = Convert.ToInt32(this.DataGridViewIzvestajPorudzbenica.CurrentRow.Cells[0].Value);
            string upit = "select a.Naziv as 'Naziv artikla', ps.Kolicina, ps.Napomena " +
               "from PorudzbenicaStavka ps " +
               "inner join Artikal as a on ps.ArtikalRefId = a.Id " +
               "inner join Porudzbenica as p on ps.PorudzbenicaRefId = p.Id " +
               "where p.Id = "+ IdPorudzbenice + "";

            try
            {
                dataGridViewDetalji.DataSource = HelperService.getDataTable(upit);
                GridColumnsSetup();
                DataGridViewIzvestajPorudzbenica.ClearSelection();
                dataGridViewDetalji.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska u detaljima porudzbenice!");
            }
        }

        #endregion CellClickDetaljiPorudzbenice
    }

}

