using fejleszteszi_mintak_06.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using fejleszteszi_mintak_06.Entities;

namespace fejleszteszi_mintak_06.Entities
{
    
    public class BallFactory :IToyFactory
    {
        public Color BallColor { get; set; }
        public Toy CreateNew()
        {
            return new Ball(BallColor);
        }
    }
}
