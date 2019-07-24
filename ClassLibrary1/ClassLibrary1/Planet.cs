using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverOnPlanet
{
    public class Planet
    {
        public Planet(int planetLength, int planetWidth)
        {
            this.Length = planetLength;
            this.Width = planetWidth;
        }
        public int Length { get;  }
        public int Width { get; }
    }
}
