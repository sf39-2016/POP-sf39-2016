using POP_sf39_2016.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_sf39_2016
{
    class Program
    {
        public static List<Namestaj> Namestaj { get; set; } = new List<Namestaj>();
        public static List<TipNamestaja> TipoviN { get; set; } = new List<TipNamestaja>();
        static void Main(string[] args)
        {
            var s1 = new Salon()
            {
                Id = 1,
                Naziv = "Forma FTNale",
                Adresa = "Trg Dositeja Obradovica 6",
                BrRacuna = "81515151-13141",
                Email = "123@ftn.com",
                MaticniBr = 5125151,
                Pib = 15151,
                BrojTelefona = "1235415151",
                EAdresa = "http://TestSite.jeftino.com"

            };
            var tn1 = new TipNamestaja()
            {
                Id = 1,
                Naziv = "Krevet",
                

            };
            TipoviN.Add(tn1);
            var n1 = new Namestaj()
            {
                Id = 1,
                Sifra = "151",
                TipNamestaja = tn1,
                NazivNamestaja = "Ikea Krevet",
                BrKomada =41,
                CenaKomad = 1541.2,
            
            };
            Namestaj.Add(n1);
            Console.WriteLine("Dobrodosli");
            IspisGlavnogMenija();
        }
        private static void IspisGlavnogMenija()
        {
            int izbor = 0;
            do
            {
                Console.WriteLine("GLAVNI MENI");
                Console.WriteLine("1.RAD SA NAMESTAJEM");
                Console.WriteLine("2.RAD SA TIPOM NAMESTAJA");
                izbor = int.Parse(Console.ReadLine());
                // ZAVRSITI MENI
            } while (izbor < 0 || izbor > 2);
            
            switch (izbor)
            {
                case 1:
                    IspisiMeniNamestaja();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        private static void IspisiMeniNamestaja()
        {
            int izbor = 0;
            do
            {
                Console.WriteLine("MENI NAMESTAJA");
                Console.WriteLine("1. Izlistaj");
                Console.WriteLine("2. Dodaj novi namestaj");
                Console.WriteLine("3. Izmeni postojeci namestaj");
                Console.WriteLine("4. Obrisi postojeci");
                Console.WriteLine("0. Povratak na glavni meni");
                izbor = int.Parse(Console.ReadLine());
            } while (izbor < 0 || izbor > 4);
            switch(izbor)
            {
                case 1:
                    IzlistajNamestaj();
                    break;
                case 2:
                    DodajNoviNamestaj();
                    break;
                case 0:
                    IspisGlavnogMenija();
                    break;
                default:
                    break;
            }
        }

        private static void IzlistajNamestaj()
        {
            
            Console.WriteLine("Izlistavanje namestaja");
            for (int i = 0; i < Namestaj.Count; i++)
            {
                if (!Namestaj[i].Obrisan)
                {
                    Console.WriteLine($"{i+1}.{Namestaj[i].NazivNamestaja},cena:{Namestaj[i].CenaKomad}");
                }
            }
            IspisiMeniNamestaja();
        }
        private static void DodajNoviNamestaj()
        {
            TipNamestaja TrazeniTipNamestaja = null;
            Namestaj NoviNamestaj = new Namestaj();
            NoviNamestaj.Id= Namestaj.Count + 1;
            Console.WriteLine("Unesite naziv namestaja");
            NoviNamestaj.NazivNamestaja = Console.ReadLine();
            Console.WriteLine("Unesite sifru namestaja");
            NoviNamestaj.Sifra = Console.ReadLine();
            Console.WriteLine("Unesite cenu");
            NoviNamestaj.CenaKomad = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Unesite tip namestaja");
                string UnetiTip = Console.ReadLine();


                foreach (TipNamestaja Tip in TipoviN)
                {
                    if (UnetiTip.Equals(Tip.Naziv))
                    {
                        TrazeniTipNamestaja = Tip;
                        
                    }
                }
            } while (TrazeniTipNamestaja == null);
            NoviNamestaj.TipNamestaja = TrazeniTipNamestaja;
            Namestaj.Add(NoviNamestaj);
            IspisiMeniNamestaja();
        }
        private static void IzmenaNamestaja()
        {
            Namestaj namestajZaIzmenu = null
            Console.WriteLine("Unesite ime namestaja koji zelite da izmenite");
            string nazivTrazenogNamestaja = Console.ReadLine();
            foreach (Namestaj trenutniNamestaj in Namestaj)
            {
                if (trenutniNamestaj.NazivNamestaja.Equals(nazivTrazenogNamestaja))
                {
                    namestajZaIzmenu = trenutniNamestaj;
                }
            }
            Console.WriteLine("Sta zelite da izmenite?");
        }
    }
    
}
