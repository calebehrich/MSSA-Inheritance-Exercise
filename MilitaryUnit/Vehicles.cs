using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Vehicles
    {
        public void EngineStarts(string startEngine)
        {
            Console.WriteLine($"The engine starts: {startEngine}");
        }

        public void EngineStops(string stopEngine)
        {
            Console.WriteLine($"The engine stops: {stopEngine}");
        }

        public virtual void Drive()
        {
            Console.WriteLine("drive");
        }

        public void EngageEnemy(string engage)
        {
            Console.WriteLine($"The unit sees the enemy and engages with their {engage}");
        }
    }
}
