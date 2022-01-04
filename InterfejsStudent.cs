using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    interface IOsoba
    {
        string imie { get; set; }
        string nazwisko { get; set; }

        string ZwrocPelnaNazwe();



    }

    class Osoba : IOsoba
    {
        private string _imie;
        public string imie 
        {
            get => _imie;
            set => _imie = value;
        }
        private string _nazwisko;
        public string nazwisko
        {
            get => _nazwisko;
            set => _nazwisko = value;
        }

        public string ZwrocPelnaNazwe()
        {
            return imie+" "+nazwisko;
        }

    }

    interface IStudent : IOsoba
    {
        string uczelnia { set; get; }
        string kierunek { set; get; }

        int rok { set; get; }
        int semestr { set; get; }

    }

    class Student : IStudent
    {
        public string imie { set; get; }
        public string nazwisko { set; get; }
        public string uczelnia { set; get; }
        public string kierunek { set; get; }
        public int rok { set; get; }
        public int semestr { set; get; }
        public string ZwrocPelnaNazwe()
        {
            return imie + " " + nazwisko;
        }

        public virtual string WypiszWszystko()
        {
            return imie + " " + nazwisko + " " + uczelnia + " " + kierunek + " " + rok + " " + semestr;
        }
    }

    class StudentUR : Student
    {
        public override string WypiszWszystko()
        {
            return base.WypiszWszystko();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba jeden = new Osoba();
            Osoba dwa = new Osoba();
            Osoba trzy = new Osoba();

            List<Osoba> listaosob = new List<Osoba>();
            listaosob.Add(jeden);
            listaosob.Add(dwa);
            listaosob.Add(trzy);

            StudentUR biedaczek = new StudentUR();
            biedaczek.imie = "jakub";
            biedaczek.nazwisko = "lis";
            biedaczek.uczelnia = "geodezyjna";
            biedaczek.kierunek = "szalenstwo";
            biedaczek.rok = 1961;
            biedaczek.semestr = 5;
            Console.WriteLine(biedaczek.WypiszWszystko());
        }
    }
}
