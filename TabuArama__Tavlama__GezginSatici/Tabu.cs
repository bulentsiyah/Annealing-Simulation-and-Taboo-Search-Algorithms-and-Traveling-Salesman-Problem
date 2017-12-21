using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuArama__Tavlama__GezginSatici
{
    public class Tabu
    {
        public Tabu(int kimden, int kime )
        {
            this.kimden = kimden;
            this.kime = kime;
        }

        public int kimden { get; set; }
        public int kime { get; set; }
    }
}
