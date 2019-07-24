using System;
using Xunit;

namespace RoverOnPlanet.Test
{
    public class PlanetFixture
    {
        [Fact]
        public static void Planet_dimnsion_test()
        {
            Planet Mars = new Planet(5, 5);
            Assert.Equal(5, Mars.Length);
            Assert.Equal(5, Mars.Width);
        }
    }
}
