using Maloprodaja.Forme.Porudzbenica;
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
using System.Windows.Forms;

namespace Maloprodaja.Forme.Artikli
{
    public partial class frmPorudzbeniceLista : Form

    {
        Helper.HelperService ConfigConn = new Helper.HelperService();

        public frmPorudzbeniceLista()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitSetup();
        }

        void InitSetup()
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnDodajArtikal_Click(object sender, EventArgs e)
        {
            frmInsertPorudzbenica frm = new frmInsertPorudzbenica();
            frm.ShowDialog();
        }

        private void frmPorudzbeniceLista_Load(object sender, EventArgs e)
        {
            //GetPorudzbenice();
        }

        private void InitializeDataGridView()
        {
            // Initialize basic DataGridView properties.
            dgwPorudzbenice.Dock = DockStyle.Fill;
            dgwPorudzbenice.BackgroundColor = System.Drawing.Color.LightGray;
            dgwPorudzbenice.BorderStyle = BorderStyle.Fixed3D;

            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            dgwPorudzbenice.AllowUserToAddRows = false;
            dgwPorudzbenice.AllowUserToDeleteRows = false;
            dgwPorudzbenice.AllowUserToOrderColumns = true;
            dgwPorudzbenice.ReadOnly = true;
            dgwPorudzbenice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwPorudzbenice.MultiSelect = false;
            dgwPorudzbenice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgwPorudzbenice.AllowUserToResizeColumns = false;
            dgwPorudzbenice.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgwPorudzbenice.AllowUserToResizeRows = false;
            dgwPorudzbenice.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            dgwPorudzbenice.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgwPorudzbenice.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            dgwPorudzbenice.RowHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            dgwPorudzbenice.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dgwPorudzbenice.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;

            // Set the row and column header styles.
            dgwPorudzbenice.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgwPorudzbenice.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            dgwPorudzbenice.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

            // Empty cell default value
            dgwPorudzbenice.DefaultCellStyle.NullValue = "/";

        }

