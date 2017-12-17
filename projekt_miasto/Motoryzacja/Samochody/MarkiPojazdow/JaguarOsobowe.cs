using projekt_miasto.Motoryzacja.Samochody.TypyPojazdow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow
{
    abstract class JaguarOsobowe : SamochodyOsobowe
    {
        public JaguarOsobowe() : base()
        {
        }

        public override string Marka()
        {
            return "Jaguar";
        }

    }
}
