using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Artillery : Weapons
    {
        public void Standby()
        {
            Console.WriteLine("The unit has called for artillery support to be on standby");
        }

        public void ReadyCannons()
        {
            Console.WriteLine("The unit needs artillery support, the 13B's ready the cannons");
        }
    }
}
