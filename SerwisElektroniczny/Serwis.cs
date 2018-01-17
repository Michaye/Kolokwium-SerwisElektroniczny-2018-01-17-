using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisElektroniczny
{
    class Serwis:ISerwis
    {
        private List<Elektronika> doNaprawy=new List<Elektronika>();
        private HashSet<Komputer> komputery=new HashSet<Komputer>();

        public Serwis() { }
        public void DodajTelewizor(string marka,int nr,string usterka)
        {
            doNaprawy.Add(new Telewizor(marka,nr,usterka));
        }
        public void DodajKomputer(string marka, int nr, string usterka)
        {
            komputery.Add(new Komputer(marka,nr,usterka));
        }
        public override string ToString()
        {
            string tekst = "";
            List<Elektronika> ttt = new List<Elektronika>(); 
            ttt = doNaprawy.ToList();
            
            foreach(var t in ttt)
            {
                tekst += t.ToString()+"\n";
            }
                return "Zawartość zbioru: \n"+tekst;
        }
        public void Polacz()
        {
            foreach(Komputer t in komputery)
            {
                doNaprawy.Add(t);
            }
        }
        public void Podziel()
        {
                foreach(Komputer d in komputery)
                {
                    if (doNaprawy.Contains(d) == true)
                    {
                        doNaprawy.Remove(d);            
                    }
                }
        }
        public void Napraw()
        {
            if (doNaprawy.Count < 1)
                Console.WriteLine("Masz pustą liste!");
            else
                doNaprawy.RemoveAt(0);
        }
        public void Napraw(int nr)
        {

        }
    }
}
