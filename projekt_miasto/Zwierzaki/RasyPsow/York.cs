﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Zwierzaki.RasyPsow
{
    class York : Pies
    {
        public override string RasaZwierzaka()
        {
            return this.GetType().Name;
        }
        public York(string imie, int wiek) : base(imie, wiek)
        {
            Rodzaj = RodzajZwierzatka.DOMOWE;
        }

    }
}
