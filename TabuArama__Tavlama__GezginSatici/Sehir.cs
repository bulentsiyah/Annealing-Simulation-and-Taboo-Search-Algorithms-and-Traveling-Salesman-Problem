using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuArama__Tavlama__GezginSatici
{
    public class Sehir
    {
        public Sehir(int Sira, String Adi, Double Enlem, Double Boylam, Double Uzaklik)
        {
            this.Sira = Sira;
            this.Adi = Adi;
            this.Enlem = Enlem;
            this.Boylam = Boylam;
            this.Uzaklik = Uzaklik;
        }

        public int Sira { get; set; }
        public String Adi { get; set; }
        public Double Enlem { get; set; }
        public Double Boylam { get; set; }
        public Double Uzaklik { get; set; }
    }

}
