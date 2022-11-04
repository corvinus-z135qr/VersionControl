﻿using fejleszteszi_mintak_06.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fejleszteszi_mintak_06.Entities
{
    
    public class BallFactory :IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }
}
