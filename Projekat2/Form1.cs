using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace Projekat2
{
    public partial class Form1 : Form
    {
        Baza baza;
        List<Artikal> artikli;
        List<Grupa> grupe;
        List<int> idjevi_artikala;
        Button[] btnGrupe;
        Thread t;
        Racun racun;
        List<StavkaNaRacunu> stavkeNaRacunu;
        int grupa = -1;
        double ugaoSekunda = -180;
        double ugaoSat = -180;
        double ugaoMinut = -180;
        double poluprecnik;
        double centarKruzniceX;
        double centarKruzniceY;
        bool crtaj = false;
        private delegate void delOsveziBazu();
        Form6 f;
        public Form1(Form6 f)
        {
            InitializeComponent();
            baza = new Baza();
            artikli = new List<Artikal>();
            grupe = new List<Grupa>();
            idjevi_artikala = new List<int>();
            stavkeNaRacunu = new List<StavkaNaRacunu>();
            rbtnDigitalni.Checked = true;
            tmrSat.Enabled = true;
            this.f = f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCenaRacuna.Text = "";
            /*iscitajGrupe();
            iscrtajDugmice();*/
        }

        private void iscitajGrupe()
        {
            grupe.Clear();
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT id_grupa, naziv FROM Grupa"
                                  + Environment.NewLine + "GROUP BY naziv, id_grupa ORDER BY id_grupa";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idjevi_artikala.Clear();
                    Grupa g = new Grupa();
                    g.Id_grupa = int.Parse(reader["id_grupa"].ToString());
                    g.Naziv = reader["naziv"].ToString();
                    grupe.Add(g);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.ZatvoriKonekciju();
            }
        }

        private void iscrtajDugmice()
        {
            pnlDugmici.Controls.Clear();
            btnGrupe = new Button[grupe.Count];
            int top = 0;
            for (int i = 0; i < grupe.Count; i++)
            {
                if (grupe[i].Naziv.ToLower().Contains(txtPretragaGrupa.Text.ToLower()))
                {
                    btnGrupe[i] = new Button();
                    btnGrupe[i].Parent = pnlDugmici;
                    btnGrupe[i].Width = pnlDugmici.Width - 50;
                    btnGrupe[i].Height = 57;
                    btnGrupe[i].Left = (pnlDugmici.Width - btnGrupe[i].Width) / 2;
                    btnGrupe[i].Top = top;
                    top += btnGrupe[i].Height;
                    btnGrupe[i].Text = grupe[i].Id_grupa + ": " + grupe[i].Naziv;
                    btnGrupe[i].Font = new Font(btnGrupe[i].Font.FontFamily, 12);
                    btnGrupe[i].Click += btnGrupe_Click;
                    pnlDugmici.Controls.Add(btnGrupe[i]);
                }
            }
        }

        private int nadjiIdSelektovaneGrupe(Button grupa)
        {
            string id = "";
            for (int i = 0; i < grupa.Text.Length; i++)
            {
                if (grupa.Text[i] == ':')
                {
                    break;
                }
                else
                {
                    id += grupa.Text[i];
                }
            }
            return int.Parse(id);
        }
        private void bazaProizvoda()
        {
            while (true)
            {
                this.Invoke(new delOsveziBazu(osveziBazu));
                Thread.Sleep(30000);
            }
        }
        private void osveziBazu()
        {
            iscitajGrupe();
            iscrtajDugmice();
            iscitajArtikleSelektovaneGrupe();
        }
        private void btnGrupe_Click(object sender, EventArgs e)
        {
            string tekst = ((Button)sender).Text;
            grupa = nadjiIdSelektovaneGrupe((Button)sender);
            lblGrupa.Text = tekst.Substring(tekst.IndexOf(' '));
            iscitajArtikleSelektovaneGrupe();
        }

        private void iscitajArtikleSelektovaneGrupe()
        {
            lbxArtikli.DataSource = null;
            lbxArtikli.Items.Clear();
            if (grupa > -1)
            {
                try
                {
                    artikli.Clear();
                    baza.OtvoriKonekciju();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "SELECT * FROM Artikal" + Environment.NewLine +
                                      "WHERE id_artikla IN" + Environment.NewLine +
                                      "(SELECT id_artikla FROM Grupa WHERE id_grupa = " + grupa + ")";
                                      /*IN" + Environment.NewLine +
                                      "(SELECT id_grupa FROM Grupa WHERE naziv IN (" + '"' + grupa + '"' + ")))";*/
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Artikal a = new Artikal();
                        a.Id_artikla = int.Parse(reader["id_artikla"].ToString());
                        a.Naziv = reader["naziv"].ToString();
                        a.Cena = double.Parse(reader["cena"].ToString());
                        a.Popust = double.Parse(reader["popust"].ToString());
                        artikli.Add(a);
                    }
                    popuniArtikleSelektovaneGrupe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    baza.ZatvoriKonekciju();
                }
            }
        }

        private void popuniArtikleSelektovaneGrupe()
        {
            lbxArtikli.Items.Clear();
            for (int i = 0; i < artikli.Count; i++)
            {
                if (artikli[i].Naziv.Contains(txtPretragaArtikala.Text))
                {
                    lbxArtikli.Items.Add(artikli[i]);
                }
            }
            //lbxArtikli.DataSource = artikli;
        }
        private void btnDodajNaRacun_Click(object sender, EventArgs e)
        {
            if (lbxArtikli.SelectedItem != null)
            {
                Artikal a = (Artikal)lbxArtikli.SelectedItem;
                if (racun == null)
                {
                    racun = new Racun();
                }
                dodajNaRacun(a);
                dodajStavkuNaRacunu(a);
            }
        }
        private void dodajNaRacun(Artikal a)
        {
            racun.Cena += (a.Cena - (a.Popust / 100 * a.Cena)) * int.Parse(txtKolicina.Text);
            lblCenaRacuna.Text = racun.Cena.ToString("0.00") + " rsd";
        }
        private void promeniKolicinuNaRacunu()
        {

        }
        private void dodajStavkuNaRacunu(Artikal a)
        {
            bool vecNaRacunu = false;
            for (int i = 0; i < stavkeNaRacunu.Count; i++)
            {
                if (a.Id_artikla == stavkeNaRacunu[i].Artikal.Id_artikla)
                {
                    stavkeNaRacunu[i].Kolicina += int.Parse(txtKolicina.Text);
                    vecNaRacunu = true;
                    break;
                }
            }
            if (!vecNaRacunu)
            {
                stavkeNaRacunu.Add(new StavkaNaRacunu());
                int index = stavkeNaRacunu.Count - 1;
                stavkeNaRacunu[index].Artikal = a;
                stavkeNaRacunu[index].Kolicina = int.Parse(txtKolicina.Text);
                if (stavkeNaRacunu.Count - 1 == 0)
                {
                    stavkeNaRacunu[index].LblNaziv.Top = lblRacun.Top + lblRacun.Height;
                }
                else
                {
                    stavkeNaRacunu[index].LblNaziv.Top = stavkeNaRacunu[index - 1].LblNaziv.Top +
                                                                         stavkeNaRacunu[index - 1].LblNaziv.Height;
                }
                stavkeNaRacunu[index].LblNaziv.Parent = pnlRacun;
                if (stavkeNaRacunu.Count - 1 == 0)
                {
                    stavkeNaRacunu[index].LblKolicina.Top = lblRacun.Top + lblRacun.Height;
                }
                else
                {
                    stavkeNaRacunu[index].LblKolicina.Top = stavkeNaRacunu[index - 1].LblKolicina.Top +
                                                                         stavkeNaRacunu[index - 1].LblKolicina.Height;
                }
                stavkeNaRacunu[index].LblKolicina.Parent = pnlRacun;
                if (stavkeNaRacunu.Count - 1 == 0)
                {
                    stavkeNaRacunu[index].LblCena.Top = lblRacun.Top + lblRacun.Height;
                }
                else
                {
                    stavkeNaRacunu[index].LblCena.Top = stavkeNaRacunu[index - 1].LblCena.Top +
                                                                         stavkeNaRacunu[index - 1].LblCena.Height;
                }
                stavkeNaRacunu[index].LblCena.Parent = pnlRacun;
                if (stavkeNaRacunu.Count - 1 == 0)
                {
                    stavkeNaRacunu[index].BtnManje.Top = lblRacun.Top + lblRacun.Height;
                }
                else
                {
                    stavkeNaRacunu[index].BtnManje.Top = stavkeNaRacunu[index - 1].LblCena.Top +
                                                                         stavkeNaRacunu[index - 1].LblCena.Height;
                }
                stavkeNaRacunu[index].BtnManje.Parent = pnlRacun;
                if (stavkeNaRacunu.Count - 1 == 0)
                {
                    stavkeNaRacunu[index].BtnVise.Top = lblRacun.Top + lblRacun.Height;
                }
                else
                {
                    stavkeNaRacunu[index].BtnVise.Top = stavkeNaRacunu[index - 1].LblCena.Top +
                                                                         stavkeNaRacunu[index - 1].LblCena.Height;
                }
                stavkeNaRacunu[index].BtnVise.Parent = pnlRacun;
                if (stavkeNaRacunu.Count - 1 == 0)
                {
                    stavkeNaRacunu[index].BtnUkloni.Top = lblRacun.Top + lblRacun.Height;
                }
                else
                {
                    stavkeNaRacunu[index].BtnUkloni.Top = stavkeNaRacunu[index - 1].LblCena.Top +
                                                                         stavkeNaRacunu[index - 1].LblCena.Height;
                }
                stavkeNaRacunu[index].BtnUkloni.Parent = pnlRacun;
                stavkeNaRacunu[index].LblNaziv.Left = lblRacun.Left + 2;
                stavkeNaRacunu[index].LblKolicina.Left = stavkeNaRacunu[index].LblNaziv.Left + stavkeNaRacunu[index].LblNaziv.Width;
                stavkeNaRacunu[index].BtnManje.Left = stavkeNaRacunu[index].LblKolicina.Left + stavkeNaRacunu[index].LblKolicina.Width;
                stavkeNaRacunu[index].BtnVise.Left = stavkeNaRacunu[index].BtnManje.Left + stavkeNaRacunu[index].BtnManje.Width;
                stavkeNaRacunu[index].BtnUkloni.Left = stavkeNaRacunu[index].BtnVise.Left + stavkeNaRacunu[index].BtnVise.Width;
                stavkeNaRacunu[index].LblCena.Left = stavkeNaRacunu[index].BtnUkloni.Left + stavkeNaRacunu[index].BtnUkloni.Width + 5;
                dodajHandlerZaDugmadManjeVise(stavkeNaRacunu[index]);
                dodajHandlerZaDugmeX(stavkeNaRacunu[index]);
            }
        }

        private void dodajHandlerZaDugmadManjeVise(StavkaNaRacunu stavka)
        {
            stavka.BtnVise.Click += (sender2, e2) => btnManjeVise_Click(sender2, e2, stavka);
            stavka.BtnManje.Click += (sender2, e2) => btnManjeVise_Click(sender2, e2, stavka);
        }
        private void dodajHandlerZaDugmeX(StavkaNaRacunu stavka)
        {
            stavka.BtnUkloni.Click += (sender2, e2) => btnUkloni_Click(sender2, e2, stavka);
        }
        private void digitalniSat()
        {
            if (!this.Controls.ContainsKey("panel3"))
            {
                panel3.Top = 12;
                panel3.Left = btnIzdajRacun.Left + btnIzdajRacun.Width + 5;
                this.Controls.Add(panel3);
            }
            osveziDigitalniSat();
        }

        private void osveziDigitalniSat()
        {
            lblVreme.Text = DateTime.Now.ToLongTimeString();
            lblDatum.Text = DateTime.Now.ToShortDateString();
        }

        private void lbxArtikli_SelectedValueChanged(object sender, EventArgs e)
        {
            txtKolicina.Text = "1";
        }

        private void txtKolicina_Click(object sender, EventArgs e)
        {
            txtKolicina.SelectAll();
        }

        private void txtKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void promeniCenuRacuna()
        {
            racun.Cena = 0;
            for (int i = 0; i < stavkeNaRacunu.Count; i++)
            {
                racun.Cena += (stavkeNaRacunu[i].Cena);
            }
            lblCenaRacuna.Text = racun.Cena.ToString("0.00") + " rsd";
        }

        private void btnManjeVise_Click(object sender, EventArgs e, StavkaNaRacunu stavka)
        {
            if (stavka.Kolicina == 0)
            {
                ukloniStavku(stavka);
            }
            else
            {
                promeniCenuRacuna();
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e, StavkaNaRacunu stavka)
        {
            ukloniStavku(stavka);
        }
        private void ukloniStavku(StavkaNaRacunu stavka)
        {
            ukloniStavkuVizuelno(stavka);
            int index = stavkeNaRacunu.IndexOf(stavka);
            urediStavkeVizuelno(index);
            stavkeNaRacunu.Remove(stavka);
            promeniCenuRacuna();
        }

        private void ukloniStavkuVizuelno(StavkaNaRacunu stavka)
        {
            pnlRacun.Controls.Remove(stavka.LblNaziv);
            pnlRacun.Controls.Remove(stavka.LblKolicina);
            pnlRacun.Controls.Remove(stavka.LblCena);
            pnlRacun.Controls.Remove(stavka.BtnManje);
            pnlRacun.Controls.Remove(stavka.BtnVise);
            pnlRacun.Controls.Remove(stavka.BtnUkloni);
        }
        private void urediStavkeVizuelno(int index)
        {
            for (int i = index; i < stavkeNaRacunu.Count; i++)
            {
                stavkeNaRacunu[i].LblNaziv.Top -= stavkeNaRacunu[i].LblNaziv.Height;
                stavkeNaRacunu[i].LblKolicina.Top -= stavkeNaRacunu[i].LblNaziv.Height;
                stavkeNaRacunu[i].LblCena.Top -= stavkeNaRacunu[i].LblNaziv.Height;
                stavkeNaRacunu[i].BtnManje.Top -= stavkeNaRacunu[i].LblNaziv.Height;
                stavkeNaRacunu[i].BtnVise.Top -= stavkeNaRacunu[i].LblNaziv.Height;
                stavkeNaRacunu[i].BtnUkloni.Top -= stavkeNaRacunu[i].LblNaziv.Height;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (char.IsPunctuation(e.KeyChar) && e.KeyChar != '.') || char.IsWhiteSpace(e.KeyChar)
                || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            double uplata;
            if (!(double.TryParse(txtUplata.Text, out uplata)))
            {
                MessageBox.Show("Niste upisali koliko je musterija novca uplatila!");
            }
            else if (racun.Cena == 0)
            {
                MessageBox.Show("Nema artikla na racunu!");
            }
            else
            {
                MessageBox.Show("KUSUR: " + (uplata - racun.Cena).ToString("0.00") + " rsd");
                dodajRacun();
                for (int i = 0; i < stavkeNaRacunu.Count; i++)
                {
                    ukloniStavkuVizuelno(stavkeNaRacunu[i]);
                }
                stavkeNaRacunu.Clear();
                racun = null;
                lblCenaRacuna.Text = "0.00 rsd";
                txtUplata.Text = "";
            }
        }

        private void dodajRacun()
        {
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = @"INSERT INTO 
                Racun(cena, datum, vreme)
                 VALUES (@cena, @datum, @vreme)";
                cmd.Parameters.AddWithValue("cena", racun.Cena);
                cmd.Parameters.AddWithValue("datum", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("vreme", DateTime.Now.TimeOfDay);
                int rezultat = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.ZatvoriKonekciju();
            }
        }

        private void tmrSat_Tick(object sender, EventArgs e)
        {
            if (!crtaj)
            {
                digitalniSat();
            }
            else
            {
                analogniSat();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (crtaj)
            {
                double x;
                double y;
                double z;
                double w;
                poluprecnik = 25;
                centarKruzniceX = btnIzdajRacun.Left + btnIzdajRacun.Width + 45;
                centarKruzniceY = btnIzdajRacun.Top + 25;
                int puta;
                for (int i = -180; i > -540; i -= 6)
                {
                    if (i % 30 == 0)
                    {
                        puta = 20;
                    }
                    else
                    {
                        puta = 23;
                    }
                    x = centarKruzniceX + 25 * (Math.Sin(i * Math.PI / 180));
                    y = centarKruzniceY + 25 * (Math.Cos(i * Math.PI / 180));
                    z = centarKruzniceX + puta * (Math.Sin(i * Math.PI / 180));
                    w = centarKruzniceY + puta * (Math.Cos(i * Math.PI / 180));
                    e.Graphics.DrawLine(Pens.Black, new PointF((float)x, (float)y), new PointF((float)z, (float)w));
                }
                e.Graphics.DrawEllipse(Pens.Black, new Rectangle((int)(centarKruzniceX - 25), (int)(centarKruzniceY - 25), 50, 50));
            }
            double sek1;
            double sek2;
            double sat1;
            double sat2;
            double min1;
            double min2;
            double c = 25;
            double b = 15;
            double a = 20;
            sek1 = centarKruzniceX + c * (Math.Sin(ugaoSekunda * Math.PI / 180));
            sek2 = centarKruzniceY + c * (Math.Cos(ugaoSekunda * Math.PI / 180));
            sat1 = centarKruzniceX + b * (Math.Sin(ugaoSat * Math.PI / 180));
            sat2 = centarKruzniceY + b * (Math.Cos(ugaoSat * Math.PI / 180));
            min1 = centarKruzniceX + a * (Math.Sin(ugaoMinut * Math.PI / 180));
            min2 = centarKruzniceY + a * (Math.Cos(ugaoMinut * Math.PI / 180));
            e.Graphics.DrawLine(Pens.Black, new PointF((float)centarKruzniceX, (float)centarKruzniceY), new PointF((float)sek1, (float)sek2));
            e.Graphics.DrawLine(Pens.Black, new PointF((float)centarKruzniceX, (float)centarKruzniceY), new PointF((float)sat1, (float)sat2));
            e.Graphics.DrawLine(Pens.Black, new PointF((float)centarKruzniceX, (float)centarKruzniceY), new PointF((float)min1, (float)min2));
        }
        
        private void analogniSat()
        {
            osveziAnalogniSat();
        }

        private void osveziAnalogniSat()
        {
            ugaoSekunda = -180 - DateTime.Now.Second * 6;
            ugaoMinut = -180 - DateTime.Now.Minute * 6;
            ugaoSat = -180 - DateTime.Now.Hour * 30 - (30 * DateTime.Now.Minute / 60);
            Invalidate();
        }

        private void rbtnDigitalni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDigitalni.Checked)
            {
                Invalidate();
                crtaj = false;
            }
        }

        private void rbtnAnalogni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAnalogni.Checked)
            {
                this.Controls.Remove(panel3);
                crtaj = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            t = new Thread(bazaProizvoda);
            t.IsBackground = true;
            t.Start();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            iscrtajDugmice();
        }

        private void txtPretraga_Click(object sender, EventArgs e)
        {
            txtPretragaGrupa.SelectAll();
        }

        private void txtPretragaArtikala_TextChanged(object sender, EventArgs e)
        {
            popuniArtikleSelektovaneGrupe();
        }

        private void txtPretragaArtikala_Click(object sender, EventArgs e)
        {
            txtPretragaArtikala.SelectAll();
        }

        private void btnUkloniPretraguGrupa_Click(object sender, EventArgs e)
        {
            txtPretragaGrupa.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPretragaArtikala.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
            f.Show();
        }
    }
}
