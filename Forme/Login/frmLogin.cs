using Maloprodaja.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maloprodaja.Klase;
using Maloprodaja.Forme.Racun;
using Maloprodaja.Forme.Pocetna;

namespace Maloprodaja.Forme.Login
{
    public partial class frmLogin : Form
    {
        Thread th;
        public frmLogin()
        {
            InitializeComponent();
            LogProxy.Configure();
        }

        void Login()
        {
            try
            {
                string connectionString = HelperService.configConn;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string queryString = "SELECT TOP 1 Id, ImePrezime, KorisnickoIme FROM Operater where KorisnickoIme = '" + txtKorisnicko.Text + "' and Lozinka = '" + txtLozinka.Text + "'";

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

                                    Operater.Id = Convert.ToInt32(reader[0]);
                                    Operater.ImePrezime = reader[1].ToString();
                                    Operater.KorisnickoIme = reader[2].ToString();
                                }

                                if (Operater.Id != 0)
                                {
                                    LogProxy.log.Info("Uspena prijava operatera " + Operater.ImePrezime);
                                    this.Close();
                                    th = new Thread(openNewForm);
                                    th.SetApartmentState(ApartmentState.STA);
                                    th.Start();
                                }
                                else
                                {
                                    LogProxy.log.Error("Neuspesna prijava operatera Korisnicko ime: " + txtKorisnicko.Text + " Lozinka: " + txtLozinka.Text);
                                    MessageBox.Show("Operater ne postoji u sistemu!", "PRIJAVA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


                            }
                            else
                            {
                                LogProxy.log.Error("Neuspesna prijava operatera Korisnicko ime: " + txtKorisnicko.Text + " Lozinka: " + txtLozinka.Text);
                                MessageBox.Show("Neuspesna prijava na sistem!", "PRIJAVA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                LogProxy.log.Error(ex.Message);
                MessageBox.Show(ex.Message, "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                LogProxy.log.Error(ex.Message);
                MessageBox.Show(ex.Message, "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void openNewForm(object obj)
        {
            Application.Run(new frmPocetna());
        }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
