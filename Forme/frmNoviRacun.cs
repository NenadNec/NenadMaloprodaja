using Maloprodaja.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Maloprodaja.Klase.InvoiceRequest;

namespace Maloprodaja
{
    public partial class frmNoviRacun : Form
    {
        List<InvoiceItem> stavke = new List<InvoiceItem>();
        public frmNoviRacun()
        {
            InitializeComponent();
            List<Proizvod> list = GlobalnaKlasa.UcitajProizvode();
            cbproizvodi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbproizvodi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            cbproizvodi.DataSource = list;
            cbproizvodi.DisplayMember = "nazivProizvoda";

            var autoCompleteCollection = new AutoCompleteStringCollection();
            if (list != null && list.Count() > 0)
                foreach (Proizvod p in list)
                {
                    autoCompleteCollection.Add(p.nazivProizvoda);
                }

            cbproizvodi.AutoCompleteCustomSource = autoCompleteCollection;
            initializeComboBoxes();

            txtgotovina.Maximum = decimal.MaxValue;
            txtdrugo.Maximum = decimal.MaxValue;
            txtplatnakartica.Maximum = decimal.MaxValue;
            txtcek.Maximum = decimal.MaxValue;
            txtprenosnaracun.Maximum = decimal.MaxValue;
            txtvaucer.Maximum = decimal.MaxValue;
            txtinstantplacanje.Maximum = decimal.MaxValue;
            txtkolicina.Minimum = 1;
            txtzanaplatu.Text = "0";

            makePaymentVisible();
        }

        private void initializeComboBoxes()
        {
            cbtipidentifikacijekupca.DataSource = GlobalnaKlasa.VratiListuIdentifikacija();
            cbtipidentifikacijekupca.DisplayMember = "name";
            cbtipidentifikacijekupca.ValueMember = "code";
            cbtipidentifikacijekupca.SelectedItem = null;

            cbdokument.DataSource = GlobalnaKlasa.VratiListuIdentifikacijaZaDokumenta();
            cbdokument.DisplayMember = "name";
            cbdokument.ValueMember = "code";
            cbdokument.SelectedItem = null;
        }

        private void makePaymentVisible()
        {
            panelOstalo.Visible = Properties.Settings.Default.Ostalo;
            panelPrenosNaRacun.Visible = Properties.Settings.Default.PrenosNaRacun;
            panelVaucer.Visible = Properties.Settings.Default.Vaucer;
            panelDrugo.Visible = Properties.Settings.Default.Drugo;
            panelGotovina.Visible = Properties.Settings.Default.Gotovina;
        }

        private void DisplayTableWithListview()
        {
            lvstavke.GridLines = true;// Whether the grid lines are displayed
            lvstavke.FullRowSelect = true;// Whether to select the entire line

            lvstavke.View = View.Details;// Set display mode
            lvstavke.Scrollable = true;// Whether to show the scroll bar automatically
            lvstavke.MultiSelect = false;// Is it possible to select multiple lines
            lvstavke.Font = new Font("SystemFonts.DefaultFont", 10f);

            lvstavke.Columns.Add("Proizvod", 310, HorizontalAlignment.Left);
            lvstavke.Columns.Add("Oznaka poreza", 120, HorizontalAlignment.Center);
            lvstavke.Columns.Add("Količina", 80, HorizontalAlignment.Center);
            lvstavke.Columns.Add("Cena", 100, HorizontalAlignment.Right);
            lvstavke.Columns.Add("Iznos", 100, HorizontalAlignment.Right);



            for (int i = 0; i < stavke.Count(); i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();
                item.SubItems[0].Text = stavke[i].name.ToString();
                item.SubItems.Add(stavke[i].labels[0].ToString());
                item.SubItems.Add(stavke[i].quantity.ToString());
                item.SubItems.Add(stavke[i].unitPrice.ToString());
                item.SubItems.Add(stavke[i].totalAmount.ToString());

                lvstavke.Items.Add(item);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Proizvod p = cbproizvodi.SelectedItem as Proizvod;
            InvoiceItem item = new InvoiceItem();
            item.name = p.nazivProizvoda;
            item.quantity = (double)txtkolicina.Value;
            item.unitPrice = (double)p.cena;
            item.totalAmount = item.quantity * item.unitPrice;
            item.labels = new string[] { p.poreskaLabela };
            stavke.Add(item);
            txtkolicina.Value = 1;
            lvstavke.Items.Clear();
            lvstavke.Columns.Clear();
            DisplayTableWithListview();
            txtzanaplatu.Text = stavke.Sum(x => x.totalAmount).ToString();
        }
    }
}
