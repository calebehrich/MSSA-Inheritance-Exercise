using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Missions
    {
        public void MissionAssignment(string assign)
        {
            Console.WriteLine($"The unit is assigned a {assign} mission");
        }

        public void MissionStart(string start)
        {
            Console.WriteLine($"The unit has begun their mission by {start}");
        }

        public void MissionComplete(string complete)
        {
            Console.WriteLine($"The unit has completed their mission {complete}");
        }
      

    }
}
