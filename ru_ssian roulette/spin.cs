using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru_ssian_roulette
{
    class spin
    {
        public int load;
        public int shoot;
        public int Spin;
        public int reload = 2;

        public int sp(int spin)
        {
            if (spin == 6)
            {
                spin = 1;

            }
            else
            {
                spin++;
            }

            return spin;
        }
    }
}
