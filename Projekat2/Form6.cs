using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void BtnKasa_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(this);
            f.Show();
            this.Hide();
        }

        private void BtnGrupe_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(this);
            f.Show();
            this.Hide();
        }

        private void BtnArtikli_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(this);
            f.Show();
            this.Hide();
        }

        private void BtnRacuni_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5(this);
            f.Show();
            this.Hide();
        }
    }
}
