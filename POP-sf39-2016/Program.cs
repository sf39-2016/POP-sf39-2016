using POP_sf39_2016.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POP_sf39_2016.util;

namespace POP_sf39_2016
{
    class Program
    {
        public static List<Namestaj> ListaNamestaja { get; set; } 
        public static List<TipNamestaja> ListaTipoviNamestaja { get; set; } = new List<TipNamestaja>();
        public static List<Korisnik> ListaKorisnika { get; set; } = new List<Korisnik>();
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
            ListaTipoviNamestaja.Add(tn1);
            var tn2 = new TipNamestaja()
            {
                Id = 2,
                Naziv = "Stolica",
            };
            ListaTipoviNamestaja.Add(tn2);


            var k1 = new Korisnik()
            {
                Id = 1,
                Obrisan = false,
                Ime = "Milos",
                Prezime = "Pavicic",
                KorisnickoIme = "milosp",
                Lozinka = "1234",
                TipKorisnika = TipKorisnika.Prodavac,
            };

            ListaKorisnika.Add(k1);
            //GenericSerializer.Serialize<Namestaj>("namestaj.xml", ListaNamestaja);
            GenericSerializer.Serialize<TipNamestaja>("tipnamestaja.xml", ListaTipoviNamestaja);



            ListaNamestaja = Projekat.Instance.Namestaj;
            ListaNamestaja.Add(new Namestaj(){ Id=1,NazivNamestaja="Proba123"});
            //ListaNamestaja.RemoveAt(ListaNamestaja.Count - 1);
            Projekat.Instance.Namestaj = ListaNamestaja;
            foreach(var item in ListaNamestaja)
            {
                Console.WriteLine(item.NazivNamestaja);
            }



            
            var listaa = Projekat.Instance.TipNamestaja;
            Projekat.Instance.TipNamestaja = listaa;
            foreach (var item in listaa)
            {
                Console.WriteLine(item.Naziv);
            }



            Console.WriteLine("Serialization..");
           
            //GenericSerializer.Serialize<TipNamestaja>("tipnamestaja.xml", ListaTipoviNamestaja);
            //List<Namestaj> procitanaLista = GenericSerializer.Deserialize<Namestaj>("namestaj.xml");
            //Console.WriteLine("Finished serialization..");

