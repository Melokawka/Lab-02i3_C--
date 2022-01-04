using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private string pesel;
        private int wiek;
        private int plec =0;

        public Osoba(string imie, string nazwisko, string pesel, int wiek, int plec)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            this.wiek = wiek;
            this.plec = plec;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Pesel { set => pesel = value; }
        public int Wiek { get => wiek; }
        public int Plec { get => plec; }

        public virtual string GetEducationInfo()
        {
            return "na razie zadna";
        }
        public virtual string GetFullName()
        {
            return "nieznany!";
        }
        public virtual string CanGoAloneHome()
        {
            return "na razie nie wiadomo";
        }
    }

    class Uczen : Osoba
    {
        private string szkola;
        private bool mozeSamWracacDoDomu;

        public Uczen(string imie, string nazwisko, string pesel, int wiek, int plec, string szkola) : base(imie, nazwisko, pesel, wiek, plec)
        {
            this.szkola = szkola;
        }

        public string Szkola { set => szkola = value; }
        public bool MozeSamWracacDoDomu { get => mozeSamWracacDoDomu; set => mozeSamWracacDoDomu = value; }

        public override string GetEducationInfo()
        {
            return szkola;
        }

        public override string GetFullName()
        {
            return base.Imie+" "+base.Nazwisko;
        }

        public void CzyMozeWrocic()
        {
            if (base.Wiek >= 12) mozeSamWracacDoDomu = true;
            else mozeSamWracacDoDomu = false;
        }

    }

    class Nauczyciel : Uczen
    {
        private String TytulNaukowy;
        System.Collections.Generic.List<Uczen> ListaUczniow = new List<Uczen>();

        public Nauczyciel(string imie, string nazwisko, string pesel, int wiek, int plec, string szkola, string TytulNaukowy) : base(imie, nazwisko, pesel, wiek, plec, szkola)
        {
            this.TytulNaukowy = TytulNaukowy;
        }

        public void DodajUcznia(Uczen nieszczesnik)
        {
            ListaUczniow.Add(nieszczesnik);
        }
        public void CzyMozeSePojsc()
        {
            Console.WriteLine(DateTime.Now); 
            int i = 0;
            for (i = 0; i < ListaUczniow.Count; i++) 
            {
                if(ListaUczniow[i].MozeSamWracacDoDomu) Console.WriteLine(ListaUczniow[i].GetFullName());
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Uczen jeden = new Uczen("jakub","flis","00360206767",1,0,"Geodezyjna");
            Uczen dwa = new Uczen("jakub2", "flis2", "00360206768", 11, 0, "NieGeodezyjna");
            Uczen trzy = new Uczen("jakub3", "flis3", "00360206769", 178, 0, "MozeGeodezyjna");
            Uczen cztery = new Uczen("jakub4", "flis4", "00360206760", 179, 1, "TrocheGeodezyjna");
            Nauczyciel jedynka = new Nauczyciel("jakub", "flis", "00360206767", 176, 0, "Braakkk","Arcymistrz");
            Nauczyciel dwojka = new Nauczyciel("jakub", "flis", "00360206767", 176, 0, "Karczmiana","Geniusz");
            jedynka.DodajUcznia(jeden);
            jedynka.DodajUcznia(dwa);
            dwojka.DodajUcznia(trzy);
            dwojka.DodajUcznia(cztery);

            jeden.CzyMozeWrocic();
            dwa.CzyMozeWrocic();
            trzy.CzyMozeWrocic();
            cztery.CzyMozeWrocic();


            jedynka.CzyMozeSePojsc();
            dwojka.CzyMozeSePojsc();

        }
    }
}
