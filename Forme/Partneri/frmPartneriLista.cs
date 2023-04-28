using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maloprodaja.Forme.Partneri
{
    public partial class frmPartneriLista : Form
    {
        public frmPartneriLista()
        {
            InitializeComponent();
            InitSetup();
        }

        void InitSetup()
        {
            WindowState = FormWindowState.Maximized;
        }
        
    }
}
