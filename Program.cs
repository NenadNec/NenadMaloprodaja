using Maloprodaja.Forme.Artikli;
using Maloprodaja.Forme.Login;
using Maloprodaja.Forme.Porudzbenica;
using Maloprodaja.Forme.Racun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maloprodaja
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            //Application.Run(new frmRefundacijaRacuna());
            Application.Run(new frmLogin());
        }
    }
}
