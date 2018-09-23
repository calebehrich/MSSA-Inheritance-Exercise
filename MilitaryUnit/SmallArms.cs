using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class SmallArms : Weapons
    {
        public void ReadyWeapons()
        {
            Console.WriteLine("The unit is getting their rifles ready for the mission");
        }

        public void CleanWeapons()
        {
            Console.WriteLine("The unit is back at the base and needs to clean their rifles and prepare for the next mission");
        }
    }
}
