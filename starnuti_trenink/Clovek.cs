using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starnuti_trenink
{
    internal class Clovek
    {
        internal class osoba
        {
            public int stari { get; private set; }
            public void Starnout()
            {
                stari++;
            }
        }
    }
}
