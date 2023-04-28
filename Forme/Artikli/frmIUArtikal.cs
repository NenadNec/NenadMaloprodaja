using DocumentFormat.OpenXml.Wordprocessing;
using Maloprodaja.Helper;
using Maloprodaja.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Maloprodaja.Forme.Artikli
{
    public partial class frmIUArtikal : Form
    {
        int ArtikalId;
        int tip;
        public frmIUArtikal(int tip, int ArtikalId)
        {
            InitializeComponent();
            this.ArtikalId = ArtikalId;
            this.tip = tip;
            SetupForm(tip);
            ComboGrupaArtikala();
            ComboVrstaArtikla();
            ComboPoreskeStope();
            ComboJedinicaMere();
            ComboMagacin();
        }

        #region combobocGrupaArtikala
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

            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju grupe artikala!");
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

            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju vrste artikala!");
            }
        }


        #endregion comboboxVrsteArtikla

        #region comboboxPoreskeStope
        public void ComboPoreskeStope()
        {
            DataTable dtk = new DataTable();
            try
            {

                using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand("select Id, Naziv from PoreskeStope", conn))
                    {
                        dtk.Load(dCmd.ExecuteReader());
                    }
                    conn.Close();
                    cmbPoreskeStope.DataSource = dtk;
                    cmbPoreskeStope.DisplayMember = "Naziv";
                    cmbPoreskeStope.ValueMember = "Id";
                }
            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju poreske stope!");
            }
        }


        #endregion comboboxPoreskeStope

        #region comboboxJedinicaMere
        public void ComboJedinicaMere()
        {
            DataTable dtk = new DataTable();
            try
            {

                using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand("select Id, Naziv from JedinicaMere", conn))
                    {
                        dtk.Load(dCmd.ExecuteReader());
                    }
                    conn.Close();
                    cmbJedinicaMere.DataSource = dtk;
                    cmbJedinicaMere.DisplayMember = "Naziv";
                    cmbJedinicaMere.ValueMember = "Id";
                }

            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju jedinica mere!");
            }
        }


        #endregion comboboxJedinicaMere

        #region comboboxMagacin 

        public void ComboMagacin()
        {
            DataTable dtk = new DataTable();
            try
            {

                using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                {
                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand("select Id, Naziv, TipMagacina from Magacin", conn))
                    {
                        dtk.Load(dCmd.ExecuteReader());
                    }
                    conn.Close();
                    cmbMagacin.DataSource = dtk;
                    cmbMagacin.DisplayMember = "Naziv";
                    cmbMagacin.ValueMember = "Id";
                }

            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju jedinica mere!");
            }
        }

        #endregion comboboxMagacin

        #region btnDodajArtikal
        private void btnDodajArtikal_Click(object sender, EventArgs e)
        {
            if (txtNazivArtikla.Text == "" || txtSifraArtikla.Text == "" || txtGTIN.Text == ""
                            || Convert.ToInt32(cmbJedinicaMere.SelectedValue) == 0 || Convert.ToInt32(cmbGrupaArtikla.SelectedValue) == 0
                            || (Convert.ToInt32(cmbVrstaArtikla.SelectedValue) == 0)
                            || (Convert.ToInt32(cmbPoreskeStope.SelectedValue) == 0))
            {
                MessageBox.Show("Nisu popunjena sva polja za dodavanje artikla");
                return;
            }

            try
            {
                SqlTransaction tn;
                int artikalId = 0;
                string upitArtikal = "insert into Artikal (Naziv, GrupeArtiklaRefId, PoreskeStopeRefId, VrstaArtiklaRefId, JedinicaMereRefId, GTIN, Sifra, Raster, Popust, Kreirao, DatumKreiranja, Izmenio, DatumIzmene, MagacinRefId, OperaterRefId)" +
                    " values('"+ txtNazivArtikla.Text +"', "+ Convert.ToInt32(cmbGrupaArtikla.SelectedValue) + ", " + Convert.ToInt32(cmbPoreskeStope.SelectedValue) + ", " + Convert.ToInt32(cmbVrstaArtikla.SelectedValue) + ", "+ Convert.ToInt32(cmbJedinicaMere.SelectedValue) +", '" + txtGTIN.Text + "', '" + txtSifraArtikla.Text + "', " + Convert.ToInt32(checkRester.Checked) + ", " + Convert.ToInt32(checkPopust.Checked) + ", '', GETDATE(), '', '', " + Convert.ToInt32(cmbMagacin.SelectedValue) + ", "+ Operater.Id +") select scope_identity()";

                using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                {
                    conn.Open();
                    tn = conn.BeginTransaction();
                    try
                    {
                        using (SqlCommand dCmd = new SqlCommand(upitArtikal, conn, tn))
                        {
                            artikalId = Convert.ToInt32(dCmd.ExecuteScalar());
                        }

                        using (SqlCommand dCmd2 = new SqlCommand("insert into Cenovnik values("+artikalId+", " + txtCena.Text + " , GETDATE())", conn, tn))
                        {
                            dCmd2.ExecuteNonQuery();
                        }

                        tn.Commit();

                        MessageBox.Show("Poruka korisniku", "Artikal je uspeno dodat! ");
                        this.Close();

                    }
                    catch (SqlException ex)
                    {
                        tn.Rollback();
                        if (ex.Number == 2601) // UNIQUE INDEX
                        {
                            MessageBox.Show("Artikal sa ovom SIFROM ili GTIN vec postoji u bazi", "Poruka korisniku");
                        }
                        MessageBox.Show(ex.Message.ToString(), "GRESKA");
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Greska pri dodavanju artikla!");
            }

        }


        #endregion btnDodajArtikal

        #region btnIzmeniArtikal
        private void btnIzmeniArtikal_Click(object sender, EventArgs e)
        {
            if (txtNazivArtikla.Text == "" || txtSifraArtikla.Text == "" || txtGTIN.Text == ""
                            || Convert.ToInt32(cmbJedinicaMere.SelectedValue) == 0 || Convert.ToInt32(cmbGrupaArtikla.SelectedValue) == 0
                            || (Convert.ToInt32(cmbVrstaArtikla.SelectedValue) == 0)
                            || (Convert.ToInt32(cmbPoreskeStope.SelectedValue) == 0))
            {
                MessageBox.Show("Nisu popunjena sva polja za dodavanje artikla");
                return;
            }
            try
            {
                SqlTransaction tn;
                string upitArtikal = "update Artikal set Artikal.Naziv = '" + txtNazivArtikla.Text + "', Artikal.GrupeArtiklaRefId = "+ Convert.ToInt32(cmbGrupaArtikla.SelectedValue) +"," +
                    " Artikal.PoreskeStopeRefid = " + Convert.ToInt32(cmbPoreskeStope.SelectedValue) + ", Artikal.VrstaArtiklaRefId = " + Convert.ToInt32(cmbVrstaArtikla.SelectedValue) + ", Artikal.GTIN = '"+txtGTIN.Text+"', Artikal.Sifra = '" + txtSifraArtikla.Text + "', " +
                    "Artikal.Raster = " + Convert.ToInt32(checkRester.Checked) + ", Artikal.Popust = " + Convert.ToInt32(checkPopust.Checked) + ", Artikal.Kreirao = '', Artikal.Izmenio = '', " +
                    "Artikal.DatumIzmene = GETDATE(), Artikal.MagacinRefId = "+ Convert.ToInt32(cmbMagacin.SelectedValue) + " " +
                    "WHERE Artikal.Id = " + ArtikalId + "";

                string upitCena = "insert into Cenovnik VALUES(" + ArtikalId + ", "+txtCena.Text+", GETDATE())";

                using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                {
                    conn.Open();
                    tn = conn.BeginTransaction();
                    try
                    {
                        using (SqlCommand dCmd = new SqlCommand(upitArtikal, conn, tn))
                        {
                            dCmd.ExecuteNonQuery();
                        }

                        using (SqlCommand dCmd2 = new SqlCommand(upitCena, conn, tn))
                        {
                            dCmd2.ExecuteNonQuery();
                        }

                        tn.Commit();

                        MessageBox.Show("Poruka korisniku", "Artikal je uspeno izmenjen! ");
                        this.Close();

                    }
                    catch (SqlException ex)
                    {
                        tn.Rollback();
                        if (ex.Number == 2601) // UNIQUE INDEX
                        {
                            MessageBox.Show("Artikal sa ovom SIFROM ili GTIN vec postoji u bazi", "Poruka korisniku");
                        }
                        MessageBox.Show(ex.Message.ToString(), "GRESKA");
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Greska pri dodavanju artikla!");
            }
        }


        #endregion btnIzmeniArtikal

        private void txtCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                 e.Handled = true;
            {

            }
        }

        #region SetupForm
        void SetupForm(int tip)
        {
            if(tip == 0) // tip 0 == INSERT
            {
                btnIzmeniArtikal.Enabled = false;
                btnIzmeniArtikal.Hide();
                labelIzmeniArtikal.Hide();
                btnIzmeniNormativ.Hide();
                lblIzmeniNormativ.Hide();
                tabControlArtikal.TabPages.Remove(tabNormativ);
            }
            else if(tip == 1) // tip 1 == IZMENA
            {
                btnIzmeniArtikal.Location = new System.Drawing.Point(19, 23);
                labelIzmeniArtikal.Location = new System.Drawing.Point(28, 111);
                btnDodajArtikal.Enabled = false;
                btnDodajArtikal.Hide();
                labelDodajArtikal.Hide();

                btnIzmeniNormativ.Location = new System.Drawing.Point(19, 23);
                lblIzmeniNormativ.Location = new System.Drawing.Point(28, 111);
                btnDodajNormativ.Enabled = false;
                btnDodajNormativ.Hide();
                lblDodajNoramtiv.Hide();
            }
           
        }

        #endregion SetupForm

        #region GetArtikal
        public void getArtikal(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(HelperService.configConn))
                {

                    conn.Open();
                    using (SqlCommand dCmd = new SqlCommand(" SELECT a.Naziv AS 'Naziv artikla', a.GTIN, a.Sifra, g.Naziv AS 'Grupa artikla', v.Naziv AS 'Vrsta artikla' , j.Naziv AS 'Jedinica mere', c.Cena, a.Raster, a.Popust, ps.Naziv, m.Naziv FROM Artikal a " +
                            "INNER JOIN Cenovnik AS c ON c.ArtikalRefId = a.id INNER JOIN GrupeArtikla AS g ON g.Id = a.GrupeArtiklaRefId INNER JOIN VrstaArtikla v ON v.Id = a.VrstaArtiklaRefId " +
                            "INNER JOIN JedinicaMere j ON j.Id = a.JedinicaMereRefId " +
                            "INNER JOIN PoreskeStope ps ON ps.Id = a.PoreskeStopeRefid " +
                            "INNER JOIN Magacin m ON m.Id = a.MagacinRefId WHERE a.Id = " + Convert.ToInt32(id) + "", conn))
                    {

                        using (SqlDataReader reader = dCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txtNazivArtikla.Text = reader[0].ToString();
                                txtGTIN.Text = reader[1].ToString();
                                txtSifraArtikla.Text = reader[2].ToString();
                                cmbGrupaArtikla.Text = reader[3].ToString();
                                cmbVrstaArtikla.Text = reader[4].ToString();
                                cmbJedinicaMere.Text = reader[5].ToString();
                                txtCena.Text = reader[6].ToString();
                                checkRester.Checked = Convert.ToBoolean(reader[7]);
                                checkPopust.Checked = Convert.ToBoolean(reader[8]);
                                cmbPoreskeStope.Text = reader[9].ToString();
                                cmbMagacin.Text = reader[10].ToString();
                            }

                        }

                    }

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion GetArtikal

        private void frmIUArtikal_Load(object sender, EventArgs e)
        {
            if (tip == 1)
            {
                getArtikal(ArtikalId);
            }
        }
    }
}
