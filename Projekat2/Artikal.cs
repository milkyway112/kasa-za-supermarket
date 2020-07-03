using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    class Artikal
    {
        int id_artikla;
        string naziv;
        double cena;
        double popust;

        public Artikal()
        {
            id_artikla = -1;
            naziv = "";
            cena = 0;
            popust = 0;
        }

        public Artikal(int id_artikla, string naziv, double cena, double popust)
        {
            this.id_artikla = id_artikla;
            this.naziv = naziv;
            this.cena = cena;
            this.popust = popust;
        }

        public override string ToString()
        {
            return id_artikla + ": " + naziv + " " + cena.ToString("0.00") + " rsd, popust: " + popust + "%";
        }
        public int Id_artikla { get { return id_artikla; } set { id_artikla = value; } }
        public string Naziv { get { return naziv; } set { naziv = value; } }
        public double Cena { get { return cena; } set { cena = value; } }
        public double Popust { get { return popust; } set { popust = value; } }
    }
}
