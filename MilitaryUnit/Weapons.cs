using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Weapons
    {
        public void WeaponsFire(string firingSound)
        {
            Console.WriteLine($"The weapon fires: {firingSound}");
        }

        public void WeaponsStop(string stopFiringSound)
        {
            Console.WriteLine($"The weapon stops: {stopFiringSound}");
        }
    }
}
