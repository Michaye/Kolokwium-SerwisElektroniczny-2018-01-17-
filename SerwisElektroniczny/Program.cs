using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisElektroniczny
{ 
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Elektronika> doNaprawy = new HashSet<Elektronika>();
            Serwis one = new Serwis();

            while(true)
            {
                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine("A-dodaj tv");
                Console.WriteLine("B-dodaj komputer");
                Console.WriteLine("C1-polacz");
                Console.WriteLine("C2-podziel");
                Console.WriteLine("D-napraw");
                Console.WriteLine("E-napraw po numerze seryjnym");
                Console.WriteLine("F-Pokaz liste(aby zobaczyć liste z komputerami skorzystaj z opcji połącz-C1)");
                Console.WriteLine("X-wyjdź");
                string klawisz = Console.ReadLine();
                switch(klawisz)
                {
                    case "A":

                        Console.WriteLine("Podaj marke: ");
                markaLabel:
                        string marka = Console.ReadLine();
                        if (string.IsNullOrEmpty(marka) == true)
                        {
                            Console.WriteLine("Nie podales marki! Wprowadź ponownie: ");
                            goto markaLabel;
                        }
                        Console.WriteLine("Podaj numer seryjny: ");
                nrseryjnyLabel:
                        int nrSeryjny;
                        try
                        {
                            nrSeryjny = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Podaj poprawny numer seryjny: ");
                            goto nrseryjnyLabel;
                        }
                        Console.WriteLine("Podaj usterke: ");
                usterkaLabel:
                        string usterka = Console.ReadLine();
                        if (string.IsNullOrEmpty(usterka) == true)
                        {
                            Console.WriteLine("Nie podales usterki! Wprowadź ponownie: ");
                            goto usterkaLabel;
                        }

                        one.DodajTelewizor(marka,nrSeryjny,usterka);
                        break;
                    case "B":

                        Console.WriteLine("Podaj marke: ");
                markaLabel2:
                        marka = Console.ReadLine();
                        if (string.IsNullOrEmpty(marka) == true)
                        {
                            Console.WriteLine("Nie podales marki! Wprowadź ponownie: ");
                            goto markaLabel2;
                        }
                        Console.WriteLine("Podaj numer seryjny: ");
                nrseryjnyLabel2:
                        try
                        {
                            nrSeryjny = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Podaj poprawny numer seryjny: ");
                            goto nrseryjnyLabel2;
                        }
                        Console.WriteLine("Podaj usterke: ");
                usterkaLabel2:
                        usterka = Console.ReadLine();
                        if (string.IsNullOrEmpty(usterka) == true)
                        {
                            Console.WriteLine("Nie podales usterki! Wprowadź ponownie: ");
                            goto usterkaLabel2;
                        }

                        one.DodajKomputer(marka,nrSeryjny,usterka);
                        break;
                    case "C1":
                        one.Polacz();
                        break;
                    case "C2":
                        one.Podziel();
                        break;
                    case "D":
                        one.Napraw();
                        break;
                    case "E":  
                                                Console.WriteLine("Podaj nr do usuniecia");
                        int nrdousuniecia = 0;
                        try
                        {
                            nrdousuniecia = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Podaj poprawny numer seryjny: ");
                            goto case "E";
                        }
                        one.Napraw(nrdousuniecia);
                        break;
                    case "F":
                        Console.WriteLine(one.ToString());
                        break;
                    case "X":
                        Environment.Exit(1);
                        break;
                    default :
                        Console.WriteLine("Wybierz poprawną operacje!");
                        break;
                }
            }
                
        }
    }
}
