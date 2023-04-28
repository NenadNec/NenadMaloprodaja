using ClosedXML.Excel;
using Maloprodaja.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maloprodaja
{
    public partial class frmPodesavanje : Form
    {
        public frmPodesavanje()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            initializeCb();
        }

        private void initializeCb()
        {
            cbRezimObuke.Checked = Properties.Settings.Default.TreningRezim;
            cbStampajLogo.Checked = Properties.Settings.Default.StampajLogo;

            cbPrenosNaRacun.Checked = Properties.Settings.Default.PrenosNaRacun;
            cbVaucer.Checked = Properties.Settings.Default.Vaucer;
            cbDrugo.Checked = Properties.Settings.Default.Drugo;
            cbGotovina.Checked = Properties.Settings.Default.Gotovina;
            cbPlatnaKartica.Checked = Properties.Settings.Default.Ostalo;
            cbCek.Checked = Properties.Settings.Default.Ostalo;
            cbInstantPlacanje.Checked = Properties.Settings.Default.Ostalo;
        }

        private void cbRezimObuke_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TreningRezim = cbRezimObuke.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbStampajLogo_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.StampajLogo = cbStampajLogo.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbPrenosNaRacun_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrenosNaRacun = cbPrenosNaRacun.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbVaucer_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Vaucer = cbVaucer.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbDrugo_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Drugo = cbDrugo.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbGotovina_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Gotovina = cbGotovina.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbPlatnaKartica_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ostalo = cbPlatnaKartica.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbCek_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ostalo = cbCek.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbInstantPlacanje_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ostalo = cbInstantPlacanje.Checked;
            Properties.Settings.Default.Save();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Proizvod p = new Proizvod();
            p.nazivProizvoda = textBox13.Text;
            p.sifraProizvoda = textBox14.Text;
            p.poreskaLabela = textBox15.Text;
            p.napomena = textBox16.Text;
            p.poreskaStopa = Convert.ToDouble(textBox17.Text);
            p.cena = Convert.ToDouble(textBox18.Text);
            GlobalnaKlasa.SacuvajProizvod(p);

            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<Proizvod> list = new List<Proizvod>();

            list = GlobalnaKlasa.VratiProizvode();

            if (list.Count > 0)
            {
                var workbook = new XLWorkbook();
                workbook.AddWorksheet("sheetName");
                var ws = workbook.Worksheet("sheetName");
                int row = 1;
                foreach (var c in list)
                {
                    ws.Cell("A" + row.ToString()).Value = c.nazivProizvoda;
                    ws.Cell("B" + row.ToString()).Value = c.sifraProizvoda;
                    ws.Cell("C" + row.ToString()).Value = c.poreskaLabela;
                    ws.Cell("D" + row.ToString()).Value = c.napomena;
                    ws.Cell("E" + row.ToString()).Value = c.poreskaStopa;
                    ws.Cell("E" + row.ToString()).Value = c.cena;
                    row++;

                }
                workbook.SaveAs("Proizvodi.xlsx");
            }
        }
        private DataTable ReadExcel(string fileName)
        {
            using (XLWorkbook workBook = new XLWorkbook(fileName))
            {
                IXLWorksheet workSheet = workBook.Worksheet(1);
                DataTable dt = new DataTable();

                bool firstRow = true;
                foreach (IXLRow row in workSheet.Rows())
                {
                    if (firstRow)
                    {
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Columns.Add(cell.Value.ToString());
                        }
                        firstRow = false;
                    }
                    else
                    {
                        dt.Rows.Add();
                        int i = 0;
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                    }
                }
                return dt;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                string fileExt = Path.GetExtension(file.FileName);
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = ReadExcel(file.FileName);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = dtExcel;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Molimo odaberite .xls ili .xlsx fajl.", "Učitavanje proizvoda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
