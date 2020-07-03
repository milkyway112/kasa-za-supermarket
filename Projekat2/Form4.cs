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
    public partial class Form4 : Form
    {
        Baza baza;
        Thread t;
        List<Grupa> grupe;
        List<Artikal> artikli;
        private delegate void delOsveziBazu();
        bool menjanje = true;
        bool dodavanje = false;
        Grupa selektovanaGrupaZaIzmenu;
        Form6 f;
        
        public Form4(Form6 f)
        {
            InitializeComponent();
            grupe = new List<Grupa>();
            artikli = new List<Artikal>();
            baza = new Baza();
            rbtnMenjanje.Checked = true;
            this.f = f;
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            t = new Thread(osveziBazu);
            t.IsBackground = true;
            t.Start();
        }

        private void osveziBazu()
        {
            while (true)
            {
                this.Invoke(new delOsveziBazu(iscitajGrupe));
                Thread.Sleep(30000);
            }
            
        }

        private void iscitajGrupe()
        {
            cbxGrupe.DataSource = null;
            cbxGrupe.Items.Clear();
            cbxGrupeIzmena.DataSource = null;
            cbxGrupeIzmena.Items.Clear();
            if (grupe.Count > 0)
            {
                grupe.Clear();
            }
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
            cbxGrupe.DataSource = grupe;
            cbxGrupeIzmena.BindingContext = new BindingContext();
            cbxGrupeIzmena.DataSource = grupe;
            if (selektovanaGrupaZaIzmenu != null)
            {
                selektujGrupuZaIzmenu();
            }
        }

        private void selektujGrupuZaIzmenu()
        {
            for (int i = 0; i < cbxGrupeIzmena.Items.Count; i++)
            {
                if (((Grupa)cbxGrupeIzmena.Items[i]).Id_grupa == selektovanaGrupaZaIzmenu.Id_grupa)
                {
                    cbxGrupeIzmena.SelectedItem = cbxGrupeIzmena.Items[i];
                    break;
                }
            }
        }

        private void cbxGrupe_SelectedValueChanged(object sender, EventArgs e)
        {
            iscitajArtikleSelektovaneGrupe();
            if (dodavanje)
            {
                lbxArtikli.SelectedItem = null;
            }
            //cbxGrupeIzmena.SelectedItem = cbxGrupe.SelectedItem;
        }

        private void iscitajArtikleSelektovaneGrupe()
        {
            lbxArtikli.DataSource = null;
            lbxArtikli.Items.Clear();
            if (cbxGrupe.SelectedItem != null)
            {
                try
                {
                    artikli.Clear();
                    baza.OtvoriKonekciju();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "SELECT * FROM Artikal" + Environment.NewLine +
                                      "WHERE id_artikla IN" + Environment.NewLine +
                                      "(SELECT id_artikla FROM Grupa WHERE id_grupa = " + 
                                      ((Grupa)cbxGrupe.SelectedItem).Id_grupa + ")";
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
                    lbxArtikli.DataSource = artikli;
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

        private void lbxArtikli_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbxArtikli.SelectedItem != null)
            {
                popuniAtributeSelektovanogArtikla();
            }
            else
            {
                txtIdArtikla.Text = "";
                txtNazivArtikla.Text = "";
                txtCenaArtikla.Text = "";
                txtPopustArtikla.Text = "";
            }
        }

        private void popuniAtributeSelektovanogArtikla()
        {
            txtIdArtikla.Text = ((Artikal)lbxArtikli.SelectedItem).Id_artikla.ToString();
            txtNazivArtikla.Text = ((Artikal)lbxArtikli.SelectedItem).Naziv;
            txtCenaArtikla.Text = ((Artikal)lbxArtikli.SelectedItem).Cena.ToString("0.00");
            txtPopustArtikla.Text = ((Artikal)lbxArtikli.SelectedItem).Popust.ToString();
        }

        private void txtIdArtikla_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnIzmeniArtikal_Click(object sender, EventArgs e)
        {
            bool popunjeno = true;
            if (menjanje)
            {
                if (txtNazivArtikla.Text.Length == 0)
                {
                    popunjeno = false;
                    lblNaziv.ForeColor = Color.Red;
                }
                else
                {
                    lblNaziv.ForeColor = Color.Black;
                }
                if (txtCenaArtikla.Text.Length == 0)
                {
                    popunjeno = false;
                    lblCena.ForeColor = Color.Red;
                }
                else
                {
                    lblCena.ForeColor = Color.Black;
                }
                if (lbxArtikli.SelectedItem != null && popunjeno && !proveriDaLiJeNazivJedinstven(txtNazivArtikla.Text, int.Parse(txtIdArtikla.Text)))
                {
                    izmeniArtikal();
                    iscitajArtikleSelektovaneGrupe();
                }
            }
            else
            {
                if (txtNazivArtikla.Text.Length == 0)
                {
                    popunjeno = false;
                    lblNaziv.ForeColor = Color.Red;
                }
                else
                {
                    lblNaziv.ForeColor = Color.Black;
                }
                if (txtCenaArtikla.Text.Length == 0)
                {
                    popunjeno = false;
                    lblCena.ForeColor = Color.Red;
                }
                else
                {
                    lblCena.ForeColor = Color.Black;
                }
                if (cbxGrupeIzmena.SelectedItem == null)
                {
                    popunjeno = false;
                    cbxGrupeIzmena.BackColor = Color.Red;
                }
                else
                {
                    cbxGrupeIzmena.BackColor = Color.White;
                }
                if (!proveriDaLiJeNazivJedinstven(txtNazivArtikla.Text, -1) && popunjeno)
                {
                    List<Grupa> celeGrupeU = ucitajCeleGrupe(((Grupa)cbxGrupeIzmena.SelectedItem).Id_grupa);
                    dodajArtikal();
                    int id_artikla = nadjiZadnjiId() + 1;
                    if (celeGrupeU.Count == 1 && celeGrupeU[0].Id_artikla == -1)
                    {
                        staviUGrupuBezArtikala(((Grupa)cbxGrupeIzmena.SelectedItem).Id_grupa, id_artikla);
                    }
                    else
                    {
                        staviUGrupuSaArtiklima(((Grupa)cbxGrupeIzmena.SelectedItem).Id_grupa, id_artikla);
                    }
                    iscitajArtikleSelektovaneGrupe();
                    MessageBox.Show("Artikal uspesno dodat.");
                }
            }
        }

        private bool proveriDaLiJeNazivJedinstven(string naziv, int id)
        {
            List<Artikal> sviArtikli = iscitajSveArtikle();
            for (int i = 0; i < sviArtikli.Count; i++)
            {
                if (sviArtikli[i].Id_artikla == id)
                {
                    continue;
                }
                else
                {
                    if (sviArtikli[i].Naziv == naziv)
                    {
                        MessageBox.Show("Ovaj naziv je vec zauzet od strane drugog artikla!");
                        sviArtikli.Clear();
                        return true;
                    }
                }
            }
            sviArtikli.Clear();
            return false;
        }

        private List<Artikal> iscitajSveArtikle()
        {
            List<Artikal> sviArtikli = new List<Artikal>();
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Artikal";
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
                    sviArtikli.Add(a);
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
            return sviArtikli;
        }

        private int nadjiZadnjiId()
        {
            int id = -1; 
            List<Artikal> sviArtikli = new List<Artikal>();
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT MAX(id_artikla) FROM Artikal";
                /*IN" + Environment.NewLine +
                "(SELECT id_grupa FROM Grupa WHERE naziv IN (" + '"' + grupa + '"' + ")))";*/
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader["Expr1000"].ToString());
                    /*Artikal a = new Artikal();
                    a.Id_artikla = int.Parse(reader["id_artikla"].ToString());
                    a.Naziv = reader["naziv"].ToString();
                    a.Cena = double.Parse(reader["cena"].ToString());
                    a.Popust = double.Parse(reader["popust"].ToString());
                    sviArtikliIdjevi += Environment.NewLine + a.Id_artikla + ": " + a.Naziv;
                    sviArtikli.Add(a);*/
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
            return id;
        }
        private void izmeniArtikal()
        {
            try
            {
                int index = artikli.IndexOf((Artikal)lbxArtikli.SelectedItem);

                artikli[index].Naziv = txtNazivArtikla.Text;
                artikli[index].Cena = double.Parse(txtCenaArtikla.Text);
                if (txtPopustArtikla.Text.Length == 0)
                {
                    artikli[index].Popust = 0;
                }
                else
                {
                    artikli[index].Popust = double.Parse(txtPopustArtikla.Text);
                }
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "UPDATE Artikal" + Environment.NewLine +
                                    "SET naziv = " + '"' + artikli[index].Naziv + '"' + ", cena = " + artikli[index].Cena +
                                    ", popust = " + artikli[index].Popust + Environment.NewLine +
                                    "WHERE id_artikla = " + artikli[index].Id_artikla;
                OleDbDataReader reader = cmd.ExecuteReader();
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

        private void txtCenaArtikla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPopustArtikla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIzmeniGrupu_Click(object sender, EventArgs e)
        {
            if (lbxArtikli.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali artikal kome menjate grupu!");
            }
            else
            {
                promeniGrupuArtiklu((Artikal)lbxArtikli.SelectedItem);
            }
        }
        
        private void dodajArtikal()
        {
            //int id_artikla = nadjiZadnjiId() + 1;
            //MessageBox.Show(id_artikla.ToString());
            double popust;
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = @"INSERT INTO Artikal (cena, popust, naziv)" + Environment.NewLine +
                                  "VALUES (@cena, @popust, @naziv)";
                //cmd.Parameters.AddWithValue("id_artikla", id_artikla);
                cmd.Parameters.AddWithValue("cena", double.Parse(txtCenaArtikla.Text));
                if (txtPopustArtikla.Text.Length == 0)
                {
                    popust = 0;
                }
                else
                {
                    popust = double.Parse(txtPopustArtikla.Text);
                }
                cmd.Parameters.AddWithValue("popust", popust);
                cmd.Parameters.AddWithValue("naziv", txtNazivArtikla.Text);
                int rezultat = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("dodajArtikal() " + ex.Message);
            }
            finally
            {
                baza.ZatvoriKonekciju();
            }
            //return id_artikla;
        }

        private void promeniGrupuArtiklu(Artikal artikal)
        {
            bool imaPraznoMesto = false;
            bool vecUGrupi = false;
            List<Grupa> celeGrupeIz = ucitajCeleGrupe(((Grupa)cbxGrupe.SelectedItem).Id_grupa);
            List<Grupa> celeGrupeU = ucitajCeleGrupe(((Grupa)cbxGrupeIzmena.SelectedItem).Id_grupa);
            for (int i = 0; i < celeGrupeU.Count; i++)
            {
                if (celeGrupeU[i].Id_artikla == artikal.Id_artikla)
                {
                    vecUGrupi = true;
                    MessageBox.Show("Ovaj artikal je vec u izabranoj grupi.");
                    break;
                }
            }
            if (!vecUGrupi)
            {
                if (celeGrupeIz.Count == 1)
                {
                    napraviPraznuGrupu(((Grupa)cbxGrupe.SelectedItem).Id_grupa, artikal.Id_artikla);
                }
                else
                {
                    ukloniIzGrupe(((Grupa)cbxGrupe.SelectedItem).Id_grupa, artikal.Id_artikla);
                }
                if (celeGrupeU.Count == 1 && celeGrupeU[0].Id_artikla == -1)
                {
                    staviUGrupuBezArtikala(((Grupa)cbxGrupeIzmena.SelectedItem).Id_grupa, artikal.Id_artikla);
                }
                else
                {
                    staviUGrupuSaArtiklima(((Grupa)cbxGrupeIzmena.SelectedItem).Id_grupa, artikal.Id_artikla);
                }
                iscitajArtikleSelektovaneGrupe();
                MessageBox.Show("Grupa artikla uspesno promenjena.");
            }
        }

        private void ukloniIzGrupe(int id_grupa, int id_artikla)
        {
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "DELETE * FROM Grupa" + Environment.NewLine +
                                  "WHERE id_grupa = " + id_grupa + " AND id_artikla = " + id_artikla;
                OleDbDataReader reader = cmd.ExecuteReader();
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
        private void staviUGrupuSaArtiklima(int id_grupa, int id_artikla)
        {
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "INSERT INTO Grupa (id_grupa, id_artikla, naziv)" + Environment.NewLine +
                                  "VALUES (@id_grupa, @id_artikla, @naziv)";
                cmd.Parameters.AddWithValue("id_grupa", id_grupa);
                cmd.Parameters.AddWithValue("id_artikla", id_artikla);
                cmd.Parameters.AddWithValue("naziv", ((Grupa)cbxGrupeIzmena.SelectedItem).Naziv);
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

        private void staviUGrupuBezArtikala(int id_grupa, int id_artikla)
        {
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "UPDATE Grupa" + Environment.NewLine + 
                                  "SET id_artikla = " + id_artikla + Environment.NewLine + 
                                  "WHERE id_grupa = " + id_grupa + "AND id_artikla = -1";
                OleDbDataReader reader = cmd.ExecuteReader();
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

        public void napraviPraznuGrupu(int id_grupa, int id_artikla)
        {
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "UPDATE GRUPA" + Environment.NewLine +
                                  "SET id_artikla = -1" + Environment.NewLine + 
                                  "WHERE id_grupa = " + id_grupa + "AND id_artikla = " + id_artikla;
                OleDbDataReader reader = cmd.ExecuteReader();
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
        private List<Grupa> ucitajCeleGrupe(int id_grupa)
        {
            List<Grupa> celeGrupe = new List<Grupa>();
            try
            {
                celeGrupe.Clear();
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Grupa WHERE id_grupa = " + id_grupa;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Grupa g = new Grupa();
                    g.Id_grupa = int.Parse(reader["id_grupa"].ToString());
                    g.Naziv = reader["naziv"].ToString();
                    g.Id_artikla = int.Parse(reader["id_artikla"].ToString());
                    celeGrupe.Add(g);
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
            return celeGrupe;
        }

        private void rbtnMenjanje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMenjanje.Checked == true)
            {
                menjanje = true;
                dodavanje = false;
                btnIzmeniArtikal.Text = "Izmeni";
                btnIzmeniGrupu.Text = "Izmeni grupu";
                //cbxGrupe.DataSource = grupe;
                lbxArtikli.Enabled = true;
            }
        }

        private void rbtnDodavanje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDodavanje.Checked == true)
            {
                menjanje = false;
                dodavanje = true;
                btnIzmeniArtikal.Text = "Dodaj";
                btnIzmeniGrupu.Text = "Uzmi grupu";
                /*cbxGrupe.DataSource = null;
                cbxGrupe.Items.Clear();*/
                lbxArtikli.Enabled = false;
                txtIdArtikla.Text = "";
                txtNazivArtikla.Text = "";
                txtCenaArtikla.Text = "";
                txtPopustArtikla.Text = "";
            }
        }

        private void cbxGrupeIzmena_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxGrupeIzmena.SelectedIndex != 0 && cbxGrupeIzmena.SelectedItem != null)
            {
                selektovanaGrupaZaIzmenu = (Grupa)cbxGrupeIzmena.SelectedItem;
            }
            
        }

        private void BtnPrikazeGrupe_Click(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
            f.Show();
        }
    }
}
