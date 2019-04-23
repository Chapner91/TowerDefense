using System;

namespace TowerDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base (x, y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of this map.");
            }
        }

        public bool IsInRange(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }

        public string toString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}
