using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_sf39_2016.model
{
    public class Akcija
    {
        public DateTime PocetakAkcije { get; set; }

        public DateTime KrajAkcije { get; set; }

        public int Id { get; set; }

        public bool Obrisan { get; set; }
        //List<int> NamestajID umesto ovog dole
        public List<Namestaj> NamestajNaPopustu { get; set; }

        public double Popust { get; set; }

    }
}
