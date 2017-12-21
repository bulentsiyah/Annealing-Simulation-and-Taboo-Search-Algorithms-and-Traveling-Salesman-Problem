using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuArama__Tavlama__GezginSatici
{
    public class Cozum : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public Cozum(List<int> Kromozom, int Uygunluk)
        {
            this.Kromozom = Kromozom;
            this.Uygunluk = Uygunluk;
        }

        public List<int> Kromozom { get; set; }
        public int Uygunluk { get; set; }
    }
}