        public void GetPorudzbenice(string BrojPorudzbenice = "", string Porucilac = "", string DatumPorudzbeniceOd = "", string DatumPorudzbeniceDo = "")
        {
            string connectionString = HelperService.configConn;

            //porudzbenicaClassBindingSource.Clear();
            dgwPorudzbenice.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                StringBuilder sb = new StringBuilder();
                SqlParameter[] parameters;

                if (!string.IsNullOrEmpty(DatumPorudzbeniceOd))
                {
                    parameters = new SqlParameter[4];
                    parameters[0] = new SqlParameter("@BrojPorudzbenice", SqlDbType.VarChar) { Value = BrojPorudzbenice };
                    parameters[1] = new SqlParameter("@Porucilac", SqlDbType.VarChar) { Value = Porucilac };
                    parameters[2] = new SqlParameter("@DatumPorudzbeniceOd", SqlDbType.DateTime) { Value = DateTime.ParseExact(DatumPorudzbeniceOd, "dd.MM.yyyy", null) };
                    parameters[3] = new SqlParameter("@DatumPorudzbeniceDo", SqlDbType.DateTime) { Value = DateTime.ParseExact(DatumPorudzbeniceDo, "dd.MM.yyyy", null) };
                }
                else
                {
                    parameters = new SqlParameter[2];
                    parameters[0] = new SqlParameter("@BrojPorudzbenice", SqlDbType.VarChar) { Value = BrojPorudzbenice };
                    parameters[1] = new SqlParameter("@Porucilac", SqlDbType.VarChar) { Value = Porucilac };
                }
                

                sb.Append(@"SELECT [Id],[BrojPorudzbenice],[DatumPorudzbenice],[Porucilac],[Telefon],[DatumIsporuke],[Napomena] FROM [dbo].[Porudzbenica] WHERE 1 = 1 ");

                if (!string.IsNullOrEmpty(BrojPorudzbenice))
                {
                    sb.AppendFormat(@"AND BrojPorudzbenice = @BrojPorudzbenice ");
                }

                if (!string.IsNullOrEmpty(Porucilac))
                {
                    sb.AppendFormat(@"AND Porucilac LIKE '%' + @Porucilac + '%' ");
                }

                if (!string.IsNullOrEmpty(DatumPorudzbeniceOd))
                {
                    sb.AppendFormat(@"AND DatumPorudzbenice >= @DatumPorudzbeniceOd AND DatumPorudzbenice <= @DatumPorudzbeniceDo ");
                }

                sb.AppendFormat(@"ORDER BY Id DESC ");

                using (SqlCommand sCmd = new SqlCommand(sb.ToString(), connection))
                {
                    sCmd.Connection.Open();
                    sCmd.CommandType = CommandType.Text;
                    sCmd.Parameters.AddRange(parameters);

                    using (SqlDataReader reader = sCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                /*PorudzbenicaClass item = new PorudzbenicaClass();
                                item.Id = Convert.ToInt32(reader[0]);
                                item.BrojPorudzbenice = reader[1].ToString();
                                item.DatumPorudzbenice = Convert.ToDateTime(reader[2].ToString());
                                item.Porucilac = reader[3].ToString();
                                item.Telefon = reader[4].ToString();
                                item.DatumIsporuke = Convert.ToDateTime(reader[5].ToString());
                                item.Napomena = reader[6].ToString();

                                porudzbenicaClassBindingSource.Add(item);*/
                                dgwPorudzbenice.Rows.Add(Convert.ToInt32(reader[0]),
                                    reader[1].ToString(),
                                    Convert.ToDateTime(reader[2].ToString()).ToString("dd.MM.yyyy"),
                                    reader[3].ToString(),
                                    reader[4].ToString(),
                                    Convert.ToDateTime(reader[5].ToString()).ToString("dd.MM.yyyy"),
                                    reader[6].ToString());
                            }
                        }

                    }
                }
            }
        }

        public List<StavkaPorudzbenice> GetListaStavkiZaPorudzbenicu(int idPorudzbenice)
        {
            List<StavkaPorudzbenice> lista = new List<StavkaPorudzbenice>();
            string connectionString = HelperService.configConn;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "select p.ArtikalRefId, a.Naziv, p.Kolicina, p.Napomena from PorudzbenicaStavka p (nolock) inner join Artikal a (nolock) on p.ArtikalRefId = a.Id where p.PorudzbenicaRefId = @IdPorudzbenice";

                using (SqlCommand sCmd = new SqlCommand(queryString, connection))
                {
                    sCmd.Connection.Open();
                    sCmd.CommandType = CommandType.Text;

                    sCmd.Parameters.Add("@IdPorudzbenice", SqlDbType.Int).Value = idPorudzbenice;

                    using (SqlDataReader reader = sCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                StavkaPorudzbenice item = new StavkaPorudzbenice();
                                item.ArtikalRefId = Convert.ToInt32(reader[0]);
                                item.ArtikalNaziv = reader[1].ToString();
                                item.Kolicina = Convert.ToDecimal(reader[2].ToString());
                                item.Napomena = reader[3].ToString();

                                lista.Add(item);
                            }
                        }

                    }
                }
            }

            return lista;
        }

        public bool DeletePorudzbenica(int idPorudzbenice)
        {
            bool result = false;

            string connectionString = HelperService.configConn;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                SqlCommand deleteStavkePorudzbenice = new SqlCommand("delete PorudzbenicaStavka where PorudzbenicaRefId = @IdPorudzbenice", conn, tran);

                deleteStavkePorudzbenice.Parameters.Add("@IdPorudzbenice", SqlDbType.Int).Value = idPorudzbenice;

                try
                {
                    int deletedStavke = Convert.ToInt32(deleteStavkePorudzbenice.ExecuteNonQuery());

                    if (deletedStavke > 0)
                    {
                        SqlCommand deletePorudzbenice = new SqlCommand("delete Porudzbenica where Id = @IdPorudzbenice", conn, tran);

                        deletePorudzbenice.Parameters.Add("@IdPorudzbenice", SqlDbType.Int).Value = idPorudzbenice;

                        int deletedPorudzbenica = Convert.ToInt32(deletePorudzbenice.ExecuteNonQuery());

                        if (deletedPorudzbenica > 0)
                        {
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

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            //porudzbenicaClassBindingSource.Clear();
            dgwPorudzbenice.Rows.Clear();

            GetPorudzbenice(txtBrojPorudzbenice.Text, txtPorucilac.Text, dpDatumPorudzbeniceOd.Text, dpDatumPorudzbeniceDo.Text);
        }

        private void btnIzmeniArtikal_Click(object sender, EventArgs e)
        {
            if (dgwPorudzbenice.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                PorudzbenicaClass item = new PorudzbenicaClass();
                foreach (DataGridViewRow dataRow in this.dgwPorudzbenice.SelectedRows)
                {
                    item.ListaStavki = GetListaStavkiZaPorudzbenicu(Convert.ToInt32(dataRow.Cells[0].Value));
                    item.Id = Convert.ToInt32(dataRow.Cells[0].Value);
                    item.BrojPorudzbenice = dataRow.Cells[1].Value.ToString();
                    item.DatumPorudzbenice = Convert.ToDateTime(dataRow.Cells[2].Value);
                    item.Porucilac = dataRow.Cells[3].Value.ToString();
                    item.Telefon = dataRow.Cells[4].Value.ToString();
                    item.DatumIsporuke = Convert.ToDateTime(dataRow.Cells[5].Value);
                    item.Napomena = dataRow.Cells[6].Value.ToString();
    }

                frmInsertPorudzbenica frm = new frmInsertPorudzbenica(item);
                frm.ShowDialog();
            }
        }

        private void btnObrisiArtikal_Click(object sender, EventArgs e)
        {
            if (dgwPorudzbenice.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow item in this.dgwPorudzbenice.SelectedRows)
                {
                    if (MessageBox.Show("Da li ste sigurni da želite da izbrišete ovu porudzbenicu?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool isDeleted = DeletePorudzbenica(Convert.ToInt32(item.Cells[0].Value));
                        if (isDeleted)
                        {
                            MessageBox.Show("Uspešno obrisana porudzbenica!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            GetPorudzbenice(txtBrojPorudzbenice.Text, txtPorucilac.Text);
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBrojPorudzbenice.Clear();
            txtPorucilac.Clear();
        }

        private void btnIzveziArtikal_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
