using System;

namespace TowerDefense
{
    class Invader
    {

        // Member Variables ----------------------------------------------------------------------------------------------------
        private int _pathStep = 0;
        private readonly Path _path;


        // Properties ----------------------------------------------------------------------------------------------------
        public MapLocation Location
        {
            get
            {
                return _path.getLocationAt(_pathStep);
            }
            
        }

        public int Health { get; private set; } = 10;
        public bool IsNeutralized => Health <= 0;
        public bool HasScored => _pathStep >= _path.Length;
        public bool IsActive => !(HasScored || IsNeutralized);



        // Constructors ----------------------------------------------------------------------------------------------------
        public Invader(Path path)
        {
            _path = path;
        }



        // Methods ----------------------------------------------------------------------------------------------------
        public void Move()
        {
            _pathStep += 1;
        }

        public void takeDamage(int damageDealt)
        {
            Health -= damageDealt;
        }
    }
}
