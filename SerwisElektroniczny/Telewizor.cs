using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisElektroniczny
{
    class Telewizor : Elektronika
    {
        public Telewizor(string marka,int nr,string usterka):base(marka,nr,usterka)
        {
            this.marka = marka;
            this.numerSeryjny = nr;
            this.usterka = usterka;
        }
        public override string ToString()
        {
            return "Komputer " +"Marka: "+marka+", numer seryjny: "+numerSeryjny+", usterka: "+usterka;
        }
    }
}
