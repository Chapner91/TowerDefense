using System;

namespace TowerDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path)
        {
            this._path = path;
        }

        public int Length => _path.Length;

        private bool isOnPath(int pathStep)
        {
            return pathStep >= 0 && pathStep < _path.Length;
        }

        public MapLocation getLocationAt(int pathStep)
        {
            return (this.isOnPath(pathStep)) ? _path[pathStep] : null;         
        }
    }
}
