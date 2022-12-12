using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadatakXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Unos_knjiga frmunos = new Unos_knjiga();
            frmunos.Show();
        }

        private void buttonKorisnici_Click(object sender, EventArgs e)
        {
            Unos_Korisnika frmkorsnik = new Unos_Korisnika();
            frmkorsnik.Show();
        }

        private void buttonPosudba_Click(object sender, EventArgs e)
        {
            Posudba frmposudba = new Posudba();
            frmposudba.Show();
        }
    }
}
