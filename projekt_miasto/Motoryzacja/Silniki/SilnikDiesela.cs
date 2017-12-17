using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Silniki
{
    class SilnikDiesela : Silnik
    {
        public SilnikDiesela(double pojemnoscSilnika) : base(pojemnoscSilnika)
        {
        }

        public override string TypSilnika()
        {
            return this.GetType().Name;
        }

    }
}
