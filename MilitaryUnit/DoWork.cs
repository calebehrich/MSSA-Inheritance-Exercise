using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class DoWork
    {
        ResupplyMission resupply = new ResupplyMission();
        AssaultMission assault = new AssaultMission();
        Patrol_Mission patrol = new Patrol_Mission();
        GunTruck truck = new GunTruck();
        Tank tank = new Tank();
        LMTV lmtv = new LMTV();
        SmallArms rifle = new SmallArms();
        Artillery king = new Artillery();

        public void ImplementResupply()
        {
            resupply.MissionAssignment("resupply");
            lmtv.LoadUp();
            rifle.ReadyWeapons();
            resupply.MissionStart("Loading up in vehicles");
            lmtv.Drive();
            resupply.ConductingResupply();
            resupply.MeetElders();
            resupply.ReturnToBase();
            resupply.MissionComplete("Successfully");
            rifle.CleanWeapons();
            Console.WriteLine("\n");

        }

        public void ImplementPatrol()
        {
            patrol.MissionAssignment("patrol");
            truck.PMCS();
            rifle.ReadyWeapons();
            patrol.MissionStart("Loading personnel and extra ammo in vehicles");
            truck.Drive();
            patrol.EnemySpotted();
            rifle.WeaponsFire("Bang Bang");
            rifle.WeaponsStop("Shhhh");
            patrol.ReturnToBase();
            patrol.MissionComplete("Without incidents");
            rifle.CleanWeapons();
            Console.WriteLine("\n");
        }

        public void ImplementAssault()
        {
            assault.MissionAssignment("assault");
            tank.LoadUp();
            rifle.ReadyWeapons();
            assault.MissionStart("readying weapons and loading personnel into vehicles");
            tank.Drive();
            assault.ConductingAssault();
            king.Standby();
            king.ReadyCannons();
            king.WeaponsFire("BOOM!");
            king.WeaponsStop("Clunk");
            assault.EnemyEliminated();
            assault.OccupyCompound();
            assault.MissionComplete("With minimal injuries");
            rifle.CleanWeapons();
            Console.WriteLine("\n");
        }

    }
}
