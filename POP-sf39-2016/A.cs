﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prostorImena
{
    class A
    {
        private string naziv;
        private string ime;

        public string GetNaziv()
        {
            return this.naziv;
        }
        public void SetNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public string Ime
        {
            get
            {
                return this.ime;
            }
            set
            {
                this.ime = value;
            }
        }
    }

}
