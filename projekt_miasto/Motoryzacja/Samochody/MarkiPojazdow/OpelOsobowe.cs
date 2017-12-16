using projekt_miasto.Motoryzacja.Samochody.TypyPojazdow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow
{
    abstract class OpelOsobowe : SamochodyOsobowe, IInformacje
    {
        public string MarkaPozadzu { get; private set; }

        public OpelOsobowe()
        {
            this.MarkaPozadzu = "Opel";
        }
        public override string Marka()
        {
            return this.MarkaPozadzu;
        }

    }
}