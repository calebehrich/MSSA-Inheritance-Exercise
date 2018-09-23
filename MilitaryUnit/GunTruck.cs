using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class GunTruck : Vehicles
    {
        public void PMCS()
        {
            Console.WriteLine("Before the mission the unit must PMCS their gun truck.");
        }

        public override void Drive()
        {
            Console.WriteLine("The unit is driving to their objective: Vroom Vroom");
        }

      
    }
}
