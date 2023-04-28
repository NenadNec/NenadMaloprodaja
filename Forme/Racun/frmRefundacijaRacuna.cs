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
    public partial class frmRefundacijaRacuna : Form
    {
        private bool _needUpdateKupacRacun = false;
        private bool _canUpdateKupacRacun = true;
        Klase.Racun odabranRacun = new Klase.Racun();
        public frmRefundacijaRacuna()
        {
            InitializeComponent();
            InitSetup();
        }

        void InitSetup()
        {
            //WindowState = FormWindowState.Maximized;    
            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {
            // Initialize basic DataGridView properties.
            dataGridViewRefundacija.Dock = DockStyle.Fill;
            dataGridViewRefundacija.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewRefundacija.BorderStyle = BorderStyle.Fixed3D;

            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            dataGridViewRefundacija.AllowUserToAddRows = false;
            dataGridViewRefundacija.AllowUserToDeleteRows = false;
            dataGridViewRefundacija.AllowUserToOrderColumns = true;
            dataGridViewRefundacija.ReadOnly = true;
            dataGridViewRefundacija.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRefundacija.MultiSelect = false;
            dataGridViewRefundacija.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewRefundacija.AllowUserToResizeColumns = false;
            dataGridViewRefundacija.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewRefundacija.AllowUserToResizeRows = false;
            dataGridViewRefundacija.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            dataGridViewRefundacija.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewRefundacija.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            dataGridViewRefundacija.RowHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            dataGridViewRefundacija.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewRefundacija.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;

            // Set the row and column header styles.
            dataGridViewRefundacija.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridViewRefundacija.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewRefundacija.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

            // Empty cell default value
            dataGridViewRefundacija.DefaultCellStyle.NullValue = "/";

     



        }



        private void btnRefundacija_Click(object sender, EventArgs e)
        {
            if (dataGridViewRefundacija.Rows.Count != 0)
            {

                var Id = dataGridViewRefundacija.Rows[0].Cells[0].Value;
                var BrojRacuna = dataGridViewRefundacija.Rows[0].Cells[2].Value;
                var TipRacuna = dataGridViewRefundacija.Rows[0].Cells[3].Value;
                var OperaterRefId = dataGridViewRefundacija.Rows[0].Cells[6].Value;
                var MpRefId = dataGridViewRefundacija.Rows[0].Cells[7].Value;




                bool result = false;
                int idRacuna = 0;
                //StavkaRacuna sr = new StavkaRacuna();

                string connectionString = HelperService.configConn;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();

                    SqlCommand insertRacuna = new SqlCommand("INSERT INTO [dbo].[Racuni]([BrojRacuna],[TipRacuna],[TipTransakcije],[DatumRacuna],[OperaterRefId],[MpRefId]) VALUES(@BrojRacuna,@TipRacuna,@TipTransakcije,getdate(),@OperaterRefId,@MpRefId) select scope_identity()", conn, tran);

                    insertRacuna.Parameters.Add("@BrojRacuna", SqlDbType.NVarChar).Value = BrojRacuna;
                    insertRacuna.Parameters.Add("@TipRacuna", SqlDbType.Int).Value = TipRacuna;
                    insertRacuna.Parameters.Add("@TipTransakcije", SqlDbType.Int).Value = 1;
                    insertRacuna.Parameters.Add("@OperaterRefId", SqlDbType.Int).Value = OperaterRefId;
                    insertRacuna.Parameters.Add("@MpRefId", SqlDbType.Int).Value = MpRefId;

                    try
                    {
                        idRacuna = Convert.ToInt32(insertRacuna.ExecuteScalar());



                        for (int i = 0; i < dataGridViewRefundacija.Rows.Count; ++i)
                        {

                            var RacunRefId = dataGridViewRefundacija.Rows[i].Cells[8].Value;
                            var ArtikalRefId = dataGridViewRefundacija.Rows[i].Cells[9].Value;
                            var Kolicina = dataGridViewRefundacija.Rows[i].Cells[10].Value;
                            var Cena = dataGridViewRefundacija.Rows[i].Cells[11].Value;
                            var Popust = dataGridViewRefundacija.Rows[i].Cells[12].Value;
                            var Ukupno = dataGridViewRefundacija.Rows[i].Cells[13].Value;
                            // Upis u tabelu RacunStavka
                            SqlCommand insertStavkaRacuna = new SqlCommand("INSERT INTO [dbo].[RacunStavka]([RacunRefId],[ArtikalRefId],[Kolicina],[Cena],[Popust],[Ukupno]) VALUES(@RacunRefId,@ArtikalRefId,-1 * @Kolicina,-1 * @Cena,@Popust,-1 * @Ukupno)", conn, tran);

                            insertStavkaRacuna.Parameters.Add("@RacunRefId", SqlDbType.Int).Value = idRacuna;
                            insertStavkaRacuna.Parameters.Add("@ArtikalRefId", SqlDbType.Int).Value = ArtikalRefId;
                            insertStavkaRacuna.Parameters.Add("@Kolicina", SqlDbType.Decimal).Value = Kolicina;
                            insertStavkaRacuna.Parameters.Add("@Cena", SqlDbType.Decimal).Value = Cena;
                            insertStavkaRacuna.Parameters.Add("@Popust", SqlDbType.Decimal).Value = Popust;
                            insertStavkaRacuna.Parameters.Add("@Ukupno", SqlDbType.Decimal).Value = Ukupno;

                            insertStavkaRacuna.ExecuteNonQuery();



                        }

                        tran.Commit();



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
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                            MessageBox.Show("Racun je refundiran!");
                            dataGridViewRefundacija.DataSource = null;
                            dataGridViewRefundacija.Refresh();
                            txtKupacRacun.Clear();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Izaberite broj racuna!");
            }
        }

        #region btnSearch
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtKupacRacun.Text))
            {
                try
                {
                    var select = "select r.Id, a.Naziv as 'Naziv artikla', r.BrojRacuna as 'Broj racuna', r.TipRacuna, r.TipTransakcije, r.DatumRacuna, r.OperaterRefId, r.MpRefId, rs.RacunRefId, rs.ArtikalRefid, rs.Kolicina as 'Kolicina', rs.Cena as 'Cena', rs.Popust, rs. Ukupno as 'Ukupno' " +
                        "from Racuni r inner join RacunStavka rs on rs.RacunRefId = r.Id inner join Artikal a on rs.ArtikalRefId = a.Id where r.BrojRacuna LIKE N'" + txtKupacRacun.Text + "'";


                    using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                    {

                        conn.Open();
                        using (var dataAdapter = new SqlDataAdapter(select, conn))
                        {

                            var ds = new DataSet();
                            dataAdapter.Fill(ds);
                            dataGridViewRefundacija.ReadOnly = true;
                            dataGridViewRefundacija.AllowUserToAddRows = false;
                            dataGridViewRefundacija.DataSource = ds.Tables[0];

                        }
                        conn.Close();
                        dataGridViewRefundacija.Columns["Id"].Visible = false;
                        dataGridViewRefundacija.Columns["TipRacuna"].Visible = false;
                        dataGridViewRefundacija.Columns["TipTransakcije"].Visible = false;
                        dataGridViewRefundacija.Columns["DatumRacuna"].Visible = false;
                        dataGridViewRefundacija.Columns["OperaterRefId"].Visible = false;
                        dataGridViewRefundacija.Columns["MpRefId"].Visible = false;
                        dataGridViewRefundacija.Columns["RacunRefId"].Visible = false;
                        dataGridViewRefundacija.Columns["ArtikalRefId"].Visible = false;
                        dataGridViewRefundacija.Columns["Popust"].Visible = false;



                    }
                }
                catch
                {
                    MessageBox.Show("Greska pri ucitavanju refundacije racuna!");
                }
            }
            else
            {
                MessageBox.Show("Unesite broj racuna!");
            }
        }

        #endregion btnSearch





    }
}
