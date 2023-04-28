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

namespace Maloprodaja.Forme.Porudzbenica
{
    public partial class frmInsertPorudzbenica : Form
    {
        private bool _canUpdateArtikal = true;
        private bool _needUpdateArtikal = false;

        Artikal odabranArtikal = new Artikal();

        bool isUpdate = false;

        int noviRedniBrojPorudzbenice = 0;
        PorudzbenicaClass porudzbenicaZaUpdate = new PorudzbenicaClass();
        public frmInsertPorudzbenica()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        public frmInsertPorudzbenica(PorudzbenicaClass p)
        {
            InitializeComponent();
            InitializeDataGridView();

            isUpdate = true;
            porudzbenicaZaUpdate = p;

            txtBrojPorudzbenice.Text = p.BrojPorudzbenice;
            dpDatumPorudzbenice.Text = p.DatumPorudzbenice.ToString();
            txtPorucilac.Text = p.Porucilac;
            txtTelefon.Text = p.Telefon;
            dpDatumIsporuke.Text = p.DatumIsporuke.ToString();
            txtNapomena.Text = p.Napomena;
            foreach (StavkaPorudzbenice item in p.ListaStavki)
            {
                //stavkaPorudzbeniceBindingSource.Add(item);
                dgwStavkePorudzbenice.Rows.Add(item.ArtikalRefId, item.ArtikalNaziv, item.Kolicina, item.Napomena);
            }
        }
        public List<Artikal> GetArtikli(string term)
        {
            List<Artikal> result = new List<Artikal>();
            string connectionString = HelperService.configConn;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT Id, Naziv, Sifra +' - '+ Naziv FROM Artikal (NOLOCK) WHERE Naziv LIKE '%" + term + "%' OR Sifra LIKE '%" + term + "%'";

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
                                Artikal a = new Artikal();
                                a.Id = Convert.ToInt32(reader[0]);
                                a.NazivArtikla = reader[1].ToString();
                                a.Sifra = reader[2].ToString();

                                result.Add(a);
                            }
                        }

                    }
                }
            }
            return result;
        }

        public ProveraPorudzbenice GetBrojPorudzbenice()
        {
            ProveraPorudzbenice result = new ProveraPorudzbenice();
            string connectionString = HelperService.configConn;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT TOP 1 SUBSTRING(BrojPorudzbenice, CHARINDEX('-', BrojPorudzbenice)+1, LEN(BrojPorudzbenice)),SUBSTRING(BrojPorudzbenice, 1, 4) FROM Porudzbenica (nolock) ORDER BY Id desc";

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
                                result.RedniBrojPorudzbenice = string.IsNullOrEmpty(reader[0].ToString()) ? 0 : Convert.ToInt32(reader[0]);
                                result.Godina = string.IsNullOrEmpty(reader[1].ToString()) ? DateTime.Now.Year.ToString() : reader[1].ToString();
                            }
                        }

                    }
                }
            }
            return result;
        }
        private void cmbArtikli_TextChanged(object sender, EventArgs e)
        {
            if (_needUpdateArtikal)
            {
                if (_canUpdateArtikal)
                {
                    _canUpdateArtikal = false;
                    UpdateDataArtikli();
                }
                else
                {
                    RestartTimerArtikla();
                }
            }
        }

        private void UpdateDataArtikli()
        {
            if (cmbArtikli.Text.Length > 1)
            {
                List<Artikal> searchData = GetArtikli(cmbArtikli.Text);
                HandleTextChangedStanicaOd(searchData);
            }
        }

        private void HandleTextChangedStanicaOd(List<Artikal> dataSource)
        {
            var text = cmbArtikli.Text;

            if (dataSource.Count() > 0)
            {
                cmbArtikli.DisplayMember = "Sifra";
                cmbArtikli.ValueMember = "Id";
                cmbArtikli.DataSource = dataSource;

                /*cmbArtikli.SelectedIndex = -1;
                cmbArtikli.Text = text;*/

                var sText = cmbArtikli.Items[0].ToString();
                cmbArtikli.SelectionStart = text.Length;
                cmbArtikli.SelectionLength = sText.Length - text.Length;
                cmbArtikli.DroppedDown = true;

                

                return;
            }
            else
            {
                cmbArtikli.DroppedDown = false;
                cmbArtikli.SelectionStart = text.Length;
            }
        }

        private void RestartTimerArtikla()
        {
            timer1.Stop();
            _canUpdateArtikal = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _canUpdateArtikal = true;
            timer1.Stop();
            UpdateDataArtikli();
        }

        private void cmbArtikli_SelectedIndexChanged(object sender, EventArgs e)
        {
            _needUpdateArtikal = false;
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedItem != null)
                odabranArtikal = cmb.SelectedItem as Artikal;
        }

        private void cmbArtikli_TextUpdate(object sender, EventArgs e)
        {
            _needUpdateArtikal = true;
        }

        private void cmbArtikli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtKolicina.Focus();
                txtKolicina.Select(0, txtKolicina.Text.Length);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtKolicina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNapomenaStake.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtNapomenaStake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDodajStavku.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            Artikal a = cmbArtikli.SelectedItem as Artikal;
            if (a != null)
            {
                StavkaPorudzbenice s = new StavkaPorudzbenice();
                s.ArtikalNaziv = a.NazivArtikla;
                s.ArtikalRefId = a.Id;
                s.Kolicina = (decimal)txtKolicina.Value;
                s.Napomena = txtNapomenaStake.Text;
                //stavke.Add(s);
                cmbArtikli.Focus();
                txtKolicina.Value = 1;
                txtNapomenaStake.Clear();
                DisplayTableWithListview(s);
            }
            else
            {
                MessageBox.Show("Morate izabrati neki artikal!", "Poruka", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void DisplayTableWithListview(StavkaPorudzbenice s)
        {
            //stavkaPorudzbeniceBindingSource.Add(s);
            dgwStavkePorudzbenice.Rows.Add(s.ArtikalRefId,s.ArtikalNaziv,s.Kolicina,s.Napomena);
            dgwStavkePorudzbenice.ClearSelection();
        }

        private void dgwStavkePorudzbenice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwStavkePorudzbenice.Columns[e.ColumnIndex].Name == "ObrisiStavkuPorudzbenice")
            {
                if (MessageBox.Show("Da li ste sigurni da želite da izbrišete ovu stavku?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //stavkaPorudzbeniceBindingSource.RemoveCurrent();
                    foreach (DataGridViewRow item in this.dgwStavkePorudzbenice.SelectedRows)
                    {
                        dgwStavkePorudzbenice.Rows.RemoveAt(item.Index);
                    }
                    dgwStavkePorudzbenice.ClearSelection();
                }
            }
        }

        

        public bool InsertPorudzbenica(PorudzbenicaClass p)
        {
            bool result = false;
            int idPorudzbenice = 0;

            string connectionString = HelperService.configConn;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                SqlCommand insertPorudzbenica = new SqlCommand("INSERT INTO [dbo].[Porudzbenica] VALUES(@BrojPorudzbenice,@DatumPorudzbenice,@Porucilac,@Telefon,@DatumIsporuke,@Napomena,@OperaterRefId) select scope_identity()", conn, tran);
                
                insertPorudzbenica.Parameters.Add("@BrojPorudzbenice", SqlDbType.VarChar).Value = p.BrojPorudzbenice;
                insertPorudzbenica.Parameters.Add("@DatumPorudzbenice", SqlDbType.DateTime).Value = p.DatumPorudzbenice;
                insertPorudzbenica.Parameters.Add("@Porucilac", SqlDbType.VarChar).Value = p.Porucilac;
                insertPorudzbenica.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = p.Telefon;
                insertPorudzbenica.Parameters.Add("@DatumIsporuke", SqlDbType.DateTime).Value = p.DatumIsporuke;
                insertPorudzbenica.Parameters.Add("@Napomena", SqlDbType.VarChar).Value = p.Napomena;
                insertPorudzbenica.Parameters.Add("@OperaterRefId", SqlDbType.Int).Value = Operater.Id;

                try
                {
                    idPorudzbenice = Convert.ToInt32(insertPorudzbenica.ExecuteScalar());

                    foreach (StavkaPorudzbenice item in p.ListaStavki)
                    {
                        SqlCommand insertStavkaPorudzbenica = new SqlCommand("INSERT INTO [dbo].[PorudzbenicaStavka] VALUES(@Kolicina,@PorudzbenicaRefId,@ArtikalRefId,@Napomena)", conn, tran);
                        
                        insertStavkaPorudzbenica.Parameters.Add("@Kolicina", SqlDbType.Decimal).Value = item.Kolicina;
                        insertStavkaPorudzbenica.Parameters.Add("@PorudzbenicaRefId", SqlDbType.Int).Value = idPorudzbenice;
                        insertStavkaPorudzbenica.Parameters.Add("@ArtikalRefId", SqlDbType.Int).Value = item.ArtikalRefId;
                        insertStavkaPorudzbenica.Parameters.Add("@Napomena", SqlDbType.VarChar).Value = item.Napomena;

                        insertStavkaPorudzbenica.ExecuteNonQuery();
                    }

                    tran.Commit();

                    result = true;
                }
                catch (Exception ex)
                {
                    LogProxy.log.Error(ex.Message);
                    tran.Rollback();
                }
                finally
                {
                    conn.Close();
                }
            }

            return result;
        }

        public bool UpdatePorudzbenice(PorudzbenicaClass p)
        {
            bool result = false;


            string connectionString = HelperService.configConn;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                SqlCommand updatePorudzbenica = new SqlCommand(@"UPDATE [dbo].[Porudzbenica] SET [DatumPorudzbenice] = @DatumPorudzbenice
                                          ,[Porucilac] = @Porucilac
                                          ,[Telefon] = @Telefon
                                          ,[DatumIsporuke] = @DatumIsporuke
                                          ,[Napomena] = @Napomena
                                     WHERE Id = @IdPorudzbenice", conn, tran);

                updatePorudzbenica.Parameters.Add("@DatumPorudzbenice", SqlDbType.DateTime).Value = p.DatumPorudzbenice;
                updatePorudzbenica.Parameters.Add("@Porucilac", SqlDbType.VarChar).Value = p.Porucilac;
                updatePorudzbenica.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = p.Telefon;
                updatePorudzbenica.Parameters.Add("@DatumIsporuke", SqlDbType.DateTime).Value = p.DatumIsporuke;
                updatePorudzbenica.Parameters.Add("@Napomena", SqlDbType.VarChar).Value = p.Napomena;
                updatePorudzbenica.Parameters.Add("@IdPorudzbenice", SqlDbType.VarChar).Value = p.Id;

                SqlCommand deleteStavkePorudzbenice = new SqlCommand("delete PorudzbenicaStavka where PorudzbenicaRefId = @IdPorudzbenice", conn, tran);

                deleteStavkePorudzbenice.Parameters.Add("@IdPorudzbenice", SqlDbType.Int).Value = p.Id;

                try
                {
                    int updatePorudzbenice = Convert.ToInt32(updatePorudzbenica.ExecuteNonQuery());

                    if (updatePorudzbenice > 0)
                    {
                        int deleteStavke = Convert.ToInt32(deleteStavkePorudzbenice.ExecuteNonQuery());

                        if (deleteStavke > 0)
                        {
                            foreach (StavkaPorudzbenice item in p.ListaStavki)
                            {
                                SqlCommand insertStavkaPorudzbenica = new SqlCommand("INSERT INTO [dbo].[PorudzbenicaStavka] VALUES(@Kolicina,@PorudzbenicaRefId,@ArtikalRefId,@Napomena)", conn, tran);

                                insertStavkaPorudzbenica.Parameters.Add("@Kolicina", SqlDbType.Decimal).Value = item.Kolicina;
                                insertStavkaPorudzbenica.Parameters.Add("@PorudzbenicaRefId", SqlDbType.Int).Value = p.Id;
                                insertStavkaPorudzbenica.Parameters.Add("@ArtikalRefId", SqlDbType.Int).Value = item.ArtikalRefId;
                                insertStavkaPorudzbenica.Parameters.Add("@Napomena", SqlDbType.VarChar).Value = item.Napomena;

                                insertStavkaPorudzbenica.ExecuteNonQuery();
                            }

                            tran.Commit();

                            result = true;
                        }
                        else
                        {
                            tran.Rollback();

                            result = false;
                        }
                    }
                    else
                    {
                        tran.Rollback();

                        result = false;
                    }
                }
                catch (Exception ex)
                {
                    LogProxy.log.Error(ex.Message);
                    tran.Rollback();
                }
                finally
                {
                    conn.Close();
                }
            }

            return result;
        }

        private void txtPorucilac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTelefon.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtTelefon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dpDatumPorudzbenice.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dpDatumPorudzbenice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dpDatumIsporuke.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dpDatumIsporuke_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNapomena.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtNapomena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbArtikli.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void frmInsertPorudzbenica_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            if (!isUpdate)
            {
                ProveraPorudzbenice item = new ProveraPorudzbenice();
                item = GetBrojPorudzbenice();
                noviRedniBrojPorudzbenice = item.RedniBrojPorudzbenice + 1;
                string godina = DateTime.Now.Year.ToString();
                if (godina != item.Godina)
                {
                    noviRedniBrojPorudzbenice = 1;
                }
                txtBrojPorudzbenice.Text = godina + "-"+ Convert.ToString(noviRedniBrojPorudzbenice);
            }

            this.ActiveControl = txtPorucilac;

        }

        private void btnSacuvajArtikal_Click(object sender, EventArgs e)
        {
            PorudzbenicaClass p = new PorudzbenicaClass();
            p.Id = porudzbenicaZaUpdate.Id;
            p.BrojPorudzbenice = txtBrojPorudzbenice.Text;
            p.DatumPorudzbenice = DateTime.ParseExact(dpDatumPorudzbenice.Text, "dd.MM.yyyy", null);
            p.Porucilac = txtPorucilac.Text;
            p.Telefon = txtTelefon.Text;
            p.DatumIsporuke = DateTime.ParseExact(dpDatumIsporuke.Text, "dd.MM.yyyy", null);
            p.Napomena = txtNapomena.Text;
            List<StavkaPorudzbenice> listaStavki = new List<StavkaPorudzbenice>();
            foreach (DataGridViewRow row in dgwStavkePorudzbenice.Rows)
            {
                StavkaPorudzbenice item = new StavkaPorudzbenice();
                item.ArtikalRefId = Convert.ToInt32(row.Cells[0].Value.ToString());
                item.ArtikalNaziv = row.Cells[1].Value.ToString();
                item.Kolicina = Convert.ToDecimal(row.Cells[2].Value.ToString());
                item.Napomena = row.Cells[3].Value.ToString();

                listaStavki.Add(item);
            }
            p.ListaStavki = listaStavki;

            if (listaStavki.Count == 0)
            {
                MessageBox.Show("Morate dodati stavke u porudzbenicu!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                if (isUpdate)
                {
                    bool result = UpdatePorudzbenice(p);

                    if (result)
                    {
                        MessageBox.Show("Uspešno izmenjena porudzbenica!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.Close();
                    }
                }
                else
                {
                    bool result = InsertPorudzbenica(p);

                    if (result)
                    {
                        MessageBox.Show("Uspešno kreirana porudzbenica!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.Close();
                    }
                }
            }
        }
        private void frmInsertPorudzbenica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                PorudzbenicaClass p = new PorudzbenicaClass();
                p.Id = porudzbenicaZaUpdate.Id;
                p.BrojPorudzbenice = txtBrojPorudzbenice.Text;
                p.DatumPorudzbenice = DateTime.ParseExact(dpDatumPorudzbenice.Text, "dd.MM.yyyy", null);
                p.Porucilac = txtPorucilac.Text;
                p.Telefon = txtTelefon.Text;
                p.DatumIsporuke = DateTime.ParseExact(dpDatumIsporuke.Text, "dd.MM.yyyy", null);
                p.Napomena = txtNapomena.Text;
                List<StavkaPorudzbenice> listaStavki = new List<StavkaPorudzbenice>();
                foreach (DataGridViewRow row in dgwStavkePorudzbenice.Rows)
                {
                    StavkaPorudzbenice item = new StavkaPorudzbenice();
                    item.ArtikalRefId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    item.ArtikalNaziv = row.Cells[1].Value.ToString();
                    item.Kolicina = Convert.ToDecimal(row.Cells[2].Value.ToString());
                    item.Napomena = row.Cells[3].Value.ToString();

                    listaStavki.Add(item);
                }
                p.ListaStavki = listaStavki;

                if (listaStavki.Count == 0)
                {
                    MessageBox.Show("Morate dodati stavke u porudzbenicu!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    if (isUpdate)
                    {
                        bool result = UpdatePorudzbenice(p);

                        if (result)
                        {
                            MessageBox.Show("Uspešno izmenjena porudzbenica!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            this.Close();
                        }
                    }
                    else
                    {
                        bool result = InsertPorudzbenica(p);

                        if (result)
                        {
                            MessageBox.Show("Uspešno kreirana porudzbenica!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void txtKolicina_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            // Initialize basic DataGridView properties.
            //dgwStavkePorudzbenice.Dock = DockStyle.Fill;
            dgwStavkePorudzbenice.BackgroundColor = System.Drawing.Color.LightGray;
            dgwStavkePorudzbenice.BorderStyle = BorderStyle.Fixed3D;

            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            dgwStavkePorudzbenice.AllowUserToAddRows = false;
            dgwStavkePorudzbenice.AllowUserToDeleteRows = false;
            dgwStavkePorudzbenice.AllowUserToOrderColumns = true;
            dgwStavkePorudzbenice.ReadOnly = true;
            dgwStavkePorudzbenice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwStavkePorudzbenice.MultiSelect = false;
            dgwStavkePorudzbenice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgwStavkePorudzbenice.AllowUserToResizeColumns = false;
            dgwStavkePorudzbenice.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgwStavkePorudzbenice.AllowUserToResizeRows = false;
            dgwStavkePorudzbenice.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            dgwStavkePorudzbenice.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgwStavkePorudzbenice.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            dgwStavkePorudzbenice.RowHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            dgwStavkePorudzbenice.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dgwStavkePorudzbenice.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;

            // Set the row and column header styles.
            dgwStavkePorudzbenice.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgwStavkePorudzbenice.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            dgwStavkePorudzbenice.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

            // Empty cell default value
            dgwStavkePorudzbenice.DefaultCellStyle.NullValue = "/";

            dgwStavkePorudzbenice.RowHeadersWidthSizeMode =
          DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgwStavkePorudzbenice.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgwStavkePorudzbenice.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
