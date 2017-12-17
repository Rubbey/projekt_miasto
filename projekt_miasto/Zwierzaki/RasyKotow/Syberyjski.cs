using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Zwierzaki.RasyKotow
{
    class Syberyjski : Kot
    {
        public override string RasaZwierzaka()
        {
            return this.GetType().Name;
        }
        public Syberyjski(string imie, int wiek) : base(imie, wiek)
        {
            Rodzaj = RodzajZwierzatka.DOMOWE;
        }

    }
}
