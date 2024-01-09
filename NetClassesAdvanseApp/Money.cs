using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClassesAdvanseApp
{
    class Money
    {
        public int Rub { set; get; }
        public int Kop { set; get; }

        public Money(int rub = 0, int kop = 0)
        {
            Rub = rub;
            Kop = kop;
        }

        public override string ToString()
        {
            return $"{Rub} rub., {Kop} kop.";
        }
    }
}
