using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace NiOP_Kolekcije
{
    public partial class Form1 : Form
    {
        List<Brkovi> lista = new List<Brkovi>();
        public Form1()
        {
            InitializeComponent();

        }
        private void Unesi_Click(object sender, EventArgs e)
        {
            try
            {
                Brkovi brk = new Brkovi(Podatak1.Text, Podatak2.Text,
                        Convert.ToInt32(Podatak3.Text),
                        Convert.ToChar(Podatak4.Text));
                lista.Add(brk);
                Podatak1.Clear();
                Podatak2.Clear();
                Podatak3.Clear();
            }
            catch (Exception Greska)
            {
                MessageBox.Show("Greška");
            }
        }

        private void Obradi_Click(object sender, EventArgs e)
        {
            foreach (Brkovi brk in lista)
            {
                if(brk.Podatak4.ToString() == "M")
                {
                    brk.Dodatak = "Ima brkove";
                }
                else
                {
                    brk.Dodatak = "Nema brkove";
                }
            }
        }

        private void Ispisi_Click(object sender, EventArgs e)
        {
            TextKutija.Text = "Podatak1" + "\t" + "Podatak2" + "\t" + "Podatak3" + "\t" + "Podatak4" + "\t" + "Dodatak" + "\r\n";
            foreach (Brkovi brk in lista)
            {
                TextKutija.AppendText(brk.Ispis());
            }

        }
    }
}
