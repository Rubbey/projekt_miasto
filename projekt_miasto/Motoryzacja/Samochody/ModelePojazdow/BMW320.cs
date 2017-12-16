using projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.ModelePojazdow
{
    class BMW320 : BmwOsobowe, IInformacje
    {
        public string ModelPojazdu { get; private set; }

        public BMW320()
        {
            this.ModelPojazdu = "320";
        }

        public override string Model()
        {
            return this.ModelPojazdu;
        }
    }
}
