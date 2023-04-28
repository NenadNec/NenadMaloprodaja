using Maloprodaja.Klase;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Maloprodaja
{
    public partial class frmMain : Form
    {
        BindingSource bindingSource = new BindingSource();
        public frmMain()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            InitializeDataGridView();

            LogProxy.Configure();
            LogProxy.log.Info("Pokrenuta aplikacija!");
        }

        private void InitializeDataGridView()
        {
            try
            {
                dataGridView1.Dock = DockStyle.Fill;
                dataGridView1.AutoGenerateColumns = true;

                bindingSource.DataSource = GlobalnaKlasa.getDataTable();
                dataGridView1.DataSource = bindingSource;

                // Automatically resize the visible rows.
                dataGridView1.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                // Set the DataGridView control's border.
                dataGridView1.BorderStyle = BorderStyle.Fixed3D;

                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dataGridView1.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 28.5F, GraphicsUnit.Pixel);
                dataGridView1.Columns[1].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 28.5F, GraphicsUnit.Pixel);
                dataGridView1.Columns[2].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 28.5F, GraphicsUnit.Pixel);
                dataGridView1.Columns[3].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 28.5F, GraphicsUnit.Pixel);
                dataGridView1.Columns[4].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 28.5F, GraphicsUnit.Pixel);
                dataGridView1.Columns[5].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 28.5F, GraphicsUnit.Pixel);
                dataGridView1.Columns[6].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 28.5F, GraphicsUnit.Pixel);
                dataGridView1.Columns[7].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 28.5F, GraphicsUnit.Pixel);
                dataGridView1.Columns[8].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 28.5F, GraphicsUnit.Pixel);


                this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                LogProxy.log.Error(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmNoviRacun frmNR = new frmNoviRacun();
            frmNR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            if (selectedRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Da li zaista želite da refundirate selektovani račun ?", "Refundacija računa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    int fiskalni_id = Convert.ToInt32(selectedRow.Cells["Inerni broj"].Value);
                    string fisaklno_vreme = selectedRow.Cells["Vreme računa"].Value.ToString();
                    string invoice_no = selectedRow.Cells["Broj računa"].Value.ToString();
                    InvoiceRequest req = JsonConvert.DeserializeObject<InvoiceRequest>(selectedRow.Cells["Zahtev"].Value.ToString());

                    int refundirano = Convert.ToInt32(selectedRow.Cells["Status refundacije"].Value);
                    if (refundirano == 0)
                    {
                        LogProxy.log.Info("Otvorena forma za refundaciju računa!");
                        frmRefundacijaRacuna2 frr = new frmRefundacijaRacuna2(invoice_no, fisaklno_vreme, req, fiskalni_id);
                        frr.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ovaj račun nije moguće refundirati !", "Poruka refundacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Maloprodaja"].ConnectionString;
            int selectedrowindex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            if (selectedRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Da li zaista želite da kopirate selektovani račun ?", "Kopija računa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmPodesavanje frm = new frmPodesavanje();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmOSoftveru frm = new frmOSoftveru();
            frm.Show();
        }
    }
}
