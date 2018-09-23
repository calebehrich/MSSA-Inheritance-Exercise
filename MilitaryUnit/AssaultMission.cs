using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class AssaultMission : Missions
    {
        public void ConductingAssault()
        {
            Console.WriteLine("The unit has reached their target and begin to engage the enemy");
        }

        public void EnemyEliminated()
        {
            Console.WriteLine("The unit eliminated all enemies");
        }

        public void OccupyCompound()
        {
            Console.WriteLine("The unit has now occupied the compound and reported their status to HQ");
        }
    }
}
