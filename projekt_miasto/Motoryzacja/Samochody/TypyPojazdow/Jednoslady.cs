﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.TypyPojazdow
{
    abstract class Jednoslady : Pojazd, IInformacje
    {
        public Jednoslady() : base(1) { }
    }
}
