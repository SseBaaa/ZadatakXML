using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakXML
{
    class Korisnici
    {
        protected int ID;
        string ime, prezime;

        public Korisnici(int iD, string ime, string prezime)
        {
            ID = iD;
            this.ime = ime;
            this.prezime = prezime;
        }
        public override string ToString()
        {
            return "ID: " + ID + "\r\nIme: " + ime + "\r\nprezime: " + prezime;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
    }
}