            //for (int i = 0; i < procitanaLista.Count(); i++)
            //{
            //    Console.WriteLine(procitanaLista[i].NazivNamestaja);
            //}


            
            Console.WriteLine("Dobrodosli");
            Login();
            IspisGlavnogMenija();
        }
        private static void IspisGlavnogMenija()
        {
            int izbor = 0;
            do
            {
                Console.WriteLine("GLAVNI MENI");
                Console.WriteLine("1.Rad sa namestajem");
                Console.WriteLine("2.Rad sa tipom namestaja");
                Console.WriteLine("3.Rad sa korisnicima");
                Console.WriteLine("0.Izlaz");
                izbor = int.Parse(Console.ReadLine());
                // ZAVRSITI MENI
            } while (izbor < 0 || izbor > 3);

            switch (izbor)
            {
                case 1:
                    IspisiMeniNamestaja();
                    break;
                case 2:
                    IspisMeniTipNamestaja();
                    break;
                case 3:
                    IspisMeniKorisnici();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
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
            switch (izbor)
            {
                case 1:
                    IzlistajNamestaj();
                    break;
                case 2:
                    DodajNoviNamestaj();
                    break;
                case 3:
                    IzmeniPostojeciNamestaj();
                    break;
                case 4:
                    ObrisiPostojeciNamestaj();
                    break;
                case 0:
                    IspisGlavnogMenija();
                    break;
                default:
                    break;
            }
        }
        private static void IspisMeniTipNamestaja()
        {
            int izbor = 0;
            do
            {
                Console.WriteLine("MENI TIP NAMESTAJA");
                Console.WriteLine("1. Izlistaj");
                Console.WriteLine("2. Dodaj novi tip namestaja");
                Console.WriteLine("3. Izmeni postojeci tip namestaja");
                Console.WriteLine("4. Obrisi postojeci tip namestaja");
                Console.WriteLine("0. Povratak na glavni meni");
                izbor = int.Parse(Console.ReadLine());
            } while (izbor < 0 || izbor > 4);
            switch (izbor)
            {
                case 1:
                    IzlistajTipoveNamestaja();
                    break;
                case 2:
                    DodajNoviTipNamestaja();
                    break;
                case 3:
                    IzmeniPostojeciTipNamestaja();
                    break;
                case 4:
                    ObrisiPostojeciTipNamestaja();
                    break;
                case 0:
                    IspisGlavnogMenija();
                    break;
                default:
                    break;
            }
        }
        private static void IspisMeniKorisnici()
        {
            int izbor = 0;
            do
            {
                Console.WriteLine("MENI KORISNICI");
                Console.WriteLine("1. Izlistaj");
                Console.WriteLine("2. Dodaj novog korisnika");
                Console.WriteLine("3. Izmeni postojeceg korisnika");
                Console.WriteLine("4. Obrisi postojeceg korisnika");
                Console.WriteLine("0. Povratak na glavni meni");
                izbor = int.Parse(Console.ReadLine());
            } while (izbor < 0 || izbor > 4);
            switch (izbor)
            {
                case 1:
                    IzlistajKorisnike();
                    break;
                case 2:
                    DodajNovogKorisnika();
                    break;
                case 3:
                    IzmeniPostojecegKorisnika();
                    break;
                case 4:
                    ObrisiPostojecegKorisnika();
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
            for (int i = 0; i < ListaNamestaja.Count; i++)
            {
                if (!ListaNamestaja[i].Obrisan)
                {
                    Console.WriteLine($"{i + 1}.{ListaNamestaja[i].NazivNamestaja},cena:{ListaNamestaja[i].CenaKomad},tip namestaja:{ListaNamestaja[i].TipNamestaja.Naziv}");
                }
            }
            Console.WriteLine("Gotovo izlistavanje \n");

            IspisiMeniNamestaja();
        }
        private static void DodajNoviNamestaj()
        {
            TipNamestaja TrazeniTipNamestaja = null;
            Namestaj NoviNamestaj = new Namestaj();
            NoviNamestaj.Id = ListaNamestaja.Count + 1;
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

                foreach (TipNamestaja Tip in ListaTipoviNamestaja)
                {
                    if (UnetiTip.Equals(Tip.Naziv))
                    {
                        TrazeniTipNamestaja = Tip;

                    }
                }
            } while (TrazeniTipNamestaja == null);
            NoviNamestaj.TipNamestaja = TrazeniTipNamestaja;
            ListaNamestaja.Add(NoviNamestaj);
            IspisiMeniNamestaja();
        }
        private static void IzmeniPostojeciNamestaj()
        {
            Namestaj namestajZaIzmenu = null;
            do
            {
                Console.WriteLine("Unesite ime namestaja koji zelite da izmenite");
                string nazivTrazenogNamestaja = Console.ReadLine();
                foreach (Namestaj trenutniNamestaj in ListaNamestaja)
                {
                    if (trenutniNamestaj.NazivNamestaja.Equals(nazivTrazenogNamestaja))
                    {
                        namestajZaIzmenu = trenutniNamestaj;
                    }
                }
            } while (namestajZaIzmenu == null);

            int izbor = 0;
            do
            {
                Console.WriteLine("Sta zelite da izmenite?");
                Console.WriteLine("1. Naziv");
                Console.WriteLine("2. Sifra");
                Console.WriteLine("3. Cena");
                Console.WriteLine("4. Tip namestaja");
                Console.WriteLine("0. Povratak na glavni meni");
                izbor = int.Parse(Console.ReadLine());
            } while (izbor < 0 || izbor > 4);
            switch (izbor)
            {
                case 1:
                    string novNaziv = null;
                    do
                    {
                        Console.WriteLine("Unesite nov naziv");
                        novNaziv = Console.ReadLine();
                    } while (novNaziv == null || novNaziv == "" || novNaziv.Equals(namestajZaIzmenu.NazivNamestaja));
                    namestajZaIzmenu.NazivNamestaja = novNaziv;
                    IspisiMeniNamestaja();
                    break;

                case 2:
                    string novaSifra = null;
                    do
                    {
                        Console.WriteLine("Unesite novu sifru");
                        novaSifra = Console.ReadLine();
                    } while (novaSifra == null || novaSifra == "" || novaSifra.Equals(namestajZaIzmenu.Sifra));
                    namestajZaIzmenu.Sifra = novaSifra;
                    IspisiMeniNamestaja();
                    break;

                case 3:
                    double novaCena = 0;
                    do
                    {
                        Console.WriteLine("Unesite novu cenu");
                        novaCena = double.Parse(Console.ReadLine());
                    } while (novaCena <= 0 || novaCena == namestajZaIzmenu.CenaKomad);
                    namestajZaIzmenu.CenaKomad = novaCena;
                    IspisiMeniNamestaja();
                    break;

                case 4:
                    TipNamestaja TrazeniTipNamestaja = null;
                    do
                    {
                        Console.WriteLine("Unesite novi tip namestaja");
                        string UnetiTip = Console.ReadLine();
                        foreach (TipNamestaja Tip in ListaTipoviNamestaja)
                        {
                            if (UnetiTip.Equals(Tip.Naziv))
                                TrazeniTipNamestaja = Tip;
                        }
                    } while (TrazeniTipNamestaja == null || TrazeniTipNamestaja == namestajZaIzmenu.TipNamestaja);
                    namestajZaIzmenu.TipNamestaja = TrazeniTipNamestaja;
                    IspisiMeniNamestaja();
                    break;

                case 0:
                    IspisGlavnogMenija();
                    break;

                default:
                    break;
            }
        }
        private static void ObrisiPostojeciNamestaj()
        {
            Namestaj namestajZaBrisanje = null;
            do
            {
                Console.WriteLine("Unesite naziv namestaja");
                string unetiNaziv = Console.ReadLine();
                foreach (Namestaj trenutniNamestaj in ListaNamestaja)
                {
                    if (trenutniNamestaj.NazivNamestaja.Equals(unetiNaziv) & trenutniNamestaj.Obrisan == false)
                        namestajZaBrisanje = trenutniNamestaj;
                }
            } while (namestajZaBrisanje == null);
            Console.WriteLine("Brisanje uspesno");
            namestajZaBrisanje.Obrisan = true;
            IspisiMeniNamestaja();
        }

        //================================================================================

        private static void IzlistajTipoveNamestaja()
        {
            Console.WriteLine("Izlistavanje tipova namestaja");
            foreach (TipNamestaja trenutniTip in ListaTipoviNamestaja)
                if (trenutniTip.Obrisan != true)
                    Console.WriteLine(trenutniTip.Naziv);
            Console.WriteLine("Gotovo izlistavanje \n");
            IspisiMeniNamestaja();
        }
        private static void DodajNoviTipNamestaja()
        {
            TipNamestaja NoviTipNamestaja = new TipNamestaja();
            NoviTipNamestaja.Id = ListaTipoviNamestaja.Count + 1;
            Console.WriteLine("Unesite naziv tipa namestaja");
            NoviTipNamestaja.Naziv = Console.ReadLine();
            NoviTipNamestaja.Obrisan = false;
            ListaTipoviNamestaja.Add(NoviTipNamestaja);
        }
        private static void IzmeniPostojeciTipNamestaja()
        {
            TipNamestaja tipNamestajaZaIzmenu = null;
            do
            {
                Console.WriteLine("Unesite naziv tipa namestaja za izmenu");
                string unetiNaziv = Console.ReadLine();
                foreach (TipNamestaja trenutniTip in ListaTipoviNamestaja)
                    if (unetiNaziv.Equals(trenutniTip.Naziv))
                        tipNamestajaZaIzmenu = trenutniTip;
            } while (tipNamestajaZaIzmenu == null);
            int izbor = 0;
            do
            {
                Console.WriteLine("Sta zelite da izmenite?");
                Console.WriteLine("1. Naziv");
                Console.WriteLine("0. Povratak na meni tipa namestaja");
                izbor = int.Parse(Console.ReadLine());
            } while (izbor < 0 || izbor > 1);
            switch (izbor)
            {
                case 1:
                    string novNaziv = null;
                    do
                    {
                        Console.WriteLine("Unesite nov naziv");
                        novNaziv = Console.ReadLine();
                    } while (novNaziv == null || novNaziv == "" || novNaziv.Equals(tipNamestajaZaIzmenu.Naziv));
                    tipNamestajaZaIzmenu.Naziv = novNaziv;
                    IspisMeniTipNamestaja();
                    break;
            }
        }
        private static void ObrisiPostojeciTipNamestaja()
        {
            TipNamestaja tipNamestajaZaBrisanje = null;
            do
            {
                Console.WriteLine("Unesite naziv tipa namestaja");
                string unetiNaziv = Console.ReadLine();
                foreach (TipNamestaja trenutniTip in ListaTipoviNamestaja)
                {
                    if (trenutniTip.Naziv.Equals(unetiNaziv) & trenutniTip.Obrisan == false)
                        tipNamestajaZaBrisanje = trenutniTip;
                }
            } while (tipNamestajaZaBrisanje == null);
            Console.WriteLine("Brisanje uspesno");
            tipNamestajaZaBrisanje.Obrisan = true;
            IspisMeniTipNamestaja();
        }
        //==============================================================================
        private static void Login()
        {
            bool korisnikLogin = false;
            int pokusaj = 0;
            do
            {
                Console.WriteLine("Unesite vase korisnicko ime");
                string korisnickoIme = Console.ReadLine();
                Console.WriteLine("Unesite vasu lozinku");
                string sifra = Console.ReadLine();
                foreach (Korisnik trenutniKorisnik in ListaKorisnika)
                    if (trenutniKorisnik.KorisnickoIme == korisnickoIme & trenutniKorisnik.Lozinka == sifra && trenutniKorisnik.Obrisan!=true)
                        korisnikLogin = true;
                pokusaj++;
                if (pokusaj >= 3)
                    Environment.Exit(0);


            } while (korisnikLogin == false);
            Console.WriteLine();
        }
        //==============================================================================
        private static void IzlistajKorisnike()
        {
            Console.WriteLine("Izlistavanje korisnika ");
            foreach (Korisnik trenutniKorisnik in ListaKorisnika)
                if (trenutniKorisnik.Obrisan != true)
                    Console.WriteLine(trenutniKorisnik.Id+". "+trenutniKorisnik.Ime+" "+trenutniKorisnik.Prezime + ", " +trenutniKorisnik.TipKorisnika);
            Console.WriteLine("Gotovo izlistavanje \n");
            IspisMeniKorisnici();
        }
        private static void DodajNovogKorisnika()
        {
            Korisnik noviKorisnik = new Korisnik();
            noviKorisnik.Id = ListaKorisnika.Count + 1;
            Console.WriteLine("Unesite ime korisnika");
            noviKorisnik.Ime = Console.ReadLine();
            Console.WriteLine("Unesite prezime korisnika");
            noviKorisnik.Prezime = Console.ReadLine();
            Console.WriteLine("Unesite korisnicko ime korisnika");
            noviKorisnik.KorisnickoIme=Console.ReadLine();
            Console.WriteLine("Unesite lozinku korisnika");
            noviKorisnik.Lozinka = Console.ReadLine();
            int tipKorisnika = 0;
            do
            {
                Console.WriteLine("Unesite tip korisnika \n1. Administrator \n2. Prodavac");
                tipKorisnika = int.Parse(Console.ReadLine());
            } while (tipKorisnika<0 || tipKorisnika>2);
            switch (tipKorisnika)
            {
                case 1:
                    noviKorisnik.TipKorisnika = TipKorisnika.Administrator;
                    break;
                case 2:
                    noviKorisnik.TipKorisnika = TipKorisnika.Prodavac;
                    break;
            }
            noviKorisnik.Obrisan = false;
            Console.WriteLine("Novi korisnik je dodat");
            ListaKorisnika.Add(noviKorisnik);
            IspisMeniKorisnici();
        }
        private static void IzmeniPostojecegKorisnika()
        {
            Korisnik korisnikZaIzmenu = null;
            do
            {
                Console.WriteLine("Unesite korisnicko ime korisnika za izmenu");
                string unetoIme = Console.ReadLine();
                foreach (Korisnik trenutniKorisnik in ListaKorisnika)
                    if (trenutniKorisnik.KorisnickoIme.Equals(unetoIme))
                        korisnikZaIzmenu = trenutniKorisnik;
            } while (korisnikZaIzmenu == null);
            int izbor = 0;
            do
            {
                Console.WriteLine("Sta zelite da izmenite?");
                Console.WriteLine("1. Ime");
                Console.WriteLine("2. Prezime");
                Console.WriteLine("3. Lozinku");
                Console.WriteLine("4. Tip korisnika");
                Console.WriteLine("0. Povratak na meni korisnika");
                izbor = int.Parse(Console.ReadLine());
            } while (izbor < 0 || izbor > 4);
            switch (izbor)
            {
                case 1:
                    string novoIme = null;
                    do
                    {
                        Console.WriteLine("Unesite novo ime");
                        novoIme = Console.ReadLine();
                    } while (novoIme == null || novoIme == "" || novoIme.Equals(korisnikZaIzmenu.Ime));
                    korisnikZaIzmenu.Ime = novoIme;
                    IspisMeniKorisnici();
                    break;

                case 2:
                    string novoPrezime = null;
                    do
                    {
                        Console.WriteLine("Unesite novo prezime");
                        novoPrezime = Console.ReadLine();
                    } while (novoPrezime == null || novoPrezime == "" || novoPrezime.Equals(korisnikZaIzmenu.Prezime));
                    korisnikZaIzmenu.Prezime = novoPrezime;
                    IspisMeniKorisnici();
                    break;

                case 3:
                    string novaLozinka = null;
                    do
                    {
                        Console.WriteLine("Unesite novu lozinku");
                        novaLozinka = Console.ReadLine();
                    } while (novaLozinka == null || novaLozinka == "" || novaLozinka.Equals(korisnikZaIzmenu.Lozinka));
                    korisnikZaIzmenu.Lozinka = novaLozinka;
                    IspisMeniKorisnici();
                    break;

                case 4:
                    int tipKorisnika = 0;
                    do
                    {
                        Console.WriteLine("Unesite tip korisnika \n1. Administrator \n2. Prodavac");
                        tipKorisnika = int.Parse(Console.ReadLine());
                    } while (tipKorisnika < 0 || tipKorisnika > 2);
                    switch (tipKorisnika)
                    {
                        case 1:
                            korisnikZaIzmenu.TipKorisnika = TipKorisnika.Administrator;
                            break;
                        case 2:
                            korisnikZaIzmenu.TipKorisnika = TipKorisnika.Prodavac;
                            break;
                    }
                    IspisMeniKorisnici();
                    break;

                case 0:
                    IspisMeniKorisnici();
                    break;
            }
        }
        private static void ObrisiPostojecegKorisnika()
        {
            Korisnik korisnikZaBrisanje = null;
            do
            {
                Console.WriteLine("Unesite korisnicko ime korisnika za brisanje");
                string unetoIme = Console.ReadLine();
                foreach (Korisnik trenutniKorisnik in ListaKorisnika)
                    if (trenutniKorisnik.KorisnickoIme.Equals(unetoIme))
                        korisnikZaBrisanje = trenutniKorisnik;
            } while (korisnikZaBrisanje == null);
            korisnikZaBrisanje.Obrisan = true;
            Console.WriteLine("Korisnik je obrisan \n");
            IspisMeniKorisnici();
        }

    }
}
