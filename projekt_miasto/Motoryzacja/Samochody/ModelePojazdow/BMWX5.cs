using projekt_miasto.Motoryzacja.Samochody.MarkiPojazdow;
using projekt_miasto.Motoryzacja.Silniki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto.Motoryzacja.Samochody.ModelePojazdow
{
    class BMWX5 : BmwTerenowe, IInformacje
    {
        public string ModelPojazdu { get; private set; }

        public BMWX5() : base()
        {
            this.ModelPojazdu = "X5";
            base.Silnik = new SilnikBenzynowy();
            base.ZbiornikPaliwa = new ZbiornikPaliwa();
        }

        public override string Model()
        {
            return this.ModelPojazdu;
        }
    }
}
