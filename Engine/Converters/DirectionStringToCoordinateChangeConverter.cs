using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Converters
{
    public class DirectionStringToCoordinateChangeConverter
    {
        public int[] Convert(string direction)
        {
            if (direction.Equals("north"))
            {
                return new int[] { 0, 1 };
            }

            if (direction.Equals("east"))
            {
                return new int[] { 1, 0 };
            }

            if (direction.Equals("south"))
            {
                return new int[] { 0, -1 };
            }

            if (direction.Equals("west"))
            {
                return new int[] { -1, 0 };
            }
            return new int[] { 0, 0 };
        }
    }
}
