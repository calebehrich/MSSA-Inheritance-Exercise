using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Patrol_Mission : Missions
    {
        public void ConductingPatrol()
        {
            Console.WriteLine("The unit is outside the wire patrolling for danger.");
        }

        public void EnemySpotted()
        {
            Console.WriteLine("The lead man has spotted enemy activity and fired a warning shot, but the enemy ran away.");
        }

        public void ReturnToBase()
        {
            Console.WriteLine("The unit has made it to their objective with no incident and heads back to base.");
        }
    }
}
