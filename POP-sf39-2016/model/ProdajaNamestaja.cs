using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_sf39_2016.model
{
    public class ProdajaNamestaja
    {
        public int Id { get; set; }

        public List<Namestaj> NamestajZaProdaju { get; set; }

        public DateTime DatumProdaje { get; set; }

        public string BrRacuna { get; set; }

        public string Kupac { get; set; }

        public double PDV { get; set; }

        public List<DodatnaUsluga> DodatnaUsluga { get; set; }

        public double UkupnaCena { get; set; }
    }
}
