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
    public partial class Form3 : Form
    {
        Baza baza;
        List<Grupa> grupe;
        List<Artikal> artikli;
        Thread t;
        string grupa = "";
        private delegate void delOsveziBazu();
        Form6 f;
        public Form3(Form6 f)
        {
            InitializeComponent();
            baza = new Baza();
            grupe = new List<Grupa>();
            artikli = new List<Artikal>();
            this.f = f;
        }

        private void btnPrikazeGrupe_Click(object sender, EventArgs e)
        {
            iscitajGrupe();
        }

        private void iscitajGrupe()
        {
            lbxGrupe.DataSource = null;
            lbxGrupe.Items.Clear();
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
            lbxGrupe.DataSource = grupe;
        }

        private void btnIzbrisiGrupe_Click(object sender, EventArgs e)
        {
            if (lbxGrupe.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali grupu za brisanje!");
            }
            else
            {
                iscitajArtikle();
                if (artikli.Count > 0)
                {
                    string artikliZaBrisanje = "";
                    for (int i = 0; i < artikli.Count; i++)
                    {
                        artikliZaBrisanje += Environment.NewLine + "-" + artikli[i].Naziv;
                    }
                    if ((MessageBox.Show("Da li zelite da, sa grupom, obrisete i ove artikle?" + artikliZaBrisanje,
                                         "Artikli pripadaju ovoj grupi", MessageBoxButtons.OKCancel)) == DialogResult.OK)
                    {
                        obrisiGrupu((Grupa)lbxGrupe.SelectedItem);
                        for (int i = 0; i < artikli.Count; i++)
                        {
                            obrisiArtikal(artikli[i]);
                        }
                        MessageBox.Show("Artikli i grupa uspesno obrisani.");
                        iscitajGrupe();
                    }
                }
                else
                {
                    obrisiGrupu((Grupa)lbxGrupe.SelectedItem);
                    iscitajGrupe();
                    MessageBox.Show("Grupa uspesno obrisana.");
                }
            }
        }

        private void obrisiGrupu(Grupa grupa)
        {
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "DELETE *" + Environment.NewLine +
                                  "FROM Grupa" + Environment.NewLine +
                                  "WHERE id_grupa = " + grupa.Id_grupa;
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

        private void iscitajArtikle()
        {
            grupa = ((Grupa)lbxGrupe.SelectedItem).Id_grupa.ToString();
            if (grupa.Length > 0)
            {
                try
                {
                    artikli.Clear();
                    baza.OtvoriKonekciju();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "SELECT * FROM Artikal" + Environment.NewLine +
                                      "WHERE id_artikla IN" + Environment.NewLine +
                                      "(SELECT id_artikla FROM Grupa WHERE id_grupa IN (" +  grupa + "))";
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

        private void obrisiArtikal(Artikal artikal)
        {
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "DELETE *" + Environment.NewLine + 
                                  "FROM Artikal" + Environment.NewLine + 
                                  "WHERE naziv = " + '"' + artikal.Naziv + '"';
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lbxGrupe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbxGrupe.SelectedItem != null)
            {
                txtNazivSelektovaneGrupe.Text = ((Grupa)lbxGrupe.SelectedItem).Naziv;
            }
        }

        private void btnPromeniNaziv_Click(object sender, EventArgs e)
        {
            if (txtNazivSelektovaneGrupe.Text.Length > 0 && lbxGrupe.SelectedItem != null)
            {
                promeniNazivSelektovaneGrupe();
                iscitajGrupe();
            }
        }

        private void promeniNazivSelektovaneGrupe()
        {
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "UPDATE Grupa" + Environment.NewLine +
                                  "SET naziv = " + '"' + txtNazivSelektovaneGrupe.Text + Environment.NewLine + '"' +
                                  "WHERE id_grupa = " + ((Grupa)lbxGrupe.SelectedItem).Id_grupa;
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

        private void btnDodajGrupu_Click(object sender, EventArgs e)
        {
            bool grupaVecPostoji = false;
            if (txtNazivNoveGrupe.Text.Length > 0)
            {
                for (int i = 0; i < grupe.Count; i++)
                {
                    if (grupe[i].Naziv == txtNazivNoveGrupe.Text)
                    {
                        MessageBox.Show("Vec postoji grupa sa ovim nazivom!");
                        grupaVecPostoji = true;
                        break;
                    }
                }
                if (!grupaVecPostoji)
                {
                    dodajGrupu();
                    iscitajGrupe();
                }
            }
        }

        private void dodajGrupu()
        {
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "INSERT INTO Grupa (id_grupa, id_artikla, naziv)" + Environment.NewLine +
                                    "VALUES (@id_grupa, @id_artikla, @naziv)";
                cmd.Parameters.AddWithValue("id_grupa", grupe[grupe.Count - 1].Id_grupa + 1);
                cmd.Parameters.AddWithValue("id_artikla", -1);
                cmd.Parameters.AddWithValue("naziv", txtNazivNoveGrupe.Text);
                int rezultat = cmd.ExecuteNonQuery();
                if (rezultat > 0)
                    MessageBox.Show("Uspesno dodata grupa u bazu!");
                else
                    MessageBox.Show("Dodavanje grupe nije uspelo");
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

        private void txtNazivSelektovaneGrupe_Click(object sender, EventArgs e)
        {
            txtNazivSelektovaneGrupe.SelectAll();
        }

        private void txtNazivNoveGrupe_Click(object sender, EventArgs e)
        {
            txtNazivNoveGrupe.SelectAll();
        }

        private void Form3_Shown(object sender, EventArgs e)
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

        private void BtnDodajGrupu_Click_1(object sender, EventArgs e)
        {
            bool grupaVecPostoji = false;
            if (txtNazivNoveGrupe.Text.Length > 0)
            {
                for (int i = 0; i < grupe.Count; i++)
                {
                    if (grupe[i].Naziv == txtNazivNoveGrupe.Text)
                    {
                        MessageBox.Show("Vec postoji grupa sa ovim nazivom!");
                        grupaVecPostoji = true;
                        break;
                    }
                }
                if (!grupaVecPostoji)
                {
                    dodajGrupu();
                    iscitajGrupe();
                }
            }
        }

        private void BtnPromeniNaziv_Click_1(object sender, EventArgs e)
        {
            if (txtNazivSelektovaneGrupe.Text.Length > 0 && lbxGrupe.SelectedItem != null)
            {
                promeniNazivSelektovaneGrupe();
                iscitajGrupe();
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
            f.Show();
        }
    }
}
