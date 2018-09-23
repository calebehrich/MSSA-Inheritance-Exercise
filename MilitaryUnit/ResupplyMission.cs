using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class ResupplyMission : Missions
    {
        public void ConductingResupply()
        {
            Console.WriteLine("The unit is entering the city with medical supplies for the locals");
        }

        public void MeetElders()
        {
            Console.WriteLine("The convoy commander is meeting with the town elders to give them the supplies");
        }

        public void ReturnToBase()
        {
            Console.WriteLine("The unit completed the resupply and loads up to head back to base");
        }
    }
}
