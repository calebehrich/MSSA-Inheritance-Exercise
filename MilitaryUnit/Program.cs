﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        

        static void Main(string[] args)
        {
            DoWork work = new DoWork();
            work.ImplementResupply();
            work.ImplementPatrol();
            work.ImplementAssault();            
        }
    }
}
