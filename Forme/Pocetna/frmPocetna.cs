using Maloprodaja.Forme.Artikli;
using Maloprodaja.Forme.Izvestaji;
using Maloprodaja.Forme.Porudzbenica;
using Maloprodaja.Forme.Racun;
using Maloprodaja.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maloprodaja.Forme.Pocetna
{
    public partial class frmPocetna : Form
    {
        Thread th;
        public frmPocetna()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            SetupForm();
        }
        void SetupForm()
        {
            toolStripStatusLabelOperater.Text = "Operater: " + Operater.ImePrezime;
            toolStripStatusLabelOperater.BackColor = Color.Green;
            toolStripStatusLabelBaza.Text = "Baza: Maloprodaja2022";
            toolStripStatusLabelBaza.BackColor = Color.Gray;
            toolStripStatusLabelMp.Text = "GS Maloprodaja v 1.0.0.0";
            toolStripStatusLabelMp.BackColor = Color.Gray;

            btnDnevniIzvestaj.Hide();
            btnIyvestaZaPrometArtikla.Hide();
            btnIzvestajPrometaPoDanu.Hide();
            btnIzvestajPorudzbenice.Hide();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            th = new Thread(openFormRacun);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            btnDnevniIzvestaj.Hide();
            btnIyvestaZaPrometArtikla.Hide();
            btnIzvestajPrometaPoDanu.Hide();
            btnIzvestajPorudzbenice.Hide();
        }

        private void btnPorudzbenica_Click(object sender, EventArgs e)
        {
            
            th = new Thread(openFormPorudzbenica);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            btnDnevniIzvestaj.Hide();
            btnIyvestaZaPrometArtikla.Hide();
            btnIzvestajPrometaPoDanu.Hide();
            btnIzvestajPorudzbenice.Hide();
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
           
            th = new Thread(openFormArtikal);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            btnDnevniIzvestaj.Hide();
            btnIyvestaZaPrometArtikla.Hide();
            btnIzvestajPrometaPoDanu.Hide();
            btnIzvestajPorudzbenice.Hide();
        }

        private void btnIzvestaji_Click(object sender, EventArgs e)
        {

            btnDnevniIzvestaj.Show();
            btnIyvestaZaPrometArtikla.Show();
            btnIzvestajPrometaPoDanu.Show();
            btnIzvestajPorudzbenice.Show();

        }

        private void btnPodesavanja_Click(object sender, EventArgs e)
        {
           
            th = new Thread(openFormPodesavanja);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            btnDnevniIzvestaj.Hide();
            btnIyvestaZaPrometArtikla.Hide();
            btnIzvestajPrometaPoDanu.Hide();
            btnIzvestajPorudzbenice.Hide();
        }

        private void openFormRacun()
        {
            new frmRacun().ShowDialog();
        }
        private void openFormPorudzbenica()
        {
            new frmPorudzbeniceLista().ShowDialog();
        }
        private void openFormArtikal()
        {
            new frmArtikliLista().ShowDialog();
        }
        private void openFormDnevniIzvestaji()
        {
            new frmDnevniIzvestaj().ShowDialog();
        }
        private void openFormIzvestajPorudzbenice()
        {
           new frmIzvestajPorudzbenice().ShowDialog();
        }
        private void openFormIzvestajPrometaPoDanima()
        {
            new frmIzvestajPrometaPoDanima().ShowDialog();
        }
        private void openFormIzvestajZaPrometArtikala()
        {
            new frmIzvestajZaPrometArtikala().ShowDialog();
        }
        private void openFormPodesavanja()
        {
            new frmPodesavanje().ShowDialog();
        }

        private void btnDnevniIzvestaj_Click(object sender, EventArgs e)
        {

            th = new Thread(openFormDnevniIzvestaji);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnIzvestajPorudzbenice_Click(object sender, EventArgs e)
        {
           
            th = new Thread(openFormIzvestajPorudzbenice);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnIzvestajPrometaPoDanu_Click(object sender, EventArgs e)
        {
            
            th = new Thread(openFormIzvestajPrometaPoDanima);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnIyvestaZaPrometArtikla_Click(object sender, EventArgs e)
        {
            th = new Thread(openFormIzvestajZaPrometArtikala);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }



        #region btnPaintUI

        private bool blnButtonDown = false;

        private void btnDnevniIzvestaj_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void btnDnevniIzvestaj_MouseDown(object sender, MouseEventArgs e)
        {
            blnButtonDown = true;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnDnevniIzvestaj_MouseUp(object sender, MouseEventArgs e)
        {
            blnButtonDown = false;
            (sender as System.Windows.Forms.Button).Invalidate();
        }



        private void btnIzvestajPrometaPoDanu_MouseDown(object sender, MouseEventArgs e)
        {
            blnButtonDown = true;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnIzvestajPrometaPoDanu_MouseUp(object sender, MouseEventArgs e)
        {
            blnButtonDown = false;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnIzvestajPrometaPoDanu_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void btnIyvestaZaPrometArtikla_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void btnIyvestaZaPrometArtikla_MouseDown(object sender, MouseEventArgs e)
        {
            blnButtonDown = true;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnIyvestaZaPrometArtikla_MouseUp(object sender, MouseEventArgs e)
        {
            blnButtonDown = false;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnIzvestajPorudzbenice_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void btnIzvestajPorudzbenice_MouseDown(object sender, MouseEventArgs e)
        {
            blnButtonDown = true;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnIzvestajPorudzbenice_MouseUp(object sender, MouseEventArgs e)
        {
            blnButtonDown = false;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

     

        private void btnRacun_Paint(object sender, PaintEventArgs e)
        {

            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void btnRacun_MouseDown(object sender, MouseEventArgs e)
        {
            blnButtonDown = true;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnRacun_MouseUp(object sender, MouseEventArgs e)
        {
            blnButtonDown = false;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnPorudzbenica_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void btnPorudzbenica_MouseDown(object sender, MouseEventArgs e)
        {
            blnButtonDown = true;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnPorudzbenica_MouseUp(object sender, MouseEventArgs e)
        {
            blnButtonDown = false;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnArtikli_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void btnArtikli_MouseDown(object sender, MouseEventArgs e)
        {
            blnButtonDown = true;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnArtikli_MouseUp(object sender, MouseEventArgs e)
        {
            blnButtonDown = false;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnIzvestaji_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void btnIzvestaji_MouseDown(object sender, MouseEventArgs e)
        {
            blnButtonDown = true;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnIzvestaji_MouseUp(object sender, MouseEventArgs e)
        {
            blnButtonDown = false;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnPodesavanja_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void btnPodesavanja_MouseDown(object sender, MouseEventArgs e)
        {
            blnButtonDown = true;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void btnPodesavanja_MouseUp(object sender, MouseEventArgs e)
        {
            blnButtonDown = false;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        #endregion btnPaintUI




    }
}
