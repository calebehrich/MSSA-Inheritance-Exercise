using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class LMTV : Vehicles
    {
        public void LoadUp()
        {
            Console.WriteLine("The unit is loading up supplies on the the LMTV");
        }

        public override void Drive()
        {
            Console.WriteLine("The LMTV is driving: Brm Brm");
        }
    }
}
