using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisElektroniczny
{
    abstract class Elektronika
    {
        protected string marka;
        protected int numerSeryjny;
        protected string usterka;

        public Elektronika(string marka,int nr,string usterka)
        {
            this.marka = marka;
            this.numerSeryjny = nr;
            this.usterka = usterka;
        }
        public override string ToString()
        {
            return "Marka: "+marka+", numer seryjny: "+numerSeryjny+", usterka: "+usterka;
        }
    }
}
