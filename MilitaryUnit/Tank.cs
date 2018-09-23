using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Tank : Vehicles
    {
        public void LoadUp()
        {
            Console.WriteLine("The unit preps the tank by loading up ammunition");
        }

        public override void Drive()
        {
            Console.WriteLine("The tank is driving to its objective: Clug Clug");
        }
    }
}
