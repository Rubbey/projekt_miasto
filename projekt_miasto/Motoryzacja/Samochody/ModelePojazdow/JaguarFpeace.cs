using projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.ModelePojazdow
{
    class JaguarFpeace : JaguarTerenowe, IInformacje
    {
        public string ModelPojazdu { get; private set; }

        public JaguarFpeace()
        {
            this.ModelPojazdu = "F-Peace";
        }

        public override string Model()
        {
            return this.ModelPojazdu;
        }
    }
}
