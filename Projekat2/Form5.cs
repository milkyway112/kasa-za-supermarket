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
    public partial class Form5 : Form
    {
        ProdavnicaDataSet ds;
        ProdavnicaDataSetTableAdapters.RacunTableAdapter daRacun;
        Form6 f;
        public Form5(Form6 f)
        {
            InitializeComponent();
            ds = new ProdavnicaDataSet();
            daRacun = new ProdavnicaDataSetTableAdapters.RacunTableAdapter();
            this.f = f;
        }

        private void DtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDatumOd.Value > dtpDatumDo.Value)
            {
                dtpDatumDo.Value = dtpDatumOd.Value;
            }
        }

        private void DtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDatumDo.Value < dtpDatumOd.Value)
            {
                dtpDatumOd.Value = dtpDatumDo.Value;
            }
        }

        private void BtnIzlistajRacune_Click(object sender, EventArgs e)
        {
            DataTable dt = vratiRacuneUOpsegu();
            if (dt != null)
            {
                dgwRacuni.DataSource = dt;
                dgwRacuni.Columns[1].DefaultCellStyle.Format = "0.00 rsd";
                dgwRacuni.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgwRacuni.Columns[3].DefaultCellStyle.Format = "HH:mm:ss";
            }
            else
            {
                //dgwRacuni.Rows.Clear();
                MessageBox.Show("Nema racuna u opsegu koji ste trazili.");
            }
        }

        private DataTable vratiRacuneUOpsegu()
        {
            daRacun.Fill(ds.Racun);
            DateTime datumOd = dtpDatumOd.Value.Date;
            DateTime datumDo = dtpDatumDo.Value.Date;
            var linq = from x in ds.Racun
                       where x.datum.Date >= datumOd && x.datum.Date <= datumDo
                       select x;
            try
            {
                return linq.CopyToDataTable();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show();
        }
    }
}
