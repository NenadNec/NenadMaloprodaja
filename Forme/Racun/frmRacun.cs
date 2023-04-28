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
    public partial class frmRacun : Form
    {
        private bool _canUpdateArtikal = true;
        private bool _needUpdateArtikal = false;

        Artikal odabranArtikal = new Artikal();

        bool isUpdate = false;
        int selectedIndex;
        public frmRacun()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            InitializeDataGridView();
        }

        private void frmRacun_Load(object sender, EventArgs e)
        {
            PanelResize();
            this.ActiveControl = cmbArtikliSifra;
            this.KeyPreview = true;
        }

        private void frmRacun_Resize(object sender, EventArgs e)
        {
            PanelResize();
        }

        void PanelResize()
        {
            panelLeft.Width = Convert.ToInt32(this.Width * 0.592);
            panelRight.Width = Convert.ToInt32(this.Width * 0.392);
            panelSifra.Width = Convert.ToInt32(panel3.Width * 0.25);
            panelKolicina.Width = Convert.ToInt32(panel3.Width * 0.15);
            panelCena.Width = Convert.ToInt32(panel3.Width * 0.15);
            panelPopust.Width = Convert.ToInt32(panel3.Width * 0.15);
            panelProdajnaCena.Width = Convert.ToInt32(panel3.Width * 0.15);
            panelBtnDodajArtikal.Width = Convert.ToInt32(panel3.Width * 0.15);

            cmbArtikliSifra.Width = Convert.ToInt32(panelSifra.Width - 10);
            txtKolicina.Width = Convert.ToInt32(panelKolicina.Width - 5);
            txtCena.Width = Convert.ToInt32(panelCena.Width - 5);
            txtPopust.Width = Convert.ToInt32(panelPopust.Width - 5);
            txtProdajnaCena.Width = Convert.ToInt32(panelProdajnaCena.Width - 5);

            label3.SendToBack();
        }

        private void InitializeDataGridView()
        {
            // Initialize basic DataGridView properties.
            dataGridViewRacun.Dock = DockStyle.Fill;
            dataGridViewRacun.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewRacun.BorderStyle = BorderStyle.Fixed3D;

            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            dataGridViewRacun.AllowUserToAddRows = false;
            dataGridViewRacun.AllowUserToDeleteRows = false;
            dataGridViewRacun.AllowUserToOrderColumns = true;
            dataGridViewRacun.ReadOnly = true;
            dataGridViewRacun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRacun.MultiSelect = false;
            dataGridViewRacun.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewRacun.AllowUserToResizeColumns = false;
            dataGridViewRacun.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewRacun.AllowUserToResizeRows = false;
            dataGridViewRacun.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            dataGridViewRacun.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewRacun.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            dataGridViewRacun.RowHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            dataGridViewRacun.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewRacun.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;

            // Set the row and column header styles.
            dataGridViewRacun.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridViewRacun.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewRacun.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

            // Empty cell default value
            dataGridViewRacun.DefaultCellStyle.NullValue = "/";

        }

        private void cmbArtikliSifra_TextChanged(object sender, EventArgs e)
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
            if (cmbArtikliSifra.Text.Length > 1)
            {
                List<Artikal> searchData = GetArtikli(cmbArtikliSifra.Text);
                HandleTextChangedArtikli(searchData);
            }
        }

        private void HandleTextChangedArtikli(List<Artikal> dataSource)
        {
            var text = cmbArtikliSifra.Text;

            if (dataSource.Count() > 0)
            {
                cmbArtikliSifra.DisplayMember = "Sifra";
                cmbArtikliSifra.ValueMember = "Id";
                cmbArtikliSifra.DataSource = dataSource;

                /*cmbArtikliSifra.SelectedIndex = -1;
                cmbArtikliSifra.Text = text;*/

                var sText = cmbArtikliSifra.Items[0].ToString();
                cmbArtikliSifra.SelectionStart = text.Length;
                cmbArtikliSifra.SelectionLength = sText.Length - text.Length;
                cmbArtikliSifra.DroppedDown = true;



                return;
            }
            else
            {
                cmbArtikliSifra.DroppedDown = false;
                cmbArtikliSifra.SelectionStart = text.Length;
            }
        }

        public List<Artikal> GetArtikli(string term)
        {
            List<Artikal> result = new List<Artikal>();
            string connectionString = HelperService.configConn;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT a.Id, a.Naziv, a.Sifra +' - '+ a.Naziv, c.Cena  FROM Artikal a (NOLOCK) INNER JOIN Cenovnik c (nolock) on a.Id = c.ArtikalRefId WHERE a.Naziv LIKE N'%" + term + "%' OR a.Sifra LIKE N'%" + term + "%'";

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
                                a.Cena = Convert.ToDecimal(reader[3]);

                                result.Add(a);
                            }
                        }

                    }
                }
            }
            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _canUpdateArtikal = true;
            timer1.Stop();
            UpdateDataArtikli();
        }

        private void RestartTimerArtikla()
        {
            timer1.Stop();
            _canUpdateArtikal = false;
            timer1.Start();
        }

        private void cmbArtikliSifra_SelectedIndexChanged(object sender, EventArgs e)
        {
            _needUpdateArtikal = false;
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedItem != null)
                odabranArtikal = cmb.SelectedItem as Artikal;
        }

        private void cmbArtikliSifra_TextUpdate(object sender, EventArgs e)
        {
            _needUpdateArtikal = true;
        }

        private void cmbArtikliSifra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Artikal a = cmbArtikliSifra.SelectedItem as Artikal;

                    if (a != null)
                    {
                        txtCena.Value = a.Cena;
                        txtProdajnaCena.Value = a.Cena;

                        txtKolicina.Focus();
                        txtKolicina.Select(0, txtKolicina.Text.Length);

                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                    else
                    {
                        MessageBox.Show("Morate izabrati neki artikal!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                catch (Exception ex)
                {
                    LogProxy.log.Error(ex.Message);
                }
            }
        }

        private void txtKolicina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProdajnaCena.Value = txtCena.Value * txtKolicina.Value;
                txtCena.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtCena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProdajnaCena.Value = txtCena.Value * txtKolicina.Value;
                txtPopust.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPopust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProdajnaCena.Value = (txtCena.Value * txtKolicina.Value) * (1 - (txtPopust.Value / 100));
                btnDodajArtikal.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtKolicina_Enter(object sender, EventArgs e)
        {
            Artikal a = cmbArtikliSifra.SelectedItem as Artikal;

            if (a != null)
            {
                txtCena.Value = a.Cena;
                txtProdajnaCena.Value = a.Cena;
            }

            txtKolicina.Select(0, txtKolicina.Text.Length);
        }

        private void txtCena_Enter(object sender, EventArgs e)
        {
            txtProdajnaCena.Value = txtCena.Value * txtKolicina.Value;
            txtCena.Select(0, txtCena.Text.Length);
        }

        private void txtPopust_Enter(object sender, EventArgs e)
        {
            txtProdajnaCena.Value = txtCena.Value * txtKolicina.Value;
            txtPopust.Select(0, txtPopust.Text.Length);
        }

        private void btnDodajArtikal_Enter(object sender, EventArgs e)
        {
            txtProdajnaCena.Value = (txtCena.Value * txtKolicina.Value) * (1 - (txtPopust.Value / 100));
        }

        private void btnDodajArtikal_Click(object sender, EventArgs e)
        {
            Artikal a = cmbArtikliSifra.SelectedItem as Artikal;
            if (a != null)
            {
                bool postojiArtikal = false;
                int indexArtikla = -1; 
                decimal kolicina = txtKolicina.Value;
                decimal cena = txtCena.Value;
                decimal prodajnaCena = txtProdajnaCena.Value;
                decimal popust = (cena * kolicina) - prodajnaCena;

                decimal popustProcenat = txtPopust.Value;

                if (isUpdate)
                {
                    dataGridViewRacun.Rows[selectedIndex].Cells[0].Value = a.Id;
                    dataGridViewRacun.Rows[selectedIndex].Cells[1].Value = a.Sifra;
                    dataGridViewRacun.Rows[selectedIndex].Cells[2].Value = a.NazivArtikla;
                    dataGridViewRacun.Rows[selectedIndex].Cells[3].Value = kolicina;
                    dataGridViewRacun.Rows[selectedIndex].Cells[4].Value = Math.Round(cena, 2);
                    dataGridViewRacun.Rows[selectedIndex].Cells[5].Value = Math.Round(popust, 2);
                    dataGridViewRacun.Rows[selectedIndex].Cells[6].Value = Math.Round(prodajnaCena, 2);
                    dataGridViewRacun.Rows[selectedIndex].Cells[7].Value = Math.Round(popustProcenat, 2);
                    dataGridViewRacun.ClearSelection();
                    UpdateBalance();
                    ClearFields();
                }
                else
                {
                    foreach (DataGridViewRow row in this.dataGridViewRacun.Rows)
                    {
                        int idArtikla = Convert.ToInt32(row.Cells[0].Value.ToString());
                        decimal popustArtikla = Convert.ToDecimal(row.Cells[7].Value.ToString());
                        if (idArtikla == a.Id && popustArtikla == Math.Round(popustProcenat, 2))
                        {
                            postojiArtikal = true;
                            indexArtikla = row.Index;
                            break;
                        }
                    }
                    if (postojiArtikal)
                    {
                        dataGridViewRacun.Rows[indexArtikla].Cells[0].Value = a.Id;
                        dataGridViewRacun.Rows[indexArtikla].Cells[1].Value = a.Sifra;
                        dataGridViewRacun.Rows[indexArtikla].Cells[2].Value = a.NazivArtikla;
                        dataGridViewRacun.Rows[indexArtikla].Cells[3].Value = Convert.ToDecimal(dataGridViewRacun.Rows[indexArtikla].Cells[3].Value.ToString()) + kolicina;
                        dataGridViewRacun.Rows[indexArtikla].Cells[4].Value = Convert.ToDecimal(dataGridViewRacun.Rows[indexArtikla].Cells[4].Value.ToString()) + Math.Round(cena, 2);
                        dataGridViewRacun.Rows[indexArtikla].Cells[5].Value = Convert.ToDecimal(dataGridViewRacun.Rows[indexArtikla].Cells[5].Value.ToString()) + Math.Round(popust, 2);
                        dataGridViewRacun.Rows[indexArtikla].Cells[6].Value = Convert.ToDecimal(dataGridViewRacun.Rows[indexArtikla].Cells[6].Value.ToString()) + Math.Round(prodajnaCena, 2);
                        dataGridViewRacun.Rows[indexArtikla].Cells[7].Value = Math.Round(popustProcenat, 2);
                        dataGridViewRacun.ClearSelection();
                        UpdateBalance();
                        ClearFields();
                    }
                    else
                    {
                        dataGridViewRacun.Rows.Add(a.Id, a.Sifra, a.NazivArtikla, kolicina, Math.Round(cena, 2), Math.Round(popust, 2), Math.Round(prodajnaCena, 2), Math.Round(popustProcenat, 2));
                        dataGridViewRacun.ClearSelection();
                        UpdateBalance();
                        ClearFields();
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate izabrati neki artikal!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cmbArtikliSifra.Focus();
            }
        }

        public void ClearFields()
        {
            cmbArtikliSifra.SelectedItem = -1;
            cmbArtikliSifra.DataSource = null;
            txtKolicina.Value = 1;
            txtCena.Value = 0;
            txtPopust.Value = 0;
            txtProdajnaCena.Value = 0;

            cmbArtikliSifra.Focus();

            isUpdate = false;
        }

        private void dataGridViewRacun_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBalance();
        }

        private void dataGridViewRacun_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateBalance();
        }

        private void UpdateBalance()
        {
            int counter;

            decimal ukupno = 0;
            decimal popust = 0;
            decimal poslePopusta = 0;

            // Iterate through the rows, skipping the Starting Balance row.
            for (counter = 1; counter <= (dataGridViewRacun.Rows.Count);
                counter++)
            {
                poslePopusta += Convert.ToDecimal(dataGridViewRacun.Rows[counter - 1].Cells["Ukupno"].Value.ToString());

                if (dataGridViewRacun.Rows[counter - 1].Cells["Popust"].Value != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (dataGridViewRacun.Rows[counter - 1].Cells["Popust"].Value.ToString().Length != 0)
                    {
                        popust += Convert.ToDecimal(dataGridViewRacun.Rows[counter - 1].Cells["Popust"].Value.ToString());
                    }
                }
            }

            ukupno = popust + poslePopusta;

            /*lblUkupno.Text = Math.Round(ukupno, 2).ToString();
            lblPopust.Text = Math.Round(popust, 2).ToString();
            lblSaPopustom.Text = Math.Round(poslePopusta, 2).ToString();*/

            lblUkupno.Text = ukupno.ToString();
            lblPopust.Text = popust.ToString();
            lblSaPopustom.Text = poslePopusta.ToString();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewRacun.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Da li ste sigurni da želite da izbrišete ovaj artikal?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dataGridViewRacun.SelectedRows)
                    {
                        dataGridViewRacun.Rows.RemoveAt(item.Index);
                    }
                }
            }
        }

        private void frmRacun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                cmbArtikliSifra.Focus();
            }
            if (e.KeyCode == Keys.F9)
            {
                txtKolicina.Focus();
            }
            if (e.KeyCode == Keys.F10)
            {
                txtCena.Focus();
            }
            if (e.KeyCode == Keys.F11)
            {
                txtPopust.Focus();
            }
        }

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            if (dataGridViewRacun.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow row in this.dataGridViewRacun.SelectedRows)
                {
                    selectedIndex = row.Index;

                    decimal kolicina = Convert.ToDecimal(row.Cells[3].Value.ToString());
                    decimal cena = Convert.ToDecimal(row.Cells[4].Value.ToString());
                    decimal prodajnaCena = Convert.ToDecimal(row.Cells[6].Value.ToString());
                    decimal popustProcenat = Convert.ToDecimal(row.Cells[7].Value.ToString());

                    string nazivArtikla = row.Cells[2].Value.ToString();

                    cmbArtikliSifra.Text = nazivArtikla;
                    UpdateDataArtikliForUpdate();

                    txtKolicina.Value = kolicina;
                    txtCena.Value = cena;
                    txtPopust.Value = popustProcenat;
                    txtProdajnaCena.Value = prodajnaCena;

                    isUpdate = true;
                }
            }
        }

        private void UpdateDataArtikliForUpdate()
        {
            if (cmbArtikliSifra.Text.Length > 1)
            {
                List<Artikal> searchData = GetArtikli(cmbArtikliSifra.Text);
                HandleTextChangedArtikliForUpdate(searchData);
            }
        }

        private void HandleTextChangedArtikliForUpdate(List<Artikal> dataSource)
        {
            var text = cmbArtikliSifra.Text;

            if (dataSource.Count() > 0)
            {
                cmbArtikliSifra.DisplayMember = "Sifra";
                cmbArtikliSifra.ValueMember = "Id";
                cmbArtikliSifra.DataSource = dataSource;

                cmbArtikliSifra.SelectedIndex = 0;
                cmbArtikliSifra.Text = text;

                /*var sText = cmbArtikliSifra.Items[0].ToString();
                cmbArtikliSifra.SelectionStart = text.Length;
                cmbArtikliSifra.SelectionLength = sText.Length - text.Length;
                cmbArtikliSifra.DroppedDown = true;*/

                return;
            }
            else
            {
                cmbArtikliSifra.DroppedDown = false;
                cmbArtikliSifra.SelectionStart = text.Length;
            }
        }

        private void btnGotovina_Click(object sender, EventArgs e)
        {
            if (dataGridViewRacun.Rows.Count > 0)
            {
                List<StavkaRacuna> listaStavki = new List<StavkaRacuna>();

                foreach (DataGridViewRow row in dataGridViewRacun.Rows)
                {
                    StavkaRacuna item = new StavkaRacuna();
                    item.ArtikalRefId = Convert.ToInt32(row.Cells[0].Value);
                    item.ArtikalNaziv = row.Cells[2].Value.ToString();
                    item.Kolicina = Convert.ToDecimal(row.Cells[3].Value);
                    item.Cena = Convert.ToDecimal(row.Cells[4].Value);
                    item.Popust = Convert.ToDecimal(row.Cells[5].Value);
                    item.Ukupno = Convert.ToDecimal(row.Cells[6].Value);

                    listaStavki.Add(item);
                }

                decimal ukupno = Convert.ToDecimal(lblSaPopustom.Text);
                frmRacunPotvrda potvrda = new frmRacunPotvrda(listaStavki,ukupno,1);
                potvrda.ReturnValue += potvrda_ReturnValue;
                potvrda.Show();
            }
            else
            {
                MessageBox.Show("Morate uneti bar jednu stavku računa !", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void potvrda_ReturnValue(string poruka)
        {
            dataGridViewRacun.Rows.Clear();
            lblUkupno.Text = "0.00";
            lblPopust.Text = "0.00";
            lblSaPopustom.Text = "0.00";
        }
    }
}
