using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World world = new World();

            world.AddLocation(0, -1, "Home", "This is your home", "/Engine;component/Images/Locations/Home.png");
            world.AddLocation(0, 0, "Town Square", "There is a fountain in the middle", "/Engine;component/Images/Locations/TownSquare.png");

            return world;
        }
    }
}
