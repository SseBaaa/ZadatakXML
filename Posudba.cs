using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace ZadatakXML
{
    public partial class Posudba : Form
    {
        List<Korisnici> korisnik = new List<Korisnici>();
        List<Knjige> knjiga = new List<Knjige>();
        public Posudba()
        {
            InitializeComponent();
        }

        private void buttonPosudi_Click(object sender, EventArgs e)
        {
            var OsobeXML = XDocument.Load("Korisnici.xml");
            var names = from s in korisnik
            where s.ID1 == Convert.ToInt32(textBoxKorisnik.Text)
            select new { ID = s.ID1 };

            if(s.ID == "")
            {
                MessageBox.Show("Ne postoji taj korisnik", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            var KnjigeXML = XDocument.Load("knjige.xml");
            var knjige = from n in knjiga
                         where n.ID1 == Convert.ToInt32(textBoxKnjiga.Text)
                         select new { ID1 = n.ID1 };
            if(n.ID1 == "")
            {
                MessageBox.Show("Ne postoji ta knjiga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }
    }
}
