using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations;
        public List<Location> Locations => _locations ?? (_locations = new List<Location>());
        
        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            this.Locations.Add(new Location
            {
                XCoordinate = xCoordinate,
                YCoordinate = yCoordinate,
                Name = name,
                Description = description,
                ImageName = imageName
            });
        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location loc in this.Locations)
            {
                if (loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }
            return null;
        }
    }
}
