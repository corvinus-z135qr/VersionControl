﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimulacio_1202.Entitites
{
   public class BirthProbability
    {
        public int Age { get; set; }

        public byte NbrOfChildren { get; set; }

        public double BirthGivenProb { get; set; }
    }
}
