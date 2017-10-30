using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_sf39_2016.model
{
    public class Namestaj
    {
        public int Id { get; set; }
        public string NazivNamestaja { get; set; }

        public string Sifra { get; set; }

        public double CenaKomad { get; set; }

        public int BrKomada { get; set; }

        public TipNamestaja TipNamestaja { get; set; }

        public int? AkcijaID { get; set; }

        public int? TipNamestajaId { get; set; }

        public bool Obrisan { get; set; }

    }
}
