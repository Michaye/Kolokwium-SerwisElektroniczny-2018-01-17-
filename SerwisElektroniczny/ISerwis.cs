using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisElektroniczny
{
    interface ISerwis
    {
        void DodajTelewizor(string marka,int nr,string usterka);
        void DodajKomputer(string marka,int nr,string usterka);
        void Polacz();
        void Podziel();
        void Napraw();
        void Napraw(int nr);
    }
}
