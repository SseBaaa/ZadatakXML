using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakXML
{
    class Knjige
    {
        string naziv, autor;
        int ID;

        public Knjige(string naziv, string autor, int ID)
        {
            this.Naziv = naziv;
            this.Autor = autor;
            this.ID1 = ID;
        }
        public override string ToString()
        {
            return "Ime: " + naziv + "\r\nAutor: " + autor + "\r\nID: " + ID1;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Autor { get => autor; set => autor = value; }
        public int ID1 { get => ID; set => ID = value; }
    }
}
