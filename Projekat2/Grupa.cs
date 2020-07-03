using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat2
{
    class Grupa
    {
        int id_grupa;
        int id_artikla;
        string naziv;

        public Grupa()
        {
            id_grupa = -1;
            id_artikla = -1;
            naziv = "";
        }

        public Grupa(int id_grupa, int id_artikla, string naziv)
        {
            this.id_grupa = id_grupa;
            this.id_artikla = id_artikla;
            this.naziv = naziv;
        }

        public override string ToString()
        {
            return id_grupa + ": " + naziv;
        }

        public int Id_grupa { get { return id_grupa; } set { id_grupa = value; } }
        public int Id_artikla { get { return id_artikla; } set { id_artikla = value; } }
        public string Naziv { get { return naziv; } set { naziv = value; } }
    }
}
