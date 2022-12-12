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
    public partial class Unos_Korisnika : Form
    {
        List<Korisnici> korisnik = new List<Korisnici>();
        string document = "Korisnici.xml";
        public Unos_Korisnika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korisnici korisnici = new Korisnici(Convert.ToInt32(textBoxID.Text), textBoxIme.Text, textBoxPrezime.Text);
            korisnik.Add(korisnici);
            DialogResult upit = MessageBox.Show("Želite li upisati jos osoba?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (upit == DialogResult.Yes)
            {
                textBoxID.Clear();
                textBoxIme.Clear();
                textBoxPrezime.Clear();
            }
            else
            {
                if (File.Exists(document))
                {
                    var OsobeXML = XDocument.Load(document);


                    foreach (Korisnici o in korisnik)
                    {
                        var Osoba = new XElement("Osoba", new XElement("ID", korisnici.ID1), new XElement("Ime", korisnici.Ime), new XElement("Prezime", korisnici.Prezime));
                        OsobeXML.Root.Add(Osoba);
                    }
                    OsobeXML.Save(document);
                }
                else
                {
                    var OsobeXML = new XDocument();
                    OsobeXML.Add(new XElement("Knjige"));
                    foreach (Korisnici o in korisnik)
                    {
                        var Osoba = new XElement("Osoba", new XElement("ID", korisnici.ID1), new XElement("Ime", korisnici.Ime), new XElement("Prezime", korisnici.Prezime));
                        OsobeXML.Root.Add(Osoba);
                    }
                    OsobeXML.Save(document);
                }
                this.Close();
            }
        }
    }
}
