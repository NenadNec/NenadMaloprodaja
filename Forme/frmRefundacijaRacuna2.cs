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

namespace Maloprodaja
{
    public partial class frmRefundacijaRacuna2 : Form
    {
        int blagajnaID = 0;
        int fiskalni_id = 0;
        InvoiceRequest req = new InvoiceRequest();
        public frmRefundacijaRacuna2(string brojFiskalnog, string fiskalnoVreme, InvoiceRequest inv_req, int fiskalniID)
        {
            InitializeComponent();

            MinimizeBox = false;
            MaximizeBox = false;
            this.Text = "Refundacija računa " + brojFiskalnog;
            req = inv_req;
            fiskalni_id = fiskalniID;
            req.referentDocumentDT = fiskalnoVreme;
            req.referentDocumentNumber = brojFiskalnog;

            comboBox1.DataSource = GlobalnaKlasa.VratiListuIdentifikacija();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "code";
        }

    }
}
