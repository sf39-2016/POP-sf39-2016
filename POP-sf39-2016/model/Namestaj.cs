﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_sf39_2016.model
{
    public class Namestaj
    {

        public string NazivNamestaja { get; set; }

        public int Sifra { get; set; }

        public double CenaKomad { get; set; }

        public int BrKomada { get; set; }

        public TipNamestaja TipNamestaja { get; set; }

        public bool Obrisan { get; set; }

    }
}