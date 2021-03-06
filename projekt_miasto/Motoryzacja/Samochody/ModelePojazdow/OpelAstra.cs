﻿using projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow;
using projekt_miasto.Motoryzacja.Silniki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.ModelePojazdow
{
    class OpelAstra : OpelOsobowe
    {
        public OpelAstra() : base()
        {
            base.Silnik = new SilnikBenzynowy(1.6);
            base.ZbiornikPaliwa = new ZbiornikPaliwa(40);
        }

        public override string Model()
        {
            return "Astra";
        }
    }
}
