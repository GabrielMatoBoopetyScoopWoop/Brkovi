using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiOP_Kolekcije
{
    class Brkovi
    {
        string podatak1, podatak2, dodatak;
        int podatak3;
        char podatak4;

        public string Podatak1 { get => podatak1; set => podatak1 = value; }
        public string Podatak2 { get => podatak2; set => podatak2 = value; }
        public string Dodatak { get => dodatak; set => dodatak = value; }
        public int Podatak3 { get => podatak3; set => podatak3 = value; }
        public char Podatak4 { get => podatak4; set => podatak4 = value; }

        public Brkovi()
        {
        }

        public Brkovi(string podatak1, string podatak2, int podatak3, char podatak4)
        {
            this.podatak1 = podatak1;
            this.podatak2 = podatak2;
            this.podatak3 = podatak3;
            this.podatak4 = podatak4;
        }

        public string Ispis()
        {
            string ispis = Podatak1 + "\t" + Podatak2 + "\t" + Convert.ToString(Podatak3) + "\t" + Convert.ToString(Podatak4)+ "\t" + Dodatak + "\r\n";
            return ispis;
        }
    }
}
