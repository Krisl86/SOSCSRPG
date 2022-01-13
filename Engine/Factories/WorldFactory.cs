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
            world.AddLocation(0, 1, "Herbalist's Hut", "Small wooden hut with herbs", "/Engine;component/Images/Locations/HerbalistsHut.png");
            world.AddLocation(0, 2, "Herb Garden", "Various medical herbs grow here", "/Engine;component/Images/Locations/HerbalistsGarden.png");
            world.AddLocation(1, 0, "Town Gate", "Large gate leaving out of the city", "/Engine;component/Images/Locations/TownGate.png");
            world.AddLocation(2, 0, "Spider Forest", "This forest is full of spiders...ew", "/Engine;component/Images/Locations/SpiderForest.png");
            world.AddLocation(-1, 0, "Trading Shop", "The trader greets you", "/Engine;component/Images/Locations/Trader.png");
            world.AddLocation(-1, -1, "Farmhouse", "A small farmstead", "/Engine;component/Images/Locations/Farmhouse.png");
            world.AddLocation(-2, -1, "Farmer's Field", "You see a field of grain", "/Engine;component/Images/Locations/FarmFields.png");

            return world;
        }
    }
}
