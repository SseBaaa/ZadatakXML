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
    public partial class Unos_knjiga : Form
    {
        List<Knjige> knjiga = new List<Knjige>();
        string document = "knjige.xml";
        public Unos_knjiga()
        {
            InitializeComponent();
        }

        private void Unos_knjiga_Load(object sender, EventArgs e)
        {

        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Knjige knjige = new Knjige(textBoxNaziv.Text, textBoxAutor.Text, Convert.ToInt32(textBoxID.Text));
            knjiga.Add(knjige);
            DialogResult upit = MessageBox.Show("Želite li upisati jos knjiga?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (upit == DialogResult.Yes)
            {
                textBoxAutor.Clear();
                textBoxNaziv.Clear();
                textBoxID.Clear();
            }
            else
            {
                if (File.Exists(document))
                {
                    var KnjigeXML = XDocument.Load(document);


                    foreach (Knjige o in knjiga)
                    {
                        var Knjiga = new XElement("Knjiga", new XElement("Naziv", knjige.Naziv), new XElement("Autor", knjige.Autor), new XElement("ID", knjige.ID1));
                        KnjigeXML.Root.Add(Knjiga);
                    }
                    KnjigeXML.Save(document);
                }
                else
                {
                    var KnjigeXML = new XDocument();
                    KnjigeXML.Add(new XElement("Knjige"));
                    foreach (Knjige o in knjiga)
                    {
                        var Knjiga = new XElement("Knjiga", new XElement("Naziv", knjige.Naziv), new XElement("Autor", knjige.Autor), new XElement("ID", knjige.ID1));
                        KnjigeXML.Root.Add(Knjiga);
                    }
                    KnjigeXML.Save(document);
                }
                this.Close();
            }
        }
    }
}
